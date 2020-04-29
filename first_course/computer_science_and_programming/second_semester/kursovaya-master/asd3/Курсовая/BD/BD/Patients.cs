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
    public partial class Patients : Form
    {

        int[] kod_pat = new int[0];//массив для кодов пациентов
        string[] fiop = new string[0];//массив для ФИО пациентов
        string[] date_of_b = new string[0];//массив для даты рождения пациентов
        string[] policy = new string[0];// массив для номеров полисов 
        int kp = 0;// переменная для длины массивов
        char[] sym = { '#' };
        int kp1 = 0;//переменная для изменения записей
        string regex_fio = @"^[А-Я]{1}[а-я]*(\s{1}[А-Я]{1}[.]{1}[А-Я]{1}[.]{1})*$";
        string regex_date = @".";
        // string regex_date = @"(0[1-9]|[12][0-9]|3[01])[.](0[1-9]|1[012])[.](19|20)\d\d\s";
        string regex_policy = @"[0-9]{16}";

        public Patients()
        {
            InitializeComponent();

        }

        private void PatShow()//считывание с файла и вывод в DataGrid
        {
            dataGridView1.Rows.Clear();
            string[] s = File.ReadAllLines("patients.txt", Encoding.GetEncoding(1251));
            kp = s.Length;
            ResizeArray();
            for (int i = 0; i < kp; i++)
            {
                string[] s1 = s[i].Split(sym, StringSplitOptions.RemoveEmptyEntries);
                kod_pat[i] = int.Parse(s1[0]);
                fiop[i] = s1[1];
                date_of_b[i] = s1[2];
                policy[i] = s1[3];
                dataGridView1.Rows.Add(kod_pat[i].ToString(), fiop[i], date_of_b[i], policy[i]);
            }

        }

        private void PatSave()// Сохранение текстового файла из DataGrid
        {
            for (int i = 0; i < kp; i++)
            {

                string st = kod_pat[i] + "#" + fiop[i] + "#" + date_of_b[i]+"#"+policy[i];
                if (i == 0)// 
                {
                    FileStream aFile = new FileStream("patients.txt", FileMode.Create);
                    StreamWriter sw = new StreamWriter(aFile, Encoding.GetEncoding(1251));
                    sw.WriteLine(st);
                    sw.Close();
                }
                else
                {
                    FileStream aFile = new FileStream("patients.txt", FileMode.Append);
                    StreamWriter sw = new StreamWriter(aFile, Encoding.GetEncoding(1251));
                    sw.WriteLine(st);
                    sw.Close();
                }
            }
            string[] fio_pat = new string[0];
            string[] rec = File.ReadAllLines("receptions.txt", Encoding.GetEncoding(1251));//удаление всех записей приема, если нет врача
            int kr = rec.Length;
            Array.Resize(ref fio_pat, kr);
            for (int i = 0; i < kr; i++)
            {
                string[] s1 = rec[i].Split(sym, StringSplitOptions.RemoveEmptyEntries);
                fio_pat[i] = s1[0];
            }
            for (int i = 0; i < kr; i++)
            {
                bool pr1 = false;
                for (int j = 0; j < fiop.Length; j++)
                {
                    if (fio_pat[i] == fiop[j]) pr1 = true;
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
            //PatShow();
        }

        private void ResizeArray()//изменение размера массивов
        {
            Array.Resize(ref kod_pat, kp);
            Array.Resize(ref fiop, kp);
            Array.Resize(ref date_of_b, kp);
            Array.Resize(ref policy, kp);
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            PatShow();
        }

        private void Button1_Click(object sender, EventArgs e)//при нажатии добавить
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)//удалить запись
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтвердите удаление",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)

            {
                kp1 = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.Remove(dataGridView1.Rows[kp1]);
                dataGridView1.Refresh();
                kp--;
                ResizeArray();
                for (int i = 0; i < kp; i++)//перезаписываем массив после удаления
                {

                    kod_pat[i] = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    fiop[i] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    date_of_b[i] = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    policy[i] = dataGridView1.Rows[i].Cells[3].Value.ToString();

                }
                this.TopMost = true;
            }
        }

        private void Button3_Click(object sender, EventArgs e)//Изменение записи
        {
            kp1 = dataGridView1.CurrentRow.Index;
            textBox1.Text = fiop[kp1].ToString();
            textBox2.Text = date_of_b[kp1].ToString();
            textBox3.Text = policy[kp1].ToString();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button5.Visible = true;
            button6.Visible = false;
            button7.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
        }

        private void Button7_Click(object sender, EventArgs e)//готово при изменении
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "")
             || (Regex.IsMatch(textBox1.Text, regex_fio) == false) || (Regex.IsMatch(textBox2.Text, regex_date) == false)
             || (Regex.IsMatch(textBox3.Text, regex_policy) == false))
            {
                MessageBox.Show("Введите данные", "",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                fiop[kp1] = textBox1.Text.ToString();
                date_of_b[kp1] = textBox2.Text.ToString();
                policy[kp1] = textBox3.Text.ToString();
                dataGridView1.Rows.RemoveAt(kp1);
                dataGridView1.Rows.Insert(kp1, kod_pat[kp1].ToString(), fiop[kp1], date_of_b[kp1], policy[kp1].ToString());
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }


        }

        private void Button4_Click(object sender, EventArgs e)//кнопка Сохранить
        {
            PatSave();
        }

        private void Button5_Click(object sender, EventArgs e)//кнопка Отмена
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Button6_Click(object sender, EventArgs e)//готово при добавлении
        {
            if((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "")
             || (Regex.IsMatch(textBox1.Text, regex_fio) == false) || (Regex.IsMatch(textBox2.Text, regex_date) == false)
             || (Regex.IsMatch(textBox3.Text, regex_policy) == false))
            {
                MessageBox.Show("Некорректные данные", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                int a = 0;
                for (int i = 0; i < kp; i++)//поиск номера последнего кода
                {
                    if (a < int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()))
                        a = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                }
                int k = a + 1;
                string fiodp = textBox1.Text;
                string date_of_bd = textBox2.Text;
                string policyd = textBox3.Text;
                kp = kp + 1;
                ResizeArray();
                kod_pat[kp - 1] = k; //добавление в конец массивов введенные данные
                fiop[kp - 1] = fiodp;
                date_of_b[kp - 1] = date_of_bd;
                policy[kp - 1] = policyd;
                dataGridView1.Rows.Add(kod_pat[kp - 1].ToString(), fiop[kp - 1], date_of_b[kp - 1], policy[kp-1]);//вывод новой записи
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }

        }
        bool cl = true;
        private void Patients_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl)
            {
                cl = false;
                DialogResult result = MessageBox.Show("Сохранить перед выходом?", "Выход",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)

                {
                    PatSave();
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
