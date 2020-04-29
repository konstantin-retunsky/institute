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
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Collections;

namespace Babeshin
{
    public partial class itog : Form
    {


        public int numberCell, numberRow;
        string[] booksMassive, readersMassive, outputMassive;
        string[][] bookContent, readersContent, outputContent;
        int bookEmpty, dateLose;
        List<int> index_book_date_lose;
        int[] indexEmptyBooks, dateLoseBooks;

        private void returnTab_Click(object sender, EventArgs e)
        {
            show2.Visible = true;
            CrearteTablet();
            returnTab.Visible = false;
            showEmptyBooks.Visible = true;
            CreteDoc.Visible = false;
        }





       

        public itog()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void itog_Load(object sender, EventArgs e)
        {
            OpenFile();
            CrearteTablet();
            allEmptyBook.Text = "";
            label5.Text = "";
            returnTab.Visible = false;          
            itogDGV1.ForeColor = Color.Black;
            returnTab.BackColor = Color.Black;
            returnTab.ForeColor = Color.White;
            show2.BackColor = Color.Black;
            show2.ForeColor = Color.White;
            showEmptyBooks.BackColor = Color.Black;
            showEmptyBooks.ForeColor = Color.White;
            label1.BackColor = Color.White;
            label2.BackColor = Color.White;
            label3.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.BackColor = Color.White;
            label4.ForeColor = Color.Black;
            label5.BackColor = Color.Black;
            label5.ForeColor = Color.White;
            allLines.BackColor = Color.Black;
            allLines.ForeColor = Color.White;
            allEmptyBook.BackColor = Color.Black;
            allEmptyBook.ForeColor = Color.White;
        }

    
        private void CreteDoc_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dateLose; i++)
                {
                    string name1 = itogDGV1[2, i].Value.ToString();
                    string date = DateTime.Now.ToShortDateString().ToString();
                    double money = Math.Round((Convert.ToDateTime(DateTime.Now.ToShortDateString()) - Convert.ToDateTime(outputContent[index_book_date_lose[i]][2].ToString())).TotalDays - 15, 2);
                    var wordApp = new Word.Application();
                    wordApp.Visible = false;
                    var wordDocument = wordApp.Documents.Add(@"" + Application.StartupPath.ToString() + @"\mulct.dot");
                    RepalceWord("{name}", name1, wordDocument);
                    RepalceWord("{name}", name1, wordDocument);
                    RepalceWord("{days}", ((Convert.ToDateTime(DateTime.Now.ToShortDateString()) - Convert.ToDateTime(outputContent[index_book_date_lose[i]][2].ToString())).TotalDays - 15).ToString(), wordDocument);
                    RepalceWord("{book}", itogDGV1[1, i].Value.ToString(), wordDocument);
                    RepalceWord("{money}", money.ToString(), wordDocument);
                    RepalceWord("{date}", date, wordDocument);


                    wordApp.Visible = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void RepalceWord(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);

        }

        // КНОПКА ФОРМИРОВАНИЯ ОТЧЕТА
        Word.Application oWord = new Word.Application();

        private void itogDGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numberCell = itogDGV1.CurrentCell.ColumnIndex;
            numberRow = itogDGV1.CurrentCell.RowIndex;
            //------------При выборе ячейки в textbox'ы заносится вся информация из них------------------------




            for (int j = 0; j < readersContent.GetLength(0); j++)
            {
                if (readersContent[j][0] == outputContent[numberRow][1])
                {
                    textBox1.Text = readersContent[j][5];
                }
            }

        }

        //---------------------------------------------ОТКРЫТИЕ ФАЙЛОВ-------------------------------------------
        //-------ВСЕ ФАЙЛЫ ОТКРЫВАЮТСЯ СРАЗУ ПРИ ЗАГРУСКЕ ФОРМЫ--------------------------------------------------
        //------И ЗАПОНЯЮТЯС МАССИВЫ СООТВЕТСВУЮЩИМИ ДАННЫМИ, ДЛЯ ПОДСТАНОВСКИ И СВЯЗИ ВСЕХ ТАБЛИЦ---------------
        private void OpenFile()
        {
            StreamReader outputs = new StreamReader(@"output.txt", Encoding.Default);
            outputMassive = outputs.ReadToEnd().Split('\n');
            outputs.Close();
            outputMassive = outputMassive.Where(x => x != "").ToArray();
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
            index_book_date_lose = new List<int>();
            bookEmpty = 0;
            dateLose = 0;
            indexEmptyBooks = new int[0];
            dateLoseBooks = new int[0];
            //инициализация массивов со всеми данными
            //из строк, считанных из файлов
            bookContent = new string[booksMassive.Length][];
            readersContent = new string[readersMassive.Length][];
            outputContent = new string[outputMassive.Length][];
            //заполнение массивов данными из строк с разделителем "@"
            //КНИГИ
            for (int i = 0; i < bookContent.GetLength(0); i++)
            {
                bookContent[i] = booksMassive[i].Split('@');
                Convert.ToString(bookContent[i].ToString());
            }
            //ЧИТАТЕЛИ
            for (int i = 0; i < readersContent.GetLength(0); i++)
            {
                readersContent[i] = readersMassive[i].Split('@');
                Convert.ToString(readersContent[i].ToString());
            }
            //Создание таблицы
            itogDGV1.Rows.Clear();
            //ВЫДАЧИ
            for (int i = 0; i < outputContent.GetLength(0); i++)
            {
                outputContent[i] = outputMassive[i].Split('@');
                itogDGV1.Rows.Add();
                for (int j = 0; j < bookContent.GetLength(0); j++)
                {
                    if (bookContent[j][0] == outputContent[i][0])
                    {//заполняюся полей автор и название книги в соответствии с № паспорта в выдачах
                        itogDGV1.Rows[i].Cells[0].Value = bookContent[j][1];
                        itogDGV1.Rows[i].Cells[1].Value = bookContent[j][2];
                    }
                }
                for (int j = 0; j < readersContent.GetLength(0); j++)
                {
                    if (readersContent[j][0] == outputContent[i][1])
                    {//заполнение Фио и адрес проживания в соответствии с № паспорта в выдачах 
                        itogDGV1.Rows[i].Cells[2].Value = readersContent[j][1];
                        itogDGV1.Rows[i].Cells[3].Value = readersContent[j][2];
                    }
                }
                itogDGV1.Rows[i].Cells[4].Value = outputContent[i][2];//заполнение даты выдачи
                itogDGV1.Rows[i].Cells[5].Value = outputContent[i][3];//заполнение даты возврата
                if (outputContent[i][3].Length < 10 || Convert.ToString(outputContent[i][3].ToString()) == "")
                {//посчет несданных книг
                    bookEmpty++;
                    Array.Resize(ref indexEmptyBooks, indexEmptyBooks.Length + 1);
                    indexEmptyBooks[indexEmptyBooks.Length - 1] = i;
                }
                if ((outputContent[i][3].Length < 10 || Convert.ToString(outputContent[i][3].ToString()) == "") && (DateTime.Now - Convert.ToDateTime(outputContent[i][2].ToString())).TotalDays > 15)
                {//подсчет просроченных книг
                    dateLose++;
                    Array.Resize(ref dateLoseBooks, dateLoseBooks.Length + 1);
                    dateLoseBooks[dateLoseBooks.Length - 1] = i;
                    index_book_date_lose.Add(i);
                }
            }
            allLines.Text = Convert.ToString(outputContent.GetLength(0));
            allEmptyBook.Text = Convert.ToString(bookEmpty);
            label5.Text = Convert.ToString(dateLose);
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


        //---------------------------------------------------------КНОПКА ПОКАЗА ВСЕХ ЗАПИСЕЙ С НЕСДАННЫМИ КНИГАМИ--------------------------
        //-----В МАССИВ  indexEmptyBooks ЗАПИСЫВАЮТСЯ ИНДЕКСЫ ЗАПИСЕЙ С ПУСТОЙ СТРОКОЙ "ДАТА СДАЧИ"-----------------------------------------

        private void showEmptyBooks_Click(object sender, EventArgs e)
        {
            itogDGV1.Rows.Clear();
            for (int A = 0; A < indexEmptyBooks.Length; A++)
            {
                itogDGV1.Rows.Add();
                int a = indexEmptyBooks[A];
                for (int j = 0; j < bookContent.GetLength(0); j++)
                {
                    if (bookContent[j][0] == outputContent[a][0])
                    {
                        itogDGV1.Rows[A].Cells[0].Value = bookContent[j][1];
                        itogDGV1.Rows[A].Cells[1].Value = bookContent[j][2];
                    }
                }
                for (int j = 0; j < readersContent.GetLength(0); j++)
                {
                    if (readersContent[j][0] == outputContent[a][1])
                    {
                        itogDGV1.Rows[A].Cells[2].Value = readersContent[j][1];
                        itogDGV1.Rows[A].Cells[3].Value = readersContent[j][2];
                    }
                }

                itogDGV1.Rows[A].Cells[4].Value = outputContent[a][2];
                itogDGV1.Rows[A].Cells[5].Value = outputContent[a][3];
            }
            returnTab.Visible = true;
            showEmptyBooks.Visible = false;


        }
        private void show2_Click(object sender, EventArgs e)
        {
            CreteDoc.Visible = true;
            itogDGV1.Rows.Clear();
            for (int A = 0; A < dateLoseBooks.Length; A++)
            {
                itogDGV1.Rows.Add();
                int a = dateLoseBooks[A];
                for (int j = 0; j < bookContent.GetLength(0); j++)
                {
                    if (bookContent[j][0] == outputContent[a][0])
                    {
                        itogDGV1.Rows[A].Cells[0].Value = bookContent[j][1];
                        itogDGV1.Rows[A].Cells[1].Value = bookContent[j][2];
                    }
                }
                for (int j = 0; j < readersContent.GetLength(0); j++)
                {
                    if (readersContent[j][0] == outputContent[a][1])
                    {
                        itogDGV1.Rows[A].Cells[2].Value = readersContent[j][1];
                        itogDGV1.Rows[A].Cells[3].Value = readersContent[j][2];
                    }
                }

                itogDGV1.Rows[A].Cells[4].Value = outputContent[a][2];
                itogDGV1.Rows[A].Cells[5].Value = outputContent[a][3];
            }
            returnTab.Visible = true;
            show2.Visible = false;

        }


    }
}
