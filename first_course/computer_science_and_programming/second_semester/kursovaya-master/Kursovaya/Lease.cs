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
    public partial class Lease : Form
    {

        public bool B = false;
        public Lease()
        {
            InitializeComponent();
        }

        private void Save()
        {
            StreamWriter myFileWrite = new StreamWriter("Data/Lease.csv", false);
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
            toolStripButton1.Enabled = B = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Lease_Load(object sender, EventArgs e)
        {
            
            StreamReader FileCa = new StreamReader("Data/Cars.csv");
            string sLine = "";
            DataGridViewComboBoxColumn Col1 = new DataGridViewComboBoxColumn();
            Col1.HeaderText = "№ автотранспорта";
            dataGridView1.Columns.Insert(1, Col1);

            while (sLine != null)
            {
                sLine = FileCa.ReadLine();
                if (sLine != null)
                {
                    Col1.Items.Add(sLine.Split(';')[0]);
                }
            }
            dataGridView1.Columns[1].DataPropertyName = "trans_type";

            FileCa.Close();

            StreamReader FileCl = new StreamReader("Data/Clients.csv");
            sLine = "";
            DataGridViewComboBoxColumn Col2 = new DataGridViewComboBoxColumn();
            Col2.HeaderText = "Клиент";
            dataGridView1.Columns.Insert(2, Col2);
            ArrayList list = new ArrayList();

            while (sLine != null)
            {
                sLine = FileCl.ReadLine();
                if (sLine != null)
                {
                    string[] st = sLine.Split(';');
                    Col2.Items.Add(st[0] + " " + st[1]);
                    list.Add(st[0]);
                }
            }
            dataGridView1.Columns[2].DataPropertyName = "trans_type";



            FileCl.Close();

            StreamReader myFile = new StreamReader("Data/Lease.csv");
            sLine = "";
            int k = 0;
            while (sLine != null)
            {
                sLine = myFile.ReadLine();
                if (sLine != null)
                {
                    dataGridView1.RowCount++;
                    string[] st = sLine.Split(';');
                    if (Col1.Items.IndexOf(st[1]) == -1)
                        st[1] = "";
                    if (list.IndexOf(st[2].Split(' ')[0]) == -1)
                        st[2] = "";
                    else
                    {
                        st[2] = Col2.Items[list.IndexOf(st[2].Split(' ')[0])].ToString();
                    }
                    dataGridView1.Rows[k].SetValues(st);
                    k++;
                }
            }

            myFile.Close();
            toolStripButton1.Enabled = B = false;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            toolStripButton1.Enabled = B = true;
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            bool valid = false, nom = false, sel = false;
            if (e.FormattedValue != null || e.ColumnIndex != 4)
            {
                string str = e.FormattedValue.ToString();
                switch (e.ColumnIndex)
                {
                    case (0):
                        valid = true;
                        break;
                    case (1):
                        valid = true;
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            if (i == e.RowIndex)
                            {
                                continue;
                            }
                            if (dataGridView1.Rows[i].Cells[1].Value != null)
                            {
                                if (str == dataGridView1.Rows[i].Cells[1].Value.ToString())
                                {

                                    if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "")
                                    {
                                        sel = true;
                                        break;
                                    }
                                    if (
                                    (Convert.ToDateTime(dataGridView1.Rows[i].Cells[3].Value.ToString()) < Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()) &&
                                    Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()) < Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value.ToString())
                                    ) ||
                                    (
                                    Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()) < Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value.ToString()) &&
                                    Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value.ToString()) < Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString())))
                                        {
                                            sel = true;
                                            break;
                                        }
                                }
                            }
                        }
                        break;
                    case (2):
                        valid = true;
                        break;
                    case (3):
                        DateTime dt, date;
                        if (DateTime.TryParse(str, out dt))
                        {
                            if(dataGridView1.Rows[e.RowIndex].Cells[4].Value != null)
                                if (DateTime.TryParse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(), out date))
                                {
                                    if (dt > date)
                                    {
                                        nom = true;
                                    }
                                }
                            valid = true;
                        }
                        break;
                    case (4):
                        if(str == "")
                        {
                            valid = true;
                            break;
                        }
                        DateTime dat,da;
                        if(DateTime.TryParse(str, out dat))
                        {
                            if (dataGridView1.Rows[e.RowIndex].Cells[3].Value != null)
                                if (DateTime.TryParse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(), out da))
                                {
                                    if (dat < da)
                                    {
                                        nom = true;
                                    }
                                }
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
                MessageBox.Show("Дата аренды не может быть больше даты возврата");
            }
            else
            if (sel)
            {
                e.Cancel = true;
                MessageBox.Show("Этот автотранспрот уже используется");
            }
        }

        private void Lease_FormClosing(object sender, FormClosingEventArgs e)
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
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value = dataGridView1.RowCount.ToString();
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            toolStripButton1.Enabled = true;
        }
    }
}