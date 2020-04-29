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
using System.Text.RegularExpressions;

namespace BD
{
    public partial class Doctors : Form
    {
        int[] kod_doc = new int[0];//массив для кодов врачей
        string[] fiod = new string[0];//массив для ФИО врачей
        string[] prof = new string[0];//массив для специализации врачей
        int[] kabinet = new int[0]; // массив для кабинетов
        string[] work_hours = new string[0]; //массив для рабочего времени;
        int kd = 0;// переменная для длины массивов
        char[] sym = { '#' };
        int kd1 = 0;//переменная для изменения записей
        public Doctors()
        {
            InitializeComponent();
        }

        string regex_fio = @"^[А-Я]{1}[а-я]*(\s{1}[А-Я]{1}[.]{1}[А-Я]{1}[.]{1})*$";
        string regex_prof = @"^[А-Яа-я]*([ ][а-я])*$";
        string regex_kab = @"^[0-9]{1,}$";
        string regex_time = @"^(([0,1][0-9])|(2[0-3])):[0-5][0-9]-(([0,1][0-9])|(2[0-3])):[0-5][0-9]$";

        private void DocShow()//считывание с файла и вывод в DataGrid
        {
            dataGridView1.Rows.Clear();
            string[] s = File.ReadAllLines("doc.txt", Encoding.GetEncoding(1251));
            kd = s.Length;
            ResizeArray();
            for (int i=0; i<kd; i++)
            {
                string[] s1 = s[i].Split(sym, StringSplitOptions.RemoveEmptyEntries);
                kod_doc[i] = int.Parse(s1[0]);
                fiod[i] = s1[1];
                    prof[i] = s1[2];
                kabinet[i] = int.Parse(s1[3]);
                work_hours[i] = s1[4];
                dataGridView1.Rows.Add(kod_doc[i].ToString(), fiod[i], prof[i], kabinet[i], work_hours[i]);
            }

        }

       private void DocSave()// Сохранение текстового файла из DataGrid
        {
            for (int i = 0; i < kd; i++)
            {

                string st = kod_doc[i] + "#" + fiod[i] + "#" + prof[i]+"#"+kabinet[i]+"#"+work_hours[i];
                if (i == 0)
                {
                    FileStream aFile = new FileStream("doc.txt", FileMode.Create);
                    StreamWriter sw = new StreamWriter(aFile, Encoding.GetEncoding(1251));
                    sw.WriteLine(st);
                    sw.Close();
                }
                else
                {
                    FileStream aFile = new FileStream("doc.txt", FileMode.Append);
                    StreamWriter sw = new StreamWriter(aFile, Encoding.GetEncoding(1251));
                    sw.WriteLine(st);
                    sw.Close();
                }
            }
            string[] fio_doc=new string[0];
            string[] rec = File.ReadAllLines("receptions.txt", Encoding.GetEncoding(1251));//удаление всех записей приема, если нет врача
            int kr = rec.Length;
            Array.Resize(ref fio_doc, kr);
            for (int i = 0; i < kr; i++)
            {
                string[] s1 = rec[i].Split(sym, StringSplitOptions.RemoveEmptyEntries);
                fio_doc[i] = s1[1];
            }
            for (int i=0; i<kr; i++)
            {
                bool pr1 = false;
                for (int j=0; j<fiod.Length; j++)
                {
                    if (fio_doc[i] == fiod[j]) pr1 = true;
                }
                if (pr1 == false) rec[i] = "";

                
            }
            int c = 0;
            for (int i = 0; i < kr; i++)
            {

                string st = rec[i];
                if (st != "")
                {
                    if (c == 0)
                    {
                        FileStream aFile = new FileStream("receptions.txt", FileMode.Create);
                        StreamWriter sw = new StreamWriter(aFile, Encoding.GetEncoding(1251));
                        sw.WriteLine(st);
                        sw.Close();
                        c++;
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

        }

        private void ResizeArray()
        {
            Array.Resize(ref kod_doc, kd);
            Array.Resize(ref fiod, kd);
            Array.Resize(ref prof, kd);
            Array.Resize(ref kabinet, kd);
            Array.Resize(ref work_hours, kd);
        }


        private void Doctors_Load(object sender, EventArgs e)
        {
            button4.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            textBox1.Visible = false;
            textBox4.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            DocShow();

        }

        private void Button1_Click(object sender, EventArgs e)//Добавление новой записи 
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Visible = false; 
            button6.Visible = true;
            button7.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)//Удаление записи
        {

            DialogResult result=MessageBox.Show("Вы действительно хотите удалить запись?", "Подтвердите удаление",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)

            {
                kd1 = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.Remove(dataGridView1.Rows[kd1]);
                dataGridView1.Refresh();
                kd--;
                ResizeArray();
                for (int i = 0; i < kd; i++)
                {

                    kod_doc[i] = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    fiod[i] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    prof[i] = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    kabinet[i] = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    work_hours[i] = dataGridView1.Rows[i].Cells[4].Value.ToString();

                }
                this.TopMost = true;
            }
            

        }

        private void Button3_Click(object sender, EventArgs e)//Изменение записи
        {
            kd1 = dataGridView1.CurrentRow.Index;
            textBox1.Text = fiod[kd1].ToString();
            textBox2.Text = prof[kd1].ToString();
            textBox3.Text = kabinet[kd1].ToString();
            textBox4.Text = work_hours[kd1].ToString();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Visible = true;
            button6.Visible = true;
            button7.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
        }

        private void Button4_Click(object sender, EventArgs e)//Готово при изменении
        {


            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "")
             || (Regex.IsMatch(textBox1.Text, regex_fio) == false) || (Regex.IsMatch(textBox2.Text, regex_prof) == false)
             || (Regex.IsMatch(textBox3.Text, regex_kab) == false) || (Regex.IsMatch(textBox4.Text, regex_time) == false))
            {
                MessageBox.Show("Данные введены некорректно", "",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                bool p1 = false;
                string[] s2 = textBox4.Text.Split(new char[] { '-', ':' });
                if ((int.Parse(s2[0]) < int.Parse(s2[2])) || ((int.Parse(s2[0]) == int.Parse(s2[2])) && (int.Parse(s2[1]) < int.Parse(s2[3])))){ p1 = true; }
                else p1 = false;
                if (p1==true)
                {
                    fiod[kd1] = textBox1.Text.ToString();
                    prof[kd1] = textBox2.Text.ToString();
                    kabinet[kd1] = int.Parse(textBox3.Text);
                    work_hours[kd1] = textBox4.Text;
                    dataGridView1.Rows.RemoveAt(kd1);
                    dataGridView1.Rows.Insert(kd1, kod_doc[kd1].ToString(), fiod[kd1], prof[kd1], kabinet[kd1], work_hours[kd1]);
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    textBox1.Visible = false;
                    textBox4.Visible = false;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                }
                else MessageBox.Show("Время работы введенно некорректно", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }

        }

        private void Button5_Click(object sender, EventArgs e)// кнопка сохранить
        {
            DocSave();
        }

        private void Button6_Click(object sender, EventArgs e)//кнопка отмена
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }




        private void Button7_Click(object sender, EventArgs e)//Готово при добавлении
        {

            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "")
            || (Regex.IsMatch(textBox1.Text, regex_fio) == false) || (Regex.IsMatch(textBox2.Text, regex_prof) == false)
            || (Regex.IsMatch(textBox3.Text, regex_kab) == false) || (Regex.IsMatch(textBox4.Text, regex_time) == false))
            {
                MessageBox.Show("Данные введены некоррректно", "",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            
            else
            {
                int a = 0;
                for (int i = 0; i < kd; i++)//поиск номера последнего кода
                {
                    if (a < int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()))
                        a = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                }
                int k = a + 1;
                string fiodd = textBox1.Text;
                string profd = textBox2.Text;
                string kabinetd = textBox3.Text;
                string work_hd = textBox4.Text;
                kd = kd + 1;
                ResizeArray();
                kod_doc[kd - 1] = k;
                fiod[kd - 1] = fiodd;
                prof[kd - 1] = profd;
                kabinet[kd - 1] = int.Parse(kabinetd);
                work_hours[kd - 1] = work_hd;
                dataGridView1.Rows.Add(kod_doc[kd - 1].ToString(), fiod[kd - 1], prof[kd - 1], kabinet[kd - 1], work_hours[kd - 1]);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }

        bool cl = true;
        private void Doctors_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
            {
                cl = false;
                DialogResult result = MessageBox.Show("Сохранить перед выходом?", "Выход",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)

                {
                    DocSave();
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }

        }
    }
}
