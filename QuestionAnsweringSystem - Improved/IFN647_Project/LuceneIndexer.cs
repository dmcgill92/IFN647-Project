using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using NHunspell;
using Lucene.Net.Analysis; // for Analyser
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Analysis.Snowball;
using Lucene.Net.Documents; // for Document and Field
using Lucene.Net.Index; //for Index Writer
using Lucene.Net.Store; //for Directory
using Lucene.Net.Search; // for IndexSearcher
using Lucene.Net.QueryParsers;  // for QueryParser
using Lucene.Net.Search.Highlight;

namespace IFN647_Project
{
    class LuceneIndexer
    {
		Similarity newSimilarity;
		Lucene.Net.Store.Directory luceneIndexDirectory;
        Lucene.Net.Analysis.Analyzer analyzer;
        Lucene.Net.Index.IndexWriter writer;
		Lucene.Net.Index.IndexReader reader;
        Lucene.Net.Search.IndexSearcher searcher;
        Lucene.Net.QueryParsers.MultiFieldQueryParser parser;

		Query currentQuery;

		public string finalQuery;
		public string queryTime;

        const Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;
        const string URL_FN = "Url";
		const string PASSAGEID_FN = "Passage ID";
		const string QUERY_FN = "Query";


		public LuceneIndexer()
        {
            luceneIndexDirectory = null;
            writer = null;
			analyzer = null;
			parser = null;
			newSimilarity = new NewSimilarity();
		}

        public void OpenIndex(string indexPath) // Opens the index directory
        {
            luceneIndexDirectory = FSDirectory.Open(indexPath);
        }

        public void CreateAnalyser() // Creates analyzer
        {
			analyzer = new SnowballAnalyzer(VERSION, "English");
			//analyzer = new StandardAnalyzer(VERSION);
        }

        public void CreateWriter() // Creates index writer
        {
            IndexWriter.MaxFieldLength mfl = new IndexWriter.MaxFieldLength(IndexWriter.DEFAULT_MAX_FIELD_LENGTH);
            writer = new IndexWriter(luceneIndexDirectory, analyzer, true, mfl);
			//writer.SetSimilarity(newSimilarity);
        }

		public void CreateReader()
		{
			reader = DirectoryReader.Open(luceneIndexDirectory, true);
		}

        public void CreateSearcher() // Creates Searcher
        {
            searcher = new IndexSearcher(luceneIndexDirectory);
			//searcher.Similarity = newSimilarity;
        }

        public void CreateParser(int boostIndex) // Creates Parser
        {
			if( boostIndex == 0 )
			{
				parser = new MultiFieldQueryParser(VERSION, new string[] { URL_FN, QUERY_FN }, analyzer);
			}
			else
			{

				IDictionary<string, float> boosts = new Dictionary<string, float>();
				if(boostIndex == 1)
				{
					boosts.Add(URL_FN, 5.0f);
					boosts.Add(QUERY_FN, 1.0f);
				}
				else
				{
					boosts.Add(URL_FN, 1.0f);
					boosts.Add(QUERY_FN, 5.0f);
				}
				parser = new MultiFieldQueryParser(VERSION, new string[] { URL_FN, QUERY_FN }, analyzer, boosts);
			}
		}

        public void AddToIndex(Passage passage) // Indexes an entry
        {
			// Add all text to one field
			Field urlField = new Field(URL_FN, passage.url, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.NO);
			Field passageIDField = new Field(PASSAGEID_FN, passage.passage_id.ToString(), Field.Store.YES, Field.Index.NO, Field.TermVector.NO);
			Field queryField = new Field(QUERY_FN, passage.query, Field.Store.NO, Field.Index.ANALYZED, Field.TermVector.NO);
			Document document = new Document();
			document.Add(urlField);
			document.Add(passageIDField);
			document.Add(queryField);
			writer.AddDocument(document);
		}

        public void IndexCollection(string filePath, Dictionary<int, Passage> collection) // Indexes the coillection
        {
            OpenIndex(filePath);
            CreateAnalyser();
            CreateWriter();
            foreach (KeyValuePair<int, Passage> keyValuePair in collection)
            {
				var passage = keyValuePair.Value;
                AddToIndex(passage);
            }
			CleanUp();
        }

        public void CleanUp() // Cleans up indexer
        {
            writer.Optimize();
            writer.Flush(true, true, true);
            writer.Dispose();
        }


        public void CleanUpSearch() // Cleans up searcher
        {
            searcher.Dispose();
        }
		
        public TopDocs SearchForQuery(string querytext, out Lucene.Net.Search.Query query, bool toProcess, bool toExpand) // Searches index with query text
        {
			Stopwatch stopwatch2 = Stopwatch.StartNew();

			if(!toProcess)
			{
				querytext = "\"" + querytext + "\"";
			}
			else
			{
				if(toExpand)
				{
					var standardParser = new QueryParser(VERSION, URL_FN, new StandardAnalyzer(VERSION));
					querytext = standardParser.Parse(querytext).ToString().Replace("Url:", "").Replace("Query:", "");
					querytext = GetSynonyms(querytext);
				}
				querytext = querytext.ToLower();
			}
			if(querytext != string.Empty)
			{
				query = parser.Parse(querytext);
				currentQuery = query;
				stopwatch2.Stop();
				queryTime = stopwatch2.Elapsed.TotalSeconds.ToString();
				finalQuery = query.ToString();
				TopDocs results = searcher.Search(query, 100);
				return results;
			}
			else
			{
				query = null;
				return null;
			}
        }

		public List<Result> SearchIndex(string queryText, bool toProcess, bool toExpand, int boostIndex)
		{
			CreateSearcher();
			CreateParser(boostIndex);
			Lucene.Net.Search.Query query;
			var retrievedData = DisplayResults(SearchForQuery(queryText, out query, toProcess, toExpand), query);
			return retrievedData;
		}

        public List<Result> DisplayResults(TopDocs results, Lucene.Net.Search.Query query)
        {
            int rank = 0;
            List<Result> retrievedResults = new List<Result>();
            foreach (ScoreDoc scoreDoc in results.ScoreDocs)
            {
				rank++;
				// retrieve the document from the 'ScoreDoc' object
				Lucene.Net.Documents.Document doc = searcher.Doc(scoreDoc.Doc);
				string url = doc.Get(URL_FN).ToString();
				string title = GetTitle(url);
				int passageID = Int32.Parse(doc.Get(PASSAGEID_FN));

				retrievedResults.Add(new Result(rank, scoreDoc.Score, title, url, null, null, passageID));
			}

            return retrievedResults;
        }

		private string GetTitle(string url)
		{
			string[] fragments = url.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
			string title = fragments.Last();
			fragments = title.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
			if(fragments.Length > 1)
			{
				var sorted = fragments.OrderBy(n => n.Length);
				title = sorted.LastOrDefault();
			}
			title = title.Replace('-', ' ');
			title = title.Replace('_', ' ');
			TextInfo textInfo = new CultureInfo("en-US",false).TextInfo;
			title = textInfo.ToTitleCase(title);

			return title;
		}

		public string GeneratePreviewText(string text)
		{
			QueryScorer scorer = new QueryScorer(currentQuery);
			IFormatter formatter = new SimpleHTMLFormatter("", "");
			Highlighter highlighter = new Highlighter(formatter, scorer);
			highlighter.TextFragmenter = new SimpleFragmenter(100);
			TokenStream stream = new SnowballAnalyzer(VERSION, "English").TokenStream(URL_FN, new StringReader(text));
			//TokenStream stream = new StandardAnalyzer(VERSION).TokenStream(URL_FN, new StringReader(text));
			string fragment = highlighter.GetBestFragments(stream, text, 2, "...");
			if(string.IsNullOrEmpty(fragment))
			{
				if (text.Length > 100)
				{
					fragment = text.Substring(0, 100);
				}
				else
				{
					fragment = text;
				}
			}
			return fragment;
		}

		public string GetSynonyms(string query)
		{
			//var words = query.Split(new char[] {' '});
			//for( int i = 0; i < words.Length; i++ )
			//{
			//	var synSetList = wordNet.GetSynSets(words[i]);

			//	words[i] += "^5"; 

			//	if (synSetList.Count == 0)
			//	{
			//		continue;
			//	}

			//	foreach (var synSet in synSetList)
			//	{
			//		var synWords = synSet.Words;
			//		for( int j = 0; j < synWords.Count; j++)
			//		{
			//			if(synWords[j].Contains("_"))
			//			{
			//				synWords[j] = synWords[j].Replace("_", " ");
			//				synWords[j] = "\"" + synWords[j] + "\"";
			//			}
			//		}
			//		var synonyms = string.Join(" ", synWords);
			//		words[i] += " " + synonyms;
			//	}

			//}
			//query = string.Join(" ", words);
			//return query;

			string expandedQuery = String.Empty;

			MyThes thes = new MyThes("th_en_us_new.dat");

			using (Hunspell hunspell = new Hunspell("en_AU.aff", "en_AU.dic"))
			{
				var words = query.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				for (int i = 0; i < words.Length; i++)
				{
					List<string> stems = new List<string>();
					var word = words[i];
					expandedQuery += " " + word + "^5";
					var wordStems = hunspell.Stem(word);
					if (wordStems.Count > 0)
					{
						stems.Add(word);
						stems.AddRange(wordStems);
					}
					else
					{
						stems.Add(word);
					}

					foreach(var stem in stems)
					{
						ThesResult tr = thes.Lookup(stem, hunspell);

						if(!stem.Equals(word))
						{
							expandedQuery += " " + stem;
						}

						if(tr != null && tr.Meanings.Count > 0)
						{
							foreach (ThesMeaning meaning in tr.Meanings)
							{
								expandedQuery += " " + string.Join(" ", meaning.Synonyms);
							}
						}
					}
				}
			}
			return expandedQuery;
		}

		public string[] GetSuggestions(string query)
		{
			var terms = query.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			using (Hunspell hunspell = new Hunspell("en_AU.aff", "en_AU.dic"))
			{
				var term = terms.Last();
				var correct = hunspell.Spell(term);
				if (!correct)
				{
					var suggestions = hunspell.Suggest(term).ToArray();
					return suggestions;
				}
				return null;
			}
		}
	}
}
