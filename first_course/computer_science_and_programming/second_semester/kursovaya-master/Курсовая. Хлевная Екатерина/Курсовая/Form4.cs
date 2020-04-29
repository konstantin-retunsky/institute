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

        int kod1 = 0;
        int kod2 = 0;
        string f;
        string na;
        string aa;
        int kol = 0;
        int l= 0;
        int ts = 0;
        bool per = false;
        char[] d = new char[1] { '#' };
        string[] r = new string[1] { "  " };
        string[] name = new string[0];
        string[] auto = new string[0];
        string[] fio = new string[0];
        int[] kod_kl = new int[0];
        int[] kod_au = new int[0];
        int[] sut = new int[0];
        string[] k = new string[0];
        string[] a = new string[0];
        bool yyy = true;

        private void Form4_Load(object sender, EventArgs e)
        {
            k= File.ReadAllLines("klients.txt", Encoding.GetEncoding(1251));
            a = File.ReadAllLines("auto.txt", Encoding.GetEncoding(1251));
            for(int i=0; i < k.Length; i++)
            {
                comboBox1.Items.Add(k[i].Replace("#", "  "));

            }
            for (int i = 0; i < a.Length; i++)
            {
                comboBox2.Items.Add(a[i].Replace("#", "  "));
            }
            KLoad();
            NewLoad();
        }

        private void KLoad()
        {
            string[] ff = File.ReadAllLines("arend.txt", Encoding.GetEncoding(1251));
            l = ff.Length;
            Array.Resize(ref kod_kl, l);
            Array.Resize(ref fio, l);
            Array.Resize(ref name, l);
            Array.Resize(ref kod_au, l);
            Array.Resize(ref auto, l);
            Array.Resize(ref sut, l);
            for (int i = 0; i < l; i++)
            {
                string[] kli = ff[i].Split(d, StringSplitOptions.RemoveEmptyEntries);
                kod_kl[i] = int.Parse(kli[0]);
                kod_au[i] = int.Parse(kli[3]);
                sut[i] = int.Parse(kli[5]);
                fio[i] = kli[1];
                name[i] = kli[2];
                auto[i] = kli[4];
                dataGridView1.Rows.Add(kod_kl[i].ToString(), fio[i], name[i], kod_au[i].ToString(), auto[i], sut[i].ToString());
            }
        }
        private void NewLoad()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < l; i++)
            {
                dataGridView1.Rows.Add(kod_kl[i].ToString(), fio[i], name[i], kod_au[i].ToString(), auto[i], sut[i].ToString());
            }
        }
        private void Zaber()
        {
            string s1 = comboBox1.SelectedItem.ToString();
            string s2 = comboBox2.SelectedItem.ToString();
            string[] ss1 = s1.Split(r, StringSplitOptions.RemoveEmptyEntries);
            string[] ss2 = s2.Split(r, StringSplitOptions.RemoveEmptyEntries);
            if (textBox1.Text != "")
            {
                kod1 = int.Parse(ss1[0]);
                kod2 = int.Parse(ss2[0]);
                f = ss1[1];
                na = ss1[2];
                aa = ss2[1];
                kol = int.Parse(textBox1.Text);
            }
            else MessageBox.Show("Заполните текстовое поле!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zaber();
            if (kol == 0)
            {
                MessageBox.Show("Нельзя арендовать на 0 суток!");
            }
            else
            {
                for (int i = 0; i < l; i++)
                {
                    if (kod_au[i] == kod2 && kod_kl[i] == kod1)
                    {
                        sut[i] = kol;
                        per = true;
                        NewLoad();
                    }
                }
                if (!per)
                {
                    for (int i = 0; i < l; i++)
                    {
                        if ((kod2) == int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()))
                        {
                            MessageBox.Show("Уже арендована!");
                            yyy = false;
                        }

                    }
                    if (yyy == true)
                    {
                        l++;
                        Array.Resize(ref kod_kl, l);
                        Array.Resize(ref fio, l);
                        Array.Resize(ref name, l);
                        Array.Resize(ref kod_au, l);
                        Array.Resize(ref auto, l);
                        Array.Resize(ref sut, l);
                        kod_kl[l - 1] = kod1;
                        fio[l - 1] = f;
                        name[l - 1] = na;
                        kod_au[l - 1] = kod2;
                        auto[l - 1] = aa;
                        sut[l - 1] = kol;
                        NewLoad();
                        comboBox1.Text = "";
                        comboBox2.Text = "";
                        textBox1.Text = "";

                    }
                    yyy = true;
                }
                else MessageBox.Show("Такой клиент уже арендовал такую машину!");
            }
                         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] p = new string[l];
            for (int i = 0; i < l; i++)
            {
                p[i] = kod_kl[i].ToString() + "#" + fio[i] + "#" + name[i]+ "#" + kod_au[i].ToString() + "#" + auto[i] +"#" + sut[i].ToString();
            }
            File.WriteAllLines("arend.txt", p, Encoding.GetEncoding(1251));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zaber();
            for (int i = 0; i < l; i++)
            {
                if (kod_au[i] == kod2 && kod_kl[i] == kod1)
                {
                    ts = i;
                }
            }
            for(int i = ts; i < l-1; i++)
            {
                kod_kl[i] = kod_kl[i+1];
                kod_au[i] = kod_au[i+1];
                sut[i] = sut[i+1];
                fio[i] = fio[i+1];
                name[i] = name[i+1];
                auto[i] = auto[i+1];
            }
            l--;
            Array.Resize(ref kod_kl, l);
            Array.Resize(ref fio, l);
            Array.Resize(ref name, l);
            Array.Resize(ref kod_au, l);
            Array.Resize(ref auto, l);
            Array.Resize(ref sut, l);
            NewLoad();
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Text = "";
        }

        
    }
}
