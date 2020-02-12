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
* Name        : Time Calculator
* Author      : Bradley Owens
* Created     : 2/9/2020
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on specifications issued by our instructor
* Description : This program overall description here
*               Input: Seconds.
*               Output: Amount of days, minutes, hours, or seconds entered.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/

namespace timeCalculatorOwens
{
    public partial class timeCalculatorOwens : Form
    {
        public timeCalculatorOwens()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const int SECONDS_MINUTE = 60; //constant numbers for seconds in each item
            const int SECONDS_HOUR = 3600;
            const int SECONDS_DAY = 86400;
            int seconds; //seconds variable
            Int32.TryParse(secondsTextBox.Text, out seconds); //try parsing and outputting the textbox text to variable seconds

            if (seconds > 0 && seconds < SECONDS_MINUTE) //if less than a minute but greater than 0
            {
                secondsOutputLabel.Text = seconds.ToString(); //output 
            }
            else if (seconds >= SECONDS_MINUTE && seconds < SECONDS_HOUR) //if less than an hour but greater than a minute
            {
                minutesOutputLabel.Text = (seconds / SECONDS_MINUTE).ToString(); //output
                secondsOutputLabel.Text = (seconds % SECONDS_MINUTE).ToString();
            }
            else if (seconds >= SECONDS_HOUR && seconds < SECONDS_DAY) //if less than a day but greater than an hour
            { 
                hoursOutputLabel.Text = (seconds / SECONDS_HOUR).ToString(); //output
                minutesOutputLabel.Text = (seconds % SECONDS_HOUR).ToString();
                secondsOutputLabel.Text = (seconds % SECONDS_MINUTE).ToString();
            }
            else if (seconds >= SECONDS_DAY) //if greater than a day
            {
                daysOutputLabel.Text = (seconds / SECONDS_DAY).ToString(); //output
                hoursOutputLabel.Text = (seconds % SECONDS_DAY).ToString();
                minutesOutputLabel.Text = (seconds % SECONDS_HOUR).ToString();
                secondsOutputLabel.Text = (seconds % SECONDS_MINUTE).ToString();
            }
            else
            {
                MessageBox.Show("Enter a number."); //if wrong input
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Close program
        }
    }
}
