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
    public partial class Reception : Form
    {
        int[] kod_pat = new int[0];//код пациента для записи;
        string[] fio_pat = new string[0];//фио пациента;
        int[] kod_doc = new int[0];//код врача;
        string[] fio_doc = new string[0];//фио врача;
        string[] state = new string[0];//состояние 
        DateTime[] date_of_rec = new DateTime[0];//дата и время приема;
        DateTime[] work_time1 = new DateTime[0];//начало работы врача 
        DateTime[] work_time2 = new DateTime[0];//конец работы врача
        char[] sym = { '#' };
        int kr = 0;//переменная для длина массивов;
        int kr1 = 0;//переменная для изменения записей;
        
        string[] state_for_combo = { "Прием назначен", "На лечении", "Вылечен" };
        public Reception()
        {
            InitializeComponent();

        }

        private void RecShow()//считывание с файлов, добавление в массив и вывод в DataGrid
        {
            int s = 0;
            dataGridView1.Rows.Clear();
            string[] rec = File.ReadAllLines("receptions.txt", Encoding.GetEncoding(1251));
            kr = rec.Length;
            ResizeArray();
            for (int i = 0; i < kr; i++)
            {
                string[] s1 = rec[i].Split(sym, StringSplitOptions.RemoveEmptyEntries);
                fio_pat[i] = s1[0];
                fio_doc[i] = s1[1];
                int[] date1 = new int[6];
                string[] s2 = s1[2].Split(new char[] { '/' });
                for (int j = 0; j < 6; j++)
                {
                    date1[j] = int.Parse(s2[j]);
                }

                date_of_rec[i] = new DateTime(date1[0], date1[1], date1[2], date1[3], date1[4], date1[5]);

                if (s1[3] == "Прием назначен") state[i] = state_for_combo[0];
                else if (s1[3] == "На лечении") { state[i] = state_for_combo[1]; s = 1; }
                else if (s1[3] == "Вылечен") { state[i] = state_for_combo[2]; s = 2; }



                dataGridView1.Rows.Add(fio_pat[i].ToString(), fio_doc[i], date_of_rec[i].ToShortDateString(), date_of_rec[i].ToShortTimeString(), state[i]);


            }

        }
        private void ResizeArray()
        {

            Array.Resize(ref fio_doc, kr);
            Array.Resize(ref fio_pat, kr);
            Array.Resize(ref date_of_rec, kr);
            Array.Resize(ref state, kr);


        }

        private void ComboPat()//создание комбобокса для пациентов
        {
            string[] pat = File.ReadAllLines("patients.txt", Encoding.GetEncoding(1251));
            int kp = pat.Length;//количество пациентов
            for (int i = 0; i < kp; i++)
            {
                string[] s1 = pat[i].Split(sym, StringSplitOptions.RemoveEmptyEntries);
                comboBox1.Items.Add(s1[1].ToString());
            }


        }

        private void ComboDoc()//создание комбобокса для врачей 
        {
            string[] doc = File.ReadAllLines("doc.txt", Encoding.GetEncoding(1251));
            int kd = doc.Length;

            for (int i = 0; i < kd; i++)
            {
                string[] d = new string[4];
                string[] s1 = doc[i].Split(sym, StringSplitOptions.RemoveEmptyEntries);
                comboBox2.Items.Add(s1[1].ToString());
                string[] s2 = s1[4].Split(new char[] { ':', '-' });
                for (int j = 0; j < 4; j++)
                {
                    d[j] = s2[j];
                }
                Array.Resize(ref work_time1, kd);
                Array.Resize(ref work_time2, kd);
                work_time1[i] = new DateTime(2000, 01, 01, int.Parse(d[0]), int.Parse(d[1]), 0);
                work_time2[i] = new DateTime(2000, 01, 01, int.Parse(d[2]), int.Parse(d[3]), 0);

            }



        }

        private void SaveRec()
        {
            for (int i = 0; i < kr; i++)
            {
                string[] s1 = date_of_rec[i].ToString().Split(new char[] { '.', ':', ' ' });
                string st = fio_pat[i] + "#" + fio_doc[i] + "#" + s1[2] + "/" + s1[1] + "/" + s1[0] + "/" + s1[3] + "/" + s1[4] + "/" + s1[5] + "#" + state[i];
                if (i == 0)
                {
                    FileStream aFile = new FileStream("receptions.txt", FileMode.Create);
                    StreamWriter sw = new StreamWriter(aFile, Encoding.GetEncoding(1251));
                    sw.WriteLine(st);
                    sw.Close();
                }
                else
                {
                    FileStream aFile = new FileStream("receptions.txt", FileMode.Append);
                    StreamWriter sw = new StreamWriter(aFile, Encoding.GetEncoding(1251));
                    sw.WriteLine(st);
                    sw.Close();
                }
            }
        }

        private void Reception_Load(object sender, EventArgs e)
        {
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            RecShow();
        }

        private void Button1_Click(object sender, EventArgs e)// кнопка добавить 
        {
            ComboPat();
            ComboDoc();
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;
            comboBox3.Enabled = false;
            dateTimePicker1.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

        }


        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)//создание комбобокса1 для времени
        {
            comboBox3.Enabled = true;
            comboBox3.Items.Clear();
            int change = comboBox2.SelectedIndex;
            DateTime change_date = dateTimePicker1.Value;
            string search_doc = comboBox2.SelectedItem.ToString();

            DateTime change_time= work_time1[change];
            while (change_time != work_time2[change])
            {
            bool pr1 = true;
                for (int i = 0; i < kr; i++)
                {
                   
                    if ((fio_doc[i] == search_doc) && (date_of_rec[i].ToShortTimeString() == change_time.ToShortTimeString())
                        && (change_date.ToShortDateString()==date_of_rec[i].ToShortDateString())) pr1 = false;
                }
                    if (pr1)
                    {
                        comboBox3.Items.Add(change_time.ToShortTimeString()); 
                    }

                change_time = change_time.AddMinutes(10);
            }
        }

        private void Button6_Click(object sender, EventArgs e)//кнопка готово при добавлении
        {
            if ((comboBox1.Text == "") || (comboBox2.Text == "") || (comboBox3.Text == ""))
            {
                MessageBox.Show("Данные не заполнены", "",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                string patd = comboBox1.Text;
                string docd = comboBox2.Text;
                string dated = dateTimePicker1.Value.ToShortDateString();
                string time_d = comboBox3.Text;
                kr = kr + 1;
                ResizeArray();
                fio_doc[kr - 1] = docd;
                fio_pat[kr - 1] = patd;
                state[kr - 1] = state_for_combo[0];
                string[] s2 = dated.Split(new char[] { '.' });
                string[] s3=time_d.Split(new char[] { ':' });
                date_of_rec[kr-1] = new DateTime(int.Parse(s2[2]), int.Parse(s2[1]), int.Parse(s2[0]), int.Parse(s3[0]), int.Parse(s3[1]), 00);
                dataGridView1.Rows.Add(fio_pat[kr - 1], fio_doc[kr - 1], date_of_rec[kr - 1].ToShortDateString(), date_of_rec[kr - 1].ToShortTimeString(), state[kr-1]);
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                comboBox3.Enabled = false;
                
            }
            SaveRec();
        }

        private void Button5_Click(object sender, EventArgs e)//кнопка отмена
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)//кнопка удаление записи
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтвердите удаление",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)

            {
                kr1 = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.Remove(dataGridView1.Rows[kr1]);
                dataGridView1.Refresh();
                kr--;
                ResizeArray();
                for (int i = 0; i < kr; i++)
                {
                    fio_pat[i] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    fio_doc[i] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string dated = dataGridView1.Rows[i].Cells[2].Value.ToString(); ;
                    string time_d = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    string[] s2 = dated.Split(new char[] { '.' });
                    string[] s3 = time_d.Split(new char[] { ':' });
                    date_of_rec[i] = new DateTime(int.Parse(s2[2]), int.Parse(s2[1]), int.Parse(s2[0]), int.Parse(s3[0]), int.Parse(s3[1]), 00);
                    state[i]=dataGridView1.Rows[i].Cells[4].Value.ToString();
                }
                this.TopMost = true;
            }
            SaveRec();
        }

        private void Button3_Click(object sender, EventArgs e)//кнопка изменить
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            kr1 = dataGridView1.CurrentRow.Index;
            comboBox1.Text = fio_pat[kr1];
            comboBox2.Text = fio_doc[kr1];
            search_doc = fio_doc[kr1];
            dateTimePicker2.Text = date_of_rec[kr1].ToShortDateString();
            comboBox3.Text = date_of_rec[kr1].ToShortTimeString();
            ComboPat();
            ComboDoc();
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;
            comboBox3.Enabled = false;
            dateTimePicker2.Visible = true;
            dateTimePicker1.Visible = false;
            button5.Visible = true;
            button7.Visible = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

        }

        private void Button7_Click(object sender, EventArgs e)//готово при изменить
        {
            if ((comboBox1.Text == "") || (comboBox2.Text == "") || (comboBox3.Text == ""))
            {
                MessageBox.Show("Введите данные", "",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                fio_pat[kr1] = comboBox1.Text;
                fio_doc[kr1] = comboBox2.Text;
                string dated = dateTimePicker2.Value.ToShortDateString() ;
                string time_d = comboBox3.Text;
                string[] s2 = dated.Split(new char[] { '.' });
                string[] s3 = time_d.Split(new char[] { ':' });
                date_of_rec[kr1] = new DateTime(int.Parse(s2[2]), int.Parse(s2[1]), int.Parse(s2[0]), int.Parse(s3[0]), int.Parse(s3[1]), 00);
                dataGridView1.Rows.RemoveAt(kr1);
                dataGridView1.Rows.Insert(kr1, fio_pat[kr1], fio_doc[kr1], date_of_rec[kr1].ToShortDateString(), date_of_rec[kr1].ToShortTimeString(), state[kr1]);
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                dateTimePicker2.Visible = false;
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                comboBox3.Enabled = false;
            }
            SaveRec();
        }
        string search_doc;
       private void DateTimePicker2_ValueChanged(object sender, EventArgs e)//комбобокс для времени при изменить 
        {
            comboBox3.Enabled = true;
            comboBox3.Items.Clear();
            ComboDoc();
            int change = kr1;
            DateTime change_date = dateTimePicker2.Value;
            DateTime change_time = work_time1[kr1];
            while (change_time != work_time2[kr1])
            {
                bool pr1 = true;
                for (int i = 0; i < kr; i++)
                {

                    if ((fio_doc[i] == search_doc) && (date_of_rec[i].ToShortTimeString() == change_time.ToShortTimeString())
                        && (change_date.ToShortDateString() == date_of_rec[i].ToShortDateString())) pr1 = false;
                }
                if (pr1)
                {
                    comboBox3.Items.Add(change_time.ToShortTimeString());
                }

                change_time = change_time.AddMinutes(10);
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_doc = comboBox2.Text;
        }


        private void DataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            kr1 = dataGridView1.CurrentRow.Index;
            string state1 = dataGridView1.Rows[kr1].Cells[4].Value.ToString();
            state[kr1] = state1;
            SaveRec();
        }
    }
}
