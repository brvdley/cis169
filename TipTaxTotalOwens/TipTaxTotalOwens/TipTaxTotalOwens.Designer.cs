namespace TipTaxTotalOwens
{
    partial class TipTaxTotalOwens
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
            this.calculateBTN = new System.Windows.Forms.Button();
            this.foodPriceLBL = new System.Windows.Forms.Label();
            this.foodPriceTXT = new System.Windows.Forms.TextBox();
            this.exitBTN = new System.Windows.Forms.Button();
            this.tipLBL = new System.Windows.Forms.Label();
            this.taxLBL = new System.Windows.Forms.Label();
            this.totalLBL = new System.Windows.Forms.Label();
            this.tipAmountLBL = new System.Windows.Forms.Label();
            this.taxAmountLBL = new System.Windows.Forms.Label();
            this.totalAmountLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateBTN
            // 
            this.calculateBTN.Location = new System.Drawing.Point(113, 211);
            this.calculateBTN.Name = "calculateBTN";
            this.calculateBTN.Size = new System.Drawing.Size(75, 23);
            this.calculateBTN.TabIndex = 2;
            this.calculateBTN.Text = "Cal&culate";
            this.calculateBTN.UseVisualStyleBackColor = true;
            this.calculateBTN.Click += new System.EventHandler(this.calculateBTN_Click);
            // 
            // foodPriceLBL
            // 
            this.foodPriceLBL.AutoSize = true;
            this.foodPriceLBL.Location = new System.Drawing.Point(127, 56);
            this.foodPriceLBL.Name = "foodPriceLBL";
            this.foodPriceLBL.Size = new System.Drawing.Size(61, 13);
            this.foodPriceLBL.TabIndex = 1;
            this.foodPriceLBL.Text = "Food Price:";
            // 
            // foodPriceTXT
            // 
            this.foodPriceTXT.Location = new System.Drawing.Point(194, 53);
            this.foodPriceTXT.Name = "foodPriceTXT";
            this.foodPriceTXT.Size = new System.Drawing.Size(100, 20);
            this.foodPriceTXT.TabIndex = 1;
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(259, 211);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(75, 23);
            this.exitBTN.TabIndex = 3;
            this.exitBTN.Text = "E&xit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // tipLBL
            // 
            this.tipLBL.AutoSize = true;
            this.tipLBL.Location = new System.Drawing.Point(124, 92);
            this.tipLBL.Name = "tipLBL";
            this.tipLBL.Size = new System.Drawing.Size(64, 13);
            this.tipLBL.TabIndex = 4;
            this.tipLBL.Text = "Tip Amount:";
            // 
            // taxLBL
            // 
            this.taxLBL.AutoSize = true;
            this.taxLBL.Location = new System.Drawing.Point(121, 128);
            this.taxLBL.Name = "taxLBL";
            this.taxLBL.Size = new System.Drawing.Size(67, 13);
            this.taxLBL.TabIndex = 5;
            this.taxLBL.Text = "Tax Amount:";
            // 
            // totalLBL
            // 
            this.totalLBL.AutoSize = true;
            this.totalLBL.Location = new System.Drawing.Point(154, 163);
            this.totalLBL.Name = "totalLBL";
            this.totalLBL.Size = new System.Drawing.Size(34, 13);
            this.totalLBL.TabIndex = 6;
            this.totalLBL.Text = "Total:";
            // 
            // tipAmountLBL
            // 
            this.tipAmountLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipAmountLBL.Location = new System.Drawing.Point(194, 91);
            this.tipAmountLBL.Name = "tipAmountLBL";
            this.tipAmountLBL.Size = new System.Drawing.Size(100, 20);
            this.tipAmountLBL.TabIndex = 7;
            // 
            // taxAmountLBL
            // 
            this.taxAmountLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxAmountLBL.Location = new System.Drawing.Point(194, 127);
            this.taxAmountLBL.Name = "taxAmountLBL";
            this.taxAmountLBL.Size = new System.Drawing.Size(100, 20);
            this.taxAmountLBL.TabIndex = 8;
            // 
            // totalAmountLBL
            // 
            this.totalAmountLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalAmountLBL.Location = new System.Drawing.Point(194, 162);
            this.totalAmountLBL.Name = "totalAmountLBL";
            this.totalAmountLBL.Size = new System.Drawing.Size(100, 20);
            this.totalAmountLBL.TabIndex = 9;
            // 
            // TipTaxTotalOwens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 285);
            this.Controls.Add(this.totalAmountLBL);
            this.Controls.Add(this.taxAmountLBL);
            this.Controls.Add(this.tipAmountLBL);
            this.Controls.Add(this.totalLBL);
            this.Controls.Add(this.taxLBL);
            this.Controls.Add(this.tipLBL);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.foodPriceTXT);
            this.Controls.Add(this.foodPriceLBL);
            this.Controls.Add(this.calculateBTN);
            this.Name = "TipTaxTotalOwens";
            this.Text = "Tip, Tax, Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBTN;
        private System.Windows.Forms.Label foodPriceLBL;
        private System.Windows.Forms.TextBox foodPriceTXT;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Label tipLBL;
        private System.Windows.Forms.Label taxLBL;
        private System.Windows.Forms.Label totalLBL;
        private System.Windows.Forms.Label tipAmountLBL;
        private System.Windows.Forms.Label taxAmountLBL;
        private System.Windows.Forms.Label totalAmountLBL;
    }
}

