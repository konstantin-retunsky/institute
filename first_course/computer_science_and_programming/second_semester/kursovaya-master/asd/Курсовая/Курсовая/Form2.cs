using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class Form2 : Form
    {
        int[] kod_ch = new int[0];
        string[] fio = new string[0];
        string[] voz = new string[0];
        int kc = 0;
        int ts = 0;
        char[] d = { '#' };

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ChLoad();
            Dgv_Load();
        }

        private void ChLoad()
        {
            string[] s = File.ReadAllLines("C:\\Users\\hp\\Desktop\\Rehcjdfz\\Курсовая\\Курсовая\\files\\chit.txt", Encoding.GetEncoding(1251));
            kc = s.Length;
            Array.Resize(ref kod_ch, kc);
            Array.Resize(ref fio, kc);
            Array.Resize(ref voz, kc);

            for (int i = 0; i < kc; i++)
            {
                string[] sl = s[i].Split(d, StringSplitOptions.RemoveEmptyEntries);
                kod_ch[i] = int.Parse(sl[0]);
                fio[i] = sl[1];
                voz[i] = sl[2];
                
            }
        }

        private void Dgv_Load()
        {
            dataGridView1.Rows.Clear();
            for(int i = 0; i<kc; i++)
            {
                dataGridView1.Rows.Add(kod_ch[i].ToString(), fio[i], voz[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fio[ts] = textBox2.Text;
            voz[ts] = textBox3.Text;
            Dgv_Load();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ts = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[ts].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[ts].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[ts].Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool bib = true;
            for(int i = 0; i< dataGridView1.RowCount; i++)
            {
                if(textBox2.Text == fio[i] && textBox3.Text == voz[i])
                {
                    MessageBox.Show("Такой читатель уже существует");
                    bib = false;
                }
            }
            if (bib)
            {
                int kk = kc;
                kc++;
                Array.Resize(ref kod_ch, kc);
                Array.Resize(ref fio, kc);
                Array.Resize(ref voz, kc);
                kod_ch[kk] = dataGridView1.RowCount + 1;
                fio[kk] = textBox2.Text;
                voz[kk] = textBox3.Text;
                Dgv_Load();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for(int i = ts; i<kc -1; i++)
            {
                fio[i] = fio[i + 1];
            }
            kc--;
            Array.Resize(ref kod_ch, kc);
            Array.Resize(ref fio, kc);
            Array.Resize(ref voz, kc);
            ts = 0;
            Dgv_Load();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] s = new string[kc];
            for(int i = 0; i<kc; i++)
            {
                s[i] = kod_ch[i].ToString() + "#" + fio[i] + "#" + voz[i];
            }
            File.WriteAllLines("C:\\Users\\hp\\Desktop\\Rehcjdfz\\Курсовая\\Курсовая\\files\\chit.txt", s, Encoding.GetEncoding(1251));
        }
    }
}
