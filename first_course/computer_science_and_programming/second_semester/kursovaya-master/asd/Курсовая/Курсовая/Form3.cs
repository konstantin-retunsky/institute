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
        public Form3()
        {
            InitializeComponent();
        }

        int[] kod_kn = new int[0];
        string[] name = new string[0];
        string[] aft = new string[0];
        int ts = 0;
        int kc = 0;
        char[] d = { '#' };

        private void KnLoad()
        {
            string[] s = File.ReadAllLines("C:\\Users\\hp\\Desktop\\Rehcjdfz\\Курсовая\\Курсовая\\files\\knig.txt", Encoding.GetEncoding(1251));
            kc = s.Length;
            Array.Resize(ref kod_kn, kc);
            Array.Resize(ref name, kc);
            Array.Resize(ref aft, kc);

            for (int i = 0; i < kc; i++)
            {
                string[] sl = s[i].Split(d, StringSplitOptions.RemoveEmptyEntries);
                kod_kn[i] = int.Parse(sl[0]);
                name[i] = sl[1];
                aft[i] = sl[2];
                dataGridView1.Rows.Add(kod_kn[i].ToString(), name[i], aft[i]);
            }
        }

        private void Dgv_Load()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < kc; i++)
            {
                dataGridView1.Rows.Add(kod_kn[i].ToString(), name[i], aft[i]);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            KnLoad();
            Dgv_Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name[ts] = textBox2.Text;
            aft[ts] = textBox3.Text;
            Dgv_Load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                int kk = kc;
                kc++;
                Array.Resize(ref kod_kn, kc);
                Array.Resize(ref name, kc);
                Array.Resize(ref aft, kc);
                kod_kn[kk] = dataGridView1.RowCount + 1;
                name[kk] = textBox2.Text;
                aft[kk] = textBox3.Text;
                Dgv_Load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = ts; i < kc - 1; i++)
            {
                name[i] = name[i + 1];
            }
            kc--;
            Array.Resize(ref kod_kn, kc);
            Array.Resize(ref name, kc);
            Array.Resize(ref aft, kc);
            ts = 0;
            Dgv_Load();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] s = new string[kc];
            for (int i = 0; i < kc; i++)
            {
                s[i] = kod_kn[i].ToString() + "#" + name[i] + "#" + aft[i];
            }
            File.WriteAllLines("C:\\Users\\hp\\Desktop\\Rehcjdfz\\Курсовая\\Курсовая\\files\\knig.txt", s, Encoding.GetEncoding(1251));
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
