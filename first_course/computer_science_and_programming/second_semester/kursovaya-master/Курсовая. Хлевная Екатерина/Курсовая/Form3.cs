using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Курсовая
{
    public partial class Form3 : Form
    {
        int l = 0;
        int[] kod = new int[0];
        string[] auto = new string[0];
        int[] cena = new int[0];
        char[] d = new char[1] { '#' };
        int ts = 0;
        public Form3()
        {
            InitializeComponent();
        }
        private void KlLoad()
        {
            string[] transport = File.ReadAllLines("auto.txt", Encoding.GetEncoding(1251));
            l = transport.Length;
            Array.Resize(ref kod, l);
            Array.Resize(ref auto, l);
            Array.Resize(ref cena, l);
            for (int i = 0; i < l; i++)
            {

                string[] trans = transport[i].Split(d, StringSplitOptions.RemoveEmptyEntries);
                kod[i] = int.Parse(trans[0]);
                auto[i] = trans[1];
                cena[i] = int.Parse(trans[2]);
                dataGridView1.Rows.Add(kod[i].ToString(), auto[i], cena[i].ToString());
            }
        }

        private void NewLoad()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < l; i++)
            {
                dataGridView1.Rows.Add(kod[i].ToString(), auto[i], cena[i].ToString());
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            KlLoad();
            NewLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            auto[ts] = textBox2.Text;
            cena[ts] = int.Parse(textBox3.Text);
            NewLoad();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            int kodd = kod[l - 1] + 1;
            textBox1.Text = kodd.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            l++;
            Array.Resize(ref kod, l);
            Array.Resize(ref auto, l);
            Array.Resize(ref cena, l);
            kod[l - 1] = int.Parse(textBox1.Text);
            auto[l - 1] = textBox2.Text;
            cena[l - 1] = int.Parse(textBox3.Text);
            NewLoad();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = ts; i < l - 1; i++)
            {
                kod[i] = kod[i + 1];
                auto[i] = auto[i + 1];
                cena[i] = cena[i + 1];
            }
            l--;
            Array.Resize(ref kod, l);
            Array.Resize(ref auto, l);
            Array.Resize(ref cena, l);
            NewLoad();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] au = new string[l];
            for (int i = 0; i < l; i++)
            {
                au[i] = kod[i].ToString() + "#" + auto[i] + "#" + cena[i];
            }
            File.WriteAllLines("auto.txt", au, Encoding.GetEncoding(1251));
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ts = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[ts].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[ts].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[ts].Cells[2].Value.ToString();
        }
    }
}
