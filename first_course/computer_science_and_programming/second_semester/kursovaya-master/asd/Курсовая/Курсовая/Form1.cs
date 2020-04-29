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
            Form2 chit = new Form2();
            chit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 knig = new Form3();
            knig.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 vid = new Form4();
            vid.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 inf = new Form5();
            inf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 oinf = new Form6();
            oinf.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
