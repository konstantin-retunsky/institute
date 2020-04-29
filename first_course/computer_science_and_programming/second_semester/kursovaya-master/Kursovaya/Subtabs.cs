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
using System.Collections;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Kursovaya
{
    public partial class Subtabs : Form
    {
        public Subtabs()
        {
            InitializeComponent();
        }
        public ArrayList info = new ArrayList();

        private void Subtabs_Load(object sender, EventArgs e)
        {
            StreamReader myFile = new StreamReader("Data/Lease.csv");
            string sLine = "";

            while (sLine != null)
            {
                sLine = myFile.ReadLine();
                if (sLine != null)
                {
                    string[] st = sLine.Split(';');
                    if(!comboBox1.Items.Contains(st[2]))
                        comboBox1.Items.Add(st[2]);
                    info.Add(st);
                }
            }
            myFile.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            StreamReader myFile = new StreamReader("Data/Cars.csv");
            string sLine = "";
            ArrayList carInfo = new ArrayList();

            while (sLine != null)
            {
                sLine = myFile.ReadLine();
                if (sLine != null)
                {
                    string[] st = sLine.Split(';');
                    carInfo.Add(st);
                }
            }
            myFile.Close();

            int k = 0,l = 0;
            double sum = 0, dat = 0;
            for (int i = 0; i < info.Count; i++)
            {
                if (((string[])(info[i])).Contains(comboBox1.Text))
                {
                    for (int j = 0; j < carInfo.Count; j++)
                    {
                        if (((string[])(carInfo[j])).Contains(((string[])(info[i]))[1]))
                        {
                            string[] st = new string[] { ((string[])(carInfo[j]))[0], ((string[])(carInfo[j]))[1], ((string[])(info[i]))[3], ((string[])(info[i]))[4] };
                            dataGridView1.RowCount++;
                            dataGridView1.Rows[k].SetValues(st);
                            k++;

                            DateTime EndData, StartData = Convert.ToDateTime(((string[])(info[i]))[3]);
                            if (((string[])(info[j]))[4] != "")
                            {
                                EndData = Convert.ToDateTime(((string[])(info[i]))[4]);
                                sum += Convert.ToInt16(((string[])(carInfo[j]))[4]) * (EndData - StartData).TotalDays;
                                if(dat < (EndData - StartData).TotalDays)
                                {
                                    dat = (EndData - StartData).TotalDays;
                                    l = j;
                                }
                            }
                            else
                            {
                                sum += Convert.ToInt16(((string[])(carInfo[j]))[4]) * (DateTime.Now.Date - StartData).TotalDays;
                                if (dat < (DateTime.Now.Date - StartData).TotalDays)
                                {
                                    dat = (DateTime.Now.Date - StartData).TotalDays;
                                    l = j;
                                }
                            }
                            break;
                        }
                    }
                }
            }
            label1.Text = "Общая стоимость всех аренд:" + sum.ToString() + "р.";
            label2.Text = "Любимый автомобиль:" + ((string[])(carInfo[l]))[1] + " (" + dat.ToString() + " дней).";
    }
    }
}