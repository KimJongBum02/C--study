using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project0511
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            lblDisplay.BackColor = Color.Red;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            lblDisplay.BackColor = Color.Blue;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddr_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
