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
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;

namespace Babeshin
{
    public partial class request : Form
    {

        string[] booksMassive, readersMassive, outputMassive, dateYear;

        string[][] bookContent, readersContent, outputContent;
        string[] clmnName_for_readers = { "ФИО", "АДРЕС ПРОЖИВАНИЯ", "ДАТА РОЖДЕНИЯ", "ТЕЛЕФОН" };
        string[] clmnName = { "Автор", "Название", "Дата издания", "Издательство" };
        string selectYear, selectMonth;
        string[][] dateContent, dateContent_2;
        string[] m_Name = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
        string[] m_Numb = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
        Dictionary<string, string> mounthName;
        Dictionary<string, int> countTable, countTable_for_readers, countTable_for_mounth;
        int exclus;
        List<string> dateMonth;
        Dictionary<string, int> newLiist; // новая коллекция для люимых читателей
        Dictionary<string, int> newList_2;//новая коллекция для самых читаемых книг
        public request()
        {
            InitializeComponent();
        }



        private void request_Load(object sender, EventArgs e)
        {
            label3.Text = "";
            OpenFile();
            showDate.Enabled = false;
            mainGrid.ForeColor = Color.Black;
            showDate.BackColor = Color.Black;
            showDate.ForeColor = Color.White;
            showAutor.BackColor = Color.Black;
            showAutor.ForeColor = Color.White;
            showBook.BackColor = Color.Black;
            showBook.ForeColor = Color.White;
            bestReader.BackColor = Color.Black;
            bestReader.ForeColor = Color.White;
            search_month.BackColor = Color.Black;
            search_month.ForeColor = Color.White;
            groupBox1.BackColor = Color.DarkGray;
            statistics.BackColor = Color.Black;
            statistics.ForeColor = Color.White;

        }



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

            createMass();
        }


        private void createMass()
        {
            dateContent = new string[outputMassive.Length][];
            dateContent_2 = new string[outputMassive.Length][];
            outputContent = new string[outputMassive.Length][];
            dateYear = new string[outputMassive.Length];
            dateMonth = new List<string>();
            bookContent = new string[booksMassive.Length][];
            readersContent = new string[readersMassive.Length][];



            for (int i = 0; i < 12; i++)
            {
                dateMonth.Add(m_Numb[i]);
            }

            //Разбор массива со строками выдачами на ступенчатый массив
            for (int i = 0; i < outputMassive.Length; i++)
            {
                outputContent[i] = outputMassive[i].Split('@');
                dateContent[i] = outputContent[i][2].Split('/');
                dateYear[i] = Convert.ToString(dateContent[i][2].ToString());
                dateContent_2[i] = outputContent[i][3].Split('/');
            }
            //Разбор массива со строками книг на ступенчатый массив
            for (int i = 0; i < booksMassive.Length; i++)
            {
                bookContent[i] = booksMassive[i].Split('@');
            }
            //Разбор массива со строками читатели на ступенчатый массив
            for (int i = 0; i < readersMassive.Length; i++)
            {
                readersContent[i] = readersMassive[i].Split('@');
            }

            dateYear = dateYear.Distinct().ToArray();

            foreach (string elem in dateYear) { dateBox.Items.Add(elem); }
            foreach (string elem in dateMonth) { monthBox.Items.Add(elem); }

        }





        //------------------------------------------------------КНОПКИ--------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------


        //------------------------------------------------------Создание excel файла 

        private void statistics_Click(object sender, EventArgs e)

        {
            countTable_for_mounth = new Dictionary<string, int>();
            Dictionary<string, int> date2 = new Dictionary<string, int>();


            Excel.Application excelApp = new Excel.Application();

            Excel.Workbook workBook;
            // Создаём экземпляр листа Excel
            Excel.Worksheet workSheet;
            workBook = excelApp.Workbooks.Add();
            workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

            //----------------------------------

            for (int i = 0; i < outputContent.GetLength(0); i++)
            {
                if (DateTime.TryParse(Convert.ToString(outputContent[i][3].ToString()), out DateTime d1))
                {
                    if (dateContent_2[i].Length > 1)
                        if (!date2.ContainsKey(Convert.ToString(dateContent_2[i][1].ToString())))
                            date2.Add(Convert.ToString(dateContent_2[i][1].ToString()), 1);
                        else date2[Convert.ToString(dateContent_2[i][1].ToString())] += 1;

                }

            }

            for (int i = 0; i < dateContent.GetLength(0); i++)
            {
                int count = 0;
                count++;
                //если ключ (книга) есть в словаре то счетчик увеличивается
                //в противном случае создается новая запись
                if (!countTable_for_mounth.ContainsKey(Convert.ToString(dateContent[i][1].ToString())))
                    countTable_for_mounth.Add(Convert.ToString(dateContent[i][1].ToString()), count);
                else countTable_for_mounth[Convert.ToString(dateContent[i][1].ToString())] += 1;


            }

            string[] headerTB = { "№ месяца", "Кол-во взятых книг", "Кол-во возвращеных книг" };
            for (int i = 0; i < 3; i++)
            {
                workSheet.Cells[1, i + 1] = headerTB[i];
            }
            Excel.Range rng = workSheet.Range["A3:A14"];
            rng.NumberFormat = "@";


            for (int i = 0; i < 12; i++)
            {

                workSheet.Cells[i + 3, 1] = m_Numb[i];
                Excel.Range forYach = workSheet.Cells[i + 3, 1] as Excel.Range;
                //Получаем значение из ячейки и преобразуем в строку
                string yach = forYach.Value2.ToString();

                if (yach == m_Numb[i])
                {

                    if (countTable_for_mounth.ContainsKey(m_Numb[i]))
                    {
                        workSheet.Cells[i + 3, 2] = countTable_for_mounth[m_Numb[i]];

                    }
                    else
                    {
                        workSheet.Cells[i + 3, 2] = 0;

                    }
                    if (date2.ContainsKey(m_Numb[i]))
                        workSheet.Cells[i + 3, 3] = date2[m_Numb[i]];
                    else
                        workSheet.Cells[i + 3, 3] = 0;
                }
            }


            Excel.Range sum = workSheet.Range["B2"];
            sum.Formula = "=SUM(B3:B14)";
            sum.FormulaHidden = false;
            Excel.Range sum_2 = workSheet.Range["C2"];
            sum_2.Formula = "=SUM(C3:C14)";
            sum_2.FormulaHidden = false;


            // Строим круговую диаграмму
            Excel.ChartObjects chartObjs = (Excel.ChartObjects)workSheet.ChartObjects();
            Excel.ChartObject chartObj = chartObjs.Add(200, 50, 300, 300);
            Excel.Chart xlChart = chartObj.Chart;
            Excel.Chart chartPage = chartObj.Chart;

            chartPage.Legend.Position = Excel.XlLegendPosition.xlLegendPositionBottom;
            chartPage.HasTitle = true;
            chartPage.ChartTitle.Text = "Отношение Выдачи / возвраты";
            chartPage.HasLegend = true;
            

            var sc = chartPage.SeriesCollection();
            var series1 = sc.NewSeries();
            series1.Name = "Title";

            object misValue = System.Reflection.Missing.Value;

     

            Excel.Range chartRange = workSheet.Range["B1:C2"];
             xlChart.ChartType = Excel.XlChartType.xlPie;
            xlChart.SetSourceData(chartRange, misValue);


            Excel.Range rng2 = workSheet.Range["B14:C14"];
            // Устанавливаем тип диаграммы

       xlChart.ApplyDataLabels(Excel.XlDataLabelsType.xlDataLabelsShowPercent, Excel.XlDataLabelsType.xlDataLabelsShowLabel, true, false, false, true, false, true);

           
            // Устанавливаем источник данных (значения от 1 до 10)
           // xlChart.SetSourceData(rng2);
            








            excelApp.Visible = true;
            excelApp.UserControl = true;




        }

        //------------------------------------ПОИСК КНИГ ПО ДАТЕ---------------------------------------------------------------

        private void showDate_Click(object sender, EventArgs e)
        {
            exclus = 0;
            selectYear = dateBox.Text;
            selectMonth = monthBox.Text;
            Select_Item(exclus);

        }
        //-------------------------------Поиск месяца-----------------------------------------------------------------------------
        private void search_month_Click(object sender, EventArgs e)
        {

            mounthName = new Dictionary<string, string>();
            for (int i = 0; i < 12; i++)
            {
                mounthName.Add(m_Numb[i], m_Name[i]);
            }
            search_Month();

        }

        //------------------------------Поиск по всем книгам----------------------------------------------------------------------
        private void showBook_Click(object sender, EventArgs e)
        {
            exclus = 0;
            selectYear = 0.ToString();
            selectMonth = 0.ToString();
            Select_Item(exclus);
        }



        //------------------------------Поиск по всем книгам----------------------------------------------------------------------
        private void showAutor_Click(object sender, EventArgs e)
        {
            exclus = 1;
            selectYear = 0.ToString();
            selectMonth = 0.ToString();

            Select_Item(exclus);
        }

        //-------------------------------------------------ЛЮБИМЫЙ ЧИТАТЕЛЬ-----------------------------------------------------------
        private void bestReader_Click(object sender, EventArgs e)
        {
            search_Reader();
        }




        private void search_Month()
        {
            mainGrid.Columns.Clear();
            countTable_for_mounth = new Dictionary<string, int>();
            for (int i = 0; i < 4; i++)
            {
                mainGrid.Columns.Add("column_" + (i + 1), clmnName[i]);
            }
            for (int i = 0; i < dateContent.GetLength(0); i++)
            {
                int count = 0;
                count++;
                //если ключ (книга) есть в словаре то счетчик увеличивается
                //в противном случае создается новая запись
                if (!countTable_for_mounth.ContainsKey(Convert.ToString(dateContent[i][1].ToString()))) countTable_for_mounth.Add(Convert.ToString(dateContent[i][1].ToString()), count);
                else countTable_for_mounth[Convert.ToString(dateContent[i][1].ToString())] += 1;
            }
            var myList = countTable_for_mounth.ToList();
            myList.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
            try
            {
                string mounth = myList.First().Key.ToString();
                mainGrid.Rows.Clear();
                CrearteTablet(mounth, 2);
                label3.Text = "Самый популярный месяц : " + mounthName[mounth].ToString();
            }
            catch {MessageBox.Show("В данный период книги не брались");}}

        private void Select_Item(int exclus)
        {
            mainGrid.Columns.Clear();
            countTable = new Dictionary<string, int>();
            for (int i = 0; i < 4; i++)
            {
                mainGrid.Columns.Add("column_" + (i + 1), clmnName[i]);
            }
            for (int i = 0; i < outputMassive.Length; i++)
            {
                if (Convert.ToString(dateContent[i][2].ToString()) == selectYear && selectMonth == Convert.ToString(dateContent[i][1].ToString()) && selectMonth != "0" && selectYear != "0")//если совпадают даты выдачи книг
                {
                    int count = 0;
                    for (int j = 0; j < booksMassive.Length; j++)
                    {
                        if (Convert.ToString(bookContent[j][0].ToString()) == Convert.ToString(outputContent[i][0].ToString()))
                        {
                            count++;
                            //если ключ (книга) есть в словаре то счетчик увеличивается
                            //в противном случае создается новая запись
                            if (!countTable.ContainsKey(Convert.ToString(outputContent[i][0].ToString()))) countTable.Add(Convert.ToString(outputContent[i][0].ToString()), count);
                            else countTable[Convert.ToString(outputContent[i][0].ToString())] += 1;
                        } }   }
                else if (selectMonth == "0" && selectYear == "0")
                {
                    int count = 0;
                    for (int j = 0; j < booksMassive.Length; j++)
                    {
                        if (Convert.ToString(bookContent[j][0].ToString()) == Convert.ToString(outputContent[i][0].ToString()))
                        {
                            count++;
                            //если ключ (книга) есть в словаре то счетчик увеличивается
                            //в противном случае создается новая запись
                            if (!countTable.ContainsKey(Convert.ToString(outputContent[i][0].ToString()))) countTable.Add(Convert.ToString(outputContent[i][0].ToString()), count);
                            else countTable[Convert.ToString(outputContent[i][0].ToString())] += 1;                }                    }
                }
            }
            //сортировка по значениям
            var myList = countTable.ToList();
            if (exclus == 0)//самая популярная
                myList.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
            else//самая не популярная
                myList.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
            newList_2 = new Dictionary<string, int>();
            try
            {
                string pass = myList.First().Key.ToString();
                int countPass = myList.First().Value;
                foreach (var el in countTable)
                    if (el.Value == countPass)
                        newList_2.Add(el.Key, countTable[el.Key]);
                mainGrid.Rows.Clear();
                CrearteTablet(pass, 0);
                if (selectMonth == "0" && selectYear == "0")
                    label3.Text = "Количество читателей взявших данную книгу : " + myList.First().Value.ToString();
                else
                    label3.Text = "Количество книг взятых за данный период : " + myList.First().Value.ToString();
            }
            catch{MessageBox.Show("В данный период книги не брались");}
        }

        private void search_Reader()
        {
            mainGrid.Columns.Clear();
            countTable_for_readers = new Dictionary<string, int>();
            for (int i = 0; i < 4; i++)
            {
                mainGrid.Columns.Add("column_" + (i + 1), clmnName_for_readers[i]);
            }
            for (int i = 0; i < outputMassive.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < readersMassive.Length; j++)
                {
                    if (Convert.ToString(readersContent[j][0].ToString()) == Convert.ToString(outputContent[i][1].ToString()))
                    {
                        count++;
                        //если ключ (книга) есть в словаре то счетчик увеличивается
                        //в противном случае создается новая запись
                        if (!countTable_for_readers.ContainsKey(Convert.ToString(outputContent[i][1].ToString()))) countTable_for_readers.Add(Convert.ToString(outputContent[i][1].ToString()), count);
                        else countTable_for_readers[Convert.ToString(outputContent[i][1].ToString())] += 1;
                    }
                }
            }
            var myList = countTable_for_readers.ToList();
            myList.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
            newLiist = new Dictionary<string, int>();
            string pass = myList.First().Key.ToString();
            int countPass = myList.First().Value;
            foreach (var el in countTable_for_readers)
                if (el.Value == countPass)                
                    newLiist.Add(el.Key.ToString(), countTable_for_readers[el.Key]);             
            mainGrid.Rows.Clear();
            CrearteTablet(pass, 1);
            label3.Text = "Количество взятых книг : " + myList.First().Value.ToString();
        }

        private void monthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dateBox.Text != "" && monthBox.Text != "") { showDate.Enabled = true; } else showDate.Enabled = false;
        }

        private void dateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dateBox.Text != "" && monthBox.Text != "") { showDate.Enabled = true; } else showDate.Enabled = false;
        }

        private void CrearteTablet(string pas, int book_or_reader)
        {
            mainGrid.Height = 67;
            if (book_or_reader == 0)
            {
                foreach (var elem in newList_2)
                {
                     mainGrid.Rows.Add();
                    if (mainGrid.Height < 154)
                        mainGrid.Height = mainGrid.Height + 20;
                    else
                        mainGrid.Height = 154;

                    for (int i = 0; i < outputMassive.Length; i++)
                    {

                        if (Convert.ToString(outputContent[i][0].ToString()) == elem.Key)
                        {


                            for (int k = 0; k < bookContent.GetLength(0); k++)
                            {

                                if (Convert.ToString(bookContent[k][0].ToString()) == elem.Key)
                                {
                                    mainGrid[0, mainGrid.Rows.Count - 1].Value = bookContent[k][1];
                                    mainGrid[1, mainGrid.Rows.Count - 1].Value = bookContent[k][2];
                                    mainGrid[2, mainGrid.Rows.Count - 1].Value = bookContent[k][3];
                                    mainGrid[3, mainGrid.Rows.Count - 1].Value = bookContent[k][4];

                                }
                            }

                        }
                    }
                }
            }
            else if (book_or_reader == 1)
            {
                mainGrid.Height = 67;
                foreach (var elem in newLiist)
                {
                    mainGrid.Rows.Add();
                    if (mainGrid.Height < 154)
                        mainGrid.Height = mainGrid.Height + 20;
                    else
                        mainGrid.Height = 154;
                    for (int i = 0; i < outputMassive.Length; i++)
                    {

                        if (Convert.ToString(outputContent[i][1].ToString()) == elem.Key)
                        {


                            for (int k = 0; k < readersContent.GetLength(0); k++)
                            {

                                if (Convert.ToString(readersContent[k][0].ToString()) == elem.Key)
                                {

                                    mainGrid[0, mainGrid.Rows.Count - 1].Value = readersContent[k][1];
                                    mainGrid[1, mainGrid.Rows.Count - 1].Value = readersContent[k][2];
                                    mainGrid[2, mainGrid.Rows.Count - 1].Value = readersContent[k][3];
                                    mainGrid[3, mainGrid.Rows.Count - 1].Value = readersContent[k][5];

                                }
                            }

                        }
                    }
                }
            }
            else if (book_or_reader == 2)
            {

                mainGrid.Height = 154;
                for (int i = 0; i < dateContent.GetLength(0); i++)
                {

                    if (Convert.ToString(dateContent[i][1].ToString()) == pas)
                    {
                        mainGrid.Rows.Add();
                        for (int k = 0; k < bookContent.GetLength(0); k++)
                        {
                            if (Convert.ToString(bookContent[k][0].ToString()) == Convert.ToString(outputContent[i][0].ToString()))
                            {

                                mainGrid[0, mainGrid.Rows.Count - 1].Value = bookContent[k][1];
                                mainGrid[1, mainGrid.Rows.Count - 1].Value = bookContent[k][2];
                                mainGrid[2, mainGrid.Rows.Count - 1].Value = bookContent[k][3];
                                mainGrid[3, mainGrid.Rows.Count - 1].Value = bookContent[k][4];
                            }
                        }

                    }
                }
            }



        }
    }
}
