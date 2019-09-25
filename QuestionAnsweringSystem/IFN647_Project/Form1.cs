using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFN647_Project
{
    public partial class Form1 : Form
    {
        LuceneIndexer myLuceneApp = new LuceneIndexer();
        List<Entry> entries;
        private JSONParser jsonParser = new JSONParser();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
            openFileDialog.Title = "Select collection file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = openFileDialog.FileName;
                txtCollectionFile.Text = path;
                entries = jsonParser.ReadJSON(path);
            }
        }

        private void BtnBrowse2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.Description = "Select where to save index";
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var path = folderBrowserDialog.SelectedPath;
                txtIndexFile.Text = path;

            }
        }

        private void TxtCollectionFile_TextChanged(object sender, EventArgs e)
        {
            btnCreateIndex.Enabled = !( String.IsNullOrEmpty(txtCollectionFile.Text) || String.IsNullOrEmpty(txtIndexFile.Text));
        }

        private void TxtIndexFile_TextChanged(object sender, EventArgs e)
        {
            btnCreateIndex.Enabled = !(String.IsNullOrEmpty(txtCollectionFile.Text) || String.IsNullOrEmpty(txtIndexFile.Text));
        }

        private void BtnCreateIndex_Click(object sender, EventArgs e)
        {
            entries = jsonParser.ReadJSON(txtCollectionFile.Text);
            myLuceneApp.IndexCollection(txtIndexFile.Text + @"\Index", entries);
            pnlIndex.Visible = false;
            pnlSearch.Visible = true;
        }
    }
}
