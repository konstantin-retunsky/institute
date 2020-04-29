using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        string aft = "";
        string date = "";
        char[] d = { '#' };
        string[] sl = new string[0];
        string[] s = File.ReadAllLines("C:\\Users\\hp\\Desktop\\Rehcjdfz\\Курсовая\\Курсовая\\files\\chit.txt", Encoding.GetEncoding(1251));
        string[] s1 = File.ReadAllLines("C:\\Users\\hp\\Desktop\\Rehcjdfz\\Курсовая\\Курсовая\\files\\knig.txt", Encoding.GetEncoding(1251));
        string[] s2 = File.ReadAllLines("C:\\Users\\hp\\Desktop\\Rehcjdfz\\Курсовая\\Курсовая\\files\\vid.txt", Encoding.GetEncoding(1251));


        private void Form6_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < s2.Length; i++)
            {
                string[] sl2 = s2[i].Split(d, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < s1.Length; j++)
                {
                    string[] sl1 = s1[j].Split(d, StringSplitOptions.RemoveEmptyEntries);
                    if (sl1[1]==sl2[2])
                    {
                        aft = sl1[2];
                    }
                }
                for (int g = 0; g<s.Length; g++)
                {
                    sl = s[g].Split(d, StringSplitOptions.RemoveEmptyEntries);
                    if (sl2[1] == sl[1])
                    {
                        date = sl[2];
                    }
                }

                dataGridView1.Rows.Add(sl2[0], sl2[3], sl2[2], aft, sl2[1], date);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                int bolsh = 0;
                int cn = 0;
                string chit = "";
                if (comboBox1.Text == "Наиболее популярная книга")
                {
                    for (int j = 0; j < s1.Length; j++)
                    {
                        cn = 0;
                        string[] sl1 = s1[j].Split(d, StringSplitOptions.RemoveEmptyEntries);

                        for (int i = 0; i < s2.Length; i++)
                        {
                            string[] sl2 = s2[i].Split(d, StringSplitOptions.RemoveEmptyEntries);

                            if (sl2[2] == sl1[1])
                                cn++;
                            if (cn > bolsh)
                            {
                                bolsh = cn;
                                chit = sl1[1];
                            }
                        }
                    }
                    label1.Text = chit;
                }
                else if (comboBox1.Text == "Читатель с наибольшими выдачами")
                {
                    for (int j = 0; j < s.Length; j++)
                    {
                        cn = 0;
                        string[] sl = s[j].Split(d, StringSplitOptions.RemoveEmptyEntries);

                        for (int i = 0; i < s2.Length; i++)
                        {
                            string[] sl2 = s2[i].Split(d, StringSplitOptions.RemoveEmptyEntries);

                            if (sl2[1] == sl[1])
                                cn++;
                        }
                        if (cn > bolsh)
                        {
                            bolsh = cn;
                            chit = sl[1];
                        }
                    }
                    label1.Text = chit;
                }
            }
        }
    }
}
