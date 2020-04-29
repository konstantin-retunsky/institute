using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program {
    public partial class FormSearch:Form {
        public FormSearch () {
            InitializeComponent();
        }

        private void FormSearch_Load (object sender, EventArgs e) {
            fMain main = Owner as fMain;

            List<TextBox> listTextBoxs = new List<TextBox>();
            List<Label>   listLabels = new List<Label>();

            // Копируем fMain.dgv в FormSearch.dgvSearch
            foreach (DataGridViewColumn Col in main.dgv.Columns) {
                dgvSearch.Columns.Add((DataGridViewColumn) Col.Clone());
            }
            foreach (DataGridViewRow Row in main.dgv.Rows) {
                dgvSearch.Rows.Add((DataGridViewRow) Row.Clone());

                for (int i = 0; i < main.dgv.Columns.Count; i++)
                    dgvSearch.Rows[Row.Index].Cells[i].Value = Row.Cells[i].Value;
            }

            // блокируем сортировку dgv 
            foreach (DataGridViewColumn column in dgvSearch.Columns) {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // заполнение формы лейблами и текстбоксами
            int locationIndex = 30;
            for (byte i = 0; i < main.dgv.ColumnCount; i++) {
                listTextBoxs.Add(new TextBox());
                this.Controls.Add(listTextBoxs[i]);
                listTextBoxs[i].Location = new Point(650, locationIndex);
                listTextBoxs[i].Width = 200;
                listTextBoxs[i].Name = "textBox" + i;

                listLabels.Add(new Label());
                this.Controls.Add(listLabels[i]);
                listLabels[i].Location = new Point(650, locationIndex - 15);
                listLabels[i].Text = main.dgv.Columns[i].HeaderText;
                locationIndex += 40;

                // AutoCompliteText for ListTextBoxs
                listTextBoxs[i].AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                listTextBoxs[i].AutoCompleteSource = AutoCompleteSource.CustomSource;
                if (i == 0) {
                } else {
                    AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
                    for (int dgvRow = 0; dgvRow < dgvSearch.RowCount; dgvRow++) {
                        autoComplete.Add(dgvSearch.Rows[dgvRow].Cells[i].Value.ToString());
                    }
                    listTextBoxs[i].AutoCompleteCustomSource = autoComplete;
                }
            }
            listTextBoxs[0].Enabled = false;
            listTextBoxs[0].Text = ( int.Parse(main.dgv.Rows[main.dgv.RowCount - 1].Cells[0].Value.ToString()) + 1 ).ToString();


            // Search to dgv
            string strColumn = "";
            string rowName = "";
            foreach (TextBox textBox in listTextBoxs) {
                textBox.TextChanged += (object senderAdd, EventArgs eTextChanged) => {
                    strColumn = textBox.Name.ToString();
                    int indexTextBox = int.Parse((strColumn[strColumn.Length -1].ToString()));
                    for (int i = 0; i < dgvSearch.Rows.Count; i++) {
                        rowName = dgvSearch.Rows[i].Cells[indexTextBox].Value.ToString();
                        
                        if (Regex.IsMatch(dgvSearch.Rows[i].Cells[indexTextBox].Value.ToString(), $@"^{listTextBoxs[indexTextBox].Text}", RegexOptions.Multiline)) {
                            dgvSearch.Rows[i].Visible = true;
                        } else {
                            dgvSearch.Rows[i].Visible = false;
                        }
                    }
                };
            }

            // добавление кнопок 
            List<Button> listButtons = new List<Button>();
            locationIndex = listTextBoxs.Last().Location.Y + 40;
            for (byte i = 0; i < 4; i++) {
                listButtons.Add(new Button());
                this.Controls.Add(listButtons[i]);
                listButtons[i].Location = new Point(650, locationIndex);
                locationIndex += 40;
            }
            listButtons[0].Text = "Add";
            listButtons[1].Text = "Editing";
            listButtons[2].Text = "Delete";
            listButtons[3].Text = "Exit";

            //btn Add
            listButtons[0].Click += (object senderAdd, EventArgs eAdd) => {
                DialogResult dialogResult = MessageBox.Show("Вы уверены в этом?", "Добавление", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {
                    try {
                        fMain.dbConnection.Open();
                        OleDbCommand command = fMain.dbConnection.CreateCommand();
                        OleDbDataAdapter dbAdapter = new OleDbDataAdapter("select * from" + "[" + main.treeView.SelectedNode.Text + "]", fMain.dbConnection);
                        dbAdapter.Fill(fMain.dataSet, main.treeView.SelectedNode.Text);

                        string inputRow = "";
                        string columnNameAccess= "";
                        for (byte i = 1; i < dgvSearch.ColumnCount; i++) {
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
                        dgvSearch.DataSource = fMain.dataSet.Tables[0];
                        main.dgv.DataSource = fMain.dataSet.Tables[0];
                        fMain.dataSet.Tables.Clear();
                        fMain.dbConnection.Close();
                    } catch {
                        MessageBox.Show("Неверно заполнены поля");
                        fMain.dataSet.Tables.Clear();
                        fMain.dbConnection.Close();
                    }
                } else if (dialogResult == DialogResult.No) {

                }
            };

            //btn Editing 
            listButtons[1].Click += (object senderEditing, EventArgs eEditing) => {
                DialogResult dialogResult = MessageBox.Show("Вы уверены в этом?", "Редактирование", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {
                    try {
                        fMain.dbConnection.Open();
                        OleDbDataAdapter dbAdapter = new OleDbDataAdapter("select * from" + "[" + main.treeView.SelectedNode.Text + "]", fMain.dbConnection);
                        dbAdapter.Fill(fMain.dataSet, main.treeView.SelectedNode.Text);

                        string columnNameAccess = "";
                        for (byte i = 1; i < fMain.dataSet.Tables[0].Columns.Count; i++) {
                            columnNameAccess += $"[{fMain.dataSet.Tables[0].Columns[i]}]='{listTextBoxs[i].Text}', ";
                            dgvSearch.Rows[dgvSearch.CurrentCell.RowIndex].Cells[i].Value = listTextBoxs[i].Text;
                        }
                        dgvSearch.Rows[dgvSearch.CurrentCell.RowIndex].Cells[0].Value = listTextBoxs[0].Text;

                        string query =  $"UPDATE [{main.treeView.SelectedNode.Text}] SET {columnNameAccess.Substring(0, columnNameAccess.Length - 2)} WHERE [{fMain.dataSet.Tables[0].Columns[0]}]={listTextBoxs[0].Text}";
                        OleDbCommand  dbCommand= new OleDbCommand(query, fMain.dbConnection);
                        dbCommand.CommandText = query;
                        dbCommand.ExecuteNonQuery();
                        fMain.dataSet.Tables.Clear();
                        fMain.dbConnection.Close();

                        //обновляем dgv
                        fMain.dbConnection.Open();
                        dbAdapter = new OleDbDataAdapter("select * from" + "[" + main.treeView.SelectedNode.Text + "]", fMain.dbConnection);
                        dbAdapter.Fill(fMain.dataSet, main.treeView.SelectedNode.Text);
                        main.dgv.DataSource = fMain.dataSet.Tables[0];
                        dgvSearch.DataSource = fMain.dataSet.Tables[0];
                        fMain.dataSet.Tables.Clear();
                        fMain.dbConnection.Close();
                    } catch {
                        MessageBox.Show("Неверно заполнены поля");
                        fMain.dataSet.Tables.Clear();
                        fMain.dbConnection.Close();
                    }
                } else if (dialogResult == DialogResult.No) {
                }
            };

            // btn delete
            listButtons[2].Click += (object senderDelete, EventArgs eDelete) => {
                fMain.dbConnection.Open();
                fMain.dbAdapter = new OleDbDataAdapter("select * from" + "[" + main.treeView.SelectedNode.Text + "]", fMain.dbConnection);
                fMain.dbAdapter.Fill(fMain.dataSet, main.treeView.SelectedNode.Text);

                string query = $"DELETE FROM [{main.treeView.SelectedNode.Text}] WHERE [{fMain.dataSet.Tables[0].Columns[0]}]=?";
                OleDbCommand deleteCommand = new OleDbCommand(query, fMain.dbConnection);

                deleteCommand.Parameters.AddWithValue("@ID", int.Parse(dgvSearch.Rows[dgvSearch.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                deleteCommand.ExecuteNonQuery();

                // обновление dgv
                fMain.dataSet.Tables.Clear();
                fMain.dbAdapter.Fill(fMain.dataSet, main.treeView.SelectedNode.Text);
                dgvSearch.DataSource = fMain.dataSet.Tables[0];
                main.dgv.DataSource = fMain.dataSet.Tables[0];
                fMain.dataSet.Tables.Clear();
                fMain.dbConnection.Close();
            };

            //btn exit 
            listButtons[3].Click += (object senderExit, EventArgs eExit) => {
                //обновляем dgv
                fMain.dbConnection.Open();
                fMain.dbAdapter = new OleDbDataAdapter("select * from" + "[" + main.treeView.SelectedNode.Text + "]", fMain.dbConnection);
                fMain.dbAdapter.Fill(fMain.dataSet, main.treeView.SelectedNode.Text);
                main.dgv.DataSource = fMain.dataSet.Tables[0];
                fMain.dataSet.Tables.Clear();
                fMain.dbConnection.Close();
                Close();
            };
        }
        private void textBox1_TextChanged (object sender, EventArgs e) {

        }
    }
}
