using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net.Analysis; // for Analyser
using Lucene.Net.Documents; // for Document and Field
using Lucene.Net.Index; //for Index Writer
using Lucene.Net.Store; //for Directory

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
            /* Make sure to pass a new directory that does not exist */
            luceneIndexDirectory = FSDirectory.Open(indexPath);
        }

        public void CreateAnalyser()
        {
            // TODO: Enter code to create the Lucene Analyser 
            analyzer = new SimpleAnalyzer();
        }

        public void CreateWriter()
        {
            IndexWriter.MaxFieldLength mfl = new IndexWriter.MaxFieldLength(IndexWriter.DEFAULT_MAX_FIELD_LENGTH);
            // TODO: Enter code to create the Lucene Writer 
            writer = new IndexWriter(luceneIndexDirectory, analyzer, true, mfl);

        }

        public void AddToIndex(Entry entry)
        {
            foreach( Passage passage in entry.passages)
            {
                Field passageField = new Field("Passage", passage.passage_text, Field.Store.YES, Field.Index.ANALYZED);
                NumericField idField = new NumericField("ID", passage.passage_id, Field.Store.YES, true);
                Field urlField = new Field("URL", passage.url, Field.Store.YES, Field.Index.NOT_ANALYZED);
                Document document = new Document();
                document.Add(passageField);
                document.Add(idField);
                document.Add(urlField);
                writer.AddDocument(document);
            }
        }

        public void IndexCollection(string filePath, List<Entry> collection)
        {
            OpenIndex(filePath);
            CreateAnalyser();
            CreateWriter();
            foreach(Entry entry in collection)
            {
                AddToIndex(entry);
            }
            CleanUp();
        }

        public void CleanUp()
        {
            writer.Optimize();
            writer.Flush(true, true, true);
            writer.Dispose();
        }
    }
}
