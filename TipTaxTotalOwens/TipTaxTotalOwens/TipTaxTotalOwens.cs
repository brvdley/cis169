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
* Name        : Tip, Tax, Total
* Author      : Bradley Owens
* Created     : 2/2/2020
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on specifications issued by our instructor
* Description : This program overall description here
*               Input: Original Food Price
*               Output: Tax calculation, tip calculation, and total calculation
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/

namespace TipTaxTotalOwens
{
    public partial class TipTaxTotalOwens : Form
    {
        public TipTaxTotalOwens()
        {
            InitializeComponent();
        }

        private void calculateBTN_Click(object sender, EventArgs e)
        {
            try //error handler incase they enter invalid data
            {
                double foodPrice = Double.Parse(foodPriceTXT.Text); //Declaring initial variables
                const double taxRate = .07;
                const double tipRate = .15;
                double total;
                double tipAmount;
                double taxAmount;

                tipAmount = foodPrice * tipRate; // tip, tax, and total calculations
                taxAmount = foodPrice * taxRate;
                total = foodPrice + tipAmount + taxAmount;
                taxAmountLBL.Text = "$" + taxAmount.ToString(); // outputting calculations to labels
                tipAmountLBL.Text = "$" + tipAmount.ToString();
                totalAmountLBL.Text = "$" + total.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid Data. Try Again.");
            }
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close(); //close application
        }
    }
}
