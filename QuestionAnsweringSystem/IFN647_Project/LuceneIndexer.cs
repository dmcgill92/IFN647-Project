using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net.Analysis; // for Analyser
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
        Lucene.Net.Store.Directory luceneIndexDirectory;
        Lucene.Net.Analysis.Analyzer analyzer;
        Lucene.Net.Index.IndexWriter writer;
        Lucene.Net.Search.IndexSearcher searcher;
        Lucene.Net.QueryParsers.QueryParser parser;

		public string finalQuery;
		public string queryTime;

        const Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;
        const string TEXT_FN = "Text";

        public LuceneIndexer()
        {
            luceneIndexDirectory = null;
            writer = null;
            analyzer = new Lucene.Net.Analysis.SimpleAnalyzer();
            parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, TEXT_FN, analyzer);
        }

        public void OpenIndex(string indexPath) // Opens the index directory
        {
            luceneIndexDirectory = FSDirectory.Open(indexPath);
        }

        public void CreateAnalyser() // Creates analyzer
        {
            analyzer = new SimpleAnalyzer();
        }

        public void CreateWriter() // Creates index writer
        {
            IndexWriter.MaxFieldLength mfl = new IndexWriter.MaxFieldLength(IndexWriter.DEFAULT_MAX_FIELD_LENGTH);
            writer = new IndexWriter(luceneIndexDirectory, analyzer, true, mfl);

        }
        public void CreateSearcher() // Creates Searcher
        {
            searcher = new IndexSearcher(luceneIndexDirectory);
        }

        public void CreateParser() // Creates Parser
        {
				parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, TEXT_FN, analyzer);
        }

        public void AddToIndex(Entry entry) // Indexes an entry
        {
            foreach (string item in entry.answers)
            {
                foreach (Passage passage in entry.passages)
                {
					// Add all text to one field
                    Field field = new Field(TEXT_FN, "‰" + passage.url + "‰" + passage.passage_text,Field.Store.YES, Field.Index.ANALYZED_NO_NORMS, Field.TermVector.NO);
                    Document document = new Document();
                    document.Add(field);
                    writer.AddDocument(document);
                }
            }
        }

        public void IndexCollection(string filePath, List<Entry> collection) // Indexes the coillection
        {
            OpenIndex(filePath);
            CreateAnalyser();
            CreateWriter();
            foreach (Entry entry in collection)
            {
                AddToIndex(entry);
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
		
        public TopDocs SearchForQuery(string querytext, out Query query, bool toProcess) // Searches index with query text
        {
			Stopwatch stopwatch2 = Stopwatch.StartNew();
			querytext = querytext.ToLower();
			if(!toProcess)
			{
				querytext = "\"" + querytext + "\"";
			}
            query = parser.Parse(querytext);
			stopwatch2.Stop();
			queryTime = stopwatch2.Elapsed.TotalSeconds.ToString();
			finalQuery = query.ToString();
            TopDocs results = searcher.Search(query, 100);
            return results;
        }

		public List<string> SearchIndex(string queryText, bool toProcess)
		{
			CreateSearcher();
			CreateParser();
			Query query;
			var retrievedData = DisplayResults(SearchForQuery(queryText, out query, toProcess), query);
			return retrievedData;
		}

        public List<string> DisplayResults(TopDocs results, Query query)
        {
            int rank = 0;
            List<string> retrievedResults = new List<string>();
            foreach (ScoreDoc scoreDoc in results.ScoreDocs)
            {
                rank++;
                // retrieve the document from the 'ScoreDoc' object
                Lucene.Net.Documents.Document doc = searcher.Doc(scoreDoc.Doc);
                string myFieldValue = doc.Get(TEXT_FN).ToString();
				//Console.WriteLine("Rank " + rank + " score " + scoreDoc.Score + " text " + myFieldValue);
				//console.writeline("rank " + rank + "\n"+ myfieldvalue);
				string[] sArray = myFieldValue.Split(new char[]{'‰'}, StringSplitOptions.RemoveEmptyEntries);
				string title = GetTitle(sArray[0]);
				string previewText = GeneratePreviewText(query, sArray[1]);
				retrievedResults.Add(rank + "‰" + scoreDoc.Score + "‰" + scoreDoc.Doc + "‰" + previewText + "‰" + title + myFieldValue);


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

		public string GeneratePreviewText(Query q, string text)
		{
			QueryScorer scorer = new QueryScorer(q);
			IFormatter formatter = new SimpleHTMLFormatter("", "");
			Highlighter highlighter = new Highlighter(formatter, scorer);
			highlighter.TextFragmenter = new SimpleFragmenter(100);
			TokenStream stream = new SimpleAnalyzer().TokenStream(TEXT_FN, new StringReader(text));
			string fragment = highlighter.GetBestFragments(stream, text, 2, "...");
			if(string.IsNullOrEmpty(fragment))
			{
				fragment = text.Substring(0, 100);
			}
			return fragment;
		}
	}
}
