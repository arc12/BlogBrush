namespace BlogBrush
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
            this.grpDecisions = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDefer = new System.Windows.Forms.Button();
            this.btnWebPage = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnUnknown = new System.Windows.Forms.Button();
            this.btnCommercial = new System.Windows.Forms.Button();
            this.btnBlog = new System.Windows.Forms.Button();
            this.grpFile = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpExtract = new System.Windows.Forms.GroupBox();
            this.btnExtract = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lblUrlCount = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAbort = new System.Windows.Forms.Button();
            this.chkAutoExtract = new System.Windows.Forms.CheckBox();
            this.grpDecisions.SuspendLayout();
            this.grpFile.SuspendLayout();
            this.grpExtract.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDecisions
            // 
            this.grpDecisions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDecisions.Controls.Add(this.label2);
            this.grpDecisions.Controls.Add(this.btnDefer);
            this.grpDecisions.Controls.Add(this.btnWebPage);
            this.grpDecisions.Controls.Add(this.btnReject);
            this.grpDecisions.Controls.Add(this.btnUnknown);
            this.grpDecisions.Controls.Add(this.btnCommercial);
            this.grpDecisions.Controls.Add(this.btnBlog);
            this.grpDecisions.Enabled = false;
            this.grpDecisions.Location = new System.Drawing.Point(652, 12);
            this.grpDecisions.Name = "grpDecisions";
            this.grpDecisions.Size = new System.Drawing.Size(118, 253);
            this.grpDecisions.TabIndex = 0;
            this.grpDecisions.TabStop = false;
            this.grpDecisions.Text = "URL Decisions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "TEL Types";
            // 
            // btnDefer
            // 
            this.btnDefer.Location = new System.Drawing.Point(7, 171);
            this.btnDefer.Name = "btnDefer";
            this.btnDefer.Size = new System.Drawing.Size(102, 23);
            this.btnDefer.TabIndex = 5;
            this.btnDefer.Text = "(defer decision)";
            this.btnDefer.UseVisualStyleBackColor = true;
            this.btnDefer.Click += new System.EventHandler(this.btnDefer_Click);
            // 
            // btnWebPage
            // 
            this.btnWebPage.Location = new System.Drawing.Point(7, 92);
            this.btnWebPage.Name = "btnWebPage";
            this.btnWebPage.Size = new System.Drawing.Size(102, 23);
            this.btnWebPage.TabIndex = 4;
            this.btnWebPage.Text = "Web Page";
            this.btnWebPage.UseVisualStyleBackColor = true;
            this.btnWebPage.Click += new System.EventHandler(this.btnWebPage_Click);
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(7, 220);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(102, 23);
            this.btnReject.TabIndex = 3;
            this.btnReject.Text = "Reject (non-TEL)";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnUnknown
            // 
            this.btnUnknown.Location = new System.Drawing.Point(7, 121);
            this.btnUnknown.Name = "btnUnknown";
            this.btnUnknown.Size = new System.Drawing.Size(102, 23);
            this.btnUnknown.TabIndex = 2;
            this.btnUnknown.Text = "Unknown";
            this.btnUnknown.UseVisualStyleBackColor = true;
            this.btnUnknown.Click += new System.EventHandler(this.btnUnknown_Click);
            // 
            // btnCommercial
            // 
            this.btnCommercial.Location = new System.Drawing.Point(7, 63);
            this.btnCommercial.Name = "btnCommercial";
            this.btnCommercial.Size = new System.Drawing.Size(102, 23);
            this.btnCommercial.TabIndex = 1;
            this.btnCommercial.Text = "Commercial";
            this.btnCommercial.UseVisualStyleBackColor = true;
            this.btnCommercial.Click += new System.EventHandler(this.btnCommercial_Click);
            // 
            // btnBlog
            // 
            this.btnBlog.Location = new System.Drawing.Point(7, 34);
            this.btnBlog.Name = "btnBlog";
            this.btnBlog.Size = new System.Drawing.Size(102, 23);
            this.btnBlog.TabIndex = 0;
            this.btnBlog.Text = "Blog";
            this.btnBlog.UseVisualStyleBackColor = true;
            this.btnBlog.Click += new System.EventHandler(this.btnBlog_Click);
            // 
            // grpFile
            // 
            this.grpFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFile.Controls.Add(this.btnOpen);
            this.grpFile.Controls.Add(this.btnSave);
            this.grpFile.Location = new System.Drawing.Point(652, 278);
            this.grpFile.Name = "grpFile";
            this.grpFile.Size = new System.Drawing.Size(118, 86);
            this.grpFile.TabIndex = 1;
            this.grpFile.TabStop = false;
            this.grpFile.Text = "File";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(7, 50);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(102, 25);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(7, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpExtract
            // 
            this.grpExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpExtract.Controls.Add(this.chkAutoExtract);
            this.grpExtract.Controls.Add(this.btnExtract);
            this.grpExtract.Enabled = false;
            this.grpExtract.Location = new System.Drawing.Point(652, 375);
            this.grpExtract.Name = "grpExtract";
            this.grpExtract.Size = new System.Drawing.Size(118, 88);
            this.grpExtract.TabIndex = 2;
            this.grpExtract.TabStop = false;
            this.grpExtract.Text = "Extract URLs";
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(7, 21);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(102, 24);
            this.btnExtract.TabIndex = 0;
            this.btnExtract.Text = "Extract Now";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(13, 539);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(757, 18);
            this.progressBar.TabIndex = 3;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "csv";
            this.openFileDialog.Filter = "CSV files|*.csv";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "csv";
            this.saveFileDialog.FileName = "Processed.csv";
            // 
            // lblUrlCount
            // 
            this.lblUrlCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUrlCount.Location = new System.Drawing.Point(670, 560);
            this.lblUrlCount.Name = "lblUrlCount";
            this.lblUrlCount.Size = new System.Drawing.Size(100, 13);
            this.lblUrlCount.TabIndex = 4;
            this.lblUrlCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // webBrowser
            // 
            this.webBrowser.AllowWebBrowserDrop = false;
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(13, 32);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(633, 501);
            this.webBrowser.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(13, 6);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(540, 20);
            this.txtAddress.TabIndex = 6;
            // 
            // btnAbort
            // 
            this.btnAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbort.Enabled = false;
            this.btnAbort.Location = new System.Drawing.Point(560, 6);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(85, 20);
            this.btnAbort.TabIndex = 7;
            this.btnAbort.Text = "Abort Load";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // chkAutoExtract
            // 
            this.chkAutoExtract.AutoSize = true;
            this.chkAutoExtract.Location = new System.Drawing.Point(8, 64);
            this.chkAutoExtract.Name = "chkAutoExtract";
            this.chkAutoExtract.Size = new System.Drawing.Size(104, 17);
            this.chkAutoExtract.TabIndex = 1;
            this.chkAutoExtract.Text = "auto on decision";
            this.chkAutoExtract.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 578);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.lblUrlCount);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.grpExtract);
            this.Controls.Add(this.grpFile);
            this.Controls.Add(this.grpDecisions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.grpDecisions.ResumeLayout(false);
            this.grpDecisions.PerformLayout();
            this.grpFile.ResumeLayout(false);
            this.grpExtract.ResumeLayout(false);
            this.grpExtract.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDecisions;
        private System.Windows.Forms.GroupBox grpFile;
        private System.Windows.Forms.Button btnWebPage;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnUnknown;
        private System.Windows.Forms.Button btnCommercial;
        private System.Windows.Forms.Button btnBlog;
        private System.Windows.Forms.GroupBox grpExtract;
        private System.Windows.Forms.Button btnDefer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label lblUrlCount;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkAutoExtract;
    }
}

