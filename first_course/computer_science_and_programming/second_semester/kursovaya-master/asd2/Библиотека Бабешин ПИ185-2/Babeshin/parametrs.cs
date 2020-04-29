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

namespace Babeshin
{

    public partial class parametrs : Form
    {
        public ColorDialog Colors;
        public FontDialog Fonts;
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

        public parametrs()
        {
            InitializeComponent();
        }

        private void parametrs_Load(object sender, EventArgs e)
        {

            string nameFile = @"options.txt";

            StreamReader f = new StreamReader(nameFile, Encoding.Default);
            string[] options = f.ReadLine().Split('@');
            f.Close();
            fonts = new Font(options[1], float.Parse(options[2]), FontStyle.Bold);
            colors = ColorTranslator.FromHtml(options[0]);
            foreColors = ColorTranslator.FromHtml(options[3]);

            Form1 main = new Form1();
            comboBox1.Text = comboBox1.SelectedText;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Colors = new ColorDialog();
            Colors.AllowFullOpen = true;
            Colors.ShowHelp = true;
            Colors.Color = colors;

            if (Colors.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = Colors.Color;
                colors = Colors.Color;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
           
            Fonts = new FontDialog();
            Fonts.ShowColor = true;

            Fonts.Font = fonts;
            Fonts.Color = foreColors;
            if (Fonts.ShowDialog() != DialogResult.Cancel)
            {
                textBox1.Text = Fonts.Font.ToString().Substring(12) + "\r";
                textBox1.Text += Fonts.Color.ToString();
                fonts = Fonts.Font;
                foreColors = Fonts.Color;
                styles = Fonts.Font.Style;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.SelectedText;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    fonts = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);
                    foreColors = Color.White;
                    colors = Color.FromArgb(64, 64, 64);
                    styles = FontStyle.Bold;
                    break;
                case 1:
                    fonts = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular);
                    foreColors = Color.Black;
                    colors = Color.White;
                    styles = FontStyle.Regular;
                    break;
                case 2:
                    fonts = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular);
                    foreColors = Color.Black;
                    colors = Color.LightSkyBlue;
                    styles = FontStyle.Bold;
                    break;
                case 3:
                    fonts = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular);
                    foreColors = Color.Black;
                    colors = Color.BurlyWood;
                    styles = FontStyle.Bold;
                    break;
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            infText.Text = tabControl1.SelectedTab.Text;
        }

        private void SAVEPARAMS_Click(object sender, EventArgs e)
        {
            
           string options;
            StreamWriter f = new StreamWriter(@"options.txt", false, System.Text.Encoding.Default);
            if (new Regex(@"\d").IsMatch(colors.Name.ToString()) == true)
                options = "#" + colors.Name.ToString() + "@" + fonts.Name.ToString() + "@" + Font.Size.ToString() +"@"+ foreColors.Name.ToString();
            else
                options = colors.Name.ToString() + "@" + fonts.Name.ToString() + "@" + Font.Size.ToString() + "@" + foreColors.Name.ToString();
            f.Write(options);

            f.Close();
           
           // MessageBox.Show(colors.ToString() +"\n\r"+ fonts.ToString() + "\n\r"+ styles.ToString(), "ВНИМАНИЕ");
            Close();




        }
    }
}
