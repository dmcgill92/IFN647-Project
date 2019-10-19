using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFN647_Project
{
	class Result
	{
		public int rank { get; set; }
		public float score { get; set; }
		public string title { get; set; }
		public string url { get; set; }
		public string previewText { get; set; }
		public string passage { get; set; }
		public int passage_id { get; set; }

		public Result(int rank, float score, string title, string url, string previewText, string passage, int passage_id)
		{
			this.rank = rank;
			this.score = score;
			this.title = title;
			this.url = url;
			this.previewText = previewText;
			this.passage = passage;
			this.passage_id = passage_id;
		}
	}
}
