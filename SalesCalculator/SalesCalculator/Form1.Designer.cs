namespace SalesCalculator
{
    partial class salesForm
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
            this.submitBtn = new System.Windows.Forms.Button();
            this.totalLbl = new System.Windows.Forms.Label();
            this.taxLbl = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.taxesBox = new System.Windows.Forms.TextBox();
            this.subTotalBox = new System.Windows.Forms.TextBox();
            this.subtotalLbl = new System.Windows.Forms.Label();
            this.outputControls = new System.Windows.Forms.GroupBox();
            this.inputPriceBox = new System.Windows.Forms.GroupBox();
            this.taxIn = new System.Windows.Forms.TextBox();
            this.subTotalIn = new System.Windows.Forms.TextBox();
            this.taxLabel = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.outputControls.SuspendLayout();
            this.inputPriceBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(69, 252);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 0;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(62, 101);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(34, 13);
            this.totalLbl.TabIndex = 2;
            this.totalLbl.Text = "Total:";
            // 
            // taxLbl
            // 
            this.taxLbl.AutoSize = true;
            this.taxLbl.Location = new System.Drawing.Point(60, 58);
            this.taxLbl.Name = "taxLbl";
            this.taxLbl.Size = new System.Drawing.Size(36, 13);
            this.taxLbl.TabIndex = 3;
            this.taxLbl.Text = "Taxes";
            // 
            // totalBox
            // 
            this.totalBox.BackColor = System.Drawing.SystemColors.Control;
            this.totalBox.Location = new System.Drawing.Point(102, 94);
            this.totalBox.Name = "totalBox";
            this.totalBox.ReadOnly = true;
            this.totalBox.Size = new System.Drawing.Size(66, 20);
            this.totalBox.TabIndex = 4;
            // 
            // taxesBox
            // 
            this.taxesBox.BackColor = System.Drawing.SystemColors.Control;
            this.taxesBox.Location = new System.Drawing.Point(102, 55);
            this.taxesBox.Name = "taxesBox";
            this.taxesBox.ReadOnly = true;
            this.taxesBox.Size = new System.Drawing.Size(66, 20);
            this.taxesBox.TabIndex = 5;
            // 
            // subTotalBox
            // 
            this.subTotalBox.Location = new System.Drawing.Point(102, 13);
            this.subTotalBox.Name = "subTotalBox";
            this.subTotalBox.ReadOnly = true;
            this.subTotalBox.Size = new System.Drawing.Size(66, 20);
            this.subTotalBox.TabIndex = 6;
            // 
            // subtotalLbl
            // 
            this.subtotalLbl.AutoSize = true;
            this.subtotalLbl.Location = new System.Drawing.Point(46, 16);
            this.subtotalLbl.Name = "subtotalLbl";
            this.subtotalLbl.Size = new System.Drawing.Size(50, 13);
            this.subtotalLbl.TabIndex = 7;
            this.subtotalLbl.Text = "SubTotal";
            // 
            // outputControls
            // 
            this.outputControls.Controls.Add(this.subtotalLbl);
            this.outputControls.Controls.Add(this.totalLbl);
            this.outputControls.Controls.Add(this.subTotalBox);
            this.outputControls.Controls.Add(this.taxLbl);
            this.outputControls.Controls.Add(this.taxesBox);
            this.outputControls.Controls.Add(this.totalBox);
            this.outputControls.Location = new System.Drawing.Point(180, 166);
            this.outputControls.Name = "outputControls";
            this.outputControls.Size = new System.Drawing.Size(203, 124);
            this.outputControls.TabIndex = 8;
            this.outputControls.TabStop = false;
            this.outputControls.Text = "PriceDisplay";
            // 
            // inputPriceBox
            // 
            this.inputPriceBox.Controls.Add(this.taxIn);
            this.inputPriceBox.Controls.Add(this.subTotalIn);
            this.inputPriceBox.Controls.Add(this.taxLabel);
            this.inputPriceBox.Controls.Add(this.PriceLbl);
            this.inputPriceBox.Location = new System.Drawing.Point(183, 39);
            this.inputPriceBox.Name = "inputPriceBox";
            this.inputPriceBox.Size = new System.Drawing.Size(200, 121);
            this.inputPriceBox.TabIndex = 9;
            this.inputPriceBox.TabStop = false;
            this.inputPriceBox.Text = "InputPrices";
            // 
            // taxIn
            // 
            this.taxIn.Location = new System.Drawing.Point(99, 60);
            this.taxIn.Name = "taxIn";
            this.taxIn.Size = new System.Drawing.Size(66, 20);
            this.taxIn.TabIndex = 3;
            // 
            // subTotalIn
            // 
            this.subTotalIn.Location = new System.Drawing.Point(99, 26);
            this.subTotalIn.Name = "subTotalIn";
            this.subTotalIn.Size = new System.Drawing.Size(66, 20);
            this.subTotalIn.TabIndex = 2;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(24, 60);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(39, 13);
            this.taxLabel.TabIndex = 1;
            this.taxLabel.Text = "Taxes:";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Location = new System.Drawing.Point(24, 26);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(50, 13);
            this.PriceLbl.TabIndex = 0;
            this.PriceLbl.Text = "SubTotal";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(69, 213);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 10;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // salesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 302);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.inputPriceBox);
            this.Controls.Add(this.outputControls);
            this.Controls.Add(this.submitBtn);
            this.Name = "salesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesCalculator";
            this.Load += new System.EventHandler(this.salesForm_Load);
            this.outputControls.ResumeLayout(false);
            this.outputControls.PerformLayout();
            this.inputPriceBox.ResumeLayout(false);
            this.inputPriceBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label taxLbl;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.TextBox taxesBox;
        private System.Windows.Forms.TextBox subTotalBox;
        private System.Windows.Forms.Label subtotalLbl;
        private System.Windows.Forms.GroupBox outputControls;
        private System.Windows.Forms.GroupBox inputPriceBox;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.TextBox taxIn;
        private System.Windows.Forms.TextBox subTotalIn;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Button resetBtn;
    }
}

