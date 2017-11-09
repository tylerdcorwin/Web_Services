namespace XMLParsing
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
            this.btnReadXMLFile = new System.Windows.Forms.Button();
            this.btnReadXMLValues = new System.Windows.Forms.Button();
            this.btnInnerText = new System.Windows.Forms.Button();
            this.btnFindingChildren = new System.Windows.Forms.Button();
            this.btnGetElementByTagName = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReadXMLFile
            // 
            this.btnReadXMLFile.Location = new System.Drawing.Point(37, 26);
            this.btnReadXMLFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReadXMLFile.Name = "btnReadXMLFile";
            this.btnReadXMLFile.Size = new System.Drawing.Size(111, 73);
            this.btnReadXMLFile.TabIndex = 4;
            this.btnReadXMLFile.Text = "Reading An XML File";
            this.btnReadXMLFile.UseVisualStyleBackColor = true;
            this.btnReadXMLFile.Click += new System.EventHandler(this.btnReadXMLFile_Click);
            // 
            // btnReadXMLValues
            // 
            this.btnReadXMLValues.Location = new System.Drawing.Point(196, 26);
            this.btnReadXMLValues.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReadXMLValues.Name = "btnReadXMLValues";
            this.btnReadXMLValues.Size = new System.Drawing.Size(111, 73);
            this.btnReadXMLValues.TabIndex = 5;
            this.btnReadXMLValues.Text = "Read XML Value";
            this.btnReadXMLValues.UseVisualStyleBackColor = true;
            this.btnReadXMLValues.Click += new System.EventHandler(this.btnReadXMLValues_Click);
            // 
            // btnInnerText
            // 
            this.btnInnerText.Location = new System.Drawing.Point(514, 26);
            this.btnInnerText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInnerText.Name = "btnInnerText";
            this.btnInnerText.Size = new System.Drawing.Size(111, 73);
            this.btnInnerText.TabIndex = 6;
            this.btnInnerText.Text = "Inner and Outer Text";
            this.btnInnerText.UseVisualStyleBackColor = true;
            this.btnInnerText.Click += new System.EventHandler(this.btnInnerText_Click);
            // 
            // btnFindingChildren
            // 
            this.btnFindingChildren.Location = new System.Drawing.Point(355, 26);
            this.btnFindingChildren.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFindingChildren.Name = "btnFindingChildren";
            this.btnFindingChildren.Size = new System.Drawing.Size(111, 73);
            this.btnFindingChildren.TabIndex = 7;
            this.btnFindingChildren.Text = "Finding Child Nodes";
            this.btnFindingChildren.UseVisualStyleBackColor = true;
            this.btnFindingChildren.Click += new System.EventHandler(this.btnFindingChildren_Click);
            // 
            // btnGetElementByTagName
            // 
            this.btnGetElementByTagName.Location = new System.Drawing.Point(673, 26);
            this.btnGetElementByTagName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetElementByTagName.Name = "btnGetElementByTagName";
            this.btnGetElementByTagName.Size = new System.Drawing.Size(111, 73);
            this.btnGetElementByTagName.TabIndex = 8;
            this.btnGetElementByTagName.Text = "Get Element By Tag Name";
            this.btnGetElementByTagName.UseVisualStyleBackColor = true;
            this.btnGetElementByTagName.Click += new System.EventHandler(this.btnGetElementByTagName_Click);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(145, 151);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResults.Size = new System.Drawing.Size(552, 333);
            this.txtResults.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 521);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnGetElementByTagName);
            this.Controls.Add(this.btnFindingChildren);
            this.Controls.Add(this.btnInnerText);
            this.Controls.Add(this.btnReadXMLValues);
            this.Controls.Add(this.btnReadXMLFile);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Set output as a console application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadXMLFile;
        private System.Windows.Forms.Button btnReadXMLValues;
        private System.Windows.Forms.Button btnInnerText;
        private System.Windows.Forms.Button btnFindingChildren;
        private System.Windows.Forms.Button btnGetElementByTagName;
        private System.Windows.Forms.TextBox txtResults;
    }
}

