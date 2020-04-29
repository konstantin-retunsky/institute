using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace program {
    public partial class FormAdd:Form {
        public FormAdd () {
            InitializeComponent();
        }

        private void FormAdd_Load (object sender, EventArgs e) {
            fMain main = Owner as fMain;
            short locationIndex = 30;
            List<TextBox> listTextBoxs = new List<TextBox>();
            List<Label>   listLabels = new List<Label>();

            // заполнение формУ лейблами и текстбоксами
            for (byte i = 0; i < main.dgv.ColumnCount; i++) {
                listTextBoxs.Add(new TextBox());
                this.Controls.Add(listTextBoxs[i]);
                listTextBoxs[i].Location = new Point(30, locationIndex);
                listTextBoxs[i].Width = 200;

                listLabels.Add(new Label());
                this.Controls.Add(listLabels[i]);
                listLabels[i].Location = new Point(30, locationIndex - 15);
                listLabels[i].Text = main.dgv.Columns[i].HeaderText;

                locationIndex += 40;
            }
            listTextBoxs[0].Enabled = false;
            listTextBoxs[0].Text = (int.Parse(main.dgv.Rows[main.dgv.RowCount - 1].Cells[0].Value.ToString()) + 1).ToString();

            // btn exit
            Button btnExit = new Button();
            btnExit.Text = "Выход";
            this.Controls.Add(btnExit);
            btnExit.Click += (asd, asd2) => {
                Close();
            };
            // btn result
            Button btnResult = new Button();
            btnResult.Text = "Добавить";
            this.Controls.Add(btnResult);
            btnResult.Location = new Point(30, listTextBoxs.Last().Location.Y + 40);
            this.Height = btnResult.Location.Y + 75;
            btnExit.Location = new Point(155, btnResult.Location.Y);

            // Добавляем данные в бд
            btnResult.Click += (object senderAdd, EventArgs eAdd) => {
                
                DialogResult dialogResult = MessageBox.Show("Вы уверены в этом?", "Добавление", MessageBoxButtons.YesNo);
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
                    
                    // после проверки на повторное ввождение данных приступаем к самому добавлению
                    if (boolean) {
                        MessageBox.Show("Такая строка уже есть");
                    } else {
                        try {
                            fMain.dbConnection.Open();
                            OleDbCommand command = fMain.dbConnection.CreateCommand();
                            OleDbDataAdapter dbAdapter = new OleDbDataAdapter("select * from" + "[" + main.treeView.SelectedNode.Text + "]", fMain.dbConnection);
                            dbAdapter.Fill(fMain.dataSet, main.treeView.SelectedNode.Text);

                            string inputRow = "";
                            string columnNameAccess= "";
                            for (byte i = 1; i < main.dgv.ColumnCount; i++) {
                                inputRow += $"'{listTextBoxs[i].Text}',";
                                columnNameAccess += $"[{fMain.dataSet.Tables[0].Columns[i]}],";
                            }
                            
                            command.CommandText = $"INSERT INTO [{main.treeView.SelectedNode.Text}] ({columnNameAccess.Substring(0, columnNameAccess.Length - 1)}) VALUES ({inputRow.Substring(0, inputRow.Length - 1)});";
                            command.ExecuteNonQuery();
                            fMain.dataSet.Tables.Clear();
                            fMain.dbConnection.Close();

                            //обновляем dgv
                            fMain.dbConnection.Open();
                            dbAdapter = new OleDbDataAdapter("select * from" + "[" + main.treeView.SelectedNode.Text + "]", fMain.dbConnection);
                            dbAdapter.Fill(fMain.dataSet, main.treeView.SelectedNode.Text);
                            main.dgv.DataSource = fMain.dataSet.Tables[0];
                            fMain.dataSet.Tables.Clear();
                            fMain.dbConnection.Close();
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
