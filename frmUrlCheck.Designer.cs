namespace BlogBrush
{
    partial class frmUrlCheck
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
            this.listCandidates = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtScan = new System.Windows.Forms.TextBox();
            this.txtWhite = new System.Windows.Forms.TextBox();
            this.txtBlack = new System.Windows.Forms.TextBox();
            this.btnAdd2Scan = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listCandidates
            // 
            this.listCandidates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listCandidates.FormattingEnabled = true;
            this.listCandidates.Location = new System.Drawing.Point(6, 19);
            this.listCandidates.Name = "listCandidates";
            this.listCandidates.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listCandidates.Size = new System.Drawing.Size(540, 589);
            this.listCandidates.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Candidates (multi-select)";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add to Scan";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Add to Whitelist Domains";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Add to Blacklist Domains";
            // 
            // txtScan
            // 
            this.txtScan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScan.Location = new System.Drawing.Point(583, 22);
            this.txtScan.Multiline = true;
            this.txtScan.Name = "txtScan";
            this.txtScan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtScan.Size = new System.Drawing.Size(342, 351);
            this.txtScan.TabIndex = 5;
            // 
            // txtWhite
            // 
            this.txtWhite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWhite.Location = new System.Drawing.Point(583, 397);
            this.txtWhite.Multiline = true;
            this.txtWhite.Name = "txtWhite";
            this.txtWhite.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWhite.Size = new System.Drawing.Size(342, 81);
            this.txtWhite.TabIndex = 6;
            // 
            // txtBlack
            // 
            this.txtBlack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBlack.Location = new System.Drawing.Point(583, 501);
            this.txtBlack.Multiline = true;
            this.txtBlack.Name = "txtBlack";
            this.txtBlack.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBlack.Size = new System.Drawing.Size(342, 85);
            this.txtBlack.TabIndex = 7;
            // 
            // btnAdd2Scan
            // 
            this.btnAdd2Scan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd2Scan.Location = new System.Drawing.Point(552, 133);
            this.btnAdd2Scan.Name = "btnAdd2Scan";
            this.btnAdd2Scan.Size = new System.Drawing.Size(25, 55);
            this.btnAdd2Scan.TabIndex = 8;
            this.btnAdd2Scan.Text = ">";
            this.btnAdd2Scan.UseVisualStyleBackColor = true;
            this.btnAdd2Scan.Click += new System.EventHandler(this.btnAdd2Scan_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWhite.Location = new System.Drawing.Point(552, 410);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(25, 55);
            this.btnWhite.TabIndex = 9;
            this.btnWhite.Text = ">";
            this.btnWhite.UseVisualStyleBackColor = true;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBlack.Location = new System.Drawing.Point(552, 516);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(25, 55);
            this.btnBlack.TabIndex = 10;
            this.btnBlack.Text = ">";
            this.btnBlack.UseVisualStyleBackColor = true;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(804, 590);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 21);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmUrlCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 614);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBlack);
            this.Controls.Add(this.btnWhite);
            this.Controls.Add(this.btnAdd2Scan);
            this.Controls.Add(this.txtBlack);
            this.Controls.Add(this.txtWhite);
            this.Controls.Add(this.txtScan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listCandidates);
            this.Name = "frmUrlCheck";
            this.Text = "frmUrlCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCandidates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtScan;
        private System.Windows.Forms.TextBox txtWhite;
        private System.Windows.Forms.TextBox txtBlack;
        private System.Windows.Forms.Button btnAdd2Scan;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnSave;
    }
}