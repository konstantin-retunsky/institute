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
	public partial class FormEdit : Form {
		public FormEdit ( ) {
			InitializeComponent ( );
		}

		private void FormEdit_Load ( object sender, EventArgs e ) {
			FormMain formMain = Owner as FormMain;
			List<Label> labels = new List<Label>();
			List<TextBox> textBoxes = new List<TextBox>();
			List<ComboBox> comboBoxes = new List<ComboBox>();
			DateTimePicker dateTimePicker = new DateTimePicker();

			if ( formMain.comboBoxTable.SelectedItem.ToString ( ) == "Перевозки" ) {
				byte indexTextBoxes = new byte();
				byte indexComboBoxes = new byte();

				// создание элементов для таблицы Перевозки
				for ( int i = 0; i < formMain.dataGridView.Columns.Count; i++ ) {
					labels.Add ( new Label ( ) );
					labels[ i ].Text = formMain.dataGridView.Columns[ i ].HeaderText;
					labels[ i ].Location = new Point ( 30, i * 40 + 10 );
					labels[ i ].Width = 200;

					if ( i == 0 | i > 4 ) {
						textBoxes.Add ( new TextBox ( ) );
						textBoxes[ textBoxes.Count - 1 ].Location = new Point ( 30, labels[ i ].Location.Y + 15 );
						textBoxes[ textBoxes.Count - 1 ].Width = 200;
						this.Controls.Add ( textBoxes[ textBoxes.Count - 1 ] );
					} else if ( i == 4 ) {
						dateTimePicker.Location = new Point ( 30, labels[ i ].Location.Y + 15 );
						dateTimePicker.Width = 200;
						this.Controls.Add ( dateTimePicker );
					} else {
						comboBoxes.Add ( new ComboBox ( ) );
						comboBoxes[ comboBoxes.Count - 1 ].Location = new Point ( 30, labels[ i ].Location.Y + 15 );
						comboBoxes[ comboBoxes.Count - 1 ].Width = 200;
						comboBoxes[ comboBoxes.Count - 1 ].KeyPress += ( senderCobobox, eComboBox ) => eComboBox.Handled = true;

						this.Controls.Add ( comboBoxes[ comboBoxes.Count - 1 ] );
					}
					this.Controls.Add ( labels[ i ] );
				}
				textBoxes[ 0 ].Enabled = false;
				textBoxes[ textBoxes.Count - 1 ].Enabled = false;

				for ( byte i = 0; i < formMain.dataGridView.ColumnCount; i++ ) {
					if ( i == 0 | i > 4 ) {
						textBoxes[ indexTextBoxes ].Text = formMain.dataGridView.Rows[ formMain.dataGridView.CurrentRow.Index ].Cells[ i ].Value.ToString ( );
						indexTextBoxes++;
					} else if ( i == 4 ) {
						dateTimePicker.Value = DateTime.Parse ( formMain.dataGridView.Rows[ formMain.dataGridView.CurrentRow.Index ].Cells[ i ].Value.ToString ( ) );
					} else {
						comboBoxes[ indexComboBoxes ].Text = formMain.dataGridView.Rows[ formMain.dataGridView.CurrentRow.Index ].Cells[ i ].Value.ToString ( );
						indexComboBoxes++;
					}
				}

				string pattern = @"##";
				string pathClients = Application.StartupPath + "\\" + "Клиенты.txt";
				string pathService = Application.StartupPath + "\\" + "Услуги.txt";
				string[] loadedClientsFile = File.ReadAllLines(pathClients);
				string[] loadedServiceFile = File.ReadAllLines(pathService);

				//заполняем комбобоксы
				for ( int i = 1; i < loadedClientsFile.Length; i++ ) {
					if ( !string.IsNullOrWhiteSpace ( loadedClientsFile[ i ] ) ) {
						string[] line = Regex.Split(loadedClientsFile[i], pattern);
						comboBoxes[ 0 ].Items.Add ( line[ 1 ] );
					}
				}

				for ( int i = 1; i < loadedServiceFile.Length; i++ ) {
					if ( !string.IsNullOrWhiteSpace ( loadedServiceFile[ i ] ) ) {
						string[] line = Regex.Split(loadedServiceFile[i], pattern);
						if ( !comboBoxes[ 1 ].Items.Contains ( line[ 1 ] ) ) {
							comboBoxes[ 1 ].Items.Add ( line[ 1 ] );
						}
					}
				}

				comboBoxes[ 1 ].TextChanged += ( object senderComboBoxes_1, EventArgs eComboBoxes_1 ) => {
					comboBoxes[ 2 ].Items.Clear ( );
					comboBoxes[ 2 ].Text = "";
					textBoxes[ 2 ].Text = "";
					for ( int i = 0; i < loadedServiceFile.Length; i++ ) {
						if ( !string.IsNullOrWhiteSpace ( loadedServiceFile[ i ] ) ) {
							string[] line = Regex.Split(loadedServiceFile[i], pattern);
							if ( line[ 1 ] == comboBoxes[ 1 ].Text ) {
								comboBoxes[ 2 ].Items.Add ( line[ 2 ] );
							}
						}
					}
				};

				comboBoxes[ 2 ].SelectionChangeCommitted += ( object senderComboBoxes_2, EventArgs eComboBoxes_2 ) => {
					if ( !string.IsNullOrWhiteSpace ( textBoxes[ 1 ].Text ) ) {
						for ( int i = 0; i < loadedServiceFile.Length; i++ ) {
							string[] line = Regex.Split(loadedServiceFile[i], pattern);
							bool IsDigit = textBoxes[2].Text.Length == textBoxes[2].Text.Where(c => char.IsDigit(c)).Count();
							if ( comboBoxes[ 2 ].Text == line[ 2 ] & IsDigit ) {
								textBoxes[ 2 ].Text = ( int.Parse ( textBoxes[ 1 ].Text ) * int.Parse ( line[ 3 ] ) ).ToString ( );
							} else {
								textBoxes[ 2 ].Text = "";
							}
						}
					}
				};

				textBoxes[ 1 ].TextChanged += ( object senderTextBoxes_1, EventArgs eTextBoxes_1 ) => {
					if ( !string.IsNullOrWhiteSpace ( textBoxes[ 1 ].Text ) ) {
						for ( int i = 0; i < loadedServiceFile.Length; i++ ) {
							string[] line = Regex.Split(loadedServiceFile[i], pattern);
							if ( comboBoxes[ 2 ].Text == line[ 2 ] ) {
								textBoxes[ 2 ].Text = ( int.Parse ( textBoxes[ 1 ].Text ) * int.Parse ( line[ 3 ] ) ).ToString ( );
							}
						}
					}
				};

				//Кнопка редактировать
				Button buttonEdit = new Button();
				buttonEdit.Text = "Редактировать";
				buttonEdit.Location = new Point ( 30, textBoxes[ textBoxes.Count - 1 ].Location.Y + 30 );
				this.Controls.Add ( buttonEdit );
				buttonEdit.Click += ( object senderbuttonEdit, EventArgs ebuttonEdit ) => {

					bool isNull = true;

					for ( int i = 0; i < textBoxes.Count; i++ ) {
						if ( string.IsNullOrWhiteSpace ( textBoxes[ i ].Text ) ) {
							isNull = false;
						}
					}
					for ( int i = 0; i < comboBoxes.Count; i++ ) {
						if ( string.IsNullOrWhiteSpace ( comboBoxes[ i ].Text ) ) {
							isNull = false;
						}
					}

					if ( isNull ) {

						formMain.changeEdit = true;

						indexTextBoxes = 0;
						indexComboBoxes = 0;
						for ( int i = 0; i < formMain.dataGridView.ColumnCount; i++ ) {
							if ( i == 0 | i > 4 ) {
								formMain.dataGridView.Rows[ formMain.dataGridView.CurrentRow.Index ].Cells[ i ].Value = textBoxes[ indexTextBoxes ].Text;
								indexTextBoxes++;
							} else if ( i == 4 ) {
								formMain.dataGridView.Rows[ formMain.dataGridView.CurrentRow.Index ].Cells[ i ].Value = dateTimePicker.Value.ToShortDateString ( );
							} else {
								formMain.dataGridView.Rows[ formMain.dataGridView.CurrentRow.Index ].Cells[ i ].Value = comboBoxes[ indexComboBoxes ].Text;
								indexComboBoxes++;
							}
						}
						this.Close ( );
					} else {
						MessageBox.Show ( "Поля заполнены не корректно" );
					}
				};

				//Кнопка отмены
				Button buttonCancle = new Button();
				buttonCancle.Text = "Отмена";
				buttonCancle.Location = new Point ( buttonEdit.Location.X + 100, buttonEdit.Location.Y );
				this.Controls.Add ( buttonCancle );
				buttonCancle.Click += ( object senderButtonCancle, EventArgs eButtonCancle ) => {
					this.Close ( );
				};

			} else {
				// создание элементов для под таблицу Клиенты, или Услуги
				for ( int i = 0; i < formMain.dataGridView.Columns.Count; i++ ) {
					textBoxes.Add ( new TextBox ( ) );
					labels.Add ( new Label ( ) );

					labels[ i ].Text = formMain.dataGridView.Columns[ i ].HeaderText;
					labels[ i ].Location = new Point ( 30, i * 40 + 10 );

					if ( formMain.dataGridView.Columns[ i ].HeaderText != "Дата регистрации" ) {
						textBoxes[ i ].Location = new Point ( 30, labels[ i ].Location.Y + 15 );
						textBoxes[ i ].Width = 200;
						this.Controls.Add ( textBoxes[ i ] );
					} else {
						dateTimePicker = new DateTimePicker ( );
						dateTimePicker.Location = new Point ( 30, labels[ i ].Location.Y + 15 );
						dateTimePicker.Width = 200;
						this.Controls.Add ( dateTimePicker );
					}

					this.Controls.Add ( labels[ i ] );
				}
				textBoxes[ 0 ].Enabled = false;

				for ( byte i = 0; i < formMain.dataGridView.ColumnCount; i++ ) {
					textBoxes[ i ].Text = formMain.dataGridView.Rows[ formMain.dataGridView.CurrentRow.Index ].Cells[ i ].Value.ToString ( );
				};

				//Кнопка редактирования
				Button buttonEdit = new Button();
				buttonEdit.Text = "Редактировать";
				buttonEdit.Location = new Point ( 30, textBoxes[ textBoxes.Count - 1 ].Location.Y + 30 );
				this.Controls.Add ( buttonEdit );
				buttonEdit.Click += ( object senderbuttonEdit, EventArgs ebuttonEdit ) => {


					bool isNull = true;

					for ( int i = 0; i < textBoxes.Count; i++ ) {
						if ( string.IsNullOrWhiteSpace ( textBoxes[ i ].Text ) ) {
							isNull = false;
						}
					}

					if ( isNull ) {

						formMain.changeEdit = true;
						if ( formMain.comboBoxTable.SelectedItem.ToString ( ) == "Клиенты" ) {
							for ( int i = 0; i < formMain.dataGridView.ColumnCount; i++ ) {
								if ( i != 2 ) {
									formMain.dataGridView.Rows[ formMain.dataGridView.CurrentRow.Index ].Cells[ i ].Value = textBoxes[ i ].Text;
								} else {
									formMain.dataGridView.Rows[ formMain.dataGridView.CurrentRow.Index ].Cells[ i ].Value = dateTimePicker.Value.ToShortDateString ( );
								}
							}
						} else {
							for ( int i = 0; i < formMain.dataGridView.ColumnCount; i++ ) {	
									formMain.dataGridView.Rows[ formMain.dataGridView.CurrentRow.Index ].Cells[ i ].Value = textBoxes[ i ].Text;
							}
						}


						this.Close ( );
					} else {
						MessageBox.Show ( "Поля заполнены не корректно" );
					}
				};

				//Кнопка отмены
				Button buttonCancle = new Button();
				buttonCancle.Text = "Отмена";
				buttonCancle.Location = new Point ( buttonEdit.Location.X + 100, buttonEdit.Location.Y );
				this.Controls.Add ( buttonCancle );
				buttonCancle.Click += ( object senderButtonCancle, EventArgs eButtonCancle ) => {
					this.Close ( );
				};
			}
		}
	}
}
