using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net.Search;
using FieldInvertState = Lucene.Net.Index.FieldInvertState;

namespace IFN647_Project
{
	public class NewSimilarity : DefaultSimilarity
	{
        public override float Idf(int docFreq, int numDocs)
        {
            return 1;
        }


        public override float LengthNorm(string fieldName, int numTerms)
		{
			return 1;
		}
	}
}
