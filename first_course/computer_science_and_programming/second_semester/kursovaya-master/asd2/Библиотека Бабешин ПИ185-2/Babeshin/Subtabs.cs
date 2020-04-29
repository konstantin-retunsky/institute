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
    public partial class Subtabs : Form
    {

        public int numberCell, numberRow, emptyDatetwo;
        string[] booksMassive, readersMassive, outputMassive, pasportNumb;
        string[][] bookContent, readersContent, outputContent;
        int booklose;
        List<int> index_book_date_lose;

        private void button1_Click(object sender, System.EventArgs e)
        { }
        // КНОПКА ФОРМИРОВАНИЯ ОТЧЕТА
        Word.Application oWord = new Word.Application();

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < emptyDatetwo; i++)
                {
                    string name1 = readersList.Text.ToString();
                    string date = DateTime.Now.ToShortDateString().ToString();
                    double money = Math.Round((Convert.ToDateTime(DateTime.Now.ToShortDateString()) - Convert.ToDateTime(outputContent[index_book_date_lose[i]][2].ToString())).TotalDays - 15, 2);
                    var wordApp = new Word.Application();
                    wordApp.Visible = false;
                    var wordDocument = wordApp.Documents.Add(@"" + Application.StartupPath.ToString() + @"\mulct.dot");
                    RepalceWord("{name}", name1, wordDocument);
                    RepalceWord("{name}", name1, wordDocument);
                    RepalceWord("{days}", ((Convert.ToDateTime(DateTime.Now.ToShortDateString()) - Convert.ToDateTime(outputContent[index_book_date_lose[i]][2].ToString())).TotalDays - 15).ToString(), wordDocument);
                    RepalceWord("{book}", subtab[0, i].Value.ToString(), wordDocument);
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


        public Subtabs()
        {
            InitializeComponent();
        }

        private void readersList_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = true;
            /**/
        }

        private void readersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabCreate();
            label2.Text = "Книги, которые брал " + readersList.Items[readersList.SelectedIndex];
            label3.Text = "Количество взятых книг : " + pasportNumb.Length;
            label4.Text = "Количество просроченых книг : " + emptyDatetwo;
            label5.Text = "Количество не сданых книг : " + booklose;
            createdoc.Enabled = true;
            if (readersList.SelectedIndex == -1)
                createdoc.Enabled = false;
            if (emptyDatetwo > 0)
                createdoc.Enabled = true;
            else
                createdoc.Enabled = false;
            if (!createdoc.Enabled)
                createdoc.BackColor = Color.FromArgb(120, 141, 139);
            else
                createdoc.BackColor = DefaultBackColor;
        }

        private void Subtabs_Load(object sender, EventArgs e)
        {
            createdoc.Enabled = false;
            OpenFile();
            createList();
            subtab.ForeColor = Color.Black;
            createdoc.ForeColor = Color.Black;

        }



        private void OpenFile()
        {
            StreamReader outputs = new StreamReader(@"output.txt", Encoding.Default);
            outputMassive = outputs.ReadToEnd().Split('\n');
            outputs.Close();
            if (outputMassive.Length == 1 && outputMassive[outputMassive.Length - 1] == "")
            {
                outputMassive[outputMassive.Length - 1] = "111111@Название@ФИО@01/01/2010";
            }
            outputMassive = outputMassive.Where(x => x != "").ToArray();


            StreamReader books = new StreamReader(@"books.txt", Encoding.Default);
            booksMassive = books.ReadToEnd().Split('\n');
            books.Close();

            StreamReader readers = new StreamReader(@"readers.txt", Encoding.Default);
            readersMassive = readers.ReadToEnd().Split('\n');
            readers.Close();
        }

        private void createList()
        {

            readersContent = new string[readersMassive.Length][];

            for (int i = 0; i < readersMassive.Length; i++)
            {
                readersContent[i] = readersMassive[i].Split('@');
                readersList.Items.Add(readersContent[i][1]);
            }
            //    readersList.Text = Convert.ToString(readersList.Items[0]);

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
            }

            //ЧИТАТЕЛИ
            for (int i = 0; i < readersContent.GetLength(0); i++)
            {
                readersContent[i] = readersMassive[i].Split('@');
            }


            //ВЫДАЧИ
            for (int i = 0; i < outputContent.GetLength(0); i++)
            {
                outputContent[i] = outputMassive[i].Split('@');
            }
        }

        private void tabCreate()
        {
            index_book_date_lose = new List<int>();
            booklose = 0;
            emptyDatetwo = 0;
            string pasportNumber = "";
            subtab.Rows.Clear();

            for (int i = 0; i < readersContent.GetLength(0); i++)
            {
                if (readersList.Items[readersList.SelectedIndex].ToString() == readersContent[i][1])
                {
                    pasportNumber = readersContent[i][0];
                   

                }

            }

            pasportNumb = new string[0];


            for (int i = 0; i < outputContent.GetLength(0); i++)
            {
                if (pasportNumber == outputContent[i][1])
                {
                    Array.Resize(ref pasportNumb, pasportNumb.Length + 1);
                    pasportNumb[pasportNumb.Length - 1] = outputMassive[i];
                    if ((outputContent[i][3].Length < 10 || outputContent[i][3].ToString() == "") && (DateTime.Now - Convert.ToDateTime(outputContent[i][2].ToString())).TotalDays > 15)
                    {
                        emptyDatetwo++;
                        index_book_date_lose.Add(i);
                    }
                    if (outputContent[i][3].Length < 10 || outputContent[i][3].ToString() == "")
                        booklose++;
                }
            }



            string[][] outputContentTwo = new string[pasportNumb.Length][];

            for (int i = 0; i < pasportNumb.Length; i++)
            {
                outputContentTwo[i] = pasportNumb[i].Split('@');
                
            }


            for (int i = 0; i < pasportNumb.Length; i++)
            {
                subtab.Rows.Add();
                for (int j = 0; j < bookContent.GetLength(0); j++)
                {
                    if (bookContent[j][0] == outputContentTwo[i][0])
                    {
                        subtab.Rows[i].Cells[0].Value = bookContent[j][2];
                        subtab.Rows[i].Cells[1].Value = bookContent[j][1];

                    }
                }
                subtab.Rows[i].Cells[2].Value = outputContentTwo[i][2];
                subtab.Rows[i].Cells[3].Value = outputContentTwo[i][3];

            }
        }
    }
}
