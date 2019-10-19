using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net.Analysis; // for Analyser
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Analysis.Snowball;
using Lucene.Net.Documents; // for Document and Field
using Lucene.Net.Index; //for Index Writer
using Lucene.Net.Store; //for Directory
using Lucene.Net.Search; // for IndexSearcher
using Lucene.Net.QueryParsers;  // for QueryParser
using Lucene.Net.Search.Highlight;
using Syn.WordNet;

namespace IFN647_Project
{
    class LuceneIndexer
    {
		Similarity newSimilarity;
		Lucene.Net.Store.Directory luceneIndexDirectory;
        Lucene.Net.Analysis.Analyzer analyzer;
        Lucene.Net.Index.IndexWriter writer;
        Lucene.Net.Search.IndexSearcher searcher;
        Lucene.Net.QueryParsers.QueryParser parser;
		Query currentQuery;
		WordNetEngine wordNet;

		public string finalQuery;
		public string queryTime;

        const Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;
        const string URL_FN = "Url";
		const string PASSAGEID_FN = "Passage ID";

        public LuceneIndexer()
        {
            luceneIndexDirectory = null;
            writer = null;
			analyzer = null;
			parser = null;
			newSimilarity = new NewSimilarity();
			var directory = System.IO.Directory.GetCurrentDirectory() + @"\wordnet\";
			wordNet = new WordNetEngine();
			wordNet.LoadFromDirectory(directory);
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
        public void CreateSearcher() // Creates Searcher
        {
            searcher = new IndexSearcher(luceneIndexDirectory);
			//searcher.Similarity = newSimilarity;
        }

        public void CreateParser() // Creates Parser
        {
				parser = new QueryParser(VERSION, URL_FN, analyzer);
        }

        public void AddToIndex(Passage passage) // Indexes an entry
        {
			// Add all text to one field
			Field urlField = new Field(URL_FN, passage.url, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.NO);
			Field passageIDField = new Field(PASSAGEID_FN, passage.passage_id.ToString(), Field.Store.YES, Field.Index.NO, Field.TermVector.NO);
			Document document = new Document();
			document.Add(urlField);
			document.Add(passageIDField);
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
		
        public TopDocs SearchForQuery(string querytext, out Lucene.Net.Search.Query query, bool toProcess) // Searches index with query text
        {
			Stopwatch stopwatch2 = Stopwatch.StartNew();

			if(!toProcess)
			{
				querytext = "\"" + querytext + "\"";
			}
			else
			{
				var standardParser = new QueryParser(VERSION, URL_FN, new StandardAnalyzer(VERSION));
				querytext = standardParser.Parse(querytext).ToString().Replace("Url:", "");
				querytext = GetSynonyms(querytext);
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

		public List<Result> SearchIndex(string queryText, bool toProcess)
		{
			CreateSearcher();
			CreateParser();
			Lucene.Net.Search.Query query;
			var retrievedData = DisplayResults(SearchForQuery(queryText, out query, toProcess), query);
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
			var words = query.Split(new char[] {' '});
			for( int i = 0; i < words.Length; i++ )
			{
				var synSetList = wordNet.GetSynSets(words[i]);
				
				words[i] += "^5"; 

				if (synSetList.Count == 0)
				{
					continue;
				}

				foreach (var synSet in synSetList)
				{
					var synWords = synSet.Words;
					for( int j = 0; j < synWords.Count; j++)
					{
						if(synWords[j].Contains("_"))
						{
							synWords[j] = synWords[j].Replace("_", " ");
							synWords[j] = "\"" + synWords[j] + "\"";
						}
					}
					var synonyms = string.Join(" ", synWords);
					words[i] += " " + synonyms;
				}

			}
			query = string.Join(" ", words);
			return query;
		}
	}
}
