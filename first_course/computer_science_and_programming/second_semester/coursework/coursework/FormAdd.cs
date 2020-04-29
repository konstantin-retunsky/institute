using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework {

	public partial class FormAdd : Form {

		public FormAdd() {
			InitializeComponent();
		}

		private void FormAddClintsOrService_Load( object sender, EventArgs e ) {

			FormMain formMain = Owner as FormMain;
			List<Label> labels = new List<Label>();
			List<TextBox> textBoxes = new List<TextBox>();
			List<ComboBox> comboBoxes = new List<ComboBox>();
			DateTimePicker dateTimePicker = new DateTimePicker();
			int lastIndexRowForDataGridView = formMain.dataGridView.Rows.Count;

			if ( formMain.comboBoxTable.SelectedItem.ToString() == "Перевозки" ) {

				// создание элементов для таблицы Перевозки
				for ( int i = 0; i < formMain.dataGridView.Columns.Count; i++ ) {
					labels.Add(new Label());
					labels[i].Text = formMain.dataGridView.Columns[i].HeaderText;
					labels[i].Location = new Point(30, i * 40 + 10);
					labels[i].Width = 200;

					if ( i == 0 | i > 4 ) {
						textBoxes.Add(new TextBox());
						textBoxes[textBoxes.Count - 1].Location = new Point(30, labels[i].Location.Y + 15);
						textBoxes[textBoxes.Count - 1].Width = 200;
						this.Controls.Add(textBoxes[textBoxes.Count - 1]);
					} else if ( i == 4 ) {
						dateTimePicker.Location = new Point(30, labels[i].Location.Y + 15);
						dateTimePicker.Width = 200;
						this.Controls.Add(dateTimePicker);
					} else {
						comboBoxes.Add(new ComboBox());
						comboBoxes[comboBoxes.Count - 1].Location = new Point(30, labels[i].Location.Y + 15);
						comboBoxes[comboBoxes.Count - 1].Width = 200;
						comboBoxes[comboBoxes.Count - 1].DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

						this.Controls.Add(comboBoxes[comboBoxes.Count - 1]);
					}
					this.Controls.Add(labels[i]);
				}
				textBoxes[0].Enabled = false;
				textBoxes[textBoxes.Count - 1].Enabled = false;

				if ( formMain.dataGridView.Rows.Count > 0 ) {
					textBoxes[0].Text = ( int.Parse(formMain.dataGridView.Rows[lastIndexRowForDataGridView - 1].Cells[0].Value.ToString()) + 1 ).ToString();
				} else if ( formMain.dataGridView.Rows.Count == 0 ) {
					textBoxes[0].Text = 1.ToString();
				}

				string pattern = @"##";
				string pathClients = Application.StartupPath + "\\" + "Клиенты.txt";
				string pathService = Application.StartupPath + "\\" + "Услуги.txt";
				string[] loadedClientsFile = File.ReadAllLines(pathClients);
				string[] loadedServiceFile = File.ReadAllLines(pathService);

				//заполняем комбобоксы
				for ( int i = 1; i < loadedClientsFile.Length; i++ ) {
					if ( !string.IsNullOrWhiteSpace(loadedClientsFile[i]) ) {
						string[] line = Regex.Split(loadedClientsFile[i], pattern);
						comboBoxes[0].Items.Add(line[1]);
					}
				}

				for ( int i = 1; i < loadedServiceFile.Length; i++ ) {
					if ( !string.IsNullOrWhiteSpace(loadedServiceFile[i]) ) {
						string[] line = Regex.Split(loadedServiceFile[i], pattern);
						if ( !comboBoxes[1].Items.Contains(line[1]) ) {
							comboBoxes[1].Items.Add(line[1]);
						}
					}
				}

				comboBoxes[1].SelectionChangeCommitted += ( object senderComboBoxes_1, EventArgs eComboBoxes_1 ) => {
					comboBoxes[2].Items.Clear();
					comboBoxes[2].Text = "";
					textBoxes[ 1 ].Text = "";
					textBoxes[2].Text = "";
					for ( int i = 0; i < loadedServiceFile.Length; i++ ) {
						if ( !string.IsNullOrWhiteSpace(loadedServiceFile[i]) ) {
							string[] line = Regex.Split(loadedServiceFile[i], pattern);
							if ( line[1] == comboBoxes[1].Text ) {
								comboBoxes[2].Items.Add(line[2]);
							}
						}
					}
				};

				comboBoxes[2].SelectionChangeCommitted += ( object senderComboBoxes_2, EventArgs eComboBoxes_2 ) => {
					if ( !string.IsNullOrWhiteSpace(textBoxes[1].Text) ) {
						for ( int i = 0; i < loadedServiceFile.Length; i++ ) {
							string[] line = Regex.Split(loadedServiceFile[i], pattern);
							bool IsDigit = textBoxes[2].Text.Length == textBoxes[2].Text.Where(c => char.IsDigit(c)).Count();
							if ( comboBoxes[2].Text == line[2] & IsDigit ) {
								textBoxes[2].Text = ( int.Parse(textBoxes[1].Text) * int.Parse(line[3]) ).ToString();
							} else {
								textBoxes[2].Text = "";
							}
						}
					}
				}; 

				textBoxes[1].TextChanged += ( object senderTextBoxes_1, EventArgs eTextBoxes_1 ) => {
					if ( !string.IsNullOrWhiteSpace(textBoxes[1].Text) ) {
						for ( int i = 0; i < loadedServiceFile.Length; i++ ) {
							string[] line = Regex.Split(loadedServiceFile[i], pattern);
							if ( comboBoxes[2].Text == line[2] ) {
								textBoxes[2].Text = ( int.Parse(textBoxes[1].Text) * int.Parse(line[3]) ).ToString();
							}
						}
					}
				};

				//Кнопка добавления
				Button buttonAdd = new Button();
				buttonAdd.Text = "Добавить";
				buttonAdd.Location = new Point(30, textBoxes[textBoxes.Count - 1].Location.Y + 30);
				this.Controls.Add(buttonAdd);
				buttonAdd.Click += ( object senderButtonAdd, EventArgs eButtonAdd ) => {

					bool isNull = true;

					for ( int i = 0; i < textBoxes.Count; i++ ) {
						if ( string.IsNullOrWhiteSpace(textBoxes[i].Text) ) {
							isNull = false;
						}
					}
					for ( int i = 0; i < comboBoxes.Count; i++ ) {
						if ( string.IsNullOrWhiteSpace(comboBoxes[i].Text) ) {
							isNull = false;
						}
					}

					if ( isNull ) {

						formMain.changeEdit = true;
						formMain.dataGridView.Rows.Add();

						byte indexTextBoxes = new byte();
						byte indexComboBoxes = new byte();
						for ( int i = 0; i < formMain.dataGridView.ColumnCount; i++ ) {
							if ( i == 0 | i > 4 ) {
								formMain.dataGridView.Rows[lastIndexRowForDataGridView].Cells[i].Value = textBoxes[indexTextBoxes].Text;
								indexTextBoxes++;
							} else if ( i == 4 ) {
								formMain.dataGridView.Rows[lastIndexRowForDataGridView].Cells[i].Value = dateTimePicker.Value.ToShortDateString();
							} else {
								formMain.dataGridView.Rows[lastIndexRowForDataGridView].Cells[i].Value = comboBoxes[indexComboBoxes].Text;
								indexComboBoxes++;
							}
						}

						this.Close();
					} else {
						MessageBox.Show("Поля заполнены не корректно");
					}
				};

				//Кнопка отмены
				Button buttonCancle = new Button();
				buttonCancle.Text = "Отмена";
				buttonCancle.Location = new Point(buttonAdd.Location.X + 100, buttonAdd.Location.Y);
				this.Controls.Add(buttonCancle);
				buttonCancle.Click += ( object senderButtonCancle, EventArgs eButtonCancle ) => {
					this.Close();
				};

			} else {
				// создание элементов под таблицу Клиенты, или Услуги
				byte indexTextBox = 0;
				for ( int i = 0; i < formMain.dataGridView.Columns.Count; i++ ) {
					labels.Add(new Label());
					labels[i].Text = formMain.dataGridView.Columns[i].HeaderText;
					labels[i].Location = new Point(30, i * 40 + 10);
					labels[i].Width = 200;
					if ( formMain.dataGridView.Columns[i].HeaderText == "Дата регистрации" ) {
						dateTimePicker = new DateTimePicker();
						dateTimePicker.Location = new Point(30, labels[i].Location.Y + 15);
						dateTimePicker.Width = 200;
						this.Controls.Add(dateTimePicker);
					} else {
						textBoxes.Add(new TextBox());
						textBoxes[indexTextBox].Width = 200;
						textBoxes[indexTextBox].Location = new Point(30, labels[i].Location.Y + 15);
						this.Controls.Add(textBoxes[indexTextBox]);
						indexTextBox++;
					}
					this.Controls.Add(labels[i]);
				}


				textBoxes[0].Enabled = false;
				textBoxes[0].Text = ( int.Parse(formMain.dataGridView.Rows[lastIndexRowForDataGridView - 1].Cells[0].Value.ToString()) + 1 ).ToString();

				//Кнопка добавления
				Button buttonAdd = new Button();
				buttonAdd.Text = "Добавить";
				buttonAdd.Location = new Point(30, textBoxes[textBoxes.Count - 1].Location.Y + 30);
				this.Controls.Add(buttonAdd);
				buttonAdd.Click += ( object senderButtonAdd, EventArgs eButtonAdd ) => {

					bool isNull = true;

					for ( int i = 0; i < textBoxes.Count; i++ ) {
						if ( string.IsNullOrWhiteSpace(textBoxes[i].Text) ) {
							isNull = false;
						}
					}

					if ( isNull ) {

						formMain.changeEdit = true;
						formMain.dataGridView.Rows.Add();
						if ( formMain.comboBoxTable.SelectedItem.ToString ( ) == "Клиенты" ) {
							byte indexTextBoxClients = 0;
							for ( int i = 0; i < formMain.dataGridView.Columns.Count; i++ ) {
								if ( i != 2 ) {
									formMain.dataGridView.Rows[ lastIndexRowForDataGridView ].Cells[ i ].Value = textBoxes[ indexTextBoxClients ].Text;
									indexTextBoxClients++;
								} else {
									formMain.dataGridView.Rows[ lastIndexRowForDataGridView ].Cells[ i ].Value = dateTimePicker.Value.ToShortDateString ( );
								}
							}
							lastIndexRowForDataGridView++;
						} else {
							byte indexTextBoxClients = 0;
							for ( int i = 0; i < formMain.dataGridView.Columns.Count; i++ ) {
									formMain.dataGridView.Rows[ lastIndexRowForDataGridView ].Cells[ i ].Value = textBoxes[ indexTextBoxClients ].Text;
									indexTextBoxClients++;
							}
						}
						this.Close();
						formMain.changeEdit = true;
					} else {
						MessageBox.Show("Поля заполнены некорректно");
					}
				};

				//Кнопка отмены
				Button buttonCancle = new Button();
				buttonCancle.Text = "Отмена";
				buttonCancle.Location = new Point(buttonAdd.Location.X + 100, buttonAdd.Location.Y);
				this.Controls.Add(buttonCancle);
				buttonCancle.Click += ( object senderButtonCancle, EventArgs eButtonCancle ) => {
					this.Close();
				};
			}
		}
	}
}
