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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int kod = 0;
        int[] kod_kl = new int[0];
        int[] kod_au = new int[0];
        int[] sut = new int[0];
        string[] au = new string[0];
        int l1 = 0;
        int l2 = 0;
        int l3 = 0;
        char[] d = new char[1] { '#' };
        string[] r = new string[1] { "  " };
        string[] k = new string[0];

        private void Form6_Load(object sender, EventArgs e)
        {
            //comboBox1.Items.AddRange(File.ReadAllLines("klients.txt", Encoding.GetEncoding(1251)));
            k = File.ReadAllLines("klients.txt", Encoding.GetEncoding(1251));
            for (int i = 0; i < k.Length; i++)
            {
                comboBox1.Items.Add(k[i].Replace("#", "  "));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string item = comboBox1.SelectedItem.ToString();
            string[] it = item.Split(r, StringSplitOptions.RemoveEmptyEntries);
            kod = int.Parse(it[0]);
            string[] klients = File.ReadAllLines("klients.txt", Encoding.GetEncoding(1251));
            string[] auto = File.ReadAllLines("auto.txt", Encoding.GetEncoding(1251));
            string[] arenda = File.ReadAllLines("arend.txt", Encoding.GetEncoding(1251));
            l1 = klients.Length;
            l2 = auto.Length;
            l3 = arenda.Length;
            Array.Resize(ref kod_kl, l1);
            Array.Resize(ref kod_au, l2);
            Array.Resize(ref au, l2);
            Array.Resize(ref sut, l3);
            for (int i = 0; i < l1; i++)
            {
                string[] v1 = klients[i].Split(d, StringSplitOptions.RemoveEmptyEntries);
                kod_kl[i] = int.Parse(v1[0]);
            }
            for (int i = 0; i < l2; i++)
            {
                string[] v2 = auto[i].Split(d, StringSplitOptions.RemoveEmptyEntries);
                kod_au[i] = int.Parse(v2[0]);
                au[i] = v2[1];
            }
            for (int i = 0; i < l3; i++)
            {
                string[] v3 = arenda[i].Split(d, StringSplitOptions.RemoveEmptyEntries);
                sut[i] = int.Parse(v3[5]);
                if (int.Parse(v3[0]) == kod)
                {
                    for (int j = 0; j < l1; j++)
                    {
                        for (int k = 0; k < l2; k++)
                        {
                            if(kod==kod_kl[j] && int.Parse(v3[3]) == kod_au[k])
                            {
                                dataGridView1.Rows.Add(au[k],sut[i]);
                            }
                        }
                    }
                }
            }
        }
    }
}
