using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Flip
{
    public partial class CardFlip : Form
    {
        public CardFlip()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cardBackPic.Visible = false;
            cardFacePic.Visible = true;
        }

        private void cardBackBtn_Click(object sender, EventArgs e)
        {
            cardBackPic.Visible = true;
            cardFacePic.Visible = false;
        }
    }
}
