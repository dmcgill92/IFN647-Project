using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Documents;

namespace IFN647_Project
{
    public partial class Form1 : Form
    {
		int numQueries = 0;
		string indexPath;
		Dictionary<int, Passage> collection;
		Dictionary<int, string> queries;
        private JSONParser jsonParser = new JSONParser();
        LuceneIndexer myLuceneApp = new LuceneIndexer();
		bool toProcess = true;
		bool queryExpansion = false;
		int boostIndex = 0;
		List<Result> relevantDocuments;
		string groupName = "ImprovedSystem";
		string queryText = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
		{
			txtAllResults.SelectionTabs = new int[] { 60, 110, 160, 210, 290 };
			txtQueryResults.SelectionTabs = new int[] { 60, 110, 160, 210, 290 };
			cmbbxBoosting1.SelectedIndex = 0;
			cmbbxBoosting2.SelectedIndex = 0;
		}

        private void BtnBrowse_Click(object sender, EventArgs e) // Opens file browser, user selects the .json collection
        {
            openFileDialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
            openFileDialog.Title = "Select collection file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = openFileDialog.FileName;
                txtCollectionFile.Text = path;
				if (collection != null)
				{
					collection.Clear();
				}
				if (queries != null)
				{
					queries.Clear();
				}
				collection = jsonParser.ReadJSON(path, out queries);
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
			myLuceneApp.IndexCollection(txtIndexFile.Text + @"\Index", collection);
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
				var suggestions = myLuceneApp.GetSuggestions(txtSearchContent1.Text);
				if (suggestions != null && suggestions.Length > 0)
				{
					var max = suggestions.Length >= 3 ? 3 : suggestions.Length;
					var suggestionsJoined = string.Join(", ", suggestions, 0, max);
					lblSuggestions1.Show();
					lblSuggestions1.Text = String.Format("Did you mean: {0}", suggestionsJoined);
				}
				else
				{
					lblSuggestions1.Hide();
				}
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
			tblResults.RowCount = 1;
			tblResults.Controls.Clear();
			tblResults.RowStyles.Clear();
			queryText = txtSearchContent1.Text;

            Stopwatch stopwatch = Stopwatch.StartNew();

			relevantDocuments = myLuceneApp.SearchIndex(queryText, toProcess, queryExpansion, boostIndex);
				
            myLuceneApp.CleanUpSearch();
			lblQueryGenTimeResult.Text = myLuceneApp.queryTime;
			txtFinalQuery.Text = myLuceneApp.finalQuery;

            //Data categorize
            int numRetrieved = relevantDocuments.Count;
            if (numRetrieved != 0)
            {
				int currentQueryID = 0;
                for (int i = 0; i < numRetrieved; i++)
                {
					var result = relevantDocuments[i];
					result.passage = collection[result.passage_id].passage_text;
					result.previewText = myLuceneApp.GeneratePreviewText(result.passage);

					if(i == 0)
					{
						currentQueryID = collection[result.passage_id].query_id;
					}

					txtAllResults.AppendText(String.Format("{0}\tQ0\t{1}\t{2}\t{3}\t{4}", currentQueryID.ToString("000"), result.passage_id, result.rank, result.score, groupName));
					txtAllResults.AppendText(Environment.NewLine);
					txtQueryResults.AppendText(String.Format("{0}\tQ0\t{1}\t{2}\t{3}\t{4}", currentQueryID.ToString("000"), result.passage_id, result.rank, result.score, groupName));
					txtQueryResults.AppendText(Environment.NewLine);
				}

				for( int i = 0; i < numRetrieved; i++)
				{
					if(i >= 10)
					{
						break;
					}
					var result = relevantDocuments[i];
					var rtResult = new RichTextBox();
					rtResult.Name = i.ToString();
					rtResult.Clear();
					rtResult.DeselectAll();
					rtResult.SelectionFont = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Bold);
					rtResult.AppendText(result.title);
					rtResult.AppendText(Environment.NewLine);
					rtResult.SelectionFont = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular);
					rtResult.AppendText(result.previewText);
					rtResult.AppendText(Environment.NewLine);
					rtResult.AppendText(result.url);
					rtResult.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
					rtResult.ScrollBars = RichTextBoxScrollBars.None;
					rtResult.WordWrap = true;
					rtResult.Multiline = true;
					rtResult.ReadOnly = true;
					rtResult.Dock = DockStyle.Top;
					rtResult.ContentsResized += rtb_ContentsResized;
					rtResult.DoubleClick += rtb_DoubleClick;

					// Highlight text
					string[] words = queryText.Split(' ');
					foreach (string word in words)
					{
						int startindex = 0;
						while (startindex < rtResult.TextLength)
						{
							int wordstartIndex = rtResult.Find(word, startindex, RichTextBoxFinds.None);
							if (wordstartIndex != -1)
							{
								rtResult.SelectionStart = wordstartIndex;
								rtResult.SelectionLength = word.Length;
								rtResult.SelectionBackColor = Color.Yellow;
							}
							else
								break;
							startindex += wordstartIndex + word.Length;
						}
					}

					tblResults.RowCount = i + 1;
					tblResults.RowStyles.Add(new RowStyle(SizeType.AutoSize));
					tblResults.Controls.Add(rtResult, 0, i);

					tblResults.AutoScroll = false;
					tblResults.AutoScroll = true;
					int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;
					tblResults.Padding = new Padding(0, 0, vertScrollWidth, 0);
				}

                lblNumRelDocsResult.Text = numRetrieved.ToString();
                stopwatch.Stop();
                lblSearchingTimesResult.Text = stopwatch.Elapsed.TotalSeconds.ToString();
            }
			pnlSearchHome.Hide();
			pnlSearch.Show();
        }

		private void rtb_ContentsResized(object sender, ContentsResizedEventArgs e)
		{
			((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
		}

		private void ChkbxProcessing1_CheckedChanged(object sender, EventArgs e)
		{
			toProcess = !chkbxProcessing1.Checked;

			if (chkbxProcessing2.Checked != chkbxProcessing1.Checked)
			{
				chkbxProcessing2.Checked = chkbxProcessing1.Checked;
			}

			if(toProcess == false)
			{
				chkbxQueryExpansion1.Enabled = false;
				chkbxQueryExpansion2.Enabled = false;
			}
			else
			{
				chkbxQueryExpansion1.Enabled = true;
				chkbxQueryExpansion2.Enabled = true;
			}
		}

		private void ChkbxProcessing2_CheckedChanged(object sender, EventArgs e)
		{
			toProcess = !chkbxProcessing2.Checked;
			
			if(chkbxProcessing1.Checked != chkbxProcessing2.Checked)
			{
				chkbxProcessing1.Checked = chkbxProcessing2.Checked;
			}

			if (toProcess == false)
			{
				chkbxQueryExpansion1.Enabled = false;
				chkbxQueryExpansion2.Enabled = false;
			}
			else
			{
				chkbxQueryExpansion1.Enabled = true;
				chkbxQueryExpansion2.Enabled = true;
			}
		}

		private void rtb_DoubleClick(object sender, EventArgs e)
		{
			var rtBox = (RichTextBox)sender;
			var index = Int32.Parse(rtBox.Name);

			var result = relevantDocuments[index];

			MessageBox.Show( result.passage + "\n\n" + result.url, "Full Passage", MessageBoxButtons.OK, MessageBoxIcon.None);
		}

		private void ChkbxQueryExpansion1_CheckedChanged(object sender, EventArgs e)
		{
			queryExpansion = chkbxQueryExpansion1.Checked;
			if(chkbxQueryExpansion2.Checked != chkbxQueryExpansion1.Checked)
			{
				chkbxQueryExpansion2.Checked = chkbxQueryExpansion1.Checked;
			}

			if (queryExpansion == true)
			{
				chkbxProcessing1.Enabled = false;
				chkbxProcessing2.Enabled = false;
			}
			else
			{
				chkbxProcessing1.Enabled = true;
				chkbxProcessing2.Enabled = true;
			}
		}

		private void ChkbxQueryExpansion2_CheckedChanged(object sender, EventArgs e)
		{
			queryExpansion = chkbxQueryExpansion2.Checked;
			if (chkbxQueryExpansion1.Checked != chkbxQueryExpansion2.Checked)
			{
				chkbxQueryExpansion1.Checked = chkbxQueryExpansion2.Checked;
			}

			if (queryExpansion == true)
			{
				chkbxProcessing1.Enabled = false;
				chkbxProcessing2.Enabled = false;
			}
			else
			{
				chkbxProcessing1.Enabled = true;
				chkbxProcessing2.Enabled = true;
			}
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
				bool append = false;
				string lastLine;
				string[] split;

				if (File.Exists(sFile))
				{
					append = true;
					lastLine = File.ReadLines(sFile).Last();
					split = resultsString.Split(new string[] { lastLine }, StringSplitOptions.None);
					if (split.Length > 1)
					{
						resultsString = split.Last();
					}
				}
				using(StreamWriter sw = new StreamWriter(sFile, append))
				{
					if (append)
					{
						sw.Write("\n");
					}
					var lines = resultsString.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
					foreach (string line in lines)
					{
						sw.Write(line + "\n");
					}
				}
			}
		}

		private void CmbbxBoosting1_SelectedIndexChanged(object sender, EventArgs e)
		{
			boostIndex = cmbbxBoosting1.SelectedIndex;

			if(cmbbxBoosting2.SelectedIndex != cmbbxBoosting1.SelectedIndex)
			{
				cmbbxBoosting2.SelectedIndex = cmbbxBoosting1.SelectedIndex;
			}
		}

		private void CmbbxBoosting2_SelectedIndexChanged(object sender, EventArgs e)
		{
			boostIndex = cmbbxBoosting2.SelectedIndex;

			if (cmbbxBoosting1.SelectedIndex != cmbbxBoosting2.SelectedIndex)
			{
				cmbbxBoosting1.SelectedIndex = cmbbxBoosting2.SelectedIndex;
			}
		}
	}
}
