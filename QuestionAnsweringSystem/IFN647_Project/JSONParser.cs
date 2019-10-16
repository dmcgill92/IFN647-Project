using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IFN647_Project
{
    class JSONParser
    {
        public Dictionary<int, Passage> ReadJSON(string pathFile, out Dictionary<int, string> queries)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            List<Entry> items;
			Dictionary<int, Passage> collection = new Dictionary<int, Passage>();
			queries = new Dictionary<int, string>();
            using (StreamReader sr = File.OpenText(pathFile))
            {
                var json = sr.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<Entry>>(json);
            }

			foreach(var item in items)
			{
				queries.Add(item.query_id, item.query);
				foreach (var passage in item.passages)
				{
					passage.query_id = item.query_id;
					collection.Add(passage.passage_id, passage);
				}
			}
            stopwatch.Stop();
            string time = stopwatch.Elapsed.TotalMilliseconds.ToString();
            return collection;
        }
    }
}
