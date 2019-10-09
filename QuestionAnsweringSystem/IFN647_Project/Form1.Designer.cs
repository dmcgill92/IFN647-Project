namespace IFN647_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.txtCollectionFile = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.lblCollectionFile = new System.Windows.Forms.Label();
			this.txtIndexFile = new System.Windows.Forms.TextBox();
			this.btnBrowse2 = new System.Windows.Forms.Button();
			this.lblIndexSave = new System.Windows.Forms.Label();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.btnCreateIndex = new System.Windows.Forms.Button();
			this.txtSearchContent1 = new System.Windows.Forms.TextBox();
			this.lblSearch1 = new System.Windows.Forms.Label();
			this.btnSearch1 = new System.Windows.Forms.Button();
			this.lblQueryGenTimeResult = new System.Windows.Forms.Label();
			this.lblIndexTime = new System.Windows.Forms.Label();
			this.lblQueryGenTime = new System.Windows.Forms.Label();
			this.lblSearchingTimesResult = new System.Windows.Forms.Label();
			this.lblFinalQuery = new System.Windows.Forms.Label();
			this.lblNumRelDocs = new System.Windows.Forms.Label();
			this.lblNumRelDocsResult = new System.Windows.Forms.Label();
			this.txtAnswer = new System.Windows.Forms.RichTextBox();
			this.txtFinalQuery = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.lblSearchingTimes = new System.Windows.Forms.Label();
			this.lblIndexTimeResult = new System.Windows.Forms.Label();
			this.task4 = new System.Windows.Forms.RichTextBox();
			this.lblQueryBaseline = new System.Windows.Forms.Label();
			this.lblQueryBaselineAll = new System.Windows.Forms.Label();
			this.lblAnswer = new System.Windows.Forms.Label();
			this.lblRelevantDocuments = new System.Windows.Forms.Label();
			this.btnSaveCranqrel = new System.Windows.Forms.Button();
			this.savedialogconqrel = new System.Windows.Forms.SaveFileDialog();
			this.lblCranqrel = new System.Windows.Forms.Label();
			this.save_conqrel = new System.Windows.Forms.RichTextBox();
			this.richTextBox3 = new System.Windows.Forms.RichTextBox();
			this.Link = new System.Windows.Forms.Button();
			this.pnlIndex = new System.Windows.Forms.Panel();
			this.pnlSearchHome = new System.Windows.Forms.Panel();
			this.chkbxProcessing1 = new System.Windows.Forms.CheckBox();
			this.pnlSearch = new System.Windows.Forms.Panel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabSearch = new System.Windows.Forms.TabPage();
			this.pnlSearchResults = new System.Windows.Forms.Panel();
			this.lblSearch2 = new System.Windows.Forms.Label();
			this.txtSearchContent2 = new System.Windows.Forms.TextBox();
			this.btnSearch2 = new System.Windows.Forms.Button();
			this.chlbxProcessing2 = new System.Windows.Forms.CheckBox();
			this.tabDiagnostics = new System.Windows.Forms.TabPage();
			this.dataResults = new System.Windows.Forms.DataGridView();
			this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.pnlIndex.SuspendLayout();
			this.pnlSearchHome.SuspendLayout();
			this.pnlSearch.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabSearch.SuspendLayout();
			this.pnlSearchResults.SuspendLayout();
			this.tabDiagnostics.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataResults)).BeginInit();
			this.SuspendLayout();
			// 
			// txtCollectionFile
			// 
			this.txtCollectionFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtCollectionFile.Location = new System.Drawing.Point(386, 116);
			this.txtCollectionFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCollectionFile.Name = "txtCollectionFile";
			this.txtCollectionFile.ReadOnly = true;
			this.txtCollectionFile.Size = new System.Drawing.Size(396, 20);
			this.txtCollectionFile.TabIndex = 0;
			this.txtCollectionFile.TextChanged += new System.EventHandler(this.TxtCollectionFile_TextChanged);
			// 
			// btnBrowse
			// 
			this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnBrowse.Location = new System.Drawing.Point(543, 142);
			this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(82, 30);
			this.btnBrowse.TabIndex = 1;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
			// 
			// lblCollectionFile
			// 
			this.lblCollectionFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblCollectionFile.AutoSize = true;
			this.lblCollectionFile.Location = new System.Drawing.Point(536, 99);
			this.lblCollectionFile.Name = "lblCollectionFile";
			this.lblCollectionFile.Size = new System.Drawing.Size(97, 13);
			this.lblCollectionFile.TabIndex = 2;
			this.lblCollectionFile.Text = "Collection Location";
			// 
			// txtIndexFile
			// 
			this.txtIndexFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtIndexFile.Location = new System.Drawing.Point(386, 247);
			this.txtIndexFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtIndexFile.Name = "txtIndexFile";
			this.txtIndexFile.ReadOnly = true;
			this.txtIndexFile.Size = new System.Drawing.Size(396, 20);
			this.txtIndexFile.TabIndex = 0;
			this.txtIndexFile.TextChanged += new System.EventHandler(this.TxtIndexFile_TextChanged);
			// 
			// btnBrowse2
			// 
			this.btnBrowse2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnBrowse2.Location = new System.Drawing.Point(544, 271);
			this.btnBrowse2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBrowse2.Name = "btnBrowse2";
			this.btnBrowse2.Size = new System.Drawing.Size(81, 30);
			this.btnBrowse2.TabIndex = 1;
			this.btnBrowse2.Text = "Browse";
			this.btnBrowse2.UseVisualStyleBackColor = true;
			this.btnBrowse2.Click += new System.EventHandler(this.BtnBrowse2_Click);
			// 
			// lblIndexSave
			// 
			this.lblIndexSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblIndexSave.AutoSize = true;
			this.lblIndexSave.Location = new System.Drawing.Point(532, 232);
			this.lblIndexSave.Name = "lblIndexSave";
			this.lblIndexSave.Size = new System.Drawing.Size(105, 13);
			this.lblIndexSave.TabIndex = 2;
			this.lblIndexSave.Text = "Index Save Location";
			// 
			// btnCreateIndex
			// 
			this.btnCreateIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCreateIndex.Enabled = false;
			this.btnCreateIndex.Location = new System.Drawing.Point(1069, 535);
			this.btnCreateIndex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCreateIndex.Name = "btnCreateIndex";
			this.btnCreateIndex.Size = new System.Drawing.Size(82, 30);
			this.btnCreateIndex.TabIndex = 1;
			this.btnCreateIndex.Text = "Create Index";
			this.btnCreateIndex.UseVisualStyleBackColor = true;
			this.btnCreateIndex.Click += new System.EventHandler(this.BtnCreateIndex_Click);
			// 
			// txtSearchContent1
			// 
			this.txtSearchContent1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtSearchContent1.Location = new System.Drawing.Point(329, 229);
			this.txtSearchContent1.Margin = new System.Windows.Forms.Padding(2);
			this.txtSearchContent1.Name = "txtSearchContent1";
			this.txtSearchContent1.Size = new System.Drawing.Size(496, 20);
			this.txtSearchContent1.TabIndex = 3;
			this.txtSearchContent1.TextChanged += new System.EventHandler(this.TxtSearchContent1_TextChanged);
			// 
			// lblSearch1
			// 
			this.lblSearch1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblSearch1.AutoSize = true;
			this.lblSearch1.Location = new System.Drawing.Point(523, 203);
			this.lblSearch1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSearch1.Name = "lblSearch1";
			this.lblSearch1.Size = new System.Drawing.Size(108, 13);
			this.lblSearch1.TabIndex = 4;
			this.lblSearch1.Text = "Input Search Content";
			// 
			// btnSearch1
			// 
			this.btnSearch1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnSearch1.Enabled = false;
			this.btnSearch1.Location = new System.Drawing.Point(538, 300);
			this.btnSearch1.Margin = new System.Windows.Forms.Padding(2);
			this.btnSearch1.Name = "btnSearch1";
			this.btnSearch1.Size = new System.Drawing.Size(78, 27);
			this.btnSearch1.TabIndex = 5;
			this.btnSearch1.Text = "Search";
			this.btnSearch1.UseMnemonic = false;
			this.btnSearch1.UseVisualStyleBackColor = true;
			this.btnSearch1.Click += new System.EventHandler(this.BtnSearch_Click);
			// 
			// lblQueryGenTimeResult
			// 
			this.lblQueryGenTimeResult.AutoSize = true;
			this.lblQueryGenTimeResult.Location = new System.Drawing.Point(171, 43);
			this.lblQueryGenTimeResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblQueryGenTimeResult.Name = "lblQueryGenTimeResult";
			this.lblQueryGenTimeResult.Size = new System.Drawing.Size(13, 13);
			this.lblQueryGenTimeResult.TabIndex = 6;
			this.lblQueryGenTimeResult.Text = "0";
			this.lblQueryGenTimeResult.Click += new System.EventHandler(this.Time_Click);
			// 
			// lblIndexTime
			// 
			this.lblIndexTime.AutoSize = true;
			this.lblIndexTime.Location = new System.Drawing.Point(33, 66);
			this.lblIndexTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblIndexTime.Name = "lblIndexTime";
			this.lblIndexTime.Size = new System.Drawing.Size(96, 13);
			this.lblIndexTime.TabIndex = 9;
			this.lblIndexTime.Text = "Time for indexing:  ";
			// 
			// lblQueryGenTime
			// 
			this.lblQueryGenTime.AutoSize = true;
			this.lblQueryGenTime.Location = new System.Drawing.Point(33, 43);
			this.lblQueryGenTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblQueryGenTime.Name = "lblQueryGenTime";
			this.lblQueryGenTime.Size = new System.Drawing.Size(107, 13);
			this.lblQueryGenTime.TabIndex = 10;
			this.lblQueryGenTime.Text = "Time to create query:";
			// 
			// lblSearchingTimesResult
			// 
			this.lblSearchingTimesResult.AutoSize = true;
			this.lblSearchingTimesResult.Location = new System.Drawing.Point(171, 90);
			this.lblSearchingTimesResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSearchingTimesResult.Name = "lblSearchingTimesResult";
			this.lblSearchingTimesResult.Size = new System.Drawing.Size(13, 13);
			this.lblSearchingTimesResult.TabIndex = 11;
			this.lblSearchingTimesResult.Text = "0";
			this.lblSearchingTimesResult.Click += new System.EventHandler(this.Searching_time_Click);
			// 
			// lblFinalQuery
			// 
			this.lblFinalQuery.AutoSize = true;
			this.lblFinalQuery.Location = new System.Drawing.Point(8, 96);
			this.lblFinalQuery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblFinalQuery.Name = "lblFinalQuery";
			this.lblFinalQuery.Size = new System.Drawing.Size(77, 13);
			this.lblFinalQuery.TabIndex = 12;
			this.lblFinalQuery.Text = "The final query";
			// 
			// lblNumRelDocs
			// 
			this.lblNumRelDocs.AutoSize = true;
			this.lblNumRelDocs.Location = new System.Drawing.Point(33, 20);
			this.lblNumRelDocs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNumRelDocs.Name = "lblNumRelDocs";
			this.lblNumRelDocs.Size = new System.Drawing.Size(133, 13);
			this.lblNumRelDocs.TabIndex = 14;
			this.lblNumRelDocs.Text = "Number of relevant results:";
			// 
			// lblNumRelDocsResult
			// 
			this.lblNumRelDocsResult.AutoSize = true;
			this.lblNumRelDocsResult.Location = new System.Drawing.Point(171, 20);
			this.lblNumRelDocsResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNumRelDocsResult.Name = "lblNumRelDocsResult";
			this.lblNumRelDocsResult.Size = new System.Drawing.Size(13, 13);
			this.lblNumRelDocsResult.TabIndex = 15;
			this.lblNumRelDocsResult.Text = "0";
			this.lblNumRelDocsResult.Click += new System.EventHandler(this.Number_result_Click);
			// 
			// txtAnswer
			// 
			this.txtAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.txtAnswer.Location = new System.Drawing.Point(7, 171);
			this.txtAnswer.Margin = new System.Windows.Forms.Padding(2);
			this.txtAnswer.Name = "txtAnswer";
			this.txtAnswer.ReadOnly = true;
			this.txtAnswer.Size = new System.Drawing.Size(379, 374);
			this.txtAnswer.TabIndex = 18;
			this.txtAnswer.Text = "";
			this.txtAnswer.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
			// 
			// txtFinalQuery
			// 
			this.txtFinalQuery.Location = new System.Drawing.Point(8, 115);
			this.txtFinalQuery.Margin = new System.Windows.Forms.Padding(2);
			this.txtFinalQuery.Multiline = true;
			this.txtFinalQuery.Name = "txtFinalQuery";
			this.txtFinalQuery.ReadOnly = true;
			this.txtFinalQuery.Size = new System.Drawing.Size(379, 22);
			this.txtFinalQuery.TabIndex = 20;
			this.txtFinalQuery.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(197, 252);
			this.button4.Margin = new System.Windows.Forms.Padding(2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(88, 43);
			this.button4.TabIndex = 21;
			this.button4.Text = "Clear";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(739, 449);
			this.btnSave.Margin = new System.Windows.Forms.Padding(2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(55, 25);
			this.btnSave.TabIndex = 22;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.Save_button_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1_FileOk);
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(707, 264);
			this.richTextBox2.Margin = new System.Windows.Forms.Padding(2);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.ShortcutsEnabled = false;
			this.richTextBox2.Size = new System.Drawing.Size(422, 179);
			this.richTextBox2.TabIndex = 23;
			this.richTextBox2.Text = "";
			this.richTextBox2.TextChanged += new System.EventHandler(this.RichTextBox2_TextChanged);
			// 
			// lblSearchingTimes
			// 
			this.lblSearchingTimes.AutoSize = true;
			this.lblSearchingTimes.Location = new System.Drawing.Point(34, 90);
			this.lblSearchingTimes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSearchingTimes.Name = "lblSearchingTimes";
			this.lblSearchingTimes.Size = new System.Drawing.Size(80, 13);
			this.lblSearchingTimes.TabIndex = 24;
			this.lblSearchingTimes.Text = "Time to search:";
			// 
			// lblIndexTimeResult
			// 
			this.lblIndexTimeResult.AutoSize = true;
			this.lblIndexTimeResult.Location = new System.Drawing.Point(171, 66);
			this.lblIndexTimeResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblIndexTimeResult.Name = "lblIndexTimeResult";
			this.lblIndexTimeResult.Size = new System.Drawing.Size(13, 13);
			this.lblIndexTimeResult.TabIndex = 25;
			this.lblIndexTimeResult.Text = "0";
			this.lblIndexTimeResult.Click += new System.EventHandler(this.Coun_time_Click);
			// 
			// task4
			// 
			this.task4.Location = new System.Drawing.Point(707, 89);
			this.task4.Margin = new System.Windows.Forms.Padding(2);
			this.task4.Name = "task4";
			this.task4.Size = new System.Drawing.Size(419, 121);
			this.task4.TabIndex = 26;
			this.task4.Text = "";
			this.task4.TextChanged += new System.EventHandler(this.Task4_TextChanged);
			// 
			// lblQueryBaseline
			// 
			this.lblQueryBaseline.AutoSize = true;
			this.lblQueryBaseline.Location = new System.Drawing.Point(704, 74);
			this.lblQueryBaseline.Name = "lblQueryBaseline";
			this.lblQueryBaseline.Size = new System.Drawing.Size(118, 13);
			this.lblQueryBaseline.TabIndex = 27;
			this.lblQueryBaseline.Text = "baseline_for_this_query";
			// 
			// lblQueryBaselineAll
			// 
			this.lblQueryBaselineAll.AutoSize = true;
			this.lblQueryBaselineAll.Location = new System.Drawing.Point(704, 249);
			this.lblQueryBaselineAll.Name = "lblQueryBaselineAll";
			this.lblQueryBaselineAll.Size = new System.Drawing.Size(112, 13);
			this.lblQueryBaselineAll.TabIndex = 28;
			this.lblQueryBaselineAll.Text = "baseline_for_all_query";
			// 
			// lblAnswer
			// 
			this.lblAnswer.AutoSize = true;
			this.lblAnswer.Location = new System.Drawing.Point(5, 151);
			this.lblAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblAnswer.Name = "lblAnswer";
			this.lblAnswer.Size = new System.Drawing.Size(97, 13);
			this.lblAnswer.TabIndex = 29;
			this.lblAnswer.Text = "Answer_For_Query";
			// 
			// lblRelevantDocuments
			// 
			this.lblRelevantDocuments.AutoSize = true;
			this.lblRelevantDocuments.Location = new System.Drawing.Point(411, 10);
			this.lblRelevantDocuments.Name = "lblRelevantDocuments";
			this.lblRelevantDocuments.Size = new System.Drawing.Size(94, 13);
			this.lblRelevantDocuments.TabIndex = 31;
			this.lblRelevantDocuments.Text = "All_matching_Text";
			// 
			// btnSaveCranqrel
			// 
			this.btnSaveCranqrel.Location = new System.Drawing.Point(53, 494);
			this.btnSaveCranqrel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnSaveCranqrel.Name = "btnSaveCranqrel";
			this.btnSaveCranqrel.Size = new System.Drawing.Size(85, 25);
			this.btnSaveCranqrel.TabIndex = 34;
			this.btnSaveCranqrel.Text = "Save_cranqrel";
			this.btnSaveCranqrel.UseVisualStyleBackColor = true;
			this.btnSaveCranqrel.Click += new System.EventHandler(this.Save_cranqrel_Click);
			// 
			// savedialogconqrel
			// 
			this.savedialogconqrel.FileOk += new System.ComponentModel.CancelEventHandler(this.Savedialogconqrel_FileOk);
			// 
			// lblCranqrel
			// 
			this.lblCranqrel.AutoSize = true;
			this.lblCranqrel.Location = new System.Drawing.Point(50, 335);
			this.lblCranqrel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblCranqrel.Name = "lblCranqrel";
			this.lblCranqrel.Size = new System.Drawing.Size(45, 13);
			this.lblCranqrel.TabIndex = 35;
			this.lblCranqrel.Text = "cranqrel";
			// 
			// save_conqrel
			// 
			this.save_conqrel.Location = new System.Drawing.Point(53, 351);
			this.save_conqrel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.save_conqrel.Name = "save_conqrel";
			this.save_conqrel.Size = new System.Drawing.Size(419, 137);
			this.save_conqrel.TabIndex = 36;
			this.save_conqrel.Text = "";
			this.save_conqrel.TextChanged += new System.EventHandler(this.Save_conqrel_TextChanged);
			// 
			// richTextBox3
			// 
			this.richTextBox3.Location = new System.Drawing.Point(240, 145);
			this.richTextBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.richTextBox3.Name = "richTextBox3";
			this.richTextBox3.Size = new System.Drawing.Size(422, 75);
			this.richTextBox3.TabIndex = 37;
			this.richTextBox3.Text = "";
			this.richTextBox3.TextChanged += new System.EventHandler(this.RichTextBox3_TextChanged_1);
			// 
			// Link
			// 
			this.Link.Location = new System.Drawing.Point(549, 285);
			this.Link.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.Link.Name = "Link";
			this.Link.Size = new System.Drawing.Size(95, 66);
			this.Link.TabIndex = 38;
			this.Link.Text = "button2";
			this.Link.UseVisualStyleBackColor = true;
			this.Link.Click += new System.EventHandler(this.Link_Click);
			// 
			// pnlIndex
			// 
			this.pnlIndex.Controls.Add(this.txtCollectionFile);
			this.pnlIndex.Controls.Add(this.btnBrowse);
			this.pnlIndex.Controls.Add(this.lblCollectionFile);
			this.pnlIndex.Controls.Add(this.lblIndexSave);
			this.pnlIndex.Controls.Add(this.txtIndexFile);
			this.pnlIndex.Controls.Add(this.btnBrowse2);
			this.pnlIndex.Controls.Add(this.btnCreateIndex);
			this.pnlIndex.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlIndex.Location = new System.Drawing.Point(0, 0);
			this.pnlIndex.Name = "pnlIndex";
			this.pnlIndex.Size = new System.Drawing.Size(1168, 588);
			this.pnlIndex.TabIndex = 39;
			// 
			// pnlSearchHome
			// 
			this.pnlSearchHome.Controls.Add(this.chkbxProcessing1);
			this.pnlSearchHome.Controls.Add(this.lblSearch1);
			this.pnlSearchHome.Controls.Add(this.txtSearchContent1);
			this.pnlSearchHome.Controls.Add(this.btnSearch1);
			this.pnlSearchHome.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlSearchHome.Location = new System.Drawing.Point(3, 3);
			this.pnlSearchHome.Name = "pnlSearchHome";
			this.pnlSearchHome.Size = new System.Drawing.Size(1154, 556);
			this.pnlSearchHome.TabIndex = 40;
			// 
			// chkbxProcessing1
			// 
			this.chkbxProcessing1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.chkbxProcessing1.AutoSize = true;
			this.chkbxProcessing1.Location = new System.Drawing.Point(514, 263);
			this.chkbxProcessing1.Name = "chkbxProcessing1";
			this.chkbxProcessing1.Size = new System.Drawing.Size(127, 17);
			this.chkbxProcessing1.TabIndex = 6;
			this.chkbxProcessing1.Text = "Do not process query";
			this.chkbxProcessing1.UseVisualStyleBackColor = true;
			this.chkbxProcessing1.Visible = false;
			// 
			// pnlSearch
			// 
			this.pnlSearch.Controls.Add(this.tabControl1);
			this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlSearch.Location = new System.Drawing.Point(0, 0);
			this.pnlSearch.Name = "pnlSearch";
			this.pnlSearch.Size = new System.Drawing.Size(1168, 588);
			this.pnlSearch.TabIndex = 41;
			this.pnlSearch.Visible = false;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabSearch);
			this.tabControl1.Controls.Add(this.tabDiagnostics);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1168, 588);
			this.tabControl1.TabIndex = 36;
			// 
			// tabSearch
			// 
			this.tabSearch.Controls.Add(this.pnlSearchHome);
			this.tabSearch.Controls.Add(this.pnlSearchResults);
			this.tabSearch.Location = new System.Drawing.Point(4, 22);
			this.tabSearch.Name = "tabSearch";
			this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
			this.tabSearch.Size = new System.Drawing.Size(1160, 562);
			this.tabSearch.TabIndex = 0;
			this.tabSearch.Text = "Search";
			this.tabSearch.UseVisualStyleBackColor = true;
			// 
			// pnlSearchResults
			// 
			this.pnlSearchResults.Controls.Add(this.dataResults);
			this.pnlSearchResults.Controls.Add(this.lblRelevantDocuments);
			this.pnlSearchResults.Controls.Add(this.txtAnswer);
			this.pnlSearchResults.Controls.Add(this.lblAnswer);
			this.pnlSearchResults.Controls.Add(this.txtFinalQuery);
			this.pnlSearchResults.Controls.Add(this.lblFinalQuery);
			this.pnlSearchResults.Controls.Add(this.lblSearch2);
			this.pnlSearchResults.Controls.Add(this.txtSearchContent2);
			this.pnlSearchResults.Controls.Add(this.btnSearch2);
			this.pnlSearchResults.Controls.Add(this.chlbxProcessing2);
			this.pnlSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlSearchResults.Location = new System.Drawing.Point(3, 3);
			this.pnlSearchResults.Name = "pnlSearchResults";
			this.pnlSearchResults.Size = new System.Drawing.Size(1154, 556);
			this.pnlSearchResults.TabIndex = 36;
			this.pnlSearchResults.Visible = false;
			// 
			// lblSearch2
			// 
			this.lblSearch2.AutoSize = true;
			this.lblSearch2.Location = new System.Drawing.Point(8, 10);
			this.lblSearch2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSearch2.Name = "lblSearch2";
			this.lblSearch2.Size = new System.Drawing.Size(108, 13);
			this.lblSearch2.TabIndex = 32;
			this.lblSearch2.Text = "Input Search Content";
			// 
			// txtSearchContent2
			// 
			this.txtSearchContent2.Location = new System.Drawing.Point(11, 33);
			this.txtSearchContent2.Name = "txtSearchContent2";
			this.txtSearchContent2.Size = new System.Drawing.Size(379, 20);
			this.txtSearchContent2.TabIndex = 33;
			this.txtSearchContent2.TextChanged += new System.EventHandler(this.TxtSearchContent2_TextChanged);
			// 
			// btnSearch2
			// 
			this.btnSearch2.Enabled = false;
			this.btnSearch2.Location = new System.Drawing.Point(315, 59);
			this.btnSearch2.Name = "btnSearch2";
			this.btnSearch2.Size = new System.Drawing.Size(75, 23);
			this.btnSearch2.TabIndex = 34;
			this.btnSearch2.Text = "Search";
			this.btnSearch2.UseVisualStyleBackColor = true;
			this.btnSearch2.Click += new System.EventHandler(this.BtnSearch_Click);
			// 
			// chlbxProcessing2
			// 
			this.chlbxProcessing2.AutoSize = true;
			this.chlbxProcessing2.Location = new System.Drawing.Point(11, 63);
			this.chlbxProcessing2.Name = "chlbxProcessing2";
			this.chlbxProcessing2.Size = new System.Drawing.Size(98, 17);
			this.chlbxProcessing2.TabIndex = 35;
			this.chlbxProcessing2.Text = "Do not process";
			this.chlbxProcessing2.UseVisualStyleBackColor = true;
			this.chlbxProcessing2.Visible = false;
			// 
			// tabDiagnostics
			// 
			this.tabDiagnostics.Controls.Add(this.Link);
			this.tabDiagnostics.Controls.Add(this.richTextBox3);
			this.tabDiagnostics.Controls.Add(this.save_conqrel);
			this.tabDiagnostics.Controls.Add(this.lblCranqrel);
			this.tabDiagnostics.Controls.Add(this.lblQueryGenTimeResult);
			this.tabDiagnostics.Controls.Add(this.btnSaveCranqrel);
			this.tabDiagnostics.Controls.Add(this.lblQueryBaselineAll);
			this.tabDiagnostics.Controls.Add(this.lblQueryBaseline);
			this.tabDiagnostics.Controls.Add(this.lblIndexTime);
			this.tabDiagnostics.Controls.Add(this.task4);
			this.tabDiagnostics.Controls.Add(this.lblQueryGenTime);
			this.tabDiagnostics.Controls.Add(this.richTextBox2);
			this.tabDiagnostics.Controls.Add(this.lblIndexTimeResult);
			this.tabDiagnostics.Controls.Add(this.lblSearchingTimes);
			this.tabDiagnostics.Controls.Add(this.btnSave);
			this.tabDiagnostics.Controls.Add(this.button4);
			this.tabDiagnostics.Controls.Add(this.lblNumRelDocsResult);
			this.tabDiagnostics.Controls.Add(this.lblNumRelDocs);
			this.tabDiagnostics.Controls.Add(this.lblSearchingTimesResult);
			this.tabDiagnostics.Location = new System.Drawing.Point(4, 22);
			this.tabDiagnostics.Name = "tabDiagnostics";
			this.tabDiagnostics.Padding = new System.Windows.Forms.Padding(3);
			this.tabDiagnostics.Size = new System.Drawing.Size(1160, 562);
			this.tabDiagnostics.TabIndex = 1;
			this.tabDiagnostics.Text = "Diagnostics";
			this.tabDiagnostics.UseVisualStyleBackColor = true;
			this.tabDiagnostics.Click += new System.EventHandler(this.TabDiagnostics_Click);
			// 
			// dataResults
			// 
			this.dataResults.AllowUserToAddRows = false;
			this.dataResults.AllowUserToDeleteRows = false;
			this.dataResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rank,
            this.Result});
			this.dataResults.Location = new System.Drawing.Point(414, 33);
			this.dataResults.MultiSelect = false;
			this.dataResults.Name = "dataResults";
			this.dataResults.ReadOnly = true;
			this.dataResults.RowHeadersVisible = false;
			this.dataResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataResults.Size = new System.Drawing.Size(730, 512);
			this.dataResults.TabIndex = 36;
			// 
			// Rank
			// 
			this.Rank.FillWeight = 15.22843F;
			this.Rank.HeaderText = "Rank";
			this.Rank.Name = "Rank";
			this.Rank.ReadOnly = true;
			// 
			// Result
			// 
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Result.DefaultCellStyle = dataGridViewCellStyle3;
			this.Result.FillWeight = 184.7716F;
			this.Result.HeaderText = "Result";
			this.Result.Name = "Result";
			this.Result.ReadOnly = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1168, 588);
			this.Controls.Add(this.pnlSearch);
			this.Controls.Add(this.pnlIndex);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "Form1";
			this.Text = "xxx";
			this.Load += new System.EventHandler(this.Form1_Load_1);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.pnlIndex.ResumeLayout(false);
			this.pnlIndex.PerformLayout();
			this.pnlSearchHome.ResumeLayout(false);
			this.pnlSearchHome.PerformLayout();
			this.pnlSearch.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabSearch.ResumeLayout(false);
			this.pnlSearchResults.ResumeLayout(false);
			this.pnlSearchResults.PerformLayout();
			this.tabDiagnostics.ResumeLayout(false);
			this.tabDiagnostics.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataResults)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtCollectionFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblCollectionFile;
        private System.Windows.Forms.TextBox txtIndexFile;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.Label lblIndexSave;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnCreateIndex;
        private System.Windows.Forms.TextBox txtSearchContent1;
        private System.Windows.Forms.Label lblSearch1;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.Label lblQueryGenTimeResult;
        private System.Windows.Forms.Label lblIndexTime;
        private System.Windows.Forms.Label lblQueryGenTime;
        private System.Windows.Forms.Label lblSearchingTimesResult;
        private System.Windows.Forms.Label lblFinalQuery;
        private System.Windows.Forms.Label lblNumRelDocs;
        private System.Windows.Forms.Label lblNumRelDocsResult;
        private System.Windows.Forms.RichTextBox txtAnswer;
        private System.Windows.Forms.TextBox txtFinalQuery;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label lblSearchingTimes;
        private System.Windows.Forms.Label lblIndexTimeResult;
        private System.Windows.Forms.RichTextBox task4;
        private System.Windows.Forms.Label lblQueryBaseline;
        private System.Windows.Forms.Label lblQueryBaselineAll;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblRelevantDocuments;
        private System.Windows.Forms.Button btnSaveCranqrel;
        private System.Windows.Forms.SaveFileDialog savedialogconqrel;
        private System.Windows.Forms.Label lblCranqrel;
        private System.Windows.Forms.RichTextBox save_conqrel;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button Link;
		private System.Windows.Forms.Panel pnlIndex;
		private System.Windows.Forms.Panel pnlSearchHome;
		private System.Windows.Forms.Panel pnlSearch;
		private System.Windows.Forms.Label lblSearch2;
		private System.Windows.Forms.CheckBox chkbxProcessing1;
		private System.Windows.Forms.TextBox txtSearchContent2;
		private System.Windows.Forms.Button btnSearch2;
		private System.Windows.Forms.CheckBox chlbxProcessing2;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabSearch;
		private System.Windows.Forms.TabPage tabDiagnostics;
		private System.Windows.Forms.Panel pnlSearchResults;
		private System.Windows.Forms.DataGridView dataResults;
		private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
		private System.Windows.Forms.DataGridViewTextBoxColumn Result;
	}
}

