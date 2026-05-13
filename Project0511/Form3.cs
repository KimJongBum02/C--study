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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (comboBox1.SelectedIndex == 0)        /// 기계공학전공
           {
                label1.Text = "장준환 교수\n황규대 교수";
           }
           else if (comboBox1.SelectedIndex == 2)   /// 컴퓨터소프트웨어전공
           {
                label1.Text = "김원일 교수\n장윤경 교수";
           }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("딸기");
            listBox1.Items.Add("바나나");
            listBox1.Items.Add("사과");
            listBox1.Items.Add("포도");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("선택한 과일은 " + listBox1.SelectedItem.ToString());
        }
    }
}
