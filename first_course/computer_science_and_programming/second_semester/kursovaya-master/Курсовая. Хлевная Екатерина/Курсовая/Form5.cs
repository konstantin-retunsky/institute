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
    public partial class Form5 : Form
    {
        public Form5()
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

        private void Form5_Load(object sender, EventArgs e)
        {
            Loading();
        }
        private void Loading()
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
            for(int i=0; i < l1; i++)
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
                for(int j = 0; j < l1; j++)
                {
                    for(int k = 0; k < l2; k++)
                    {
                        if(int.Parse(v3[0])==kod_kl[j]&& int.Parse(v3[3]) == kod_au[k])
                        {
                            dataGridView1.Rows.Add(kod_kl[j].ToString(), name[j], fio[j], kod_au[k].ToString(), au[k], cena[k].ToString(), sut[i].ToString(), (cena[k]* sut[i]).ToString());
                        }
                    }
                }
            }
        }
    }
}
