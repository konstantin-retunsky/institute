using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form clients = new Clients();
            clients.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form cars = new Cars();
            cars.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form lease = new Lease();
            lease.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form totals = new Totals();
            totals.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form subtabs = new Subtabs();
            subtabs.ShowDialog();
        }
    }
}
