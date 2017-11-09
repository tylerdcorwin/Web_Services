namespace ReadFromXPath
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
            this.btnDisplayVerDate = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnDisplayMale = new System.Windows.Forms.Button();
            this.btnDisplayLast = new System.Windows.Forms.Button();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblVer = new System.Windows.Forms.Label();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDisplayVerDate
            // 
            this.btnDisplayVerDate.Location = new System.Drawing.Point(12, 12);
            this.btnDisplayVerDate.Name = "btnDisplayVerDate";
            this.btnDisplayVerDate.Size = new System.Drawing.Size(116, 23);
            this.btnDisplayVerDate.TabIndex = 0;
            this.btnDisplayVerDate.Text = "Display Version Date";
            this.btnDisplayVerDate.UseVisualStyleBackColor = true;
            this.btnDisplayVerDate.Click += new System.EventHandler(this.btnDisplayVerDate_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(181, 41);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 2;
            this.btnAll.Text = "All Info";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnDisplayMale
            // 
            this.btnDisplayMale.Location = new System.Drawing.Point(181, 12);
            this.btnDisplayMale.Name = "btnDisplayMale";
            this.btnDisplayMale.Size = new System.Drawing.Size(116, 23);
            this.btnDisplayMale.TabIndex = 3;
            this.btnDisplayMale.Text = "Display Only Males";
            this.btnDisplayMale.UseVisualStyleBackColor = true;
            this.btnDisplayMale.Click += new System.EventHandler(this.btnDisplayMale_Click);
            // 
            // btnDisplayLast
            // 
            this.btnDisplayLast.Location = new System.Drawing.Point(13, 295);
            this.btnDisplayLast.Name = "btnDisplayLast";
            this.btnDisplayLast.Size = new System.Drawing.Size(116, 23);
            this.btnDisplayLast.TabIndex = 4;
            this.btnDisplayLast.Text = "Display Last Name";
            this.btnDisplayLast.UseVisualStyleBackColor = true;
            this.btnDisplayLast.Click += new System.EventHandler(this.btnDisplayLast_Click);
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(135, 295);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(149, 20);
            this.txtLName.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(13, 50);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "lblDate";
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.Location = new System.Drawing.Point(13, 73);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(33, 13);
            this.lblVer.TabIndex = 7;
            this.lblVer.Text = "lblVer";
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(16, 106);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(268, 160);
            this.lbResults.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 348);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.lblVer);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.btnDisplayLast);
            this.Controls.Add(this.btnDisplayMale);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnDisplayVerDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayVerDate;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnDisplayMale;
        private System.Windows.Forms.Button btnDisplayLast;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.ListBox lbResults;
    }
}

