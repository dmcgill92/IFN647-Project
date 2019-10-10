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
		int numQueries = 0;
		string indexPath;
        List<Entry> entries;
        private JSONParser jsonParser = new JSONParser();
        LuceneIndexer myLuceneApp = new LuceneIndexer();
		bool toProcess = true;
		List<string> relevantDocuments;
		string groupName = "BaselineSystem";

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
			var location = chkbxProcessing2.Location;
			chkbxProcessing2.Location = new Point(location.X, location.Y - 45);
			location = btnSearch2.Location;
			btnSearch2.Location = new Point(location.X, location.Y - 45);
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
			numQueries++;
			txtQueryResults.Text = string.Empty;
			if(pnlSearchHome.Visible)
			{
				pnlSearchHome.Hide();
				pnlSearchResults.Show();
			}
			dataResults.Rows.Clear();
			string queryText = txtSearchContent1.Text;
            if (chkbxProcessing1.Checked != true)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                
				
				var retrievedData = myLuceneApp.SearchIndex(queryText);

				relevantDocuments = new List<string>(retrievedData);
				
                myLuceneApp.CleanUpSearch();
				lblQueryGenTimeResult.Text = myLuceneApp.queryTime;
				txtFinalQuery.Text = myLuceneApp.finalQuery;

                //Data categorize
                int numRetrieved = retrievedData.Count;
                if (numRetrieved != 0)
                {
                    for (int i = 0; i < numRetrieved; i++)
                    {
						string[] sArray = retrievedData[i].Split(new char[] { '‰' });
						string rank = sArray[0];
						string score = sArray[1];
						string docNum = sArray[2];
						string previewText = sArray[3];
						string title = sArray[4];
						string url = sArray[5];
						string passage = sArray[6];

						if(i<10)
						{

							dataResults.Rows.Add(rank, title + "\n" + previewText + "\n" + url);
						}

						txtAllResults.AppendText(String.Format("{0}\tQ0\t{1}\t{2}\t{3}\t\t{4}", numQueries.ToString("000"), docNum, rank, score, groupName));
						txtAllResults.AppendText(Environment.NewLine);
						txtQueryResults.AppendText(String.Format("{0}\tQ0\t{1}\t{2}\t{3}\t\t{4}", numQueries.ToString("000"), docNum, rank, score, groupName));
						txtQueryResults.AppendText(Environment.NewLine);
					}
                    lblNumRelDocsResult.Text = numRetrieved.ToString();
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

		private void BtnSearchDropdown_Click(object sender, EventArgs e)
		{
			if(toProcess)
			{
				if(btnSearchDropdown.ImageIndex == 0)
				{
					btnSearchDropdown.ImageIndex = 1;
					lblFinalQuery.Show();
					txtFinalQuery.Show();
					var location = chkbxProcessing2.Location;
					chkbxProcessing2.Location = new Point(location.X, location.Y + 45);
					location = btnSearch2.Location;
					btnSearch2.Location = new Point(location.X, location.Y + 45);
				}
				else
				{
					btnSearchDropdown.ImageIndex = 0;
					lblFinalQuery.Hide();
					txtFinalQuery.Hide();
					var location = chkbxProcessing2.Location;
					chkbxProcessing2.Location = new Point(location.X, location.Y - 45);
					location = btnSearch2.Location;
					btnSearch2.Location = new Point(location.X, location.Y - 45);
				}
			}
		}

		private void ChkbxProcessing2_CheckedChanged(object sender, EventArgs e)
		{
			toProcess = !chkbxProcessing2.Checked;
			
			if(chkbxProcessing1.Checked != chkbxProcessing2.Checked)
			{
				chkbxProcessing1.Checked = chkbxProcessing2.Checked;
			}
			if (!toProcess)
			{
				btnSearchDropdown.Hide();
				if (btnSearchDropdown.ImageIndex == 1)
				{
					lblFinalQuery.Hide();
					txtFinalQuery.Hide();
					var location = chkbxProcessing2.Location;
					chkbxProcessing2.Location = new Point(location.X, location.Y - 45);
					location = btnSearch2.Location;
					btnSearch2.Location = new Point(location.X, location.Y - 45);
				}
			}
			else
			{
				btnSearchDropdown.Show();
				if (btnSearchDropdown.ImageIndex == 1)
				{
					lblFinalQuery.Show();
					txtFinalQuery.Show();
					var location = chkbxProcessing2.Location;
					chkbxProcessing2.Location = new Point(location.X, location.Y + 45);
					location = btnSearch2.Location;
					btnSearch2.Location = new Point(location.X, location.Y + 45);
				}
			}
		}

		private void ChkbxProcessing1_CheckedChanged(object sender, EventArgs e)
		{
			toProcess = !chkbxProcessing1.Checked;

			if (chkbxProcessing2.Checked != chkbxProcessing1.Checked)
			{
				chkbxProcessing2.Checked = chkbxProcessing1.Checked;
			}
			if (!toProcess)
			{
				btnSearchDropdown.Hide();
				lblFinalQuery.Hide();
				txtFinalQuery.Hide();
			}
			else
			{
				btnSearchDropdown.Show();
			}
		}

		private void DataResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var grid = (DataGridView)sender;
			var index = grid.Rows.IndexOf(grid.CurrentRow);

			var result = relevantDocuments[index];
			var sArray = result.Split(new char[] { '‰' });
			string rank = sArray[0];
			string score = sArray[1];
			string docNum = sArray[2];
			string previewText = sArray[3];
			string title = sArray[4];
			string url = sArray[5];
			string passage = sArray[6];
			MessageBox.Show( passage + "\n\n" + url, "Full Passage", MessageBoxButtons.OK, MessageBoxIcon.None);
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			saveFileDialog1.FileName = "Results";
			saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
			saveFileDialog1.DefaultExt = "txt";
			saveFileDialog1.Title = "Result file save location";
			saveFileDialog1.OverwritePrompt = true;
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string sFile = saveFileDialog1.FileName;
				var resultsString = txtAllResults.Text;
				if(saveFileDialog1.OpenFile() != null)
				{
					var lastLine = File.ReadLines(sFile).Last();
					var split = resultsString.Split(new string[] { lastLine }, StringSplitOptions.None);
					if (split.Length > 1)
					{
						resultsString = split.Last();
					}

					var lines = resultsString.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
					File.AppendAllLines(sFile, lines);
				}
				else
				{
					var lines = resultsString.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
					using(StreamWriter sw = new StreamWriter(sFile))
					{
						foreach (string line in lines)
						{
							sw.WriteLine(line);
						}
					}
				}
			}
		}
	}
}
