using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form1 = new Form2();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form1 = new Form3();
            form1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form1 = new Form4();
            form1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form1 = new Form5();
            form1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 form1 = new Form6();
            form1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 form1 = new Form7();
            form1.ShowDialog();
        }
    }
}
