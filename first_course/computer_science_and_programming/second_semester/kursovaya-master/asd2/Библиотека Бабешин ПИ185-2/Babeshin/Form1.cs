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

namespace Babeshin
{
    public partial class Form1 : Form
    {
        public Font fonts;
        public FontStyle styles;
        public Color colors, foreColors;
        public Font font
        {
            get { return fonts; }
            set { fonts = Font; }
        }
        public Color color
        {
            get { return colors; }
            set { colors = BackColor; }
        }
        public Color foreColor
        {
            get { return foreColors; }
            set { foreColors = ForeColor; }
        }
        public FontStyle style
        {
            get { return styles; }
            set { styles = Font.Style; }
        }


        public Form1()
        {
            InitializeComponent();
        }
        private void readers_Click(object sender, EventArgs e)
        {
            Form1 param = new Form1();
            Form readers = new readersForm();
            readers.ForeColor = ForeColor;
            readers.BackColor = BackColor;
            readers.Font = new Font(Font.Name, 8, FontStyle.Bold);
            readers.ShowDialog();
        }

        private void books_Click(object sender, EventArgs e)
        {
            Form booksForm = new booksForm();
            booksForm.ForeColor = ForeColor;
            booksForm.BackColor = BackColor;
            booksForm.Font = new Font(Font.Name, 8, FontStyle.Bold);
            booksForm.ShowDialog();
        }

        private void Output_Click(object sender, EventArgs e)
        {
            Form Output = new Output();
            Output.ForeColor = ForeColor;
            Output.BackColor = BackColor;
            Output.Font = new Font(Font.Name, 8, FontStyle.Bold);
            Output.ShowDialog();
        }

        private void itog_Click(object sender, EventArgs e)
        {
            Form itog = new itog();
            itog.ForeColor = ForeColor;
            itog.BackColor = BackColor;
            itog.Font = new Font(Font.Name,8, FontStyle.Bold);
            itog.ShowDialog();
        }

        private void subitog_Click(object sender, EventArgs e)
        {
            Form subtab = new Subtabs();
            subtab.ForeColor = ForeColor;
            subtab.BackColor = BackColor;
            subtab.Font = new Font(Font.Name,8, FontStyle.Bold); 
            subtab.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Вы хотите закрыть программу?", "ВНИМАНИЕ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void booksFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Application.StartupPath.ToString()+"\\books.txt", "Расположение файла и его имя", MessageBoxButtons.OK);
        }

        private void readersFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Application.StartupPath.ToString() + "\\readers.txt", "Расположение файла и его имя", MessageBoxButtons.OK);
        }

        private void outputFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Application.StartupPath.ToString() + "\\output.txt", "Расположение файла и его имя", MessageBoxButtons.OK);
        }

        private void About_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] options = new string[4];
            string nameFile = @"options.txt";

            StreamReader f = new StreamReader(nameFile, Encoding.Default);
            options = f.ReadLine().Split('@');
            f.Close();
            // Color myColor = System.Drawing.ColorTranslator.FromHtml("Red");
            Font = new Font(options[1], float.Parse(options[2]), FontStyle.Bold);
            BackColor = ColorTranslator.FromHtml(options[0]);
            ForeColor = ColorTranslator.FromHtml(options[3]);
            ChangeColor();
        }

        private void parametr_Click(object sender, EventArgs e)
        {
            
            parametrs param = new parametrs();
            param.color = this.BackColor;
            param.font = this.Font;
            param.foreColor = this.ForeColor;
            param.style = this.Font.Style;
            param.ShowDialog();

           
            

            BackColor = param.color;
            ForeColor = param.foreColor;
            Font = param.font;

            Font = new Font(Font.Name, 8, FontStyle.Bold);
            //   this.Font. = param.style;
           
            ChangeColor();


        }

        private void informAbout_Click(object sender, EventArgs e)
        {
            DialogResult infBox = MessageBox.Show("\tВЕРСИЯ 1.0\n\rГотовое решение для автоматизации учета выдач книг \n в библиотеке <<Библиотека>>. \nB этой версии присутствуют возможности удаления,добавления, редактирования и поиска записей.", "Информация о данном продукте", MessageBoxButtons.OK);
            
        }

        private void requests_Click(object sender, EventArgs e)
        {
            request req = new request();
            req.ForeColor = ForeColor;
            req.BackColor = BackColor;
            req.Font = new Font(Font.Name, 8, FontStyle.Bold);
            req.ShowDialog();
        }

        public void ChangeColor()
        {
            menuStrip1.BackColor = BackColor;
            menuStrip1.ForeColor = ForeColor;
            toolStripMenuItem1.BackColor = BackColor;
            toolStripMenuItem1.ForeColor = ForeColor;
            toolStripMenuItem1.Font = new Font(Font.Name, 8, FontStyle.Regular);
            menuStrip1.Font = new Font(Font.Name, 8, FontStyle.Regular);
            groupBox2.Font = new Font(Font.Name, 8, FontStyle.Regular);
            groupBox2.BackColor = BackColor;
            groupBox2.ForeColor = ForeColor;
            groupBox1.Font = new Font(Font.Name, 8, FontStyle.Regular);
            groupBox1.ForeColor = ForeColor;
            groupBox1.BackColor = BackColor;
            if (BackColor == Color.FromArgb(64, 64, 64) || BackColor == Color.White|| BackColor == ColorTranslator.FromHtml("#ff404040"))
            {
                readers.BackColor = Color.FromArgb(64, 64, 64);
                readers.ForeColor = Color.White;
                books.BackColor = Color.FromArgb(64, 64, 64);
                books.ForeColor = Color.White;
                Output.BackColor = Color.FromArgb(64, 64, 64);
                Output.ForeColor = Color.White;
                itog.BackColor = Color.Silver;
                itog.ForeColor = Color.Black;
                subitog.BackColor = Color.Silver;
                subitog.ForeColor = Color.Black;
                requests.BackColor = Color.Silver;
                requests.ForeColor = Color.Black;
                toolStripMenuItem1.ForeColor = Color.White;
                menuStrip1.ForeColor = Color.White; 
            }
            else if (BackColor == Color.LightSkyBlue)
            {
                readers.BackColor = Color.DeepSkyBlue;
                readers.ForeColor = Color.Black;
                books.BackColor = Color.DeepSkyBlue;
                books.ForeColor = Color.Black;
                Output.BackColor = Color.DeepSkyBlue;
                Output.ForeColor = Color.Black;
                itog.BackColor = Color.LightSteelBlue;
                itog.ForeColor = Color.Black;
                subitog.BackColor = Color.LightSteelBlue;
                subitog.ForeColor = Color.Black;
                requests.BackColor = Color.LightSteelBlue;
                requests.ForeColor = Color.Black;
            }
            else if (BackColor == Color.BurlyWood)
            {
                readers.BackColor = Color.DarkKhaki;
                readers.ForeColor = Color.Black;
                books.BackColor = Color.DarkKhaki;
                books.ForeColor = Color.Black;
                Output.BackColor = Color.DarkKhaki;
                Output.ForeColor = Color.Black;
                itog.BackColor = Color.NavajoWhite;
                itog.ForeColor = Color.Black;
                subitog.BackColor = Color.NavajoWhite;
                subitog.ForeColor = Color.Black;
                requests.BackColor = Color.NavajoWhite;
                requests.ForeColor = Color.Black;
            }
            if (BackColor == Color.White)
            {
                toolStripMenuItem1.ForeColor = Color.Black;
                menuStrip1.ForeColor = Color.Black;
            }
        }
    }
}
