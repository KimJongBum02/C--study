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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void chkRamen_CheckedChanged(object sender, EventArgs e)
        {
            string menu = "";
            if (chkRamen.Checked)
            {
                menu = chkRamen.Text;
            }

            if (chkGalbi.Checked)
            {
                menu += chkGalbi.Text;
            }

            if (chkMara.Checked)
            {
                menu += chkMara.Text;
            }

            label1.Text = menu;
        }

        private void chkGalbi_CheckedChanged(object sender, EventArgs e)
        {
            string menu = "";
            if (chkRamen.Checked)
            {
                menu = chkRamen.Text;
            }

            if (chkGalbi.Checked)
            {
                menu += chkGalbi.Text;
            }

            if (chkMara.Checked)
            {
                menu += chkMara.Text;
            }

            label1.Text = menu;
        }

        private void chkMara_CheckedChanged(object sender, EventArgs e)
        {
            string menu = "";
            if (chkRamen.Checked)
            {
                menu = chkRamen.Text;
            }

            if (chkGalbi.Checked)
            {
                menu += chkGalbi.Text;
            }

            if (chkMara.Checked)
            {
                menu += chkMara.Text;
            }

            label1.Text = menu;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label2.Text = "성별은 " + radioButton1.Text;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label2.Text = "성별은 " + radioButton2.Text;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                label3.Text = "학년은 " + radioButton3.Text;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                label3.Text = "학년은 " + radioButton3.Text;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                label3.Text = "학년은 " + radioButton3.Text;
            }
        }
    }
}
