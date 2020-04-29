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
    public partial class InfoAll : Form

    {
        int[] kod_pat = new int[0];//код пациента для записи;
        string[] fio_pat = new string[0];//фио пациента для "приемы";
        string[] fiop = new string[0];//фио пациента для "пациенты";
        int[] kod_doc = new int[0];//код врача;
        string[] fio_doc = new string[0];//фио врача для "преимы";
        string[] fiod = new string[0];//фио врача для "докторы"
        DateTime[] date_of_rec = new DateTime[0];//дата и время приема;
        string[] work_hours = new string[0]; //массив для рабочего времени;
        char[] sym = { '#' };
        int kr = 0;//переменная для длина массивов;
        int kr1 = 0;//переменная для изменения записей;
        string[] date_of_b = new string[0];//массив для даты рождения пациентов
        string[] policy = new string[0];// массив для номеров полисов 
        int kp = 0;// переменная для длины массивов
        int kp1 = 0;//переменная для изменения записей
        string[] prof = new string[0];//массив для специализации врачей
        int[] kabinet = new int[0]; // массив для кабинетов
        int kd = 0;// переменная для длины массивов
        string[] state = new string[0];//массив для статуса приема
        string[] state_for_combo = { "Прием назначен", "На лечении", "Вылечен" };

        public InfoAll()
        {
            InitializeComponent();
            textBox1.Enabled = false;

        }

        private void InfoAll_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox5.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            dateTimePicker1.Enabled = false;
        }

        private void ComboDoc()//создание комбобокса  для врачей 
        {
            comboBox1.Items.Clear();
            string[] doc = File.ReadAllLines("doc.txt", Encoding.GetEncoding(1251));
            int kd = doc.Length;

            for (int i = 0; i < kd; i++)
            {
                string[] d = new string[4];
                string[] s1 = doc[i].Split(sym, StringSplitOptions.RemoveEmptyEntries);
                comboBox1.Items.Add(s1[1].ToString());
                string[] s2 = s1[4].Split(new char[] { ':', '-' });
                for (int j = 0; j < 4; j++)
                {
                    d[j] = s2[j];
                }

            }
        }

        private void ComboState()//создание массива для состояния
        {

            comboBox2.Items.Clear();
            for (int i = 0; i < state_for_combo.Length; i++)
            {
                comboBox2.Items.Add(state_for_combo[i]);
            }


        }
        bool pr1 = false;
        private void Check_of_click()
        {
            if ((checkBox1.Checked) || (checkBox2.Checked) || (checkBox3.Checked) || (checkBox4.Checked) || (checkBox5.Checked) ||
                (checkBox6.Checked) || (checkBox7.Checked) || (checkBox8.Checked) || (checkBox9.Checked) || (checkBox10.Checked) ||
                (checkBox11.Checked) || (checkBox12.Checked) || (checkBox13.Checked) || (checkBox14.Checked) || (checkBox15.Checked) ||
                (checkBox16.Checked) || (checkBox17.Checked)) pr1 = true;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            dateTimePicker1.Enabled = false;
            checkBox6.Enabled = false;
            checkBox11.Enabled = false;
            button1.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Check_of_click();
            k = 0;
            if (pr1 == true)
            {
                string[] rec = File.ReadAllLines("receptions.txt", Encoding.GetEncoding(1251));//считывание с файла приемы
                kr = rec.Length;
                Array.Resize(ref fio_doc, kr);
                Array.Resize(ref fio_pat, kr);
                Array.Resize(ref date_of_rec, kr);
                Array.Resize(ref state, kr);
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
                    state[i] = s1[3];

                }

                string[] doc = File.ReadAllLines("doc.txt", Encoding.GetEncoding(1251));//считывание с файла врачи
                kd = doc.Length;
                Array.Resize(ref kod_doc, kd);
                Array.Resize(ref fiod, kd);
                Array.Resize(ref prof, kd);
                Array.Resize(ref kabinet, kd);
                Array.Resize(ref work_hours, kd);
                for (int i = 0; i < kd; i++)
                {
                    string[] s1 = doc[i].Split(sym, StringSplitOptions.RemoveEmptyEntries);
                    kod_doc[i] = int.Parse(s1[0]);
                    fiod[i] = s1[1];
                    prof[i] = s1[2];
                    kabinet[i] = int.Parse(s1[3]);
                    work_hours[i] = s1[4];
                }

                string[] pat = File.ReadAllLines("patients.txt", Encoding.GetEncoding(1251));//считывание с файла пациенты
                kp = pat.Length;
                Array.Resize(ref kod_pat, kp);
                Array.Resize(ref fiop, kp);
                Array.Resize(ref date_of_b, kp);
                Array.Resize(ref policy, kp);
                for (int i = 0; i < kp; i++)
                {
                    string[] s1 = pat[i].Split(sym, StringSplitOptions.RemoveEmptyEntries);
                    kod_pat[i] = int.Parse(s1[0]);
                    fiop[i] = s1[1];
                    date_of_b[i] = s1[2];
                    policy[i] = s1[3];
                }
                if (radioButton1.Checked)//создание датагрид для "приемы"
                {
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Column0", HeaderText = "№", Width = 60 });
                    dataGridView1.Rows.Add(kr);
                    for (int i = 0; i < kr; i++)
                    {
                        dataGridView1.Rows[i].Cells["Column0"].Value = i + 1;
                    }

                    if (checkBox10.Checked)//код пациента
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Column1", HeaderText = "Код пациента", Width = 60 });
                        for (int i = 0; i < kr; i++)
                        {
                            for (int j = 0; j < fiop.Length; j++)
                            {
                                if (fio_pat[i] == fiop[j])
                                    dataGridView1.Rows[i].Cells["Column1"].Value = kod_pat[j];
                            }
                        }
                    }

                    if (checkBox1.Checked)//фио пациента
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Column2", HeaderText = "ФИО пациента", Width = 150 });
                        for (int i = 0; i < kr; i++)
                        {
                            dataGridView1.Rows[i].Cells["Column2"].Value = fio_pat[i];
                        }
                    }

                    if (checkBox12.Checked)//дата рождения пациента
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Column3", HeaderText = "Дата Рождения", Width = 80 });
                        for (int i = 0; i < kr; i++)
                        {
                            for (int j = 0; j < fiop.Length; j++)
                            {
                                if (fio_pat[i] == fiop[j])
                                    dataGridView1.Rows[i].Cells["Column3"].Value = date_of_b[j];
                            }
                        }
                    }

                    if (checkBox13.Checked)//номер полиса
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Column4", HeaderText = "Номер полиса", Width = 100 });
                        for (int i = 0; i < kr; i++)
                        {
                            for (int j = 0; j < fiop.Length; j++)
                            {
                                if (fio_pat[i] == fiop[j])
                                    dataGridView1.Rows[i].Cells["Column4"].Value = policy[j];
                            }
                        }
                    }

                    if (checkBox5.Checked)//код врача
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Column5", HeaderText = "Код крача", Width = 60 });
                        for (int i = 0; i < kr; i++)
                        {
                            for (int j = 0; j < fiod.Length; j++)
                            {
                                if (fio_doc[i] == fiod[j])
                                    dataGridView1.Rows[i].Cells["Column5"].Value = kod_doc[j];
                            }
                        }
                    }


                    if (checkBox2.Checked)//фио врача
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Column6", HeaderText = "ФИО врача", Width = 150 });
                        for (int i = 0; i < kr; i++)
                        {

                            dataGridView1.Rows[i].Cells["Column6"].Value = fio_doc[i];
                        }
                    }

                    if (checkBox7.Checked)//специализация врача
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Column7", HeaderText = "Специализация", Width = 60 });
                        for (int i = 0; i < kr; i++)
                        {
                            for (int j = 0; j < fiod.Length; j++)
                            {
                                if (fio_doc[i] == fiod[j])
                                    dataGridView1.Rows[i].Cells["Column7"].Value = prof[j];
                            }
                        }
                    }

                    if (checkBox8.Checked)//кабинет
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Column8", HeaderText = "Кабинет", Width = 60 });
                        for (int i = 0; i < kr; i++)
                        {
                            for (int j = 0; j < fiod.Length; j++)
                            {
                                if (fio_doc[i] == fiod[j])
                                    dataGridView1.Rows[i].Cells["Column8"].Value = kabinet[j];
                            }
                        }
                    }

                    if (checkBox9.Checked)//время работы
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Column9", HeaderText = "Время работы", Width = 60 });
                        for (int i = 0; i < kr; i++)
                        {
                            for (int j = 0; j < fiod.Length; j++)
                            {
                                if (fio_doc[i] == fiod[j])
                                    dataGridView1.Rows[i].Cells["Column9"].Value = work_hours[j];
                            }
                        }
                    }
                    if (checkBox3.Checked)//дата приема
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Column10", HeaderText = "Дата приема", Width = 100 });
                        for (int i = 0; i < kr; i++)
                        {
                            dataGridView1.Rows[i].Cells["Column10"].Value = date_of_rec[i].ToShortDateString();
                        }
                    }
                    if (checkBox4.Checked)//время приема
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Column11", HeaderText = "Время приема", Width = 60 });
                        for (int i = 0; i < kr; i++)
                        {
                            dataGridView1.Rows[i].Cells["Column11"].Value = date_of_rec[i].ToShortTimeString();
                        }
                    }

                    if (checkBox17.Checked)//состояние пациента, записи
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Column12", HeaderText = "Состояние", Width = 100 });
                        for (int i = 0; i < kr; i++)
                        {
                            dataGridView1.Rows[i].Cells["Column12"].Value = state[i];
                        }
                    }
                    groupBox5.Enabled = true;
                }

                if (radioButton2.Checked)//создание датагрид для "врачи"
                {

                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Column0", HeaderText = "№", Width = 60 });
                    dataGridView1.Rows.Add(kd);
                    for (int i = 0; i < kd; i++)
                    {
                        dataGridView1.Rows[i].Cells["Column0"].Value = i + 1;
                    }

                    if (checkBox5.Checked)
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Column1", HeaderText = "Код врача", Width = 60 });
                        for (int i = 0; i < kr; i++)
                        {

                            dataGridView1.Rows[i].Cells["Column1"].Value = kod_doc[i].ToString();
                        }
                    }

                    if (checkBox6.Checked)
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Column2", HeaderText = "ФИО врача", Width = 180 });
                        for (int i = 0; i < kd; i++)
                        {
                            dataGridView1.Rows[i].Cells["Column2"].Value = fiod[i];
                        }
                    }

                    if (checkBox7.Checked)
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Column3", HeaderText = "Специализация", Width = 100 });
                        for (int i = 0; i < kd; i++)
                        {
                            dataGridView1.Rows[i].Cells["Column3"].Value = prof[i];
                        }
                    }
                    if (checkBox8.Checked)
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Column4", HeaderText = "Кабинет", Width = 60 });
                        for (int i = 0; i < kd; i++)
                        {
                            dataGridView1.Rows[i].Cells["Column4"].Value = kabinet[i].ToString();
                        }
                    }
                    if (checkBox9.Checked)
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Column5", HeaderText = "Время работы", Width = 80 });
                        for (int i = 0; i < kd; i++)
                        {
                            dataGridView1.Rows[i].Cells["Column5"].Value = work_hours[i];
                        }
                    }
                }

                if (radioButton3.Checked)//"создание датагрид для пациенты"
                {
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Column0", HeaderText = "№", Width = 60 });
                    dataGridView1.Rows.Add(kp);
                    for (int i = 0; i < kp; i++)
                    {
                        dataGridView1.Rows[i].Cells["Column0"].Value = i + 1;
                    }

                    if (checkBox10.Checked)
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Column1", HeaderText = "Код пациента", Width = 60 });
                        for (int i = 0; i < kp; i++)
                        {

                            dataGridView1.Rows[i].Cells["Column1"].Value = kod_pat[i].ToString();
                        }
                    }

                    if (checkBox11.Checked)
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Column2", HeaderText = "ФИО пациента", Width = 180 });
                        for (int i = 0; i < kp; i++)
                        {
                            dataGridView1.Rows[i].Cells["Column2"].Value = fiop[i];
                        }
                    }
                    if (checkBox12.Checked)
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Column3", HeaderText = "Дата рождения", Width = 80 });
                        for (int i = 0; i < kp; i++)
                        {
                            dataGridView1.Rows[i].Cells["Column3"].Value = date_of_b[i];
                        }
                    }
                    if (checkBox13.Checked)
                    {
                        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Column4", HeaderText = "Номер полиса", Width = 100 });
                        for (int i = 0; i < kp; i++)
                        {
                            dataGridView1.Rows[i].Cells["Column4"].Value = policy[i];
                        }
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Выберите необходимые данные", "Данные не выбраны",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }


            button1.Enabled = false;
            button2.Enabled = true;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            button3.Enabled = true;
            int a = dataGridView1.RowCount;
            for (int i = 0; i < a; i++)
            {
                if (dataGridView1.Rows[i].Visible) k++;
            }
            textBox1.Text = "Количество записей: " + k;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            groupBox3.Enabled = false;
            groupBox5.Enabled = false;
            comboBox2.Enabled = false;
            comboBox2.Enabled = false;
            dateTimePicker1.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            checkBox6.Enabled = true;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = true;
            groupBox5.Enabled = false;
            comboBox2.Enabled = false;
            comboBox2.Enabled = false;
            dateTimePicker1.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            checkBox11.Enabled = true;
        }



        private void Button3_Click(object sender, EventArgs e)//при нажатии сохранить 
        {
            Window_for_name farm1 = new Window_for_name();
            farm1.ShowDialog();
            string name = Window_for_name.name_doc + ".txt";
            int n = dataGridView1.ColumnCount;
            int k = dataGridView1.RowCount;
            string str;
            for (int i = 0; i < k; i++)
            {
                if (dataGridView1.Rows[i].Visible)
                {
                    str = "";
                    for (int j = 1; j < n; j++)
                    {
                        str += dataGridView1.Rows[i].Cells[j].Value + " ";
                    }
                    if (i == 0)
                    {
                        FileStream aFile = new FileStream(name, FileMode.Create);
                        StreamWriter sw = new StreamWriter(aFile, Encoding.GetEncoding(1251));
                        sw.WriteLine(str);
                        sw.Close();
                    }
                    else if (i != 0 && i != k - 1)
                    {
                        FileStream aFile = new FileStream(name, FileMode.Append);
                        StreamWriter sw = new StreamWriter(aFile, Encoding.GetEncoding(1251));
                        sw.WriteLine(str);
                        sw.Close();
                    }

                    else if (i == k - 1)
                    {
                        FileStream aFile = new FileStream(name, FileMode.Append);
                        StreamWriter sw = new StreamWriter(aFile, Encoding.GetEncoding(1251));
                        str +="\r\n"+textBox1.Text;
                        sw.WriteLine(str);
                        sw.Close();
                    }

                }

            }

            DialogResult result = MessageBox.Show("Текстовый документ создан", "Успешно",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);



        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int a = dataGridView1.ColumnCount;
            for (int i = 0; i < a; i++)
            {
                dataGridView1.Columns.RemoveAt(0);
            }

            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = true;
            groupBox5.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            dateTimePicker1.Enabled = false;
            checkBox1.Checked = false; checkBox9.Checked = false;
            checkBox2.Checked = false; checkBox10.Checked = false;
            checkBox3.Checked = false; checkBox11.Checked = false;
            checkBox4.Checked = false; checkBox12.Checked = false;
            checkBox5.Checked = false; checkBox13.Checked = false;
            checkBox6.Checked = false; checkBox14.Checked = false;
            checkBox7.Checked = false; checkBox15.Checked = false;
            checkBox8.Checked = false; checkBox16.Checked = false; checkBox17.Checked = false;

        }
        int k = 0;//для подведения итогов

        private void CheckBox14_CheckedChanged(object sender, EventArgs e)//при выделении чекбокса по врачам
        {
            k = 0;
            if (checkBox14.Checked)
            {
                comboBox1.Enabled = true;
                ComboDoc();
            }
            else
            {
                int a = dataGridView1.RowCount;
                for (int i = 0; i < a; i++)
                {
                    dataGridView1.Rows[i].Visible = true;
                }
                for (int i = 0; i < a; i++)
                {
                    if (dataGridView1.Rows[i].Visible) k++;
                }
                textBox1.Text = "Количество записей:" + k;
                if (checkBox15.Checked) Sort_of_state();
                if(checkBox16.Checked) Sort_of_date();
                comboBox1.Enabled = false;
            }
        }
        private void ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)// при изменении комбобокса врачи
        {
            k = 0;
            int a = dataGridView1.RowCount;
            for (int i = 0; i < a; i++)
            {
                dataGridView1.Rows[i].Visible = true;
            }
            dataGridView1.Columns["Column0"].Visible = false;
            for (int i = 0; i < a; i++)
            {
                if (dataGridView1.Rows[i].Visible) k++;
            }
            textBox1.Text = "Количество записей:" + k;
            if (checkBox15.Checked) { Sort_of_state(); }
            if (checkBox16.Checked) { Sort_of_date(); }
            Sort_of_doc();
        }

        private void Sort_of_doc()//сортировка по врачам 
        {
            k = 0;
            int a = dataGridView1.RowCount;
            string doc1 = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            for (int i = 0; i < a; i++)
            {
                if (dataGridView1["Column6", i].Value.ToString() != doc1)
                {
                    dataGridView1.Rows[i].Visible = false;

                }

            }
            for (int i = 0; i < a; i++)
            {
                if (dataGridView1.Rows[i].Visible) k++;
            }
            textBox1.Text = "Количество записей:" + k;
        }

        private void CheckBox15_CheckedChanged(object sender, EventArgs e)//при выборе чекбокса по состоянию
        {
            k = 0;
            if (checkBox15.Checked)
            {
                comboBox2.Enabled = true;
                ComboState();
            }
            else
            {
                int a = dataGridView1.RowCount;
                for (int i = 0; i < a; i++)
                {
                    dataGridView1.Rows[i].Visible = true;
                }
                for (int i = 0; i < a; i++)
                {
                    if (dataGridView1.Rows[i].Visible) k++;
                }
                textBox1.Text = "Количество записей:" + k;
                if (checkBox14.Checked) Sort_of_doc();
                if (checkBox16.Checked) Sort_of_date();
                comboBox2.Enabled = false;

            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)//при изменении космбо бокса по состоянию
        {
            k = 0;
            int a = dataGridView1.RowCount;
            for (int i = 0; i < a; i++)
            {
                dataGridView1.Rows[i].Visible = true;
            }
            dataGridView1.Columns["Column0"].Visible = false;
            for (int i = 0; i < a; i++)
            {
                if (dataGridView1.Rows[i].Visible) k++;
            }
            textBox1.Text = "Количество записей:" + k;
            if (checkBox14.Checked) { Sort_of_doc(); }
            if (checkBox16.Checked) { Sort_of_date(); }
            Sort_of_state();
            
        }

        private void Sort_of_state()//выборка по состоянию
        {
            k = 0;
            int a = dataGridView1.RowCount;
            string state1 = comboBox2.Items[comboBox2.SelectedIndex].ToString();

            for (int i = 0; i < a; i++)
            {

                if (dataGridView1["Column12", i].Value.ToString() != state1)
                {
                    dataGridView1.Rows[i].Visible = false;

                }

            }
            for (int i = 0; i < a; i++)
            {
                if (dataGridView1.Rows[i].Visible) k++;
            }
            textBox1.Text = "Количество записей:" + k;
        }

        private void Sort_of_date()//выборка по дате
        {
            k = 0;
            int a = dataGridView1.RowCount;
            string date1 = dateTimePicker1.Value.ToShortDateString();
            for (int i = 0; i < a; i++)
            {
                if (dataGridView1["Column10", i].Value.ToString() != date1)
                {
                    dataGridView1.Rows[i].Visible = false;

                }

            }
            for (int i = 0; i < a; i++)
            {
                if (dataGridView1.Rows[i].Visible) k++;
            }
            textBox1.Text = "Количество записей:" + k;
        }

        private void CheckBox16_CheckedChanged(object sender, EventArgs e)//при выборе чекбокса по дате
        {
            k = 0;
            if (checkBox16.Checked)
            {
                dateTimePicker1.Enabled = true;
            }
            else
            {
                int a = dataGridView1.RowCount;
                for (int i = 0; i < a; i++)
                {
                    dataGridView1.Rows[i].Visible = true;
                }
                for (int i = 0; i < a; i++)
                {
                    if (dataGridView1.Rows[i].Visible) k++;
                }
                textBox1.Text = "Количество записей:" + k;
                if (checkBox14.Checked) Sort_of_doc();
                if (checkBox15.Checked) Sort_of_state();
                dateTimePicker1.Enabled = false;

            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)//при изменении даты
        {
            k = 0;
            int a = dataGridView1.RowCount;
            for (int i = 0; i < a; i++)
            {
                dataGridView1.Rows[i].Visible = true;
            }
            dataGridView1.Columns["Column0"].Visible = false;
            for (int i = 0; i < a; i++)
            {
                if (dataGridView1.Rows[i].Visible) k++;
            }
            textBox1.Text = "Количество записей:" + k;
            if (checkBox14.Checked) { Sort_of_doc(); }
            if (checkBox15.Checked) { Sort_of_state(); }
            Sort_of_date();
        }
    }
}
