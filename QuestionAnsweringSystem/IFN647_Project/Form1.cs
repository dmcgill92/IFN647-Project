using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Documents;

namespace IFN647_Project
{
    public partial class Form1 : Form
    {
		string indexPath;
        List<Entry> entries;
        private JSONParser jsonParser = new JSONParser();
        LuceneIndexer myLuceneApp = new LuceneIndexer();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnBrowse_Click(object sender, EventArgs e) // Opens file browser, user selects the .json collection
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

        private void BtnBrowse2_Click(object sender, EventArgs e) // Opens a folder browser, user selects where to save the index
        {
            folderBrowserDialog.Description = "Select where to save index";
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var path = folderBrowserDialog.SelectedPath;
				indexPath = path;
                txtIndexFile.Text = path;

            }
        }

        private void TxtCollectionFile_TextChanged(object sender, EventArgs e) // Activates create index button when collection and index location are set
		{
            btnCreateIndex.Enabled = !( String.IsNullOrEmpty(txtCollectionFile.Text) || String.IsNullOrEmpty(txtIndexFile.Text));
        }

        private void TxtIndexFile_TextChanged(object sender, EventArgs e) // Activates create index button when collection and index location are set
		{
            btnCreateIndex.Enabled = !(String.IsNullOrEmpty(txtCollectionFile.Text) || String.IsNullOrEmpty(txtIndexFile.Text));
        }

        private void BtnCreateIndex_Click(object sender, EventArgs e) // Parses .json collection and creates index files
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            entries = jsonParser.ReadJSON(txtCollectionFile.Text);
            myLuceneApp.IndexCollection(txtIndexFile.Text + @"\Index", entries);
            stopwatch.Stop();

			lblIndexTimeResult.Text = stopwatch.Elapsed.TotalSeconds.ToString();
			pnlIndex.Hide();
			pnlSearch.Show();
			pnlSearchHome.Show();
        }

        private void TxtSearchContent1_TextChanged(object sender, EventArgs e) // Ensures search text boxes contain the same text
        {
			if(txtSearchContent2.Text != txtSearchContent1.Text)
			{
				txtSearchContent2.Text = txtSearchContent1.Text;
			}
			if(!String.IsNullOrEmpty(txtSearchContent1.Text))
			{
				btnSearch1.Enabled = true;
				btnSearch2.Enabled = true;
			}
			else
			{
				btnSearch1.Enabled = false;
				btnSearch2.Enabled = false;
			}
        }

		private void TxtSearchContent2_TextChanged(object sender, EventArgs e) // Ensures search text boxes contain the same text, activates search button when it contains text
		{
			if (txtSearchContent1.Text != txtSearchContent2.Text)
			{
				txtSearchContent1.Text = txtSearchContent2.Text;
			}

			if (!String.IsNullOrEmpty(txtSearchContent2.Text))
			{
				btnSearch1.Enabled = true;
				btnSearch2.Enabled = true;
			}
			else
			{
				btnSearch1.Enabled = false;
				btnSearch2.Enabled = false;
			}
		}

		private void BtnSearch_Click(object sender, EventArgs e)
		{
			if(pnlSearchHome.Visible)
			{
				pnlSearchHome.Hide();
				pnlSearchResults.Show();
			}
			dataResults.Rows.Clear();
			string queryText = txtSearchContent1.Text;
			List<string> relevantDocuments = new List<string>();
            if (chkbxProcessing1.Checked != true)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                
				
				var retrievedData = myLuceneApp.SearchIndex(queryText);
				
                myLuceneApp.CleanUpSearch();
				lblQueryGenTimeResult.Text = myLuceneApp.queryTime;
				txtFinalQuery.Text = myLuceneApp.finalQuery;

                //Data categorize
                int numRetrieved = retrievedData.Count;
                Collection mycollect = new Collection(numRetrieved);
                if (numRetrieved != 0)
                {
                    for (int i = 0; i < numRetrieved; i++)
                    {
                        string[] sArray = retrievedData[i].Split('‰');
                        mycollect.Rank[i] = sArray[1];
						mycollect.Preview_text[i] = sArray[3];
                        mycollect.ID[i] = sArray[4];
                        mycollect.Myurl[i] = sArray[5];
                        mycollect.Myanswer[i] = sArray[6];
                        mycollect.Mytext[i] = sArray[7];
                        mycollect.Selected[i] = sArray[8];
                        mycollect.Query[i] = sArray[9];

						if(i<10)
						{
							string url = mycollect.Myurl[i];
							relevantDocuments.Add(mycollect.Mytext[i]);

							dataResults.Rows.Add(mycollect.Rank[i].ToString(), String.Format("{0}\n", mycollect.Myurl[i]) + String.Format("{0}", mycollect.Preview_text[i]));
						}

                    }
                    lblNumRelDocsResult.Text = (relevantDocuments.Count).ToString();

                    //Codes to get the sample answer
                    txtAnswer.Text = "Query: " + mycollect.Query[0] + "\n\n" + "Answer: " + mycollect.Myanswer[0]
                        + "\n\n" + "Relevant Passage: " + mycollect.Mytext[0];
                    //---------------------------------------------
                    stopwatch.Stop();
                    lblSearchingTimesResult.Text = stopwatch.Elapsed.TotalSeconds.ToString();
                }
            }
            else
            {

            }
			pnlSearchHome.Hide();
			pnlSearch.Show();
        }
        
        

        private void Time_Click(object sender, EventArgs e)
        {
            
        }

        private void Processing_choice_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Without_Process_CheckedChanged(object sender, EventArgs e)
        {
  
        }

        private void Searching_time_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Number_result_Click(object sender, EventArgs e)
        {
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string name = saveFileDialog1.FileName;
                File.WriteAllText(name, richTextBox2.Text);
            }
        }



        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void RichTextBox2_TextChanged(object sender, EventArgs e)
        {


            



        }

        private void Coun_time_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Task4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Matching_text_TextChanged(object sender, EventArgs e)
        {

        }


        private void Save_cranqrel_Click(object sender, EventArgs e)
        {
            DialogResult result = savedialogconqrel.ShowDialog();
            if (result == DialogResult.OK)
            {
                string name = savedialogconqrel.FileName;
                File.WriteAllText(name, save_conqrel.Text);
            }
        }

        private void Savedialogconqrel_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Save_conqrel_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Link_Click(object sender, EventArgs e)
        {
            //string appName = @"C:\Users\luke666\Desktop\study\lecture\data retirve\9\tut\WordNet 2.1.lnk";
            //Process.Start(appName);
            //MessageBox.Show(String.Format("外部程序 {0} 启动完成！", appName), this.Text,
            //    MessageBoxButtons.OK, MessageBoxIcon.Information);

            //load_word.Load_wordnet();

        }

		private void TabDiagnostics_Click(object sender, EventArgs e)
		{

		}
	}
}
