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
    public partial class Totals : Form
    {
        public Totals()
        {
            InitializeComponent();
        }
        public bool dt1 = false, dt2 = false;
        private void Totals_Load(object sender, EventArgs e)
        {
            StreamReader myFile = new StreamReader("Data/Lease.csv");
            string sLine = "";
            ArrayList leaseInfo = new ArrayList();

            while (sLine != null)
            {
                sLine = myFile.ReadLine();
                if (sLine != null)
                {
                    string[] st = sLine.Split(';');
                    leaseInfo.Add(st);
                }
            }
            myFile.Close();

            StreamReader myFile2 = new StreamReader("Data/Clients.csv");
            sLine = "";
            ArrayList clientInfo = new ArrayList();

            while (sLine != null)
            {
                sLine = myFile2.ReadLine();
                if (sLine != null)
                {
                    string[] st = sLine.Split(';');
                    clientInfo.Add(st);
                }
            }
            myFile2.Close();

            StreamReader myFile3 = new StreamReader("Data/Cars.csv");
            sLine = "";
            ArrayList carInfo = new ArrayList();

            while (sLine != null)
            {
                sLine = myFile3.ReadLine();
                if (sLine != null)
                {
                    string[] st = sLine.Split(';');
                    carInfo.Add(st);
                }
            }
            myFile3.Close();

            dataGridView1.RowCount = leaseInfo.Count;

            for (int i = 0; i < leaseInfo.Count; i++)
            {
                for (int j = 0; j < carInfo.Count; j++)
                {
                    if (((string[])(carInfo[j])).Contains(((string[])(leaseInfo[i]))[1]))
                    {
                        string[] st =new string[] { ((string[])(carInfo[j]))[0], ((string[])(carInfo[j]))[1] };
                        dataGridView1.Rows[i].SetValues(st);
                        break;
                    }
                }

                for (int j = 0; j < clientInfo.Count; j++)
                {
                    if (((string[])(clientInfo[j])).Contains(((string[])(leaseInfo[i]))[2].Split(' ')[0]))
                    {
                        dataGridView1.Rows[i].Cells[2].Value = ((string[])(clientInfo[j]))[0];
                        dataGridView1.Rows[i].Cells[3].Value = ((string[])(clientInfo[j]))[1];
                        dataGridView1.Rows[i].Cells[4].Value = ((string[])(clientInfo[j]))[2];
                        dataGridView1.Rows[i].Cells[5].Value = ((string[])(clientInfo[j]))[4];
                        break;
                    }
                }
                dataGridView1.Rows[i].Cells[6].Value = ((string[])(leaseInfo[i]))[3];
                dataGridView1.Rows[i].Cells[7].Value = ((string[])(leaseInfo[i]))[4];
                DateTime EndData, StartData = Convert.ToDateTime(((string[])(leaseInfo[i]))[3]);
                if (((string[])(leaseInfo[i]))[4] != "")
                {
                    EndData = Convert.ToDateTime(((string[])(leaseInfo[i]))[4]);
                    dataGridView1.Rows[i].Cells[8].Value = Convert.ToInt16(((string[])(carInfo[i]))[4])*(EndData-StartData).TotalDays;
                }
                else
                {
                    dataGridView1.Rows[i].Cells[8].Value = Convert.ToInt16(((string[])(carInfo[i]))[4])*(DateTime.Now.Date-StartData).TotalDays;
                }                
            }
            
                

        }

        private void rad1_C()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[7].Value.ToString() != "")
                {
                    dataGridView1.Rows[i].Visible = false;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rad3_C();
            if (dt1)
            {
                but2_C();
            }
            if (dt2)
            {
                but3_C();
            }

            rad1_C();
        }
        
        private void rad2_C()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "")
                {
                    dataGridView1.Rows[i].Visible = false;
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            rad3_C();
            if (dt1)
            {
                but2_C();
            }
            if (dt2)
            {
                but3_C();
            }
            rad2_C();
        }

        private void rad3_C()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Visible = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            rad3_C();
            if (dt1)
            {
                but2_C();
            }
            if (dt2)
            {
                but3_C();
            }        
        }

        private void but2_C()
        {
            DateTime dat, datP1 = dateTimePicker1.Value, datP2 = dateTimePicker2.Value;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                DateTime.TryParse(dataGridView1.Rows[i].Cells[6].Value.ToString(), out dat);
                if (!(datP1 <= dat && dat <= datP2))
                {
                    dataGridView1.Rows[i].Visible = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rad3_C();
            if (radioButton1.Checked)
            {
                rad1_C();
            }
            if (radioButton2.Checked)
            {
                rad2_C();
            }
            if (dt2)
            {
                but3_C();
            }
            but2_C();
            dt1 = true;
        }
        private void but3_C()
        {
            DateTime dat, datP1 = dateTimePicker3.Value, datP2 = dateTimePicker4.Value;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                DateTime.TryParse(dataGridView1.Rows[i].Cells[7].Value.ToString(), out dat);
                if (!(datP1 <= dat && dat <= datP2) && dat != null)
                {
                    dataGridView1.Rows[i].Visible = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rad3_C();
            if (radioButton1.Checked)
            {
                rad1_C();
            }
            if (dt1)
            {
                but2_C();
            }
            but3_C();
            dt2 = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString() != "")
            {
                label5.Text = "Длительность аренды в днях:" + (Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[7].Value) - Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[6].Value)).TotalDays.ToString();
            }
            else
            {
                label5.Text = "Длительность аренды в днях:" + (DateTime.Now.Date - Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[6].Value)).TotalDays.ToString();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt1 = false;
            dt2 = false;
            rad3_C();
            radioButton3.Checked = true;
        }
    }
}
