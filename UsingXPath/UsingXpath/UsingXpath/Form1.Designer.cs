namespace UsingXpath
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
            this.btnReadFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.txtXPathExpression = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNodes = new System.Windows.Forms.ComboBox();
            this.btnGetNodes = new System.Windows.Forms.Button();
            this.txtNodeList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(83, 91);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(110, 45);
            this.btnReadFile.TabIndex = 0;
            this.btnReadFile.Text = "Read File Using Evaluate";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "XPath Expression";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(172, 75);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(52, 13);
            this.lblResults.TabIndex = 4;
            this.lblResults.Text = "lblResults";
            // 
            // txtXPathExpression
            // 
            this.txtXPathExpression.Location = new System.Drawing.Point(163, 23);
            this.txtXPathExpression.Name = "txtXPathExpression";
            this.txtXPathExpression.Size = new System.Drawing.Size(100, 20);
            this.txtXPathExpression.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nodes";
            // 
            // cmbNodes
            // 
            this.cmbNodes.FormattingEnabled = true;
            this.cmbNodes.Location = new System.Drawing.Point(121, 181);
            this.cmbNodes.Name = "cmbNodes";
            this.cmbNodes.Size = new System.Drawing.Size(121, 21);
            this.cmbNodes.TabIndex = 7;
            // 
            // btnGetNodes
            // 
            this.btnGetNodes.Location = new System.Drawing.Point(94, 220);
            this.btnGetNodes.Name = "btnGetNodes";
            this.btnGetNodes.Size = new System.Drawing.Size(75, 23);
            this.btnGetNodes.TabIndex = 8;
            this.btnGetNodes.Text = "Get Nodes";
            this.btnGetNodes.UseVisualStyleBackColor = true;
            this.btnGetNodes.Click += new System.EventHandler(this.btnGetNodes_Click);
            // 
            // txtNodeList
            // 
            this.txtNodeList.Location = new System.Drawing.Point(119, 155);
            this.txtNodeList.Name = "txtNodeList";
            this.txtNodeList.Size = new System.Drawing.Size(123, 20);
            this.txtNodeList.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.txtNodeList);
            this.Controls.Add(this.btnGetNodes);
            this.Controls.Add(this.cmbNodes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtXPathExpression);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.TextBox txtXPathExpression;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNodes;
        private System.Windows.Forms.Button btnGetNodes;
        private System.Windows.Forms.TextBox txtNodeList;
    }
}

