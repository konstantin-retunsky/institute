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
    public partial class Output : Form
    {
        public string[] stringMassive;
        public int numberCell, numberRow;
        string[][] fulContent;
        string[] booksMassive, readersMassive;
        string[][] bookContent, readersContent;
        int[] indexMassive;
        string[,] bookName, fio;
        int indexof;

        bool aaa1 = false, aaa2 = false;

        int indexforbook1, indexforbook2;

        int indexforreaders1, indexforreaders2;
        public Output()
        {
            InitializeComponent();
        }

        private void Output_Load(object sender, EventArgs e)
        {
            OpenFile();
            CrearteTablet();
            outDGV1.ForeColor = Color.Black;
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
            string nameFile = @"output.txt";

            StreamReader outputs = new StreamReader(nameFile, Encoding.Default);
            stringMassive = outputs.ReadToEnd().Split('\n');
            outputs.Close();
            if (stringMassive.Length == 1 && stringMassive[stringMassive.Length - 1] == "")
            {
                stringMassive[stringMassive.Length - 1] = "111111@Название@ФИО@01/01/2010";
            }
            stringMassive = stringMassive.Where(x => x != "").ToArray();


            StreamReader books = new StreamReader(@"books.txt", Encoding.Default);
            booksMassive = books.ReadToEnd().Split('\n');
            books.Close();

            StreamReader readers = new StreamReader(@"readers.txt", Encoding.Default);
            readersMassive = readers.ReadToEnd().Split('\n');
            readers.Close();
        }


        //----------------------------------------------------------СОЗДАНИЕ ТАБЛИЦЫ В DATAGRIDVIEW-------------------
        //-----МАССИВЫ fulContent,bookContent И readersContent НУЖНЫ ДЛЯ ХРАНЕНИЯ ВСЕХ ЭЛЕМЕНТОВ СТРОК, ЗАПИСАННЫХ ИЗ ФАЙЛА
        //-----МАССИВЫ fio И bookName НУЖНЫ ДЛЯ СВЯЗИ С ТАБЛИЦАМИ 'ЧИТАТЕЛИ' И 'КНИГИ'СООТВЕТСВЕННО-----------------------
        //-----В  ЗАПИСЫВАЮТСЯ № ПАСПОРТА (КНИГИ/ЧИТАТЕЛЯ) И НАЗВАНИЕ/ФИО-----------------------------------
        //----В ДАЛЬНЕЙШЕМ ЭТИ ДАННЫЕ БУДУТ СВЯЗАНЫ МЕЖДУ ДРУГ ДРУГОМ И ИХ МОЖНО БУДЕТ ИСПОЛЬЗОВАТЬ ДЛЯ ВЗАИМНОЙ ПРОВЕРКИ ДАННЫХ
        //---ПО ХОДУ ЗАПОЛНЕНИЯ fio И bookName ЗАПОЛНЯЮТСЯ И COMBOBOX'Ы НУЖНЫМИ ДАННЫМИ ИЗ СООТВЕТСТВУЮЩИХ ТАБЛИЦ
        private void CrearteTablet()
        {
            outDGV1.Rows.Clear();

            fulContent = new string[stringMassive.Length][];
            bookContent = new string[booksMassive.Length][];
            readersContent = new string[readersMassive.Length][];
            bookName = new string[bookContent.GetLength(0), 2];
            fio = new string[readersMassive.Length, 2];
            fioCB.Items.Clear();
            bookNameCB.Items.Clear();




            for (int i = 0; i < booksMassive.Length; i++)
            {
                bookContent[i] = booksMassive[i].Split('@');
                bookName[i, 0] = bookContent[i][0];
                bookName[i, 1] = bookContent[i][2];
                bookNameCB.Items.Add(bookName[i, 1]);

            }

            for (int i = 0; i < readersMassive.Length; i++)
            {
                readersContent[i] = readersMassive[i].Split('@');
                fio[i, 0] = readersContent[i][0];
                fio[i, 1] = readersContent[i][1];
                fioCB.Items.Add(fio[i, 1]);
            }

            for (int i = 0; i < stringMassive.Length; i++)
            {
                fulContent[i] = stringMassive[i].Split('@');
            }




            for (int i = 0; i < stringMassive.Length; i++)
            {
                outDGV1.Rows.Add();
                outDGV1.Rows[i].Cells[0].Value = i + 1;
                for (int j = 0; j < bookName.GetLength(0); j++)
                {
                    if (fulContent[i][0] == bookName[j, 0])
                        outDGV1.Rows[i].Cells[1].Value = bookName[j, 1];
                }
                for (int j = 0; j < fio.GetLength(0); j++)
                {
                    if (fulContent[i][1] == fio[j, 0])
                        outDGV1.Rows[i].Cells[2].Value = fio[j, 1];
                }
                for (int j = 2; j < 4; j++)
                {
                    outDGV1.Rows[i].Cells[j + 1].Value = fulContent[i][j];
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
        //--ЕСЛИ ВСЕ БЫЛО ВВЕДЕНО ВЕРНО, ТО ПЕРЕМЕННЫЕ book И readerFio ПОЛУЧАЮТ ЗНАЧЕНИЯ COMBOX'ОВ-----------------------------
        //--ВСЕ ПОЛЯ "СКЛИВАЮТСЯ" В ОДНУ СТРОКУ В НУЖНОМ ФОРМАТЕ, И ЗАПИСЫВАЮТСЯ В ОСНОВНОЙ МАССИВ ВСЕХ СТРОК ОСНОВНОГО ФАЙЛА---
        //--ВСЕ ПОЛЯ ОТЧИЩЮТСЯ, ЧТОБЫ ПОЛЬЗОВАТЕЛЬ МОГ ВВЕСТИ НОВУЮ ЗАПИСЬ------------------------------------------------------
        private void add_Click(object sender, EventArgs e)
        {


            if (checkTextBoxs() && aaa1 && aaa2)
            {
                string book = "", readerFio = "";
                Array.Resize(ref stringMassive, stringMassive.Length + 1);
                string newLine = "";

                if (indexforbook2 == 1)
                    book = bookName[indexforbook1, 0];
                else if (indexforbook2 == 0)
                    book = bookName[indexforbook1, indexforbook2];

                if (indexforreaders2 == 1)
                    readerFio = fio[indexforreaders1, 0];
                else if (indexforreaders2 == 0)
                    readerFio = fio[indexforreaders1, indexforreaders2];

                newLine += book + "@" + readerFio + "@" + Convert.ToString(textBox3.Text).Trim() + "@" +
                            Convert.ToString(textBox4.Text).Trim();



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
            if (!aaa1)
            {
                MessageBox.Show("Такой книги нет в базе данных. \n Сперва внесите его в таблицу 'Книги'", "Ошибка");
                fioCB.Text = "";
            }
            if (!aaa2)
            {
                MessageBox.Show("Такого читателя нет в базе данных. \n Сперва внесите его в таблицу 'Читатели'", "Ошибка");
                fioCB.Text = "";
            }

        }


        //----------------------------------------------------------------------------ИЗМЕНЕНИЕ ЗАПИСИ--------------------------------------------------------------------------
        //--------КОГДА ПОЛЬЗОВАТЕЛЬ КЛИКАЕТ ПО ЯЧЕЙКЕ, ПРОГРАММА ЗАПОМИНАЕТ НОМЕР СПРОКИ---------------------------------------------------------------------------------------
        //--------ПРИ НАЖАТИИ НА КНОПКУ "ИЗМЕНИТЬ ЗАПИСЬ" ВСЕ ПОЛЯ "СКЛИВАЮТСЯ" В ОДНУ СТРОКУ В НУЖНОМ ФОРМАТЕ, И ЗАПИСЫВАЮТСЯ В ОСНОВНОЙ МАССИВ ВСЕХ СТРОК ОСНОВНОГО ФАЙЛА-----
        //--------ТАБЛИЦА ЗАПИСЫВАЕТСЯ В ОСНОВНОЙ МАССИВ ВСЕХ СТРОК-------------------------------------------------------------------------------------------------------------
        //-----ТАБЛИЦА СТРОИТСЯ ПО НОВЫМ ДАННЫМ---------------------------------------------------------------------------------------------------------------------------------

        private void edit_Click(object sender, EventArgs e)
        {
            if (checkTextBoxs() && aaa1 && aaa2)
            {


                string book = "", readerFio = "";
                string newLine = "";

                if (indexforbook2 == 1)
                    book = bookName[indexforbook1, 0];
                else if (indexforbook2 == 0)
                    book = bookName[indexforbook1, indexforbook2];

                if (indexforreaders2 == 1)
                    readerFio = fio[indexforreaders1, 0];
                else if (indexforreaders2 == 0)
                    readerFio = fio[indexforreaders1, indexforreaders2];

                newLine += book + "@" + readerFio + "@" + Convert.ToString(textBox3.Text).Trim() + "@" +
                            Convert.ToString(textBox4.Text).Trim();

                stringMassive[numberRow] = newLine;

                CrearteTablet();
                numberCell = 0;
                numberRow = 0;
                clearTextBoxs();

            }
           
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
                StreamWriter f = new StreamWriter(@"output.txt", false, System.Text.Encoding.Default);
                for (int i = 0; i < stringMassive.Length; i++)
                {
                    if (i != stringMassive.Length - 1)
                        f.WriteLine(stringMassive[i]);
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
                    StreamWriter f = new StreamWriter(@"output.txt", false, System.Text.Encoding.Default);
                    for (int i = 0; i < stringMassive.Length; i++)
                    {
                        f.WriteLine(stringMassive[i]);
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
            indexof = -1;
            bool search = false;
            string date1 = searchTBX.Text.ToString();
            indexMassive = new int[0];
            for (int i = 0; i < outDGV1.Rows.Count; i++)
            {
                if (date1 == Convert.ToString(outDGV1[3, i].Value.ToString()))
                {
                    search = true;
                    Array.Resize(ref indexMassive, indexMassive.Length + 1);
                    indexMassive[indexMassive.Length - 1] = i;
                }
            }
            if (search)
            {
                indexof = 0;
                outDGV1.CurrentCell = outDGV1.Rows[indexMassive[0]].Cells[0];
                numberRow = outDGV1.CurrentCell.RowIndex;
                rowNumber.Text = Convert.ToString(numberRow + 1);
                bookNameCB.Text = Convert.ToString(outDGV1.Rows[numberRow].Cells[1].Value);
                fioCB.Text = Convert.ToString(outDGV1.Rows[numberRow].Cells[2].Value);
                textBox3.Text = Convert.ToString(outDGV1.Rows[numberRow].Cells[3].Value);
                textBox4.Text = Convert.ToString(outDGV1.Rows[numberRow].Cells[4].Value);
            }
            else
                MessageBox.Show("Записи с такой датой не существует", "Ошибка");

            if (indexMassive.Length > 1)
            {
                nextRow.Enabled = true;
            }
            else
            {
                backRow.Enabled = false;
                nextRow.Enabled = false;
            }




        }
        private void nextRow_Click(object sender, EventArgs e)
        {

            /* for (int i = indexof+1; i < indexMassive.Length; i++)
             {*/
            if (indexof < indexMassive.Length - 1)
            {

                backRow.Enabled = true;

                outDGV1.CurrentCell = outDGV1.Rows[indexMassive[indexof + 1]].Cells[0];
                numberRow = outDGV1.CurrentCell.RowIndex;
                rowNumber.Text = Convert.ToString(numberRow + 1);
                indexof++;
                bookNameCB.Text = Convert.ToString(outDGV1.Rows[numberRow].Cells[1].Value);
                fioCB.Text = Convert.ToString(outDGV1.Rows[numberRow].Cells[2].Value);
                textBox3.Text = Convert.ToString(outDGV1.Rows[numberRow].Cells[3].Value);
                textBox4.Text = Convert.ToString(outDGV1.Rows[numberRow].Cells[4].Value);

            }
            else if (indexof == indexMassive.Length)
            {
                nextRow.Enabled = false;
            }
            //}
        }
        private void backRow_Click(object sender, EventArgs e)
        {
            if (indexof > 0)
            {
                nextRow.Enabled = true;
                indexof--;
                outDGV1.CurrentCell = outDGV1.Rows[indexMassive[indexof]].Cells[0];
                numberRow = outDGV1.CurrentCell.RowIndex;
                rowNumber.Text = Convert.ToString(numberRow + 1);

                bookNameCB.Text = Convert.ToString(outDGV1.Rows[numberRow].Cells[1].Value);
                fioCB.Text = Convert.ToString(outDGV1.Rows[numberRow].Cells[2].Value);
                textBox3.Text = Convert.ToString(outDGV1.Rows[numberRow].Cells[3].Value);
                textBox4.Text = Convert.ToString(outDGV1.Rows[numberRow].Cells[4].Value);

            }
            else
                backRow.Enabled = false;
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


            if (!Regex.IsMatch(Convert.ToString(textBox3.Text).Trim(), date) || !DateTime.TryParse(Convert.ToString(textBox3.Text).Trim(), out DateTime dt1) ||
                textBox3.Text.Length != 10)
            {
                MessageBox.Show(@"Поле [Дата выдачи] было неверно запонено, проверьте правильность введенных данных.
                                    Формат даты: дд/мм/гггг", "", MessageBoxButtons.OK);
                textBox3.Text = "";
                bl = false;
            }
            else if (Convert.ToString(textBox4.Text).Trim().Length != 0)
            {
                if (!Regex.IsMatch(Convert.ToString(textBox4.Text).Trim(), date) || !DateTime.TryParse(Convert.ToString(textBox4.Text).Trim(), out DateTime dt12))
                {
                    MessageBox.Show(@"Поле [Дата возврата] было неверно запонено, проверьте правильность введенных данных.
                                    Формат даты: дд/мм/гггг", "", MessageBoxButtons.OK);
                    textBox4.Text = "";
                    bl = false;
                }
                else
                {
                    //проверка конечной и начальной дат

                    string[][] date0 = new string[1][];
                    string[][] date1 = new string[1][];

                    date0[0] = Convert.ToString(textBox3.Text.ToString()).Split('/');
                    date1[0] = Convert.ToString(textBox4.Text.ToString()).Split('/');


                    if (date0[0][2] == date1[0][2])//год равен
                    {
                        if (int.Parse(date0[0][1]) < int.Parse(date1[0][1]))//конечный месяц больше чем начальный 
                        {
                            bl = true;
                        }
                        else if (int.Parse(date0[0][1]) == int.Parse(date1[0][1]))//месяца равны
                        {
                            if (int.Parse(date0[0][0]) < int.Parse(date1[0][0]) || int.Parse(date0[0][0]) == int.Parse(date1[0][0]))//конечный день больше чем начальный 
                            { bl = true; }
                            else if (int.Parse(date0[0][0]) > int.Parse(date1[0][0]))//начальный день больше чем конечный
                            {
                                bl = false;
                                MessageBox.Show("Дата выдачи не может быть позже чем Дата возврата", "Ошибка");
                                textBox4.Text = "";
                            }

                        }
                        else if (int.Parse(date0[0][1]) > int.Parse(date1[0][1]))//начальный месяц больше чем конечный
                        {
                            bl = false; MessageBox.Show("Дата выдачи не может быть позже чем Дата возврата", "Ошибка");
                            textBox4.Text = "";
                        }

                    }
                    else if (int.Parse(date0[0][2]) < int.Parse(date1[0][2]))//конечный год больше, чем начальный
                    {
                        bl = true;
                    }
                    else if (int.Parse(date0[0][2]) > int.Parse(date1[0][2]))//начальный год больше, чем конечный (ОШИБКА!!!)
                    {
                        bl = false; MessageBox.Show("Дата выдачи не может быть позже чем Дата возврата", "Ошибка");
                        textBox4.Text = "";
                    }
                }


            }
            else if (
               (textBox3.Text.Length != 0 && (Regex.IsMatch(Convert.ToString(textBox3.Text).Trim(), date) && DateTime.TryParse(Convert.ToString(textBox3.Text).Trim(), out DateTime dt) && textBox4.Text.Length == 10)) &&
              ((Regex.IsMatch(Convert.ToString(textBox4.Text).Trim(), date) && DateTime.TryParse(Convert.ToString(textBox4.Text).Trim(), out DateTime dt123) && textBox4.Text.Length == 10) || textBox4.Text.Length == 0))
            {
                bl = true;
            }
            return bl;
        }

        







        //-----------------------------------------"ОТЧИЩЕНИЕ" ВСЕХ ПОЛЕЙ------------------------------------------------------
        //----------ПОЛЯ "ОТЧИЩАЮТСЯ"------------------------------------------------------------------------------------------
        private void clearTextBoxs()
        {
            bookNameCB.Text = "";
            fioCB.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
        //
        //
        //
        //
        //
        //


        //------------------------------------------------------------------------------СОБЫТИЯ----------------------------------------------------------

        //-----------------------------СОБЫТИЕ НА ИЗМЕНЕНИЯ COMBOBOX'А ДЛЯ ФИО ЧИТАТЕЛЯ-------------------------------------------------------------------------------------------------    
        //--С ПОМОЩЬЮ ЗАРАНЕЕ ВВЕДЕНОГО МАССИВА fio ДЕЛАЕТСЯ ПРОВЕРКА ЗНАЧЕНИЯ ВВЕДЕНОГО В ПОЛЕ-----------------------------------------------------------------------------------------  
        //--ЕСЛИ ВВЕДЕННОЕ ЗНАЧЕНИЕ НЕ НЕ ВСРЕЧАЕТСЯ В НАБОРЕ № ПАСПОРТОВ ИЛИ В ФИО ЧИТАТЕЛЯХ, ТО ПРОГРАММА СООБЩАЕТ, ЧТО ТАКОГО ЧИТАТЕЛЯ НЕТ В БАЗЕ ДАННЫХ И СЛЕДУЕТ СПЕРВА ОБНОВИТЬ ЕЁ

        private void fioCB_TextChanged(object sender, EventArgs e)
        {
           
            if (Convert.ToString(fioCB.Text).Trim() != "" || Convert.ToString(fioCB.Text).Trim().Length ==6)
            {


                for (int i = 0; i < fio.GetLength(0); i++)
                    for (int j = 0; j < fio.GetLength(1); j++)
                        if (fio[i, j] == Convert.ToString(fioCB.Text).Trim())
                        {
                            aaa2 = true;
                            if (aaa2)
                            {
                                indexforreaders1 = i;
                                indexforreaders2 = j;
                            }

                        }

                


            }
        }
        //Если поле поиска пустое то кнопка заблокирована, иначе разблокирована
        private void searchTBX_TextChanged(object sender, EventArgs e)
        {
            if (searchTBX.Text.Length > 0)
                search.Enabled = true;
            else if (searchTBX.Text.Length == 0)
                search.Enabled = false;
        }

        //-----------------------------СОБЫТИЕ НА ИЗМЕНЕНИЯ COMBOBOX'А ДЛЯ НАЗВАНИЯ КНИГИ--------------------------------------------------------------------------------------------   
        //--С ПОМОЩЬЮ ЗАРАНЕЕ ВВЕДЕНОГО МАССИВА bookName ДЕЛАЕТСЯ ПРОВЕРКА ЗНАЧЕНИЯ ВВЕДЕНОГО В ПОЛЕ---------------------------------------------------------------------------------  
        //--ЕСЛИ ВВЕДЕННОЕ ЗНАЧЕНИЕ НЕ НЕ ВСРЕЧАЕТСЯ В НАБОРЕ № ПАСПОРТОВ ИЛИ В НАЗВАНИЯХ КНИГ, ТО ПРОГРАММА СООБЩАЕТ, ЧТО ТАКОЙ КНИГИ НЕТ В БАЗЕ ДАННЫХ И СЛЕДУЕТ СПЕРВА ОБНОВИТЬ ЕЁ
        private void bookNameCB_TextChanged(object sender, EventArgs e)
        {
          

            if (Convert.ToString(bookNameCB.Text).Trim() != "" || Convert.ToString(bookNameCB.Text).Trim().Length == 6)
            {
                

                for (int i = 0; i < bookName.GetLength(0); i++)
                    for (int j = 0; j < bookName.GetLength(1); j++)
                        if (bookName[i, j] == Convert.ToString(bookNameCB.Text).Trim())
                        {
                            aaa1 = true;
                            if (aaa1)
                            {
                                indexforbook1 = i;
                                indexforbook2 = j;

                            }
                        }



                /*  if (!aaa)
                  {
                      MessageBox.Show("Такой книги нет в базе данных. \n Сперва внесите его в таблицу 'Книги'", "Ошибка");
                      bookNameCB.Text = "";
                  }*/
            }
        }


        //-----------------------------СОБЫТИЕ НА ЗАКРЫТИЕ ФОРМЫ---------------------------------------------------------------------------------------------------------------------
        //------------------ПРИ ЗАКРЫТИИ ФОРМЫ, ПРОГРАММА ПРЕДЛАГАЕТ СОХРАНИТЬ ТАБЛИЦУ-----------------------------------------------------------------------------------------------  


        private void Output_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Вы хотите сохранить  таблицу?", "ВНИМАНИЕ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                StreamWriter f = new StreamWriter(@"output.txt", false, System.Text.Encoding.Default);
                for (int i = 0; i < stringMassive.Length; i++)
                {
                    if (i != stringMassive.Length - 1)
                        f.WriteLine(stringMassive[i]);
                    else
                        f.Write(stringMassive[i]);
                }
                f.Close();
                MessageBox.Show("Таблица успешно сохранена", "");
            }
        }


        //-------------------------СОБИТЕ НА "ЩЕЛЧОК" ПО ЯЧЕЙКЕ ТАБЛИЦЫ--------------------------------------
        //-----------------------ПРИ ВЫБОРЕ ЯЧЕЙКИ, В ПОЛЯ ЗАНОСЯТСЯ ДАННЫЕ ИЗ СООТВЕТСТВУЮЩЕЙ СТРОКИ ТАБЛИЦЫ
        //---------------------ТАКЖЕ ПРОГРАММА ЗАПОМИНАЕТ ВЫБРАННЫЙ СТОЛБЕЦ И СТРОКУ-------------------------

        private void outDGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numberCell = outDGV1.CurrentCell.ColumnIndex;
            numberRow = outDGV1.CurrentCell.RowIndex;

            rowNumber.Text = Convert.ToString(numberRow + 1);
            //------------При выборе ячейки в textbox'ы заносится вся информация из них------------------------

            bookNameCB.Text = Convert.ToString(outDGV1.Rows[numberRow].Cells[1].Value);
            fioCB.Text = Convert.ToString(outDGV1.Rows[numberRow].Cells[2].Value);
            textBox3.Text = Convert.ToString(outDGV1.Rows[numberRow].Cells[3].Value);
            textBox4.Text = Convert.ToString(outDGV1.Rows[numberRow].Cells[4].Value);

        }






    }
}
