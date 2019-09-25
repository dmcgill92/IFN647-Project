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
        public List<Entry> ReadJSON(string pathFile) // Parses JSON data to list of 'Entry'
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            List<Entry> items;
            using (StreamReader sr = File.OpenText(pathFile))
            {
                var json = sr.ReadToEnd(); // Reads the whole file to a string
                items = JsonConvert.DeserializeObject<List<Entry>>(json); // Converts json string to list of 'Entry'
                //foreach( var item in items)
                //{
                //    Console.WriteLine("{0} {1}", item.query, item.query_id);
                //}
            }
            stopwatch.Stop();
            Console.WriteLine("Parsing Time: {0}", stopwatch.Elapsed.TotalSeconds);
            return items;
        }
    }
}
