﻿using System;
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
    public partial class Cars : Form
    {

        public bool B = false;
        public Cars()
        {
            InitializeComponent();
        }
        private void Save()
        {
            StreamWriter myFileWrite = new StreamWriter("Data/Cars.csv", false);
            int N = dataGridView1.RowCount, M = dataGridView1.ColumnCount;
            ArrayList str = new ArrayList();
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < M; ++j)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value == null)
                        str.Add("");
                    else
                        str.Add(dataGridView1.Rows[i].Cells[j].Value.ToString());
                }
                myFileWrite.WriteLine(string.Join(";", str.ToArray()));
                str.RemoveRange(0, str.Count);
            }
            myFileWrite.Close();
            toolStripButton1.Enabled = false;
            B = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            StreamReader myFile = new StreamReader("Data/Cars.csv");
            string sLine = "";
            int k = 0;

            while (sLine != null)
            {
                sLine = myFile.ReadLine();
                if (sLine != null)
                {
                    dataGridView1.RowCount++;
                    dataGridView1.Rows[k].SetValues(sLine.Split(';'));
                    k++;
                }
            }
            myFile.Close();
            toolStripButton1.Enabled = false;
            B = false;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            toolStripButton1.Enabled = true;
            B = true;
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            bool valid = false, nom = false;
            Regex regex;
            if (e.FormattedValue != null)
            {
                string str = e.FormattedValue.ToString();
                switch (e.ColumnIndex)
                {
                    case (0):
                        regex = new Regex(@"^[АВЕКМНОРСТУХ]\d{3}(?<!000)[АВЕКМНОРСТУХ]{2}\d{2,3}$");
                        valid = regex.IsMatch(str);
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            if (i == e.RowIndex)
                            {
                                continue;
                            }
                            if (dataGridView1.Rows[i].Cells[0].Value != null)
                                if (str == dataGridView1.Rows[i].Cells[0].Value.ToString())
                                {
                                    nom = true;
                                    break;
                                }
                        }
                        break;
                    case (1):
                        valid = true;
                        break;
                    case (2):
                        valid = true;
                        break;
                    case (3):
                        int n=0;
                        if(Int32.TryParse(str,out n) && n > 1800)
                        {
                            valid = true;
                        }
                        break;
                    case (4):
                        int m=0;
                        if(Int32.TryParse(str,out m))
                        {
                            valid = true;
                        }
                        break;
                }
            }
            if (!valid)
            {
                e.Cancel = true;
                MessageBox.Show("Невалидное значение!");

            }
            else
                if (nom)
            {
                e.Cancel = true;
                MessageBox.Show("Клиент с таким номером паспорта уже есть!");
            }
        }

        private void Cars_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (B)
            {
                DialogResult rsl = MessageBox.Show("Сохранить изменения?", "Внимание", MessageBoxButtons.YesNo);
                if (rsl == DialogResult.Yes)
                    Save();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount++;
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            toolStripButton1.Enabled = true;
        }
    }
}