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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtCollectionFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblCollectionFile = new System.Windows.Forms.Label();
            this.txtIndexFile = new System.Windows.Forms.TextBox();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.lblIndexSave = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCreateIndex = new System.Windows.Forms.Button();
            this.pnlIndex = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchQuery = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlIndex.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCollectionFile
            // 
            this.txtCollectionFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCollectionFile.Location = new System.Drawing.Point(274, 87);
            this.txtCollectionFile.Name = "txtCollectionFile";
            this.txtCollectionFile.ReadOnly = true;
            this.txtCollectionFile.Size = new System.Drawing.Size(461, 20);
            this.txtCollectionFile.TabIndex = 0;
            this.txtCollectionFile.TextChanged += new System.EventHandler(this.TxtCollectionFile_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBrowse.Location = new System.Drawing.Point(467, 122);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // lblCollectionFile
            // 
            this.lblCollectionFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCollectionFile.AutoSize = true;
            this.lblCollectionFile.Location = new System.Drawing.Point(456, 59);
            this.lblCollectionFile.Name = "lblCollectionFile";
            this.lblCollectionFile.Size = new System.Drawing.Size(97, 13);
            this.lblCollectionFile.TabIndex = 0;
            this.lblCollectionFile.Text = "Collection Location";
            // 
            // txtIndexFile
            // 
            this.txtIndexFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIndexFile.Location = new System.Drawing.Point(274, 220);
            this.txtIndexFile.Name = "txtIndexFile";
            this.txtIndexFile.ReadOnly = true;
            this.txtIndexFile.Size = new System.Drawing.Size(461, 20);
            this.txtIndexFile.TabIndex = 3;
            this.txtIndexFile.TextChanged += new System.EventHandler(this.TxtIndexFile_TextChanged);
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBrowse2.Location = new System.Drawing.Point(467, 255);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse2.TabIndex = 4;
            this.btnBrowse2.Text = "Browse";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.BtnBrowse2_Click);
            // 
            // lblIndexSave
            // 
            this.lblIndexSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIndexSave.AutoSize = true;
            this.lblIndexSave.Location = new System.Drawing.Point(456, 192);
            this.lblIndexSave.Name = "lblIndexSave";
            this.lblIndexSave.Size = new System.Drawing.Size(105, 13);
            this.lblIndexSave.TabIndex = 0;
            this.lblIndexSave.Text = "Index Save Location";
            // 
            // btnCreateIndex
            // 
            this.btnCreateIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateIndex.Enabled = false;
            this.btnCreateIndex.Location = new System.Drawing.Point(882, 417);
            this.btnCreateIndex.Name = "btnCreateIndex";
            this.btnCreateIndex.Size = new System.Drawing.Size(75, 23);
            this.btnCreateIndex.TabIndex = 5;
            this.btnCreateIndex.Text = "Create Index";
            this.btnCreateIndex.UseVisualStyleBackColor = true;
            this.btnCreateIndex.Click += new System.EventHandler(this.BtnCreateIndex_Click);
            // 
            // pnlIndex
            // 
            this.pnlIndex.Controls.Add(this.lblIndexSave);
            this.pnlIndex.Controls.Add(this.lblCollectionFile);
            this.pnlIndex.Controls.Add(this.btnCreateIndex);
            this.pnlIndex.Controls.Add(this.btnBrowse2);
            this.pnlIndex.Controls.Add(this.txtIndexFile);
            this.pnlIndex.Controls.Add(this.btnBrowse);
            this.pnlIndex.Controls.Add(this.txtCollectionFile);
            this.pnlIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIndex.Location = new System.Drawing.Point(0, 0);
            this.pnlIndex.Name = "pnlIndex";
            this.pnlIndex.Size = new System.Drawing.Size(1008, 473);
            this.pnlIndex.TabIndex = 3;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.lblSearchQuery);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1008, 473);
            this.pnlSearch.TabIndex = 3;
            this.pnlSearch.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.Location = new System.Drawing.Point(274, 152);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(461, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // lblSearchQuery
            // 
            this.lblSearchQuery.AutoSize = true;
            this.lblSearchQuery.Location = new System.Drawing.Point(455, 114);
            this.lblSearchQuery.Name = "lblSearchQuery";
            this.lblSearchQuery.Size = new System.Drawing.Size(99, 13);
            this.lblSearchQuery.TabIndex = 1;
            this.lblSearchQuery.Text = "Input Search Query";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(467, 191);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 473);
            this.Controls.Add(this.pnlIndex);
            this.Controls.Add(this.pnlSearch);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlIndex.ResumeLayout(false);
            this.pnlIndex.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
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
        private System.Windows.Forms.Panel pnlIndex;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchQuery;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

