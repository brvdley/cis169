namespace SalePriceCalculatorOwens
{
    partial class ExceptionHandlingOwens
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
            this.originalPriceLBL = new System.Windows.Forms.Label();
            this.originalPriceTXT = new System.Windows.Forms.TextBox();
            this.calculateBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.discountTXT = new System.Windows.Forms.TextBox();
            this.discountLBL = new System.Windows.Forms.Label();
            this.salePriceLBL = new System.Windows.Forms.Label();
            this.salePriceOutputLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // originalPriceLBL
            // 
            this.originalPriceLBL.AutoSize = true;
            this.originalPriceLBL.Location = new System.Drawing.Point(81, 59);
            this.originalPriceLBL.Name = "originalPriceLBL";
            this.originalPriceLBL.Size = new System.Drawing.Size(99, 13);
            this.originalPriceLBL.TabIndex = 0;
            this.originalPriceLBL.Text = "Item\'s original price:";
            // 
            // originalPriceTXT
            // 
            this.originalPriceTXT.Location = new System.Drawing.Point(186, 56);
            this.originalPriceTXT.Name = "originalPriceTXT";
            this.originalPriceTXT.Size = new System.Drawing.Size(100, 20);
            this.originalPriceTXT.TabIndex = 1;
            // 
            // calculateBTN
            // 
            this.calculateBTN.Location = new System.Drawing.Point(105, 208);
            this.calculateBTN.Name = "calculateBTN";
            this.calculateBTN.Size = new System.Drawing.Size(75, 23);
            this.calculateBTN.TabIndex = 3;
            this.calculateBTN.Text = "Cal&culate";
            this.calculateBTN.UseVisualStyleBackColor = true;
            this.calculateBTN.Click += new System.EventHandler(this.calculateBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBTN.Location = new System.Drawing.Point(234, 208);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(75, 23);
            this.exitBTN.TabIndex = 4;
            this.exitBTN.Text = "E&xit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // discountTXT
            // 
            this.discountTXT.Location = new System.Drawing.Point(186, 95);
            this.discountTXT.Name = "discountTXT";
            this.discountTXT.Size = new System.Drawing.Size(100, 20);
            this.discountTXT.TabIndex = 2;
            // 
            // discountLBL
            // 
            this.discountLBL.AutoSize = true;
            this.discountLBL.Location = new System.Drawing.Point(70, 98);
            this.discountLBL.Name = "discountLBL";
            this.discountLBL.Size = new System.Drawing.Size(110, 13);
            this.discountLBL.TabIndex = 5;
            this.discountLBL.Text = "Discount Percentage:";
            // 
            // salePriceLBL
            // 
            this.salePriceLBL.AutoSize = true;
            this.salePriceLBL.Location = new System.Drawing.Point(119, 138);
            this.salePriceLBL.Name = "salePriceLBL";
            this.salePriceLBL.Size = new System.Drawing.Size(58, 13);
            this.salePriceLBL.TabIndex = 6;
            this.salePriceLBL.Text = "Sale Price:";
            // 
            // salePriceOutputLBL
            // 
            this.salePriceOutputLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salePriceOutputLBL.Location = new System.Drawing.Point(183, 138);
            this.salePriceOutputLBL.Name = "salePriceOutputLBL";
            this.salePriceOutputLBL.Size = new System.Drawing.Size(100, 20);
            this.salePriceOutputLBL.TabIndex = 7;
            // 
            // SalePriceCalculatorOwens
            // 
            this.AcceptButton = this.calculateBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBTN;
            this.ClientSize = new System.Drawing.Size(410, 286);
            this.Controls.Add(this.salePriceOutputLBL);
            this.Controls.Add(this.salePriceLBL);
            this.Controls.Add(this.discountLBL);
            this.Controls.Add(this.discountTXT);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.calculateBTN);
            this.Controls.Add(this.originalPriceTXT);
            this.Controls.Add(this.originalPriceLBL);
            this.Name = "SalePriceCalculatorOwens";
            this.Text = "Sale Price Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originalPriceLBL;
        private System.Windows.Forms.TextBox originalPriceTXT;
        private System.Windows.Forms.Button calculateBTN;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.TextBox discountTXT;
        private System.Windows.Forms.Label discountLBL;
        private System.Windows.Forms.Label salePriceLBL;
        private System.Windows.Forms.Label salePriceOutputLBL;
    }
}

