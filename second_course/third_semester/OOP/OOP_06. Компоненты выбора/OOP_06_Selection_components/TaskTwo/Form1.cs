using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTwo {
    public partial class MainForm : Form {
        private int
            dividend,
            divider,
            quotientFromDivision,
            balance;

        public MainForm() {
            InitializeComponent();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e) {

            int pos = ((TextBox)sender).SelectionStart;
            //ввод минуса
            if (e.KeyChar == '-') {
                if (((TextBox)sender).Text.StartsWith("-")) {
                    ((TextBox)sender).Text = ((TextBox)sender).Text.Substring(1);
                    ((TextBox)sender).SelectionStart = pos - 1;
                }
                else {
                    ((TextBox)sender).Text = "-" + ((TextBox)sender).Text;
                    ((TextBox)sender).SelectionStart = pos + 1;
                }

                e.Handled = true;
                return;
            }

            //ввод цифр
            if (!(Char.IsDigit(e.KeyChar))) {
                if ((e.KeyChar != (char)Keys.Back)) {
                    e.Handled = true;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            TextBox textBox = (TextBox)sender;
            if (textBox.Focused == true){
                ReadTextBoxText();
                if (divider != 0) {
                    int whole = dividend / divider;
                    int balance = dividend % divider;
                    WriteTextBoxText(dividend, divider, whole, balance);
                    string text = "Частное = делимое / делитель   " + $"{dividend} / {divider} = " +
                        $"{quotientFromDivision}   Остаток = {balance}";
                    LabelFormulaText(text);
                }
                else
                    LabelFormulaText("Деление на нуль!");
            }           
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            TextBox textBox = (TextBox)sender;
            if (textBox.Focused == true) {
                ReadTextBoxText();
                int result = quotientFromDivision * divider + balance;
                WriteTextBoxText(result, divider, quotientFromDivision, balance);
                string text = "Делимое = частное * делитель + остаток   "
                    + $"{divider} * {quotientFromDivision} + " +
                        $"{balance}  = {dividend}";
                LabelFormulaText(text);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e) {
            TextBox textBox = (TextBox)sender;
            if (textBox.Focused == true) {
                ReadTextBoxText();
                int result = dividend % divider;
                WriteTextBoxText(dividend, divider, quotientFromDivision, result);
                string text = "Остаток = делимое % делитель   " 
                    + $"{dividend} % {divider} = {balance}";
                LabelFormulaText(text);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e) {
            TextBox textBox = (TextBox)sender;
            if (textBox.Focused == true) {
                ReadTextBoxText();
                int result = (dividend - balance) / quotientFromDivision;
                WriteTextBoxText(dividend, result, quotientFromDivision, balance);
                string text = "Делитель = (делимое - остаток) / частное   " + $"{divider} = " +
                        $"({dividend} - {balance}) / {quotientFromDivision}";
                LabelFormulaText(text);
            }
        }

        private void LabelFormulaText(string text) {
            labelFormula.Text = text;
            labelFormula.Visible = true;
        }
        private void ReadTextBoxText() {
            int intResult;
            bool success;

            success = int.TryParse(textBox1.Text, out intResult);
            if (success)
                dividend = intResult;
            else
                dividend = 1;

            success = int.TryParse(textBox2.Text, out intResult);
            if (success)
                divider = intResult;
            else
                divider = 1;

            success = int.TryParse(textBox3.Text, out intResult);
            if (success)
                quotientFromDivision = intResult;
            else
                quotientFromDivision = 1;

            success = int.TryParse(textBox4.Text, out intResult);
            if (success)
                balance = intResult;
            else
                balance = 0;            
        }
        private void WriteTextBoxText(int dividend, int divider, int quotientFromDivision, int balance) {
            textBox1.Text = dividend.ToString();
            textBox2.Text = divider.ToString();
            textBox3.Text = quotientFromDivision.ToString();
            textBox4.Text = balance.ToString();
        }
    }
}
