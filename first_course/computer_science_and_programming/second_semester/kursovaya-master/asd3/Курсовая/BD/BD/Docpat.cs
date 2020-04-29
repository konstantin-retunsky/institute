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

namespace BD
{
    public partial class Docpat : Form
    {
        string[] fio_pat = new string[0];//фио пациента;
        string[] state = new string[0];//состояние 
        string[] fio_doc1 = new string[0];//фио врача для 1 грида;
        string[] fio_doc2 = new string[0];//фио врача для 2 грида;
        DateTime[] date_of_rec = new DateTime[0];//дата и время приема;
        char[] sym = { '#' };
        int change; //переменная для выбора;
        public Docpat()
        {
            InitializeComponent();
        }

        private void Docpat_Load(object sender, EventArgs e)
        {
            string[] doc = File.ReadAllLines("doc.txt", Encoding.GetEncoding(1251));
            int kd = doc.Length;
            Array.Resize(ref fio_doc1,kd);
            for (int i = 0; i < kd; i++)
            {
                string[] d = new string[4];
                string[] s1 = doc[i].Split(sym, StringSplitOptions.RemoveEmptyEntries);
                fio_doc1[i] = s1[1];
                dataGridView1.Rows.Add(s1[1]);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            dataGridView2.Rows.Clear();
            string[] rec = File.ReadAllLines("receptions.txt", Encoding.GetEncoding(1251));
            int kr = rec.Length;
            Array.Resize(ref fio_doc2, kr);
            Array.Resize(ref fio_pat, kr);
            Array.Resize(ref date_of_rec, kr);
            Array.Resize(ref state, kr);
            for (int i = 0; i < kr; i++)
            {
                string[] s1 = rec[i].Split(sym, StringSplitOptions.RemoveEmptyEntries);
                fio_pat[i] = s1[0];
                fio_doc2[i] = s1[1];
                int[] date1 = new int[6];
                string[] s2 = s1[2].Split(new char[] { '/' });
                for (int j = 0; j < 6; j++)
                {
                    date1[j] = int.Parse(s2[j]);
                }

                date_of_rec[i] = new DateTime(date1[0], date1[1], date1[2], date1[3], date1[4], date1[5]);
                state[i] = s1[3];
            }
            change= dataGridView1.CurrentRow.Index;
            for (int i = 0; i < kr; i++)
                if (fio_doc1[change] == fio_doc2[i])
                {
                    dataGridView2.Rows.Add(fio_pat[i], state[i]);
                }


        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime change_date = dateTimePicker1.Value;
            int pr = dataGridView2.RowCount;
            for (int i = 0; i < pr; i++)
                if (change_date.ToShortDateString() != dataGridView2.Rows[i].Cells[1].Value.ToString())
                {
                    dataGridView2.Rows.Remove(dataGridView2.Rows[i]);
                }
        }
    }
}
