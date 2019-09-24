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
            this.SuspendLayout();
            // 
            // txtCollectionFile
            // 
            this.txtCollectionFile.Location = new System.Drawing.Point(274, 41);
            this.txtCollectionFile.Name = "txtCollectionFile";
            this.txtCollectionFile.ReadOnly = true;
            this.txtCollectionFile.Size = new System.Drawing.Size(253, 20);
            this.txtCollectionFile.TabIndex = 0;
            this.txtCollectionFile.TextChanged += new System.EventHandler(this.TxtCollectionFile_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(363, 76);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // lblCollectionFile
            // 
            this.lblCollectionFile.AutoSize = true;
            this.lblCollectionFile.Location = new System.Drawing.Point(352, 13);
            this.lblCollectionFile.Name = "lblCollectionFile";
            this.lblCollectionFile.Size = new System.Drawing.Size(97, 13);
            this.lblCollectionFile.TabIndex = 2;
            this.lblCollectionFile.Text = "Collection Location";
            // 
            // txtIndexFile
            // 
            this.txtIndexFile.Location = new System.Drawing.Point(274, 192);
            this.txtIndexFile.Name = "txtIndexFile";
            this.txtIndexFile.ReadOnly = true;
            this.txtIndexFile.Size = new System.Drawing.Size(253, 20);
            this.txtIndexFile.TabIndex = 0;
            this.txtIndexFile.TextChanged += new System.EventHandler(this.TxtIndexFile_TextChanged);
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Location = new System.Drawing.Point(363, 227);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse2.TabIndex = 1;
            this.btnBrowse2.Text = "Browse";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.BtnBrowse2_Click);
            // 
            // lblIndexSave
            // 
            this.lblIndexSave.AutoSize = true;
            this.lblIndexSave.Location = new System.Drawing.Point(352, 164);
            this.lblIndexSave.Name = "lblIndexSave";
            this.lblIndexSave.Size = new System.Drawing.Size(105, 13);
            this.lblIndexSave.TabIndex = 2;
            this.lblIndexSave.Text = "Index Save Location";
            // 
            // btnCreateIndex
            // 
            this.btnCreateIndex.Enabled = false;
            this.btnCreateIndex.Location = new System.Drawing.Point(674, 394);
            this.btnCreateIndex.Name = "btnCreateIndex";
            this.btnCreateIndex.Size = new System.Drawing.Size(75, 23);
            this.btnCreateIndex.TabIndex = 1;
            this.btnCreateIndex.Text = "Create Index";
            this.btnCreateIndex.UseVisualStyleBackColor = true;
            this.btnCreateIndex.Click += new System.EventHandler(this.BtnCreateIndex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIndexSave);
            this.Controls.Add(this.lblCollectionFile);
            this.Controls.Add(this.btnCreateIndex);
            this.Controls.Add(this.btnBrowse2);
            this.Controls.Add(this.txtIndexFile);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtCollectionFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

