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
        public List<Entry> ReadJSON(string pathFile)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            List<Entry> items;
            using (StreamReader sr = File.OpenText(pathFile))
            {
                var json = sr.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<Entry>>(json);
                foreach( var item in items)
                {
                    Console.WriteLine("{0} {1}", item.query, item.query_id);
                }
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed.TotalMilliseconds.ToString());
            return items;
        }
    }
}
