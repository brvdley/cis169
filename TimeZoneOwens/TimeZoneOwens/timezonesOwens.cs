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
* Name        : Timezones
* Author      : Bradley Owens
* Created     : 2/9/2020
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on specifications issued by our instructor
* Description : This program overall description here
*               Input: Choose a city
*               Output: City's Timezone
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/

namespace TimeZoneOwens
{
    public partial class timezonesOwens : Form
    {
        public timezonesOwens()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            int city = cityListBox.SelectedIndex; //city is the selected item in the listbox

            if (city == 0) // if denver
            {
                timezoneOutputLabel.Text = "Mountain";
            }
            else if (city == 1) //if minneapolis
            {
                timezoneOutputLabel.Text = "Central";
            }
            else if (city == 2) //if new york
            {
                timezoneOutputLabel.Text = "Eastern";
            }
            else if (city == 3) // if san francisco
            {
                timezoneOutputLabel.Text = "Pacific";
            }
            else if (city == 4) //if honolulu
            {
                timezoneOutputLabel.Text = "Hawaii-Aleutian";
            }
            else
            {
                MessageBox.Show("Select a city."); //if no city is selected
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //close program
        }
    }
}
