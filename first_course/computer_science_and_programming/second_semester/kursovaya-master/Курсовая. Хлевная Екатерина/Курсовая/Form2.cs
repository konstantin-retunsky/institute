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
    public partial class Form2 : Form
    {
        int l = 0;
        int[] kod = new int[0];
        string[] name = new string[0];
        string[] fio = new string[0];
        char[] d= new char[1] {'#'};
        int ts = 0;
        int l1 = 0;
        int[] kod_kl = new int[0];
        int[] arenda = new int[0];
        int[] kod_au = new int[0]; 
        public Form2()
        {
            
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            KlLoad();
            NewLoad();
        }

        private void KlLoad()
        {
            string[] klients = File.ReadAllLines("klients.txt", Encoding.GetEncoding(1251));
            l = klients.Length;
            Array.Resize(ref kod, l);
            Array.Resize(ref fio, l);
            Array.Resize(ref name, l);
            for (int i = 0; i < l; i++)
            {
                string[] kli = klients[i].Split(d, StringSplitOptions.RemoveEmptyEntries);
                kod[i] = int.Parse(kli[0]);
                fio[i] = kli[1];
                name[i] = kli[2];
                dataGridView1.Rows.Add(kod[i].ToString(), fio[i], name[i]);
            }
        }

        private void NewLoad()
        {
            dataGridView1.Rows.Clear();
            for(int i=0; i< l; i++)
            {
                dataGridView1.Rows.Add(kod[i].ToString(), fio[i], name[i]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ts = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[ts].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[ts].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[ts].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fio[ts] = textBox2.Text;
            name[ts] = textBox3.Text;
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
            Array.Resize(ref fio, l);
            Array.Resize(ref name, l);
            kod[l - 1] = int.Parse(textBox1.Text);
            fio[l - 1] = textBox2.Text;
            name[l - 1] = textBox3.Text;
            NewLoad();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int help = int.Parse(dataGridView1.Rows[ts].Cells[0].Value.ToString());
            for (int i = ts; i < l - 1; i++)
            {
                kod[i] = kod[i + 1];
                fio[i] = fio[i + 1];
                name[i] = name[i + 1];
            }
            l--;
            Array.Resize(ref kod, l);
            Array.Resize(ref fio, l);
            Array.Resize(ref name, l);
            string[] w = File.ReadAllLines("arenda.txt", Encoding.GetEncoding(1251));
            l1 = w.Length;
            Array.Resize(ref kod_kl, l1);
            Array.Resize(ref kod_au, l1);
            Array.Resize(ref arenda, l1);
            for (int i = 0; i < l1; i++)
            {
                string[] w1 = w[i].Split(d, StringSplitOptions.RemoveEmptyEntries);
                kod_kl[i] = int.Parse(w1[0]);
                kod_au[i] = int.Parse(w1[1]);
                arenda[i] = int.Parse(w1[2]);
            }
            for (int i = 0; i < l1; i++)
            {
                if (kod_kl[i] == help)
                {
                    MessageBox.Show("Удаление данных");
                    for (int j = i; j < l1 - 1; j++)
                    {
                        kod_kl[j] = kod_kl[j + 1];
                        kod_au[j] = kod_au[j + 1];
                        arenda[j] = arenda[j + 1];
                    }
                    l1--;
                    Array.Resize(ref kod_kl, l1);
                    Array.Resize(ref kod_au, l1);
                    Array.Resize(ref arenda, l1);
                }
            }
            NewLoad();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] kli = new string[l];
            for(int i = 0; i < l; i++)
            {
                kli[i] = kod[i].ToString() + "#" + fio[i] + "#" + name[i];
            }
            File.WriteAllLines("klients.txt", kli, Encoding.GetEncoding(1251));

            string[] a = new string[l1];
            for (int i = 0; i < l1; i++)
            {
                a[i] = kod_kl[i].ToString() + "#" + kod_au[i].ToString() + "#" + arenda[i].ToString();
            }
            File.WriteAllLines("arenda.txt", a, Encoding.GetEncoding(1251));
        }
    }
}
