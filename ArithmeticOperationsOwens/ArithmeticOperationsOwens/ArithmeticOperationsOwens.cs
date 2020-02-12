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
* Name        : Arithmetic Operations
* Author      : Bradley Owens
* Created     : 2/2/2020
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on specifications issued by our instructor
* Description : This program overall description here
*               Input:  Input numbers to calculate
*               Output: Output answers of calculations
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/

namespace ArithmeticOperationsOwens
{
    public partial class ArithmeticOperationsOwens : Form
    {
        public ArithmeticOperationsOwens()
        {
            InitializeComponent();
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            if (addFirstTXT.Text != "" && addSecondTXT.Text != "")
            {
                int resultAdd = Int32.Parse(addFirstTXT.Text) + Int32.Parse(addSecondTXT.Text);
                addAnswerLBL.Text = resultAdd.ToString();
            }
            if (subFirstTXT.Text != "" && subSecondTXT.Text != "")
            {
                int resultSub = Int32.Parse(subFirstTXT.Text) - Int32.Parse(subSecondTXT.Text);
                subAnswerLBL.Text = resultSub.ToString();
            }
            if (timesFirstTXT.Text != "" && timesSecondTXT.Text != "")
            {
                int resultTimes = Int32.Parse(timesFirstTXT.Text) * Int32.Parse(timesSecondTXT.Text);
                timesAnswerLBL.Text = resultTimes.ToString();
            }
            if (divFirstTXT.Text != "" && divSecondTXT.Text != "")
            {
                int resultDiv = Int32.Parse(divFirstTXT.Text) / Int32.Parse(divSecondTXT.Text);
                divAnswerLBL.Text = resultDiv.ToString();
            }
            if (modFirstTXT.Text != "" && modSecondTXT.Text != "")
            {
                int resultMod = Int32.Parse(modSecondTXT.Text) % Int32.Parse(modFirstTXT.Text);
                modAnswerLBL.Text = resultMod.ToString();
            }
            if (incTXT.Text != "")
            {
                int resultInc = Int32.Parse(incTXT.Text);
                resultInc++;
                incAnswerLBL.Text = resultInc.ToString();
            }
            if (decTXT.Text != "")
            {
                int resultDec = Int32.Parse(decTXT.Text);
                resultDec--;
                decAnswerLBL.Text = resultDec.ToString();
            }
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resetBTN_Click(object sender, EventArgs e)
        {
            addFirstTXT.Text = "";
            addSecondTXT.Text = "";
            subFirstTXT.Text = "";
            subSecondTXT.Text = "";
            timesFirstTXT.Text = "";
            timesSecondTXT.Text = "";
            divFirstTXT.Text = "";
            divSecondTXT.Text = "";
            modFirstTXT.Text = "";
            modSecondTXT.Text = "";
            incTXT.Text = "";
            decTXT.Text = "";
            addAnswerLBL.Text = "";
            subAnswerLBL.Text = "";
            timesAnswerLBL.Text = "";
            divAnswerLBL.Text = "";
            modAnswerLBL.Text = "";
            incAnswerLBL.Text = "";
            decAnswerLBL.Text = "";


        }
    }
}
