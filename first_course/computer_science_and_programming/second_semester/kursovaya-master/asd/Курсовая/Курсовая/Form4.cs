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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int[] kod_vd = new int[0];
        string[] fio = new string[0];
        string[] chit = new string[0];
        string[] knig = new string[0];
        string[] names = new string[0];
        string[] date = new string[0];
        int ts = 0;
        int kc = 0;
        char[] d = { '#' };

        private void VidLoad()
        {
            string[] s1 = File.ReadAllLines("C:\\Users\\hp\\Desktop\\Rehcjdfz\\Курсовая\\Курсовая\\files\\chit.txt", Encoding.GetEncoding(1251));
            string[] s2 = File.ReadAllLines("C:\\Users\\hp\\Desktop\\Rehcjdfz\\Курсовая\\Курсовая\\files\\knig.txt", Encoding.GetEncoding(1251));
            string[] s = File.ReadAllLines("C:\\Users\\hp\\Desktop\\Rehcjdfz\\Курсовая\\Курсовая\\files\\vid.txt", Encoding.GetEncoding(1251));
            kc = s.Length;
            Array.Resize(ref kod_vd, kc);
            Array.Resize(ref fio, kc);
            Array.Resize(ref names, kc);
            Array.Resize(ref date, kc);

            for (int i = 0; i<s1.Length; i++)
            {
                string[] sl = s1[i].Split(d, StringSplitOptions.RemoveEmptyEntries);
                comboBox1.Items.Add(sl[1]);
            }

            for(int i = 0; i<s2.Length; i++)
            {
                string[] sl = s2[i].Split(d, StringSplitOptions.RemoveEmptyEntries);
                comboBox2.Items.Add(sl[1]);
            }

            for (int i = 0; i < kc; i++)
            {
                string[] sl = s[i].Split(d, StringSplitOptions.RemoveEmptyEntries);
                kod_vd[i] = int.Parse(sl[0]);
                fio[i] = sl[1];
                names[i] = sl[2];
                date[i] = sl[3];
                dataGridView1.Rows.Add(kod_vd[i].ToString(), fio[i], names[i], date[i]);
            }
        }

        private void Dgv_Load()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < kc; i++)
            {
                dataGridView1.Rows.Add(kod_vd[i].ToString(), fio[i], names[i], date[i]);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            VidLoad();
            Dgv_Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fio[ts] = comboBox1.Text;
            names[ts] = comboBox2.Text;
            date[ts] = textBox2.Text;
            Dgv_Load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool bib = true;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (comboBox1.Text == fio[i] && comboBox2.Text == names[i] && textBox2.Text == date[i])
                {
                    MessageBox.Show("Эта выдача уже была записана");
                    bib = false;
                }
            }
            if (bib)
            {
                int kk = kc;
                kc++;
                Array.Resize(ref kod_vd, kc);
                Array.Resize(ref fio, kc);
                Array.Resize(ref names, kc);
                Array.Resize(ref date, kc);
                kod_vd[kk] = dataGridView1.RowCount + 1;
                fio[kk] = comboBox1.Text;
                names[kk] = comboBox2.Text;
                date[kk] = textBox2.Text;
                Dgv_Load();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = ts; i < kc - 1; i++)
            {
                fio[i] = fio[i + 1];
                date[i] = date[i + 1];
            }
            kc--;
            Array.Resize(ref kod_vd, kc);
            Array.Resize(ref fio, kc);
            Array.Resize(ref names, kc);
            Array.Resize(ref date, kc);
            ts = 0;
            Dgv_Load();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] s = new string[kc];
            for (int i = 0; i < kc; i++)
            {
                s[i] = kod_vd[i].ToString() + "#" + fio[i] + "#" + names[i] + "#" + date[i];
            }
            File.WriteAllLines("C:\\Users\\hp\\Desktop\\Rehcjdfz\\Курсовая\\Курсовая\\files\\vid.txt", s, Encoding.GetEncoding(1251));
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ts = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[ts].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[ts].Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[ts].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.Rows[ts].Cells[3].Value.ToString();
        }
    }
}
