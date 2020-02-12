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
* Name        : Days of the Week
* Author      : Bradley Owens
* Created     : 2/9/2020
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on specifications issued by our instructor
* Description : This program overall description here
*               Input: Number of the day they wish to see
*               Output: Day of the week corresponding to the number
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/

namespace DaysOfTheWeekOwens
{
    public partial class DaysOfTheWeekOwens : Form
    {
        public DaysOfTheWeekOwens()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int outputParse;
            Int32.TryParse(numberTextBox.Text, out outputParse); //get input and try parsing it

            if (outputParse > 0 && outputParse <= 7) //only run if number is between 1-7
            {
                switch (outputParse) //switch statement that checks number
                {
                    case 1:
                        daysOutputLabel.Text = "Monday"; //if 1
                        break;
                    case 2:
                        daysOutputLabel.Text = "Tuesday"; //if 2
                        break;
                    case 3:
                        daysOutputLabel.Text = "Wednesday"; //if 3
                        break;
                    case 4:
                        daysOutputLabel.Text = "Thursday"; //if 4
                        break;
                    case 5: 
                        daysOutputLabel.Text = "Friday"; //if 5
                        break;
                    case 6:
                        daysOutputLabel.Text = "Saturday"; //if 6
                        break;
                    case 7:
                        daysOutputLabel.Text = "Sunday"; //if 7
                        break;
                }
            }
            else
            {
                MessageBox.Show("Enter a number between 1-7."); //if they enter wrong number or nothing
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //close program
        }
    }
}
