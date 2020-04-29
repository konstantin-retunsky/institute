using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace coursework {

	public partial class FormMain : Form {

		public FormMain ( ) {
			InitializeComponent ( );
		}

		// для контроля изменений в dataGridView ( добавление данных, изменение данных, удаление данных и тд )
		public bool changeEdit = false;

		private void FormMain_Load ( object sender, EventArgs e ) {

			// Клиенты - таблица о клиентах
			// Услуги  - таблица об услугах 
			// Перевозки - итоговая таблица, связанная с таблицами клиенты и услуги, в которой содержится информация об перевозках 
			comboBoxTable.Items.AddRange ( new string[] { "Клиенты",
																			"Услуги",
																			"Перевозки" } );
			comboBoxTable.SelectedItem = "Перевозки";
			comboBoxTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			dataGridView.RowHeadersVisible = false;
			dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

			ChangeTheWidthOfDataGridView ( );
		}

		/*
			ComboBoxChanged 
			Подчищаем dgv за старыми таблицами, что-бы загрузить новую. 
			Далее начинается загрузка файла для записи информации в dgv.
			По окончанию вызывается метод для корректировки размера формы
		*/
		private void ComboBoxTable_SelectedIndexChanged ( object sender, EventArgs e ) {

			dataGridView.Columns.Clear ( );
			string path = Application.StartupPath + "\\" + comboBoxTable.SelectedItem + ".txt";
			MessageBox.Show ( path );
			string pattern = @"##";
			string[] loadedFile = File.ReadAllLines(path);
			string[] fileRow =  Regex.Split(loadedFile[0], pattern);

			if ( comboBoxTable.SelectedItem.ToString ( ) == "Перевозки" ) {
				string pathClients = Application.StartupPath + "\\Клиенты.txt";
				string pathService = Application.StartupPath + "\\Услуги.txt";
				string[] loadedFileClients = File.ReadAllLines(pathClients);
				string[] loadedFileService = File.ReadAllLines(pathService);
				int lengthColumn = fileRow.Length;

				for ( int column = 0; column < fileRow.Length; column++ ) {
					dataGridView.Columns.Add ( fileRow[ column ], fileRow[ column ] );
					dataGridView.Columns[ column ].SortMode = DataGridViewColumnSortMode.NotSortable;
				}
				dataGridView.Columns.Add ( "Общая сумма", "Общая сумма" );
				dataGridView.Columns[ dataGridView.Columns.Count - 1 ].SortMode = DataGridViewColumnSortMode.NotSortable;


				for ( int row = 1; row < loadedFile.Length - 1; row++ ) {
					dataGridView.Rows.Add ( );
					int lastIndexRow = dataGridView.Rows.Count - 1;
					fileRow = Regex.Split ( loadedFile[ row ], pattern );

					for ( byte column = 0; column < lengthColumn; column++ ) {
						if ( column == 0 | column > 3 ) {
							dataGridView.Rows[ lastIndexRow ].Cells[ column ].Value = fileRow[ column ];
						} else if ( column == 1 ) {
							if ( !string.IsNullOrWhiteSpace ( loadedFileClients[ int.Parse ( fileRow[ column ] ) ] ) ) {
								string[] fileRowClients =  Regex.Split(loadedFileClients[int.Parse(fileRow[column])], pattern);
								dataGridView.Rows[ lastIndexRow ].Cells[ column ].Value = fileRowClients[ 1 ];
							}
						} else if ( column == 2 ) {
							if ( !string.IsNullOrWhiteSpace ( loadedFileService[ int.Parse ( fileRow[ column ] ) ] ) ) {
								string[] fileRowService =  Regex.Split(loadedFileService[int.Parse(fileRow[column])], pattern);
								dataGridView.Rows[ lastIndexRow ].Cells[ column ].Value = fileRowService[ 1 ];
							}
						} else if ( column == 3 ) {
							if ( !string.IsNullOrWhiteSpace ( loadedFileService[ int.Parse ( fileRow[ column ] ) ] ) ) {
								string[] fileRowService =  Regex.Split(loadedFileService[int.Parse(fileRow[column])], pattern);
								dataGridView.Rows[ lastIndexRow ].Cells[ column ].Value = fileRowService[ 2 ];
							}
						}
					}
				}
				for ( int i = 0; i < dataGridView.Rows.Count; i++ ) {
					for ( int j = 0; j < loadedFileService.Length; j++ ) {
						string[] fileRowService =  Regex.Split(loadedFileService[j], pattern);
						if ( dataGridView.Rows[ i ].Cells[ 3 ].Value.ToString ( ) == fileRowService[ 2 ] ) {
							dataGridView.Rows[ i ].Cells[ dataGridView.Columns.Count - 1 ].Value = int.Parse ( fileRowService[ 3 ] ) * int.Parse(dataGridView.Rows[ i ].Cells[ dataGridView.Columns.Count - 2 ].Value.ToString());
						}
					}
				}
				ChangeTheWidthOfDataGridView ( );
			} else {
				for ( int column = 0; column < fileRow.Length; column++ ) {
					dataGridView.Columns.Add ( fileRow[ column ], fileRow[ column ] );
					dataGridView.Columns[ column ].SortMode = DataGridViewColumnSortMode.NotSortable;
				}

				for ( short row = 1; row < loadedFile.Length; row++ ) {
					if ( !string.IsNullOrWhiteSpace ( loadedFile[ row ] ) ) {
						dataGridView.Rows.Add ( );
						fileRow = Regex.Split ( loadedFile[ row ], pattern );
						int lastIndexRow = dataGridView.Rows.Count - 1;

						for ( byte column = 0; column < fileRow.Length; column++ ) {
							dataGridView.Rows[ lastIndexRow ].Cells[ column ].Value = fileRow[ column ];
						}
					}
				}


				ChangeTheWidthOfDataGridView ( );

				changeEdit = false;
			}
		}

		/*
		 Корректировка DataGridView
		*/
		public void ChangeTheWidthOfDataGridView ( ) {
			int widthDataGridView = new int();
			for ( int i = 0; i < dataGridView.Columns.Count; i++ ) {
				widthDataGridView += dataGridView.Columns[ i ].Width;
			}

			dataGridView.Width = widthDataGridView + 3;
			groupBoxButtons.Location = new Point ( widthDataGridView + 20, 5 );
			this.Width = groupBoxButtons.Location.X + 150;
		}

		/*
			Кнопка записи данных с DataGridView в файл 
		*/
		private void ButtonSave_Click ( object sender, EventArgs e ) {
			if ( changeEdit == true ) {
				DialogResult dialogResult = MessageBox.Show("Сохранить изменения?", "Сохранение", MessageBoxButtons.YesNo);
				if ( dialogResult == DialogResult.Yes ) {

					SaveInFile ( );
				}
			}
		}
		/*
		 Сохранение данных в файл, данные считываются с DataGridView и записываются в файл.
		 Если запись производится в таблицы: Клиенты, Услуги то просто считывается информация с DataGridView 
		 и записывается построчно в файл, при записи данных в таблицу Перевозки, применяется следующий метод -
		 берутся ключи из двух тоблиц Клиенты и Услуги, и записываются вместе с данными таблицы Перевозки.
		*/
		public void SaveInFile ( ) {
			string writeFile = "";
			string path = Application.StartupPath + "\\" + comboBoxTable.SelectedItem + ".txt";
			string pathClients = Application.StartupPath + "\\Клиенты.txt";
			string pathService = Application.StartupPath + "\\Услуги.txt";
			string[] loadedFileClients = File.ReadAllLines(pathClients);
			string[] loadedFileService = File.ReadAllLines(pathService);

			if ( comboBoxTable.SelectedItem.ToString ( ) == "Перевозки" ) {
				for ( byte column = 0; column < dataGridView.Columns.Count - 1; column++ ) {
					if ( column != dataGridView.Columns.Count - 2 ) {
						writeFile += dataGridView.Columns[ column ].Name.ToString ( ) + "##";
					} else {
						writeFile += dataGridView.Columns[ column ].Name.ToString ( ) + "\n";
					}
				}

				for ( short row = 0; row < dataGridView.Rows.Count; row++ ) {
					for ( byte column = 0; column < dataGridView.Columns.Count - 1; column++ ) {
						
						if ( column == 1 ) {
							for ( int j = 1; j < loadedFileClients.Length; j++ ) {
								string pattern = @"##";
								string[] fileRowClients =  Regex.Split(loadedFileClients[j], pattern);
								if ( fileRowClients[ 1 ] == dataGridView.Rows[ row ].Cells[ column ].Value.ToString ( ) ) {
									writeFile += fileRowClients[ 0 ] + "##";
									break;
								}
							}
						} else if ( column == 2 ) {
							for ( int j = 1; j < loadedFileService.Length; j++ ) {
								string pattern = @"##";
								string[] fileRowService =  Regex.Split(loadedFileService[j], pattern);
								if ( fileRowService[ 1 ] == dataGridView.Rows[ row ].Cells[ column ].Value.ToString ( ) ) {
									writeFile += fileRowService[ 0 ] + "##";
									break;
								}
							}
						} else if ( column == 3 ) {
							for ( int j = 1; j < loadedFileService.Length; j++ ) {
								string pattern = @"##";
								string[] fileRowService =  Regex.Split(loadedFileService[j], pattern);
								if ( fileRowService[ 2 ] == dataGridView.Rows[ row ].Cells[ column ].Value.ToString ( ) ) {
									writeFile += fileRowService[ 0 ] + "##";
									break;
								}
							}
						} else if ( column == 5 ) {
							writeFile += dataGridView.Rows[ row ].Cells[ column ].Value.ToString ( ) + "\n";
						} else {
							writeFile += dataGridView.Rows[ row ].Cells[ column ].Value.ToString ( ) + "##";
						}
					}
				}

				File.WriteAllText ( path, writeFile );
				changeEdit = false;
			} else {
				for ( byte column = 0; column < dataGridView.Columns.Count; column++ ) {
					if ( column != dataGridView.Columns.Count - 1 ) {
						writeFile += dataGridView.Columns[ column ].Name.ToString ( ) + "##";
					} else {
						writeFile += dataGridView.Columns[ column ].Name.ToString ( ) + "\n";
					}
				}

				for ( short row = 0; row < dataGridView.Rows.Count; row++ ) {
					for ( byte column = 0; column < dataGridView.Columns.Count; column++ ) {
						if ( column != dataGridView.Columns.Count - 1 ) {
							writeFile += dataGridView.Rows[ row ].Cells[ column ].Value.ToString ( ) + "##";
						} else {
							writeFile += dataGridView.Rows[ row ].Cells[ column ].Value.ToString ( ) + "\n";
						}
					}
				}

				File.WriteAllText ( path, writeFile );
				changeEdit = false;
			}
		}

		/*
		 Кнопка для выхода из формы, при выходе проверяет на корректирование данных, если те есть то предлагает
		 сохранить их, затем выходит из формы.
		*/
		private void ButtonExit_Click ( object sender, EventArgs e ) {
			if ( changeEdit == true ) {
				DialogResult dialogResult = MessageBox.Show("Сохранить изменения?", "Сохранение", MessageBoxButtons.YesNo);
				if ( dialogResult == DialogResult.Yes ) {
					SaveInFile ( );
				}
			}
			Close ( );
		}

		/*
		 Кнопка для удаление строки из DataGridView
		*/
		private void ButtonDelete_Click ( object sender, EventArgs e ) {
			if ( dataGridView.Rows.Count != 0 ) {
				dataGridView.Rows.RemoveAt ( dataGridView.CurrentRow.Index );
				changeEdit = true;
			}
		}

		/*
		 Открывает новую форму
		*/
		public void ShowFormDialog ( Form nameForm ) {
			nameForm.Owner = this;
			nameForm.StartPosition = FormStartPosition.CenterParent;
			nameForm.ShowDialog ( );
		}

		/*
		 Вызывает форму для редактирования
		*/
		private void ButtonEdit_Click ( object sender, EventArgs e ) {
			ShowFormDialog ( new FormEdit ( ) );
		}
		/*
		 Вызывает форму для добавления
		*/
		private void ButtonAdd_Click ( object sender, EventArgs e ) {
			ShowFormDialog ( new FormAdd ( ) );
		}

		/*
			Вызывает форму статистическую форму  
		*/
		private void Button_Click ( object sender, EventArgs e ) {
			ShowFormDialog ( new FormStatistic ( ) );
		}

		private void comboBoxTable_Click ( object sender, EventArgs e ) {
			if ( changeEdit == true ) {
				DialogResult dialogResult = MessageBox.Show(this, "Сохранить данные", "Сохранение данных", MessageBoxButtons.YesNo);
				if ( dialogResult == DialogResult.Yes ) {
					SaveInFile ( );
					changeEdit = false;
				}
			}
		}
	}
}