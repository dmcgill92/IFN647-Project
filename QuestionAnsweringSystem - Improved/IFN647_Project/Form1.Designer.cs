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
            System.Windows.Forms.Label lblSearch1;
            System.Windows.Forms.Label lblSearch2;
            System.Windows.Forms.Label lblQueryResults;
            System.Windows.Forms.Label lblAllResults;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.lblQueryGenTimeResult = new System.Windows.Forms.Label();
            this.lblIndexTime = new System.Windows.Forms.Label();
            this.lblQueryGenTime = new System.Windows.Forms.Label();
            this.lblSearchingTimesResult = new System.Windows.Forms.Label();
            this.lblFinalQuery = new System.Windows.Forms.Label();
            this.lblNumRelDocs = new System.Windows.Forms.Label();
            this.lblNumRelDocsResult = new System.Windows.Forms.Label();
            this.txtFinalQuery = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblSearchingTimes = new System.Windows.Forms.Label();
            this.lblIndexTimeResult = new System.Windows.Forms.Label();
            this.pnlIndex = new System.Windows.Forms.Panel();
            this.pnlSearchHome = new System.Windows.Forms.Panel();
            this.lblSuggestions1 = new System.Windows.Forms.Label();
            this.cmbbxBoosting1 = new System.Windows.Forms.ComboBox();
            this.chkbxQueryExpansion1 = new System.Windows.Forms.CheckBox();
            this.chkbxProcessing1 = new System.Windows.Forms.CheckBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.pnlSearchResults = new System.Windows.Forms.Panel();
            this.cmbbxBoosting2 = new System.Windows.Forms.ComboBox();
            this.tblResults = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearchContent2 = new System.Windows.Forms.TextBox();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.chkbxQueryExpansion2 = new System.Windows.Forms.CheckBox();
            this.chkbxProcessing2 = new System.Windows.Forms.CheckBox();
            this.tabDiagnostics = new System.Windows.Forms.TabPage();
            this.txtQueryResults = new System.Windows.Forms.RichTextBox();
            this.txtAllResults = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.imglstDropdown = new System.Windows.Forms.ImageList(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblSuggestions2 = new System.Windows.Forms.Label();
            lblSearch1 = new System.Windows.Forms.Label();
            lblSearch2 = new System.Windows.Forms.Label();
            lblQueryResults = new System.Windows.Forms.Label();
            lblAllResults = new System.Windows.Forms.Label();
            this.pnlIndex.SuspendLayout();
            this.pnlSearchHome.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.pnlSearchResults.SuspendLayout();
            this.tabDiagnostics.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearch1
            // 
            lblSearch1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblSearch1.AutoSize = true;
            lblSearch1.Location = new System.Drawing.Point(1046, 392);
            lblSearch1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSearch1.Name = "lblSearch1";
            lblSearch1.Size = new System.Drawing.Size(214, 25);
            lblSearch1.TabIndex = 4;
            lblSearch1.Text = "Input Search Content";
            // 
            // lblSearch2
            // 
            lblSearch2.AutoSize = true;
            lblSearch2.Location = new System.Drawing.Point(18, 33);
            lblSearch2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSearch2.Name = "lblSearch2";
            lblSearch2.Size = new System.Drawing.Size(214, 25);
            lblSearch2.TabIndex = 32;
            lblSearch2.Text = "Input Search Content";
            // 
            // lblQueryResults
            // 
            lblQueryResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblQueryResults.Location = new System.Drawing.Point(40, 192);
            lblQueryResults.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblQueryResults.Name = "lblQueryResults";
            lblQueryResults.Size = new System.Drawing.Size(1098, 25);
            lblQueryResults.TabIndex = 27;
            lblQueryResults.Text = "Results for current query";
            // 
            // lblAllResults
            // 
            lblAllResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblAllResults.Location = new System.Drawing.Point(1174, 187);
            lblAllResults.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblAllResults.Name = "lblAllResults";
            lblAllResults.Size = new System.Drawing.Size(1098, 25);
            lblAllResults.TabIndex = 27;
            lblAllResults.Text = "Results for current session";
            // 
            // txtCollectionFile
            // 
            this.txtCollectionFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCollectionFile.Location = new System.Drawing.Point(772, 223);
            this.txtCollectionFile.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtCollectionFile.Name = "txtCollectionFile";
            this.txtCollectionFile.ReadOnly = true;
            this.txtCollectionFile.Size = new System.Drawing.Size(788, 31);
            this.txtCollectionFile.TabIndex = 0;
            this.txtCollectionFile.TextChanged += new System.EventHandler(this.TxtCollectionFile_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBrowse.Location = new System.Drawing.Point(1086, 273);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(164, 58);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // lblCollectionFile
            // 
            this.lblCollectionFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCollectionFile.AutoSize = true;
            this.lblCollectionFile.Location = new System.Drawing.Point(1072, 190);
            this.lblCollectionFile.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCollectionFile.Name = "lblCollectionFile";
            this.lblCollectionFile.Size = new System.Drawing.Size(195, 25);
            this.lblCollectionFile.TabIndex = 2;
            this.lblCollectionFile.Text = "Collection Location";
            // 
            // txtIndexFile
            // 
            this.txtIndexFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIndexFile.Location = new System.Drawing.Point(772, 475);
            this.txtIndexFile.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtIndexFile.Name = "txtIndexFile";
            this.txtIndexFile.ReadOnly = true;
            this.txtIndexFile.Size = new System.Drawing.Size(788, 31);
            this.txtIndexFile.TabIndex = 0;
            this.txtIndexFile.TextChanged += new System.EventHandler(this.TxtIndexFile_TextChanged);
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBrowse2.Location = new System.Drawing.Point(1088, 521);
            this.btnBrowse2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(162, 58);
            this.btnBrowse2.TabIndex = 1;
            this.btnBrowse2.Text = "Browse";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.BtnBrowse2_Click);
            // 
            // lblIndexSave
            // 
            this.lblIndexSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIndexSave.AutoSize = true;
            this.lblIndexSave.Location = new System.Drawing.Point(1064, 446);
            this.lblIndexSave.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIndexSave.Name = "lblIndexSave";
            this.lblIndexSave.Size = new System.Drawing.Size(207, 25);
            this.lblIndexSave.TabIndex = 2;
            this.lblIndexSave.Text = "Index Save Location";
            // 
            // btnCreateIndex
            // 
            this.btnCreateIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateIndex.Enabled = false;
            this.btnCreateIndex.Location = new System.Drawing.Point(2138, 1029);
            this.btnCreateIndex.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnCreateIndex.Name = "btnCreateIndex";
            this.btnCreateIndex.Size = new System.Drawing.Size(164, 58);
            this.btnCreateIndex.TabIndex = 1;
            this.btnCreateIndex.Text = "Create Index";
            this.btnCreateIndex.UseVisualStyleBackColor = true;
            this.btnCreateIndex.Click += new System.EventHandler(this.BtnCreateIndex_Click);
            // 
            // txtSearchContent1
            // 
            this.txtSearchContent1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchContent1.Location = new System.Drawing.Point(658, 442);
            this.txtSearchContent1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchContent1.Name = "txtSearchContent1";
            this.txtSearchContent1.Size = new System.Drawing.Size(988, 31);
            this.txtSearchContent1.TabIndex = 3;
            this.txtSearchContent1.TextChanged += new System.EventHandler(this.TxtSearchContent1_TextChanged);
            // 
            // btnSearch1
            // 
            this.btnSearch1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch1.Enabled = false;
            this.btnSearch1.Location = new System.Drawing.Point(1074, 710);
            this.btnSearch1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(156, 52);
            this.btnSearch1.TabIndex = 5;
            this.btnSearch1.Text = "Search";
            this.btnSearch1.UseMnemonic = false;
            this.btnSearch1.UseVisualStyleBackColor = true;
            this.btnSearch1.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lblQueryGenTimeResult
            // 
            this.lblQueryGenTimeResult.AutoSize = true;
            this.lblQueryGenTimeResult.Location = new System.Drawing.Point(316, 81);
            this.lblQueryGenTimeResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQueryGenTimeResult.Name = "lblQueryGenTimeResult";
            this.lblQueryGenTimeResult.Size = new System.Drawing.Size(24, 25);
            this.lblQueryGenTimeResult.TabIndex = 6;
            this.lblQueryGenTimeResult.Text = "0";
            // 
            // lblIndexTime
            // 
            this.lblIndexTime.AutoSize = true;
            this.lblIndexTime.Location = new System.Drawing.Point(588, 37);
            this.lblIndexTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndexTime.Name = "lblIndexTime";
            this.lblIndexTime.Size = new System.Drawing.Size(195, 25);
            this.lblIndexTime.TabIndex = 9;
            this.lblIndexTime.Text = "Time for indexing:  ";
            // 
            // lblQueryGenTime
            // 
            this.lblQueryGenTime.AutoSize = true;
            this.lblQueryGenTime.Location = new System.Drawing.Point(40, 81);
            this.lblQueryGenTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQueryGenTime.Name = "lblQueryGenTime";
            this.lblQueryGenTime.Size = new System.Drawing.Size(215, 25);
            this.lblQueryGenTime.TabIndex = 10;
            this.lblQueryGenTime.Text = "Time to create query:";
            // 
            // lblSearchingTimesResult
            // 
            this.lblSearchingTimesResult.AutoSize = true;
            this.lblSearchingTimesResult.Location = new System.Drawing.Point(864, 83);
            this.lblSearchingTimesResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchingTimesResult.Name = "lblSearchingTimesResult";
            this.lblSearchingTimesResult.Size = new System.Drawing.Size(24, 25);
            this.lblSearchingTimesResult.TabIndex = 11;
            this.lblSearchingTimesResult.Text = "0";
            // 
            // lblFinalQuery
            // 
            this.lblFinalQuery.AutoSize = true;
            this.lblFinalQuery.Location = new System.Drawing.Point(934, 33);
            this.lblFinalQuery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalQuery.Name = "lblFinalQuery";
            this.lblFinalQuery.Size = new System.Drawing.Size(178, 25);
            this.lblFinalQuery.TabIndex = 12;
            this.lblFinalQuery.Text = "Processed Query";
            // 
            // lblNumRelDocs
            // 
            this.lblNumRelDocs.AutoSize = true;
            this.lblNumRelDocs.Location = new System.Drawing.Point(40, 37);
            this.lblNumRelDocs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumRelDocs.Name = "lblNumRelDocs";
            this.lblNumRelDocs.Size = new System.Drawing.Size(270, 25);
            this.lblNumRelDocs.TabIndex = 14;
            this.lblNumRelDocs.Text = "Number of relevant results:";
            // 
            // lblNumRelDocsResult
            // 
            this.lblNumRelDocsResult.AutoSize = true;
            this.lblNumRelDocsResult.Location = new System.Drawing.Point(316, 37);
            this.lblNumRelDocsResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumRelDocsResult.Name = "lblNumRelDocsResult";
            this.lblNumRelDocsResult.Size = new System.Drawing.Size(24, 25);
            this.lblNumRelDocsResult.TabIndex = 15;
            this.lblNumRelDocsResult.Text = "0";
            // 
            // txtFinalQuery
            // 
            this.txtFinalQuery.Location = new System.Drawing.Point(940, 63);
            this.txtFinalQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFinalQuery.Multiline = true;
            this.txtFinalQuery.Name = "txtFinalQuery";
            this.txtFinalQuery.ReadOnly = true;
            this.txtFinalQuery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFinalQuery.Size = new System.Drawing.Size(1296, 117);
            this.txtFinalQuery.TabIndex = 20;
            // 
            // lblSearchingTimes
            // 
            this.lblSearchingTimes.AutoSize = true;
            this.lblSearchingTimes.Location = new System.Drawing.Point(588, 83);
            this.lblSearchingTimes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchingTimes.Name = "lblSearchingTimes";
            this.lblSearchingTimes.Size = new System.Drawing.Size(160, 25);
            this.lblSearchingTimes.TabIndex = 24;
            this.lblSearchingTimes.Text = "Time to search:";
            // 
            // lblIndexTimeResult
            // 
            this.lblIndexTimeResult.AutoSize = true;
            this.lblIndexTimeResult.Location = new System.Drawing.Point(864, 37);
            this.lblIndexTimeResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndexTimeResult.Name = "lblIndexTimeResult";
            this.lblIndexTimeResult.Size = new System.Drawing.Size(24, 25);
            this.lblIndexTimeResult.TabIndex = 25;
            this.lblIndexTimeResult.Text = "0";
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
            this.pnlIndex.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlIndex.Name = "pnlIndex";
            this.pnlIndex.Size = new System.Drawing.Size(2336, 1131);
            this.pnlIndex.TabIndex = 39;
            // 
            // pnlSearchHome
            // 
            this.pnlSearchHome.Controls.Add(this.lblSuggestions1);
            this.pnlSearchHome.Controls.Add(this.cmbbxBoosting1);
            this.pnlSearchHome.Controls.Add(this.chkbxQueryExpansion1);
            this.pnlSearchHome.Controls.Add(this.chkbxProcessing1);
            this.pnlSearchHome.Controls.Add(lblSearch1);
            this.pnlSearchHome.Controls.Add(this.txtSearchContent1);
            this.pnlSearchHome.Controls.Add(this.btnSearch1);
            this.pnlSearchHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearchHome.Location = new System.Drawing.Point(6, 6);
            this.pnlSearchHome.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlSearchHome.Name = "pnlSearchHome";
            this.pnlSearchHome.Size = new System.Drawing.Size(2308, 1072);
            this.pnlSearchHome.TabIndex = 40;
            // 
            // lblSuggestions1
            // 
            this.lblSuggestions1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSuggestions1.Location = new System.Drawing.Point(658, 490);
            this.lblSuggestions1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSuggestions1.Name = "lblSuggestions1";
            this.lblSuggestions1.Size = new System.Drawing.Size(992, 38);
            this.lblSuggestions1.TabIndex = 42;
            this.lblSuggestions1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbbxBoosting1
            // 
            this.cmbbxBoosting1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbbxBoosting1.FormattingEnabled = true;
            this.cmbbxBoosting1.Items.AddRange(new object[] {
            "No Boosting",
            "Title Boosting",
            "Query Boosting"});
            this.cmbbxBoosting1.Location = new System.Drawing.Point(946, 650);
            this.cmbbxBoosting1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbbxBoosting1.Name = "cmbbxBoosting1";
            this.cmbbxBoosting1.Size = new System.Drawing.Size(414, 33);
            this.cmbbxBoosting1.TabIndex = 41;
            this.cmbbxBoosting1.SelectedIndexChanged += new System.EventHandler(this.CmbbxBoosting1_SelectedIndexChanged);
            // 
            // chkbxQueryExpansion1
            // 
            this.chkbxQueryExpansion1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkbxQueryExpansion1.AutoSize = true;
            this.chkbxQueryExpansion1.Location = new System.Drawing.Point(1050, 596);
            this.chkbxQueryExpansion1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkbxQueryExpansion1.Name = "chkbxQueryExpansion1";
            this.chkbxQueryExpansion1.Size = new System.Drawing.Size(207, 29);
            this.chkbxQueryExpansion1.TabIndex = 40;
            this.chkbxQueryExpansion1.Text = "Query expansion";
            this.chkbxQueryExpansion1.UseVisualStyleBackColor = true;
            this.chkbxQueryExpansion1.CheckedChanged += new System.EventHandler(this.ChkbxQueryExpansion1_CheckedChanged);
            // 
            // chkbxProcessing1
            // 
            this.chkbxProcessing1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkbxProcessing1.AutoSize = true;
            this.chkbxProcessing1.Location = new System.Drawing.Point(1028, 542);
            this.chkbxProcessing1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkbxProcessing1.Name = "chkbxProcessing1";
            this.chkbxProcessing1.Size = new System.Drawing.Size(249, 29);
            this.chkbxProcessing1.TabIndex = 6;
            this.chkbxProcessing1.Text = "Do not process query";
            this.chkbxProcessing1.UseVisualStyleBackColor = true;
            this.chkbxProcessing1.CheckedChanged += new System.EventHandler(this.ChkbxProcessing1_CheckedChanged);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.tabControl1);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(2336, 1131);
            this.pnlSearch.TabIndex = 41;
            this.pnlSearch.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSearch);
            this.tabControl1.Controls.Add(this.tabDiagnostics);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2336, 1131);
            this.tabControl1.TabIndex = 36;
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.pnlSearchResults);
            this.tabSearch.Controls.Add(this.pnlSearchHome);
            this.tabSearch.Location = new System.Drawing.Point(8, 39);
            this.tabSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabSearch.Size = new System.Drawing.Size(2320, 1084);
            this.tabSearch.TabIndex = 0;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // pnlSearchResults
            // 
            this.pnlSearchResults.Controls.Add(this.lblSuggestions2);
            this.pnlSearchResults.Controls.Add(this.cmbbxBoosting2);
            this.pnlSearchResults.Controls.Add(this.tblResults);
            this.pnlSearchResults.Controls.Add(this.txtFinalQuery);
            this.pnlSearchResults.Controls.Add(this.lblFinalQuery);
            this.pnlSearchResults.Controls.Add(lblSearch2);
            this.pnlSearchResults.Controls.Add(this.txtSearchContent2);
            this.pnlSearchResults.Controls.Add(this.btnSearch2);
            this.pnlSearchResults.Controls.Add(this.chkbxQueryExpansion2);
            this.pnlSearchResults.Controls.Add(this.chkbxProcessing2);
            this.pnlSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearchResults.Location = new System.Drawing.Point(6, 6);
            this.pnlSearchResults.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlSearchResults.Name = "pnlSearchResults";
            this.pnlSearchResults.Size = new System.Drawing.Size(2308, 1072);
            this.pnlSearchResults.TabIndex = 36;
            this.pnlSearchResults.Visible = false;
            // 
            // cmbbxBoosting2
            // 
            this.cmbbxBoosting2.FormattingEnabled = true;
            this.cmbbxBoosting2.Items.AddRange(new object[] {
            "No Boosting",
            "Title Boosting",
            "Query Boosting"});
            this.cmbbxBoosting2.Location = new System.Drawing.Point(24, 185);
            this.cmbbxBoosting2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbbxBoosting2.Name = "cmbbxBoosting2";
            this.cmbbxBoosting2.Size = new System.Drawing.Size(414, 33);
            this.cmbbxBoosting2.TabIndex = 39;
            this.cmbbxBoosting2.SelectedIndexChanged += new System.EventHandler(this.CmbbxBoosting2_SelectedIndexChanged);
            // 
            // tblResults
            // 
            this.tblResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblResults.AutoScroll = true;
            this.tblResults.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblResults.ColumnCount = 1;
            this.tblResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblResults.Location = new System.Drawing.Point(22, 223);
            this.tblResults.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tblResults.Name = "tblResults";
            this.tblResults.RowCount = 1;
            this.tblResults.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblResults.Size = new System.Drawing.Size(2266, 818);
            this.tblResults.TabIndex = 38;
            // 
            // txtSearchContent2
            // 
            this.txtSearchContent2.Location = new System.Drawing.Point(22, 63);
            this.txtSearchContent2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSearchContent2.Name = "txtSearchContent2";
            this.txtSearchContent2.Size = new System.Drawing.Size(754, 31);
            this.txtSearchContent2.TabIndex = 33;
            this.txtSearchContent2.TextChanged += new System.EventHandler(this.TxtSearchContent2_TextChanged);
            // 
            // btnSearch2
            // 
            this.btnSearch2.Enabled = false;
            this.btnSearch2.Location = new System.Drawing.Point(632, 144);
            this.btnSearch2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(150, 44);
            this.btnSearch2.TabIndex = 34;
            this.btnSearch2.Text = "Search";
            this.btnSearch2.UseVisualStyleBackColor = true;
            this.btnSearch2.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // chkbxQueryExpansion2
            // 
            this.chkbxQueryExpansion2.AutoSize = true;
            this.chkbxQueryExpansion2.Location = new System.Drawing.Point(232, 138);
            this.chkbxQueryExpansion2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkbxQueryExpansion2.Name = "chkbxQueryExpansion2";
            this.chkbxQueryExpansion2.Size = new System.Drawing.Size(207, 29);
            this.chkbxQueryExpansion2.TabIndex = 35;
            this.chkbxQueryExpansion2.Text = "Query expansion";
            this.chkbxQueryExpansion2.UseVisualStyleBackColor = true;
            this.chkbxQueryExpansion2.CheckedChanged += new System.EventHandler(this.ChkbxQueryExpansion2_CheckedChanged);
            // 
            // chkbxProcessing2
            // 
            this.chkbxProcessing2.AutoSize = true;
            this.chkbxProcessing2.Location = new System.Drawing.Point(24, 138);
            this.chkbxProcessing2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkbxProcessing2.Name = "chkbxProcessing2";
            this.chkbxProcessing2.Size = new System.Drawing.Size(189, 29);
            this.chkbxProcessing2.TabIndex = 35;
            this.chkbxProcessing2.Text = "Do not process";
            this.chkbxProcessing2.UseVisualStyleBackColor = true;
            this.chkbxProcessing2.CheckedChanged += new System.EventHandler(this.ChkbxProcessing2_CheckedChanged);
            // 
            // tabDiagnostics
            // 
            this.tabDiagnostics.Controls.Add(this.txtQueryResults);
            this.tabDiagnostics.Controls.Add(this.txtAllResults);
            this.tabDiagnostics.Controls.Add(this.btnSave);
            this.tabDiagnostics.Controls.Add(lblAllResults);
            this.tabDiagnostics.Controls.Add(lblQueryResults);
            this.tabDiagnostics.Controls.Add(this.lblQueryGenTimeResult);
            this.tabDiagnostics.Controls.Add(this.lblIndexTime);
            this.tabDiagnostics.Controls.Add(this.lblQueryGenTime);
            this.tabDiagnostics.Controls.Add(this.lblIndexTimeResult);
            this.tabDiagnostics.Controls.Add(this.lblSearchingTimes);
            this.tabDiagnostics.Controls.Add(this.lblNumRelDocsResult);
            this.tabDiagnostics.Controls.Add(this.lblNumRelDocs);
            this.tabDiagnostics.Controls.Add(this.lblSearchingTimesResult);
            this.tabDiagnostics.Location = new System.Drawing.Point(8, 39);
            this.tabDiagnostics.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabDiagnostics.Name = "tabDiagnostics";
            this.tabDiagnostics.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabDiagnostics.Size = new System.Drawing.Size(2320, 1084);
            this.tabDiagnostics.TabIndex = 1;
            this.tabDiagnostics.Text = "Diagnostics";
            this.tabDiagnostics.UseVisualStyleBackColor = true;
            // 
            // txtQueryResults
            // 
            this.txtQueryResults.Location = new System.Drawing.Point(40, 231);
            this.txtQueryResults.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtQueryResults.Name = "txtQueryResults";
            this.txtQueryResults.ReadOnly = true;
            this.txtQueryResults.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtQueryResults.Size = new System.Drawing.Size(1094, 744);
            this.txtQueryResults.TabIndex = 29;
            this.txtQueryResults.Text = "";
            // 
            // txtAllResults
            // 
            this.txtAllResults.Location = new System.Drawing.Point(1174, 231);
            this.txtAllResults.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAllResults.Name = "txtAllResults";
            this.txtAllResults.ReadOnly = true;
            this.txtAllResults.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtAllResults.Size = new System.Drawing.Size(1094, 744);
            this.txtAllResults.TabIndex = 29;
            this.txtAllResults.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(2122, 1000);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 44);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // imglstDropdown
            // 
            this.imglstDropdown.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstDropdown.ImageStream")));
            this.imglstDropdown.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstDropdown.Images.SetKeyName(0, "expand-arrow-32.png");
            this.imglstDropdown.Images.SetKeyName(1, "collapse-arrow-32.png");
            // 
            // lblSuggestions2
            // 
            this.lblSuggestions2.Location = new System.Drawing.Point(19, 97);
            this.lblSuggestions2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSuggestions2.Name = "lblSuggestions2";
            this.lblSuggestions2.Size = new System.Drawing.Size(763, 38);
            this.lblSuggestions2.TabIndex = 43;
            this.lblSuggestions2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2336, 1131);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlIndex);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MinimumSize = new System.Drawing.Size(1574, 1088);
            this.Name = "Form1";
            this.Text = "Search Engine";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.Label lblQueryGenTimeResult;
        private System.Windows.Forms.Label lblIndexTime;
        private System.Windows.Forms.Label lblQueryGenTime;
        private System.Windows.Forms.Label lblSearchingTimesResult;
        private System.Windows.Forms.Label lblFinalQuery;
        private System.Windows.Forms.Label lblNumRelDocs;
        private System.Windows.Forms.Label lblNumRelDocsResult;
        private System.Windows.Forms.TextBox txtFinalQuery;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblSearchingTimes;
        private System.Windows.Forms.Label lblIndexTimeResult;
		private System.Windows.Forms.Panel pnlIndex;
		private System.Windows.Forms.Panel pnlSearchHome;
		private System.Windows.Forms.Panel pnlSearch;
		private System.Windows.Forms.CheckBox chkbxProcessing1;
		private System.Windows.Forms.TextBox txtSearchContent2;
		private System.Windows.Forms.Button btnSearch2;
		private System.Windows.Forms.CheckBox chkbxProcessing2;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabSearch;
		private System.Windows.Forms.TabPage tabDiagnostics;
		private System.Windows.Forms.Panel pnlSearchResults;
		private System.Windows.Forms.ImageList imglstDropdown;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TableLayoutPanel tblResults;
		private System.Windows.Forms.RichTextBox txtQueryResults;
		private System.Windows.Forms.RichTextBox txtAllResults;
		private System.Windows.Forms.ComboBox cmbbxBoosting1;
		private System.Windows.Forms.CheckBox chkbxQueryExpansion1;
		private System.Windows.Forms.ComboBox cmbbxBoosting2;
		private System.Windows.Forms.CheckBox chkbxQueryExpansion2;
		private System.Windows.Forms.Label lblSuggestions1;
        private System.Windows.Forms.Label lblSuggestions2;
    }
}

