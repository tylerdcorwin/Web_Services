namespace ParseXML
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
            this.btnRevDate = new System.Windows.Forms.Button();
            this.btnListName = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRevDate
            // 
            this.btnRevDate.Location = new System.Drawing.Point(25, 12);
            this.btnRevDate.Name = "btnRevDate";
            this.btnRevDate.Size = new System.Drawing.Size(77, 70);
            this.btnRevDate.TabIndex = 0;
            this.btnRevDate.Text = "Show Revision Date";
            this.btnRevDate.UseVisualStyleBackColor = true;
            this.btnRevDate.Click += new System.EventHandler(this.btnRevDate_Click);
            // 
            // btnListName
            // 
            this.btnListName.Location = new System.Drawing.Point(164, 12);
            this.btnListName.Name = "btnListName";
            this.btnListName.Size = new System.Drawing.Size(96, 70);
            this.btnListName.TabIndex = 1;
            this.btnListName.Text = "List Names";
            this.btnListName.UseVisualStyleBackColor = true;
            this.btnListName.Click += new System.EventHandler(this.btnListName_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(25, 116);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(235, 121);
            this.txtResult.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnListName);
            this.Controls.Add(this.btnRevDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRevDate;
        private System.Windows.Forms.Button btnListName;
        private System.Windows.Forms.TextBox txtResult;
    }
}

