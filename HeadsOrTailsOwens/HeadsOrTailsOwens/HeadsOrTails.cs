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
* Name        : Heads Or Tails
* Author      : Bradley Owens
* Created     : 1/26/2020
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on specifications issued by our instructor
* Description : The user will click "Show Tails" to show the tails side of the coin and "Show Heads" to show the heads sign of the coin.
*               Input:  None
*               Output: None
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/
namespace HeadsOrTailsOwens
{
    public partial class HeadsOrTails : Form
    {
        public HeadsOrTails()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e) //Closes Application
        {
            this.Close();
        }

        private void showHeadsBtn_Click(object sender, EventArgs e) //Makes heads coin side visible and hides tails coin side.
        {
            tailsPic.Visible = false;
            headsPic.Visible = true;
        }

        private void showTailsBtn_Click(object sender, EventArgs e) //Makes tails coin side visible and hides heads coin side.
        {
            tailsPic.Visible = true;
            headsPic.Visible = false;
        }
    }
}
