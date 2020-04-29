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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        int[] kod_kl = new int[0];
        string[] name = new string[0];
        string[] fio = new string[0];
        int[] kod_au = new int[0];
        string[] au = new string[0];
        int[] cena = new int[0];
        int[] sut = new int[0];
        int l1 = 0;
        int l2 = 0;
        int l3 = 0;
        char[] d = new char[1] { '#' };

        private void Form7_Load(object sender, EventArgs e)
        {
            Loading();
        }
        private void Loading()
        {
            string[] auto = File.ReadAllLines("auto.txt", Encoding.GetEncoding(1251));
            string[] arend = File.ReadAllLines("arend.txt", Encoding.GetEncoding(1251));
            l2 = auto.Length;
            l3 = arend.Length;
            Array.Resize(ref kod_kl, l3);
            Array.Resize(ref fio, l3);
            Array.Resize(ref name, l3);
            Array.Resize(ref kod_au, l2);
            Array.Resize(ref au, l2);
            Array.Resize(ref cena, l2);
            Array.Resize(ref sut, l3);
            for (int i = 0; i < l3; i++)
            {
                string[] v1 = arend[i].Split(d, StringSplitOptions.RemoveEmptyEntries);
                kod_kl[i] = int.Parse(v1[0]);
                name[i] = v1[2];
                fio[i] = v1[1];
                kod_au[i] = int.Parse(v1[3]);
                au[i] = v1[4];
                sut[i] = int.Parse(v1[5]);
            }
            for (int i = 0; i < l2; i++)
            {
                string[] v2 = auto[i].Split(d, StringSplitOptions.RemoveEmptyEntries);
                cena[i] = int.Parse(v2[2]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loading();
            var count = 0;
            var index = -1;
            for (var i = 0; i < kod_kl.Length; ++i)
            {
                var k = 1;
                for (var j = i + 1; j < kod_kl.Length; ++j)
                    if (kod_kl[i] == kod_kl[j]) k++;
                if (k <= count) continue;
                count = k;
                index = i;
            }
            textBox1.Text = fio[index] + " " + name[index];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] klients = File.ReadAllLines("klients.txt", Encoding.GetEncoding(1251));
            string[] auto = File.ReadAllLines("auto.txt", Encoding.GetEncoding(1251));
            string[] arend = File.ReadAllLines("arend.txt", Encoding.GetEncoding(1251));
            l1 = klients.Length;
            l2 = auto.Length;
            l3 = arend.Length;
            Array.Resize(ref kod_kl, l1);
            Array.Resize(ref fio, l1);
            Array.Resize(ref name, l1);
            Array.Resize(ref kod_au, l2);
            Array.Resize(ref au, l2);
            Array.Resize(ref cena, l2);
            Array.Resize(ref sut, l3);
            for (int i = 0; i < l1; i++)
            {
                string[] v1 = klients[i].Split(d, StringSplitOptions.RemoveEmptyEntries);
                kod_kl[i] = int.Parse(v1[0]);
                name[i] = v1[2];
                fio[i] = v1[1];
            }
            for (int i = 0; i < l2; i++)
            {
                string[] v2 = auto[i].Split(d, StringSplitOptions.RemoveEmptyEntries);
                kod_au[i] = int.Parse(v2[0]);
                au[i] = v2[1];
                cena[i] = int.Parse(v2[2]);
            }
            int[] prib = new int[l3];
            int max = 0;
            int sum = 0;
            for (int i = 0; i < l3; i++)
            {
                string[] v3 = arend[i].Split(d, StringSplitOptions.RemoveEmptyEntries);
                sut[i] = int.Parse(v3[5]);
                for (int j = 0; j < l1; j++)
                {
                    for (int k = 0; k < l2; k++)
                    {
                        if (int.Parse(v3[0]) == kod_kl[j] && int.Parse(v3[3]) == kod_au[k])
                        {                                                                                
                            for(int m=0; m<l3; m++)
                            {
                                prib[m] = cena[k] * sut[i];
                                sum += prib[m];
                                if (prib[m] > max)
                                {
                                    max = prib[m];
                                }
                            }                       
                        }
                    }
                }
            }          
            textBox2.Text = max.ToString();
            textBox5.Text = ((sum / l3)/l3).ToString();
            textBox4.Text = (sum / l3).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int res = 0;
            for (int j = 0; j < sut.Length; j++)
            {
                sum = sum + sut[j];
            }
            res = sum / sut.Length;
            textBox3.Text = res.ToString();
        }       
        private void button5_Click(object sender, EventArgs e)
        {                       
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Loading();
            var max = 0;
            for (var i = 0; i < sut.Length; i++)
            {
                if (sut[i] > max)
                {
                    max = sut[i];
                }
            }
            textBox6.Text = max.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int[] sum_ar = new int[0];
            string[] klients = File.ReadAllLines("klients.txt", Encoding.GetEncoding(1251));
            string[] auto = File.ReadAllLines("auto.txt", Encoding.GetEncoding(1251));
            string[] arend = File.ReadAllLines("arend.txt", Encoding.GetEncoding(1251));
            l1 = klients.Length;
            l2 = auto.Length;
            l3 = arend.Length;
            Array.Resize(ref kod_kl, l1);
            Array.Resize(ref fio, l1);
            Array.Resize(ref name, l1);
            Array.Resize(ref kod_au, l2);
            Array.Resize(ref au, l2);
            Array.Resize(ref cena, l2);
            Array.Resize(ref sut, l3);
            Array.Resize(ref sum_ar, l3);
            for (int i = 0; i < l1; i++)
            {
                string[] v1 = klients[i].Split(d, StringSplitOptions.RemoveEmptyEntries);
                kod_kl[i] = int.Parse(v1[0]);
                name[i] = v1[2];
                fio[i] = v1[1];
            }
            for (int i = 0; i < l2; i++)
            {
                string[] v2 = auto[i].Split(d, StringSplitOptions.RemoveEmptyEntries);
                kod_au[i] = int.Parse(v2[0]);
                au[i] = v2[1];
                cena[i] = int.Parse(v2[2]);
            }
            for (int i = 0; i < l3; i++)
            {
                string[] v3 = arend[i].Split(d, StringSplitOptions.RemoveEmptyEntries);
                sut[i] = int.Parse(v3[5]);
                for (int j = 0; j < l1; j++)
                {
                    for (int k = 0; k < l2; k++)
                    {
                        if (int.Parse(v3[0]) == kod_kl[j] && int.Parse(v3[3]) == kod_au[k])
                        {
                            sum_ar[j] += cena[k] * sut[i];
                        }
                    }
                }
            }
            int max = 0;
            int index = 0;
            for (int hh=0; hh < sum_ar.Length; hh++)
            {
                if(sum_ar[hh] > max)
                {
                    max = sum_ar[hh];
                    index = hh;
                }
            }
            textBox7.Text = fio[index] + " " + name[index];
        }
    }
}
