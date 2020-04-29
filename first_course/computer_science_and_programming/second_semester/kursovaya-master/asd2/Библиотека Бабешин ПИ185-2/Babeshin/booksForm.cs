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
using System.Globalization;

namespace Babeshin
{
    public partial class booksForm : Form
    {
        public string[] stringMassive;
        public int numberCell, numberRow;
        string[][] fulContent;
        string[] numberPassport;
        public booksForm()
        {
            InitializeComponent();
        }

        private void booksForm_Load(object sender, EventArgs e)
        {
            OpenFile();
            CrearteTablet();
            bookDGV1.ForeColor = Color.Black;
            save.BackColor = Color.Black;
            save.ForeColor = Color.White;
            edit.BackColor = Color.Black;
            edit.ForeColor = Color.White;
            del.BackColor = Color.Black;
            del.ForeColor = Color.White;
            add.BackColor = Color.Black;
            add.ForeColor = Color.White;
            search.BackColor = Color.Black;
            search.ForeColor = Color.White;
        }


        //---------------------------------------------ОТКРЫТИЕ ФАЙЛОВ-------------------------------------------
        //-------ВСЕ ФАЙЛЫ ОТКРЫВАЮТСЯ СРАЗУ ПРИ ЗАГРУСКЕ ФОРМЫ--------------------------------------------------
        //------И ЗАПОНЯЮТЯС МАССИВЫ СООТВЕТСВУЮЩИМИ ДАННЫМИ, ДЛЯ ПОДСТАНОВСКИ И СВЯЗИ ВСЕХ ТАБЛИЦ---------------
        private void OpenFile()
        {
            string nameFile = @"books.txt";

            StreamReader f = new StreamReader(nameFile, Encoding.Default);
            stringMassive = f.ReadToEnd().Split('\n');
            f.Close();
            if (stringMassive.Length == 1 && stringMassive[stringMassive.Length - 1] == "")
            {
               // stringMassive[stringMassive.Length - 1] = "111111@Иванов И.И.@Название@01/01/1970";
            }
            stringMassive = stringMassive.Where(x => x != "").ToArray();
        }

        //----------------------------------------------------------СОЗДАНИЕ ТАБЛИЦЫ В DATAGRIDVIEW-------------------
        //-----МАССИВЫ fulContent,bookContent И readersContent НУЖНЫ ДЛЯ ХРАНЕНИЯ ВСЕХ ЭЛЕМЕНТОВ СТРОК, ЗАПИСАННЫХ ИЗ ФАЙЛА
        //-----МАССИВЫ fio И bookName НУЖНЫ ДЛЯ СВЯЗИ С ТАБЛИЦАМИ 'ЧИТАТЕЛИ' И 'КНИГИ'СООТВЕТСВЕННО-----------------------
        //-----В  ЗАПИСЫВАЮТСЯ № ПАСПОРТА (КНИГИ/ЧИТАТЕЛЯ) И НАЗВАНИЕ/ФИО-----------------------------------
        //----В ДАЛЬНЕЙШЕМ ЭТИ ДАННЫЕ БУДУТ СВЯЗАНЫ МЕЖДУ ДРУГ ДРУГОМ И ИХ МОЖНО БУДЕТ ИСПОЛЬЗОВАТЬ ДЛЯ ВЗАИМНОЙ ПРОВЕРКИ ДАННЫХ
        //---ПО ХОДУ ЗАПОЛНЕНИЯ fio И bookName ЗАПОЛНЯЮТСЯ И COMBOBOX'Ы НУЖНЫМИ ДАННЫМИ ИЗ СООТВЕТСТВУЮЩИХ ТАБЛИЦ
        private void CrearteTablet()
        {


            bookDGV1.Rows.Clear();

            numberPassport = new string[stringMassive.Length];
            fulContent = new string[stringMassive.Length][];

            for (int i = 0; i < stringMassive.Length; i++)
            {
                fulContent[i] = stringMassive[i].Split('@');
            }

            for (int i = 0; i < stringMassive.Length; i++)
            {
                bookDGV1.Rows.Add();
                for (int j = 0; j < 5; j++)
                {

                    bookDGV1.Rows[i].Cells[j].Value = fulContent[i][j];
                    if (j == 0)
                    {
                        numberPassport[i] = Convert.ToString(int.Parse(bookDGV1.Rows[i].Cells[j].Value.ToString()));

                    }
                }
            }

        }




        //                                                                   ______________        
        //           _        _        _          _          ______         |  __________  |       _        _       _       ___
        //          | |      / /      | |        | |       / ______ \       | |          | |      | |      / /     | |     /   |                         
        //          | |    / /        | |        | |      | |      | |      | |          | |      | |    / /       | |    /    |                  
        //          | |  / /          | |________| |      | |      | |      | |          | |      | |  / /         | |   /  /| |                                                    
        //          | |/ /            | |        | |      | |      | |      | |          | |      | |/ /           | |  /  / | |                                                           
        //          | |\ \            | |________| |      | |      | |      | |          | |      | |\ \           | | /  /  | |                                                    
        //          | |  \ \          | |        | |      | |      | |      | |          | |      | |  \ \         | |/  /   | |                                                                   
        //          | |    \ \        | |        | |      | |______| |      | |          | |      | |    \ \       |    /    | |                                                  
        //          |_|      \_\      |_|        |_|       \ ______ /       |_|          |_|      |_|      \_\     |___/     |_|                                                          
        //        
        //

        //---------------------------------КНОПКА СОЗДАНИЯ ЗАПИСИ---------------------------------------------------------------
        //---ВСЕ ПОЛЯ ПРОВЕРЯЮТСЯ НА КОРРЕКТНОСТЬ ВВЕДЕННЫХ ДАННЫХ--------------------------------------------------------------
        //--ВСЕ ПОЛЯ "СКЛИВАЮТСЯ" В ОДНУ СТРОКУ В НУЖНОМ ФОРМАТЕ, И ЗАПИСЫВАЮТСЯ В ОСНОВНОЙ МАССИВ ВСЕХ СТРОК ОСНОВНОГО ФАЙЛА---
        //--ВСЕ ПОЛЯ ОТЧИЩЮТСЯ, ЧТОБЫ ПОЛЬЗОВАТЕЛЬ МОГ ВВЕСТИ НОВУЮ ЗАПИСЬ------------------------------------------------------
        private void add_Click(object sender, EventArgs e)
        {
            if (checkTextBoxs())
                if (numberPassport.Contains(int.Parse(textBox1.Text).ToString()))
                {
                    MessageBox.Show("Книга с таким паспортом уже сусществует", "Ошибка", MessageBoxButtons.OK);
                    textBox1.Text = "";
                }
                else
                {

                    Array.Resize(ref stringMassive, stringMassive.Length + 1);
                    string newLine = "";



                    newLine += Convert.ToString(textBox1.Text).Trim() + "@" + Convert.ToString(textBox2.Text).Trim() + "@" + Convert.ToString(textBox3.Text).Trim() + "@" +
                        Convert.ToString(textBox4.Text).Trim()+"@" + Convert.ToString(izd.Text).Trim();



                    for (int i = 0; i < stringMassive.Length; i++)
                    {


                        if (i == stringMassive.Length - 1)
                        {
                            stringMassive[i] = newLine;
                        }

                    }
                    CrearteTablet();
                    numberCell = 0;
                    numberRow = 0;
                    clearTextBoxs();

                }
        }


        //----------------------------------------------------------------------------ИЗМЕНЕНИЕ ЗАПИСИ--------------------------------------------------------------------------
        //--------КОГДА ПОЛЬЗОВАТЕЛЬ КЛИКАЕТ ПО ЯЧЕЙКЕ, ПРОГРАММА ЗАПОМИНАЕТ НОМЕР СТРОКИ---------------------------------------------------------------------------------------
        //--------ПРИ НАЖАТИИ НА КНОПКУ "ИЗМЕНИТЬ ЗАПИСЬ" ВСЕ ПОЛЯ "СКЛИВАЮТСЯ" В ОДНУ СТРОКУ В НУЖНОМ ФОРМАТЕ, И ЗАПИСЫВАЮТСЯ В ОСНОВНОЙ МАССИВ ВСЕХ СТРОК ОСНОВНОГО ФАЙЛА-----
        //--------ТАБЛИЦА ЗАПИСЫВАЕТСЯ В ОСНОВНОЙ МАССИВ ВСЕХ СТРОК-------------------------------------------------------------------------------------------------------------
        //-----ТАБЛИЦА СТРОИТСЯ ПО НОВЫМ ДАННЫМ---------------------------------------------------------------------------------------------------------------------------------
        private void edit_Click(object sender, EventArgs e)
        {
            if (checkTextBoxs() && numberRow > 0)
            {
                //--------Когда user кликает по ячейке, программа запоминает номер строки----
                //--------При нажатии на кнопку изменить все textbos'ы записываются в соответствующие ячейки в таблице-----
                //--------Таблица записывается в массив------------------------------------------

                bookDGV1.Rows[numberRow].Cells[0].Value = textBox1.Text;
                bookDGV1.Rows[numberRow].Cells[1].Value = textBox2.Text;
                bookDGV1.Rows[numberRow].Cells[2].Value = textBox3.Text;
                bookDGV1.Rows[numberRow].Cells[3].Value = textBox4.Text;
                bookDGV1.Rows[numberRow].Cells[4].Value = izd.Text;


                stringMassive = new string[bookDGV1.RowCount];

                for (int i = 0; i < stringMassive.Length; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (j != 4)
                            stringMassive[i] += bookDGV1.Rows[i].Cells[j].Value + "@";
                        else
                            stringMassive[i] += bookDGV1.Rows[i].Cells[j].Value;
                    }
                }

                CrearteTablet();
                numberCell = 0;
                numberRow = 0;
                clearTextBoxs();
            }
            else 
             MessageBox.Show("Не выбрана строка!","ВНИМАНИЕ!",MessageBoxButtons.OK);
        }
        

        //--------------------------------------------УДАЛЕНИЕ ЗАПИСИ--------------------------------------------------------------------------
        //---ПРИ ВЫБОРЕ ЯЧЕЙКИ - ВЫБИРАЕТСЯ ВСЯ СТРОКА-----------------------------------------------------------------------------------------
        //------СПЕРВА ДАННАЯ СТРОКА ИЗМЕНЯЕТСЯ В МАССИВЕ НА ПУСТУЮ СТРОКУ---------------------------------------------------------------------
        //------ДАЛЕЕ МЕТОД "WHERE" ОБРАЩАЯСЬ К ПРЕДИКАТУ ПЕРЕЗАПИСЫВАЕТ ТОТ ЖЕ МАССИВ, НО УЖЕ БЕЗ ПУСТОЙ СТРОКИ-------------------------------
        //------ТАБЛИЦА ПЕРЕЗАПИСЫВАЕТСЯ, ВСЕ ПОЛЯ "ОТЧИЩАЮТСЯ"--------------------------------------------------------------------------------
        private void del_Click(object sender, EventArgs e)
        {
            //---------------------При выборе ячейки выбирается вся строка, и ее можно удалить-------
            //---------------------Удаление проиходит сперва из массива, затем таблица переписывается------

            for (int i = 0; i < stringMassive.Length; i++)
            {

                if (i == numberRow)
                    stringMassive[i] = "";
                else
                    stringMassive[i] = stringMassive[i];

            }

            //Имя_Массива = Имя_Массива.Where(x => x != null).ToArray();
            stringMassive = stringMassive.Where(x => x != "").ToArray();
            CrearteTablet();
            numberCell = 0;
            numberRow = 0;
            clearTextBoxs();


        }

        //-------------------------------------------------КНОПКА СОХРАНЕНИЯ ТАБЛИЦЫ-----------------------------------
        //-----------МЕТОД ПРОВЕРЯЕТ, НЕ ПУСТАЯ ЛИ ТАБЛИЦА (МАССИВ ИЗ ВСЕХ СТРОК)--------------------------------------
        //-----ЕСЛИ ТАБЛИЦА (МАССИВ) ПУСТАЯ, ТО ВЫЛЕЗАЕТ ПРЕДУПРЕЖДЕНИЕ О ВОЗМОЖНОСТИ ПОТЕРИ ВСЕХ ДАННЫХ---------------
        //----ИНАЧЕ ОТКРЫВАЕТСЯ СООТВЕТСВУЮЩИЙ ФАЙЛ ДЛЯ ЗАПИСИ В НЕГО, ПОЛНОСТЬЮ ПЕРЕЗАПИСЫВАЯ ЕГО---------------------
        private void save_Click(object sender, EventArgs e)
        {
            if (stringMassive.Length > 0)
            {
                StreamWriter f = new StreamWriter(@"books.txt", false, System.Text.Encoding.Default);
                for (int i = 0; i < stringMassive.Length; i++)
                {
                    if (i != stringMassive.Length - 1)
                       f.Write(stringMassive[i]+"\n");
                   else
                        f.Write(stringMassive[i]);
                }
                f.Close();
                MessageBox.Show("Таблица успешно сохранена", "");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Вы хотите сохранить пустую таблицу, после сохранения все данные будут потеряный!", "ВНИМАНИЕ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    StreamWriter f = new StreamWriter(@"books.txt", false, System.Text.Encoding.Default);
                    for (int i = 0; i < stringMassive.Length; i++)
                    {
                        f.Write(stringMassive[i] + "\n");
                    }
                    f.Close();
                    MessageBox.Show("Таблица успешно сохранена", "");
                }
            }
        }

        //------------------------------------------------------------------КНОПКА ПОИСКА------------------------------------------
        //-----------------МЕТОД ИЩЕТ ПЕРВОЕ СОВПАДЕНИЕ ПОСПОРТОВ В ТАБЛИЦЕ, Т.К. ДВУХ ОДИНАКОВЫХ ПАСПОРТОВ БЫТЬ НЕ МОЖЕТ----------
        //-----------------МЕТОД ВЫДАСТ НОМЕР И СОДЕРЖИМОЕ СТРОКИ С ЭТИМ ПАСПОРТОМ-------------------------------------------------
        private void search_Click(object sender, EventArgs e)
        {
            bool search = false;
            string passport = searchTBX.Text.ToString();
            for (int i = 0; i < bookDGV1.Rows.Count; i++)
            {
                if (passport == Convert.ToString(int.Parse(bookDGV1[0, i].Value.ToString())))
                {
                    search = true;
                    bookDGV1.CurrentCell = bookDGV1.Rows[i].Cells[0];
                    numberRow = bookDGV1.CurrentCell.RowIndex;
                    rowNumber.Text = Convert.ToString(numberRow + 1);

                    //------------При выборе ячейки в textbox'ы заносится вся информация из них------------------------

                    textBox1.Text = Convert.ToString(bookDGV1.Rows[numberRow].Cells[0].Value);
                    textBox2.Text = Convert.ToString(bookDGV1.Rows[numberRow].Cells[1].Value);
                    textBox3.Text = Convert.ToString(bookDGV1.Rows[numberRow].Cells[2].Value);
                    textBox4.Text = Convert.ToString(bookDGV1.Rows[numberRow].Cells[3].Value);
                    izd.Text = Convert.ToString(bookDGV1.Rows[numberRow].Cells[4].Value);

                }
            }
            if (!search)
            {
                MessageBox.Show("Записи с таким паспортом не найдено", "Ошибка");
            }
        }


        //
        //
        //
        //
        //
        //
        //

        //
        //-----------------------------------------ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ----------------------------------------------------
        //


        //--------ПРОВЕРКА ПОЛЕЙ, ПРЕДНАЗНАЧЕННЫХ ДЛЯ ВВОДА------------------------------------------------------------------
        //----ДАТЫ ПРОВЕРЯЮТСЯ СПЕРВА РЕГУЛЯРНЫМ ВЫРАЖЕНИЕМ ДЛЯ ФОРМАТА ДД/ММ/ГГГ--------------------------------------------
        //----ЗАТЕМ DateTime.TryParse ПРОВЕРЯЕТ ВВЕДЕННУЮ ДАТУ НА КОРРЕКТНОСТЬ ВВОДА-----------------------------------------
        //---ЕСЛИ ВСЕ ПРОВЕРКИ ВЫПОЛНЕНЫ ТО МЕТОД ВОЗВРАЩАЕТ TRUE, ИНАЧЕ FALSE-----------------------------------------------
        private bool checkTextBoxs()
        {
            bool bl = true;
            string date = @"^([0-9]{2}\/[0-9]{2}\/[0-9]{4})$";

            //--------Проверка всех полей на корректность ввода-----

          /*  if (!int.TryParse(Convert.ToString(textBox1.Text).Trim(), out int aaa) || textBox1.Text.Length != 6)
            {
                MessageBox.Show("Поле [№ паспорта] было неверно запонено, проверьте правильность введенных данных", "", MessageBoxButtons.OK);
                textBox1.Text = "";
                bl = false;
            }*/
             if (textBox2.Text.Length == 0 || Convert.ToString(textBox2.Text).Trim() == "" || Convert.ToString(textBox2.Text).Trim() == " ")
            {
                MessageBox.Show("Поле [Автор] было неверно запонено, проверьте правильность введенных данных", "", MessageBoxButtons.OK);
                textBox2.Text = "";
                bl = false;
            }
            else if (textBox3.Text.Length == 0 || Convert.ToString(textBox3.Text).Trim() == "" || Convert.ToString(textBox3.Text).Trim() == " ")
            {
                MessageBox.Show("Поле [Название] было неверно запонено, проверьте правильность введенных данных", "", MessageBoxButtons.OK);
                textBox3.Text = "";
                bl = false;
            }
            else if (!Regex.IsMatch(Convert.ToString(textBox4.Text).Trim(), date) || !DateTime.TryParse(Convert.ToString(textBox4.Text).Trim(), out DateTime dt1) /*||
                 textBox4.Text.Length != 10*/)
            {
                MessageBox.Show(@"Поле [Дата издания] было неверно запонено, проверьте правильность введенных данных.
                                    Формат даты: дд/мм/гггг", "", MessageBoxButtons.OK);
                textBox4.Text = "";
                bl = false;
            }

            else if (int.TryParse(Convert.ToString(textBox1.Text).Trim(), out int a) && textBox1.Text.Length == 6 &&
              textBox2.Text.Length != 0 && (Convert.ToString(textBox2.Text).Trim() != "" || Convert.ToString(textBox2.Text).Trim() != " ") &&
               textBox3.Text.Length != 0 && (Convert.ToString(textBox3.Text).Trim() != "" || Convert.ToString(textBox3.Text).Trim() != " ") &&
               Regex.IsMatch(Convert.ToString(textBox4.Text).Trim(), date) && DateTime.TryParse(Convert.ToString(textBox4.Text).Trim(), out DateTime dt) && textBox4.Text.Length == 10)

                bl = true;
            return bl;
        }

        
        //-----------------------------------------"ОТЧИЩЕНИЕ" ВСЕХ ПОЛЕЙ------------------------------------------------------
        //----------ПОЛЯ "ОТЧИЩАЮТСЯ"------------------------------------------------------------------------------------------

        private void clearTextBoxs()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            izd.Text = "";
        }


        //
        //
        //
        //
        //
        //


        //------------------------------------------------------------------------------СОБЫТИЯ----------------------------------------------------------


        //-----------------------------СОБЫТИЕ НА ЗАКРЫТИЕ ФОРМЫ---------------------------------------------------------------------------------------------------------------------
        //------------------ПРИ ЗАКРЫТИИ ФОРМЫ, ПРОГРАММА ПРЕДЛАГАЕТ СОХРАНИТЬ ТАБЛИЦУ-----------------------------------------------------------------------------------------------  
        private void booksForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы хотите сохранить  таблицу?", "ВНИМАНИЕ", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                StreamWriter f = new StreamWriter(@"books.txt", false, System.Text.Encoding.Default);
                for (int i = 0; i < stringMassive.Length; i++)
                {
                   if (i != stringMassive.Length - 1)
                        f.Write(stringMassive[i] + "\n");
                    else
                        f.Write(stringMassive[i]);
                }
                f.Close();
                MessageBox.Show("Таблица успешно сохранена", "");
            }
            if (dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }


        //Если поле поиска пустое то кнопка заблокирована, иначе разблокирована
        private void searchTBX_TextChanged(object sender, EventArgs e)
        {
            if (searchTBX.Text.Length > 0)
                search.Enabled = true;
            else if(searchTBX.Text.Length == 0)
                search.Enabled = false;
        }

      

        //-------------------------СОБИТЕ НА "ЩЕЛЧОК" ПО ЯЧЕЙКЕ ТАБЛИЦЫ--------------------------------------
        //-----------------------ПРИ ВЫБОРЕ ЯЧЕЙКИ, В ПОЛЯ ЗАНОСЯТСЯ ДАННЫЕ ИЗ СООТВЕТСТВУЮЩЕЙ СТРОКИ ТАБЛИЦЫ
        //---------------------ТАКЖЕ ПРОГРАММА ЗАПОМИНАЕТ ВЫБРАННЫЙ СТОЛБЕЦ И СТРОКУ-------------------------
        private void bookDGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            numberCell = bookDGV1.CurrentCell.ColumnIndex;
            numberRow = bookDGV1.CurrentCell.RowIndex;
            rowNumber.Text = Convert.ToString(numberRow + 1);

            //------------При выборе ячейки в textbox'ы заносится вся информация из них------------------------

            textBox1.Text = Convert.ToString(bookDGV1.Rows[numberRow].Cells[0].Value);
            textBox2.Text = Convert.ToString(bookDGV1.Rows[numberRow].Cells[1].Value);
            textBox3.Text = Convert.ToString(bookDGV1.Rows[numberRow].Cells[2].Value);
            textBox4.Text = Convert.ToString(bookDGV1.Rows[numberRow].Cells[3].Value);
            izd.Text = Convert.ToString(bookDGV1.Rows[numberRow].Cells[4].Value);
        }








    }
}
