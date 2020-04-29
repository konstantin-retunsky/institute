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
using System.Data.SqlClient;
using System.Data.OleDb;

namespace coursework {

	public partial class fMain : Form {

        //string fileName = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\institute\\computer science and programming\\second semester\\coursework\\access\\coursework.mdb;";
        string fileName = null;
        OleDbConnection oleDbConnection;

        private void Button1_Click (object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                fileName = openFileDialog.FileName;
                MessageBox.Show(openFileDialog.FileName);
            }
        }

        public fMain() {
            
        }

        // массив для комбобокса, и тултип для кнопок
        string[] arrComboBox = {"Клиенты", "Услуги", "Перевозки" };
        ToolTip toolTip = new ToolTip();

        private void FMain_Load(object sender, EventArgs e) {
            this.Size = new Size(815, 410);
            comboBoxChoose.Items.AddRange(arrComboBox);

            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(this.comboBoxChoose, "Выберите нужную таблицу представленных в данном списке");
        }

        // index: [0-3] - Клиенты, [4-7] - Услуги
        private void ComboBoxChoose_SelectionChangeCommitted (object sender, EventArgs e) {

            string[] strForToolTip = {"нового клиента", "выбранного клиента", "выбранного клиаента", "килаентам",
                                      "новых услуг",    "выбранных услуг",    "выбранных услуг"    , "услугам"};
            for (byte i = 0; i < arrComboBox.Length; i++) {
                if (comboBoxChoose.SelectedIndex == i) {
                    toolTip.SetToolTip(this.btnAdd,    "Добавление "       + strForToolTip[i]);
                    toolTip.SetToolTip(this.btnEdit,   "Редактирование "   + strForToolTip[i + 1]);
                    toolTip.SetToolTip(this.btnRemove, "Удаление "         + strForToolTip[i + 2]);
                    toolTip.SetToolTip(this.btnSearch, "Выборка по "       + strForToolTip[i + 3]);
                }
            }
            if (comboBoxChoose.SelectedIndex == 2) {
                groupBoxBtn.Visible = false;
                groupBoxEdit.Visible = false;
            } else {
                groupBoxBtn.Visible = true;
                groupBoxEdit.Visible = true;
            }
        }

        private void BtnAdd_Click (object sender, EventArgs e) {
            visableGroupBox();
            groupBoxEdit.Text = "Добавление";
            btnCalc.Text = "Добавить";
            toolTip.SetToolTip(btnCalc,"Добавить новые данные в таблицу");
        }

        private void BtnEdit_Click (object sender, EventArgs e) {
            visableGroupBox();
            groupBoxEdit.Text = "Редактирование";
            btnCalc.Text = "Редактировать";
            toolTip.SetToolTip(btnCalc, "Отредактировать выбранный элемент, на нововведенные данные");
        }

        private void BtnSearch_Click (object sender, EventArgs e) {
            visableGroupBox();
            groupBoxEdit.Text = "Выборка";
            btnCalc.Text = "Поиск";
            toolTip.SetToolTip(btnCalc, "Поиск по таблице");
        }

        /// <summary>
        /// groupBoxEdit.Visable = true; this.Size = new Size(815, 487);
        /// </summary>
        public void visableGroupBox () {
            groupBoxEdit.Visible = true;
            this.Size = new Size(815, 520);
        }

        private void ВыходToolStripMenuItem_Click (object sender, EventArgs e) {
            Close();
        }

      
    }
}
