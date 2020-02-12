using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/***************************************************************
* Name        : Sale Price Calculator
* Author      : Bradley Owens
* Created     : 2/2/2020
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on specifications issued by our instructor
* Description : This program overall description here
*               Input:  The original price of an item. The discount percentage of the item.
*               Output: The original price of the item minus the discount amount.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/

namespace SalePriceCalculatorOwens
{
    public partial class ExceptionHandlingOwens : Form
    {
        public ExceptionHandlingOwens()
        {
            InitializeComponent();
        }

        private void calculateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                double originalPrice = Double.Parse(originalPriceTXT.Text);
                double discountPercentage = Double.Parse(discountTXT.Text) / 100;
                double discountAmount = originalPrice * discountPercentage;
                double salePrice = originalPrice - discountAmount;
                salePriceOutputLBL.Text = "$" + salePrice.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid data was entered. Try again.");
            }
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
