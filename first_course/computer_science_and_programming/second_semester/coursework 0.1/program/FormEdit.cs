using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace program {
    public partial class FormEdit:Form {
        public FormEdit () {
            InitializeComponent();
        }

        private void FormEdit_Load (object sender, EventArgs e) {
            fMain main = Owner as fMain;
            short locationIndex = 30;
            List<TextBox> listTextBoxs = new List<TextBox>();
            List<Label>   listLabels = new List<Label>();

            // заполнение форму лейблами и текстбоксами
            for (byte i = 0; i < main.dgv.ColumnCount; i++) {
                listTextBoxs.Add(new TextBox());
                this.Controls.Add(listTextBoxs[i]);
                listTextBoxs[i].Location = new Point(30, locationIndex);
                listTextBoxs[i].Text = main.dgv.Rows[main.dgv.CurrentCell.RowIndex].Cells[i].Value.ToString();
                listTextBoxs[i].Width = 200;

                listLabels.Add(new Label());
                this.Controls.Add(listLabels[i]);
                listLabels[i].Location = new Point(30, locationIndex - 15);
                listLabels[i].Text = main.dgv.Columns[i].HeaderText;

                locationIndex += 40;
            }
            listTextBoxs[0].Enabled = false;

            // btn exit
            Button btnExit = new Button();
            btnExit.Text   = "Выход";
            this.Controls.Add(btnExit);
            btnExit.Click += (asd, asd2) => {
                Close();
            };
            // btn result
            Button btnResult = new Button();
            btnResult.Text = "Редактировать";
            this.Controls.Add(btnResult);
            btnResult.Location = new Point(30, listTextBoxs.Last().Location.Y + 40);
            this.Height = btnResult.Location.Y + 75;
            btnExit.Location = new Point(155, btnResult.Location.Y);

            // редактируем бд
            btnResult.Click += (object senderResult, EventArgs eResult) => {
                DialogResult dialogResult = MessageBox.Show("Вы уверены в этом?", "Редактирование", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {

                    // проверка на повторные данные
                    bool boolean = new bool();
                    string inputData = "";
                    string oldData   = "";
                    for (byte i = 0; i < listTextBoxs.Count; i++) {
                        string str = "";
                        str += listTextBoxs[i].Text;
                        inputData += listTextBoxs[i].Text;
                    }
                    for (short i = 0; i < main.dgv.RowCount; i++) {
                        for (byte j = 0; j < main.dgv.ColumnCount; j++) {
                            oldData += main.dgv.Rows[i].Cells[j].Value.ToString();
                        }
                        if (inputData == oldData) {
                            boolean = true;
                        }
                    }

                    // после проверки на повторное ввождение данных приступаем к редактированию
                    if (boolean) {
                        MessageBox.Show("Такая строка уже есть");
                    } else {
                        try {
                            fMain.dbConnection.Open();
                            OleDbDataAdapter dbAdapter = new OleDbDataAdapter("select * from" + "[" + main.treeView.SelectedNode.Text + "]", fMain.dbConnection);
                            dbAdapter.Fill(fMain.dataSet, main.treeView.SelectedNode.Text);

                            string columnNameAccess = "";
                            for (byte i = 1; i < fMain.dataSet.Tables[0].Columns.Count; i++) {
                                columnNameAccess += $"[{fMain.dataSet.Tables[0].Columns[i]}]='{listTextBoxs[i].Text}', ";
                                main.dgv.Rows[main.dgv.CurrentCell.RowIndex].Cells[i].Value = listTextBoxs[i].Text;
                            }
                            main.dgv.Rows[main.dgv.CurrentCell.RowIndex].Cells[0].Value = listTextBoxs[0].Text;

                            string query =  $"UPDATE [{main.treeView.SelectedNode.Text}] SET {columnNameAccess.Substring(0, columnNameAccess.Length - 2)} WHERE [{fMain.dataSet.Tables[0].Columns[0]}]={listTextBoxs[0].Text}";

                            OleDbCommand  dbCommand= new OleDbCommand(query, fMain.dbConnection);
                            dbCommand.CommandText = query;
                            dbCommand.ExecuteNonQuery();
                            fMain.dataSet.Tables.Clear();
                            fMain.dbConnection.Close();

                            Close();
                        } catch {
                            MessageBox.Show("Неверно заполнены поля");
                            fMain.dataSet.Tables.Clear();
                            fMain.dbConnection.Close();
                        }
                    }
                } else if (dialogResult == DialogResult.No) {
                }
            };
        }
    }
}
