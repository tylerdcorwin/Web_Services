namespace Lab2
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
            this.lbBilling = new System.Windows.Forms.ListBox();
            this.lbShipping = new System.Windows.Forms.ListBox();
            this.lbItem = new System.Windows.Forms.ListBox();
            this.lblItems = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblItemResult = new System.Windows.Forms.Label();
            this.lblCostResult = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBilling
            // 
            this.lbBilling.FormattingEnabled = true;
            this.lbBilling.Location = new System.Drawing.Point(12, 28);
            this.lbBilling.Name = "lbBilling";
            this.lbBilling.Size = new System.Drawing.Size(190, 134);
            this.lbBilling.TabIndex = 0;
            // 
            // lbShipping
            // 
            this.lbShipping.FormattingEnabled = true;
            this.lbShipping.Location = new System.Drawing.Point(234, 28);
            this.lbShipping.Name = "lbShipping";
            this.lbShipping.Size = new System.Drawing.Size(190, 134);
            this.lbShipping.TabIndex = 1;
            // 
            // lbItem
            // 
            this.lbItem.FormattingEnabled = true;
            this.lbItem.Location = new System.Drawing.Point(448, 28);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(190, 134);
            this.lbItem.TabIndex = 2;
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(115, 168);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(87, 13);
            this.lblItems.TabIndex = 3;
            this.lblItems.Text = "Number of Items:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(144, 200);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(58, 13);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "Total Cost:";
            // 
            // lblItemResult
            // 
            this.lblItemResult.AutoSize = true;
            this.lblItemResult.Location = new System.Drawing.Point(234, 168);
            this.lblItemResult.Name = "lblItemResult";
            this.lblItemResult.Size = new System.Drawing.Size(42, 13);
            this.lblItemResult.TabIndex = 5;
            this.lblItemResult.Text = "Results";
            // 
            // lblCostResult
            // 
            this.lblCostResult.AutoSize = true;
            this.lblCostResult.Location = new System.Drawing.Point(234, 200);
            this.lblCostResult.Name = "lblCostResult";
            this.lblCostResult.Size = new System.Drawing.Size(42, 13);
            this.lblCostResult.TabIndex = 6;
            this.lblCostResult.Text = "Results";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(349, 178);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Pull Invoice";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Billing Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Shipping Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Item Information";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 259);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblCostResult);
            this.Controls.Add(this.lblItemResult);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.lbItem);
            this.Controls.Add(this.lbShipping);
            this.Controls.Add(this.lbBilling);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBilling;
        private System.Windows.Forms.ListBox lbShipping;
        private System.Windows.Forms.ListBox lbItem;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblItemResult;
        private System.Windows.Forms.Label lblCostResult;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

