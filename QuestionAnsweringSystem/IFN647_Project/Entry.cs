using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFN647_Project
{
    class Entry
    {
        public List<Passage> passages { get; set; }
        public int query_id { get; set; }
        public List<string> answers { get; set; }
        public string query_type { get; set; }
        public string query { get; set; }
    }
    class Passage
    {
        public int is_selected { get; set; }
        public string url { get; set; }
        public string passage_text { get; set; }
        public int passage_id { get; set; }
    }



    class Collection
    {
        private string[] _rank;
        private string[] _score;
        private string[] _id;
        private string[] _myurl;
        private string[] _myanswer;
        private string[] _mytext;
        private string[] _save_result;
        private string[] _is_selected;
        private string[] _myquery;
        private string[] _mycranqrel;
		private string[] _preview_text;

        public string[] Rank
        {
            get { return _rank; }
            set { _rank = value; }
        }
        public string[] Score
        {
            get { return _score; }
            set { _score = value; }
        }
        public string[] ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string[] Myurl
        {
            get { return _myurl; }
            set { _myurl = value; }
        }
        public string[] Myanswer
        {
            get { return _myanswer; }
            set { _myanswer = value; }
        }
        public string[] Mytext
        {
            get { return _mytext; }
            set { _mytext = value; }
        }
        public string[] Myresult
        {
            get { return _save_result; }
            set { _save_result = value; }
        }
        public string[] Selected
        {
            get { return _is_selected; }
            set { _is_selected = value; }
        }
        public string[] Query
        {
            get { return _myquery; }
            set { _myquery = value; }
        }
        public string[] Cranqrel
        {
            get { return _mycranqrel; }
            set { _mycranqrel = value; }
        }

		public string[] Preview_text { get => _preview_text; set => _preview_text = value; }

		public Collection()
        {


        }//constructor

        public Collection(int sizeOFArray)
        {
            this._rank = new string[sizeOFArray];
            this._score = new string[sizeOFArray];
            this._id = new string[sizeOFArray];
            this._myurl = new string[sizeOFArray];
            this._myanswer = new string[sizeOFArray];
            this._mytext = new string[sizeOFArray];
            this._save_result = new string[sizeOFArray];
            this._is_selected = new string[sizeOFArray];
            this._myquery = new string[sizeOFArray];
            this._mycranqrel = new string[sizeOFArray];
			this._preview_text = new string[sizeOFArray];
        }
    }





}
