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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string[] fio = new string[0];
        string[] knig = new string[0];
        string[] date = new string[0];
        int kc = 0;
        char[] d = { '#' };
        string[] s = File.ReadAllLines("C:\\Users\\hp\\Desktop\\Rehcjdfz\\Курсовая\\Курсовая\\files\\vid.txt", Encoding.GetEncoding(1251));

        private void Form5_Load(object sender, EventArgs e)
        {
            string[] s1 = File.ReadAllLines("C:\\Users\\hp\\Desktop\\Rehcjdfz\\Курсовая\\Курсовая\\files\\chit.txt", Encoding.GetEncoding(1251));
            kc = s1.Length;
            Array.Resize(ref fio, kc);
            
            for (int i = 0; i < s1.Length; i++)
            {
                string[] sl = s1[i].Split(d, StringSplitOptions.RemoveEmptyEntries);
                comboBox1.Items.Add(sl[1]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bib = 0;
            dataGridView1.Rows.Clear();
            for (int i =0; i<s.Length; i++)
            {
                string[] sl = s[i].Split(d, StringSplitOptions.RemoveEmptyEntries);
                if(sl[1] == comboBox1.Text)
                {
                    dataGridView1.Rows.Add(sl[2], sl[3]);
                    bib++;
                }

            }
            label2.Text = "Всего книг было взято: " + bib;
        }
    }
}