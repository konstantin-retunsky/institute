using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolTip1.UseAnimation = true;

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Form Doctors = new Doctors();
            Doctors.ShowDialog();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Form Patients = new Patients();
            Patients.ShowDialog();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Form Reception = new Reception();
            Reception.ShowDialog();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Form Docpat = new Docpat();
            Docpat.ShowDialog();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            Form InfoAll = new InfoAll();
            InfoAll.ShowDialog();
        }



    }
}
