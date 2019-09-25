using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net.Analysis; // for Analyser
using Lucene.Net.Documents; // for Document and Field
using Lucene.Net.Index; //for Index Writer
using Lucene.Net.Store; //for Directory
using System.Diagnostics;

namespace IFN647_Project
{
    class LuceneIndexer
    {
        Lucene.Net.Store.Directory luceneIndexDirectory;
        Lucene.Net.Analysis.Analyzer analyzer;
        Lucene.Net.Index.IndexWriter writer;

        const Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;
        const string TEXT_FN = "Text";

        public LuceneIndexer ()
        {
            luceneIndexDirectory = null;
            writer = null;
            analyzer = new Lucene.Net.Analysis.SimpleAnalyzer();
        }

        public void OpenIndex(string indexPath)
        {
            luceneIndexDirectory = FSDirectory.Open(indexPath);
        }

        public void CreateAnalyser()
        {
            analyzer = new SimpleAnalyzer();
        }

        public void CreateWriter()
        {
            IndexWriter.MaxFieldLength mfl = new IndexWriter.MaxFieldLength(IndexWriter.DEFAULT_MAX_FIELD_LENGTH);
            writer = new IndexWriter(luceneIndexDirectory, analyzer, true, mfl);

        }

        public void AddToIndex(Entry entry)
        {
            foreach( Passage passage in entry.passages)
            {
                Field field = new Field(TEXT_FN, passage.url + " " + passage.passage_text, Field.Store.YES, Field.Index.ANALYZED_NO_NORMS, Field.TermVector.NO);
                Document document = new Document();
                document.Add(field);
                writer.AddDocument(document);
            }
        }

        public void IndexCollection(string filePath, List<Entry> collection)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            OpenIndex(filePath);
            CreateAnalyser();
            CreateWriter();
            foreach(Entry entry in collection)
            {
                AddToIndex(entry);
            }
            CleanUp();
            watch.Stop();
            Console.WriteLine("Index Time: {0}", watch.Elapsed.TotalSeconds);
        }

        public void CleanUp()
        {
            writer.Optimize();
            writer.Flush(true, true, true);
            writer.Dispose();
        }
    }
}
