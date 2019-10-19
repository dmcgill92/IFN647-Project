using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFN647_Project
{
	class Passage
	{
		public int is_selected { get; set; }
		public string url { get; set; }
		public string passage_text { get; set; }
		public int passage_id { get; set; }
		public int query_id { get; set; }
		public string query { get; set; }
	}
}
