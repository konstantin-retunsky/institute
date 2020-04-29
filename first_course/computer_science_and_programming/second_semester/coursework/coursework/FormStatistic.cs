using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace coursework {
	public partial class FormStatistic : Form {
		public FormStatistic ( ) {
			InitializeComponent ( );
		}
		private void StatisticForm_Load ( object sender, EventArgs e ) {
			comboBoxTable.Items.AddRange ( new string[] { "Клиенты",
																									"Услуги",
																									"Перевозки" } );

			comboBoxTable.SelectedItem = "Перевозки";
			comboBoxTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboBoxCells.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			dataGridViewStatistic.RowHeadersVisible = false;
		}
		private void ButtonTopYear_Click ( object sender, EventArgs e ) {
			comboBoxTable.SelectedItem = "Перевозки";
			LoadedDataGridView ( );
			List<string> years = new List<string>();
			for ( int i = 0; i < dataGridViewStatistic.RowCount; i++ ) {
				if ( !years.Contains ( dataGridViewStatistic.Rows[ i ].Cells[ 4 ].Value.ToString ( ).Remove ( 0, 6 ) ) ) {
					years.Add ( dataGridViewStatistic.Rows[ i ].Cells[ 4 ].Value.ToString ( ).Remove ( 0, 6 ) );
					
				}
			}
			int[] sumYears = new int[years.Count];
			for ( int i = 0; i < dataGridViewStatistic.RowCount; i++ ) {
				for ( int j = 0; j < years.Count; j++ ) {
					if ( dataGridViewStatistic.Rows[ i ].Cells[ 4 ].Value.ToString ( ).Remove ( 0, 6 ) == years[ j ] ) {
						sumYears[j] +=  int.Parse( dataGridViewStatistic.Rows[ i ].Cells[ dataGridViewStatistic.Columns.Count - 1 ].Value.ToString ( ));
					}
				}				
			}

			dataGridViewStatistic.Rows.Clear ( );
			dataGridViewStatistic.Columns.Clear ( );
			dataGridViewStatistic.Columns.Add ( "Лучший год", "Лучший год" );
			dataGridViewStatistic.Columns.Add ( "Общая сумма", "Общая сумма" );

			for ( int i = 0; i < years.Count; i++ ) {
				dataGridViewStatistic.Rows.Add ( );
				dataGridViewStatistic.Rows[ i ].Cells[ 0 ].Value = years[ i ] + " - год";
				dataGridViewStatistic.Rows[ i ].Cells[ 1 ].Value = sumYears[ i ];
			}

			string tempNum;
			string tempStr;
			for ( int i = 0; i < dataGridViewStatistic.Rows.Count - 1; i++ ) {
				for ( int j = 0; j < dataGridViewStatistic.Rows.Count - i - 1; j++ ) {
					if ( int.Parse ( dataGridViewStatistic.Rows[ j + 1 ].Cells[ 1 ].Value.ToString ( ) ) > int.Parse ( dataGridViewStatistic.Rows[ j ].Cells[ 1 ].Value.ToString ( ) ) ) {
						tempNum = dataGridViewStatistic.Rows[ j + 1 ].Cells[ 1 ].Value.ToString ( );
						dataGridViewStatistic.Rows[ j + 1 ].Cells[ 1 ].Value = dataGridViewStatistic.Rows[ j ].Cells[ 1 ].Value.ToString ( );
						dataGridViewStatistic.Rows[ j ].Cells[ 1 ].Value = tempNum;

						tempStr = dataGridViewStatistic.Rows[ j + 1 ].Cells[ 0 ].Value.ToString ( );
						dataGridViewStatistic.Rows[ j + 1 ].Cells[ 0 ].Value = dataGridViewStatistic.Rows[ j ].Cells[ 0 ].Value.ToString ( );
						dataGridViewStatistic.Rows[ j ].Cells[ 0 ].Value = tempStr;
					}
				}
			}
		}

		private void ButtonTopClient_Click ( object sender, EventArgs e ) {
			comboBoxTable.SelectedItem = "Перевозки";
			LoadedDataGridView ( );
			List<string> clients = new List<string>();
			for ( int i = 0; i < dataGridViewStatistic.RowCount; i++ ) {
				if ( !clients.Contains ( dataGridViewStatistic.Rows[ i ].Cells[ 1 ].Value.ToString ( ) ) ) {
					clients.Add ( dataGridViewStatistic.Rows[ i ].Cells[ 1 ].Value.ToString() );

				}
			}
			int[] sumYears = new int[clients.Count];
			for ( int i = 0; i < dataGridViewStatistic.RowCount; i++ ) {
				for ( int j = 0; j < clients.Count; j++ ) {
					if ( dataGridViewStatistic.Rows[ i ].Cells[ 1 ].Value.ToString ( ) == clients[ j ] ) {
						sumYears[ j ] += int.Parse ( dataGridViewStatistic.Rows[ i ].Cells[ dataGridViewStatistic.Columns.Count - 1 ].Value.ToString ( ) );
					}
				}
			}

			dataGridViewStatistic.Rows.Clear ( );
			dataGridViewStatistic.Columns.Clear ( );
			dataGridViewStatistic.Columns.Add ( "Лучший клиент", "Лучший клиент" );
			dataGridViewStatistic.Columns.Add ( "Общая сумма", "Общая сумма" );

			for ( int i = 0; i < clients.Count; i++ ) {
				dataGridViewStatistic.Rows.Add ( );
				dataGridViewStatistic.Rows[ i ].Cells[ 0 ].Value = clients[ i ];
				dataGridViewStatistic.Rows[ i ].Cells[ 1 ].Value = sumYears[ i ];
			}

			string tempNum;
			string tempStr;
			for ( int i = 0; i < dataGridViewStatistic.Rows.Count - 1; i++ ) {
				for ( int j = 0; j < dataGridViewStatistic.Rows.Count - i - 1; j++ ) {
					if ( int.Parse ( dataGridViewStatistic.Rows[ j + 1 ].Cells[ 1 ].Value.ToString ( ) ) > int.Parse ( dataGridViewStatistic.Rows[ j ].Cells[ 1 ].Value.ToString ( ) ) ) {
						tempNum = dataGridViewStatistic.Rows[ j + 1 ].Cells[ 1 ].Value.ToString ( );
						dataGridViewStatistic.Rows[ j + 1 ].Cells[ 1 ].Value = dataGridViewStatistic.Rows[ j ].Cells[ 1 ].Value.ToString ( );
						dataGridViewStatistic.Rows[ j ].Cells[ 1 ].Value = tempNum;

						tempStr = dataGridViewStatistic.Rows[ j + 1 ].Cells[ 0 ].Value.ToString ( );
						dataGridViewStatistic.Rows[ j + 1 ].Cells[ 0 ].Value = dataGridViewStatistic.Rows[ j ].Cells[ 0 ].Value.ToString ( );
						dataGridViewStatistic.Rows[ j ].Cells[ 0 ].Value = tempStr;
					}
				}
			}
		}
		public void LoadedDataGridView ( ) {
			dataGridViewStatistic.Columns.Clear ( );
			string path = Application.StartupPath + "\\" + comboBoxTable.SelectedItem + ".txt";
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
					dataGridViewStatistic.Columns.Add ( fileRow[ column ], fileRow[ column ] );
					dataGridViewStatistic.Columns[ column ].SortMode = DataGridViewColumnSortMode.NotSortable;
				}
				dataGridViewStatistic.Columns.Add ( "Общая сумма", "Общая сумма" );
				dataGridViewStatistic.Columns[ dataGridViewStatistic.Columns.Count - 1 ].SortMode = DataGridViewColumnSortMode.NotSortable;


				for ( int row = 1; row < loadedFile.Length - 1; row++ ) {
					dataGridViewStatistic.Rows.Add ( );
					int lastIndexRow = dataGridViewStatistic.Rows.Count - 1;
					fileRow = Regex.Split ( loadedFile[ row ], pattern );

					for ( byte column = 0; column < lengthColumn; column++ ) {
						if ( column == 0 | column > 3 ) {
							dataGridViewStatistic.Rows[ lastIndexRow ].Cells[ column ].Value = fileRow[ column ];
						} else if ( column == 1 ) {
							if ( !string.IsNullOrWhiteSpace ( loadedFileClients[ int.Parse ( fileRow[ column ] ) ] ) ) {
								string[] fileRowClients =  Regex.Split(loadedFileClients[int.Parse(fileRow[column])], pattern);
								dataGridViewStatistic.Rows[ lastIndexRow ].Cells[ column ].Value = fileRowClients[ 1 ];
							}
						} else if ( column == 2 ) {
							if ( !string.IsNullOrWhiteSpace ( loadedFileService[ int.Parse ( fileRow[ column ] ) ] ) ) {
								string[] fileRowService =  Regex.Split(loadedFileService[int.Parse(fileRow[column])], pattern);
								dataGridViewStatistic.Rows[ lastIndexRow ].Cells[ column ].Value = fileRowService[ 1 ];
							}
						} else if ( column == 3 ) {
							if ( !string.IsNullOrWhiteSpace ( loadedFileService[ int.Parse ( fileRow[ column ] ) ] ) ) {
								string[] fileRowService =  Regex.Split(loadedFileService[int.Parse(fileRow[column])], pattern);
								dataGridViewStatistic.Rows[ lastIndexRow ].Cells[ column ].Value = fileRowService[ 2 ];
							}
						}
					}
				}
				for ( int i = 0; i < dataGridViewStatistic.Rows.Count; i++ ) {
					for ( int j = 0; j < loadedFileService.Length; j++ ) {
						string[] fileRowService =  Regex.Split(loadedFileService[j], pattern);
						if ( dataGridViewStatistic.Rows[ i ].Cells[ 3 ].Value.ToString ( ) == fileRowService[ 2 ] ) {
							dataGridViewStatistic.Rows[ i ].Cells[ dataGridViewStatistic.Columns.Count - 1 ].Value = int.Parse ( fileRowService[ 3 ] ) * int.Parse ( dataGridViewStatistic.Rows[ i ].Cells[ dataGridViewStatistic.Columns.Count - 2 ].Value.ToString ( ) );
						}
					}
				}

			} else {
				for ( int column = 0; column < fileRow.Length; column++ ) {
					dataGridViewStatistic.Columns.Add ( fileRow[ column ], fileRow[ column ] );
					dataGridViewStatistic.Columns[ column ].SortMode = DataGridViewColumnSortMode.NotSortable;
				}

				for ( short row = 1; row < loadedFile.Length; row++ ) {
					if ( !string.IsNullOrWhiteSpace ( loadedFile[ row ] ) ) {
						dataGridViewStatistic.Rows.Add ( );
						fileRow = Regex.Split ( loadedFile[ row ], pattern );
						int lastIndexRow = dataGridViewStatistic.Rows.Count - 1;

						for ( byte column = 0; column < fileRow.Length; column++ ) {
							dataGridViewStatistic.Rows[ lastIndexRow ].Cells[ column ].Value = fileRow[ column ];
						}
					}
				}
			}
		}
		private void ComboBoxTable_SelectionChangeCommitted ( object sender, EventArgs e ) {
			LoadedDataGridView ( );
			comboBoxCells.Items.Clear ( );
			for ( int i = 1; i < dataGridViewStatistic.Columns.Count; i ++ ) {
				comboBoxCells.Items.Add ( dataGridViewStatistic.Columns[ i ].Name.ToString ( ) );
			}
		}


		private void BttonTopService_Click ( object sender, EventArgs e ) {
			comboBoxTable.SelectedItem = "Перевозки";
			LoadedDataGridView ( );
			List<string> services = new List<string>();
			for ( int i = 0; i < dataGridViewStatistic.RowCount; i++ ) {
				if ( !services.Contains ( dataGridViewStatistic.Rows[ i ].Cells[ 2 ].Value.ToString ( ) ) ) {
					services.Add ( dataGridViewStatistic.Rows[ i ].Cells[ 2 ].Value.ToString ( ) );

				}
			}
			int[] sumYears = new int[services.Count];
			for ( int i = 0; i < dataGridViewStatistic.RowCount; i++ ) {
				for ( int j = 0; j < services.Count; j++ ) {
					if ( dataGridViewStatistic.Rows[ i ].Cells[ 2 ].Value.ToString ( ) == services[ j ] ) {
						sumYears[ j ] += int.Parse ( dataGridViewStatistic.Rows[ i ].Cells[ dataGridViewStatistic.Columns.Count - 1 ].Value.ToString ( ) );
					}
				}
			}

			dataGridViewStatistic.Rows.Clear ( );
			dataGridViewStatistic.Columns.Clear ( );
			dataGridViewStatistic.Columns.Add ( "Лучшая услуга", "Лучшая услуга" );
			dataGridViewStatistic.Columns.Add ( "Общая сумма", "Общая сумма" );

			for ( int i = 0; i < services.Count; i++ ) {
				dataGridViewStatistic.Rows.Add ( );
				dataGridViewStatistic.Rows[ i ].Cells[ 0 ].Value = services[ i ];
				dataGridViewStatistic.Rows[ i ].Cells[ 1 ].Value = sumYears[ i ];
			}

			string tempNum;
			string tempStr;
			for ( int i = 0; i < dataGridViewStatistic.Rows.Count - 1; i++ ) {
				for ( int j = 0; j < dataGridViewStatistic.Rows.Count - i - 1; j++ ) {
					if ( int.Parse ( dataGridViewStatistic.Rows[ j + 1 ].Cells[ 1 ].Value.ToString ( ) ) > int.Parse ( dataGridViewStatistic.Rows[ j ].Cells[ 1 ].Value.ToString ( ) ) ) {
						tempNum = dataGridViewStatistic.Rows[ j + 1 ].Cells[ 1 ].Value.ToString ( );
						dataGridViewStatistic.Rows[ j + 1 ].Cells[ 1 ].Value = dataGridViewStatistic.Rows[ j ].Cells[ 1 ].Value.ToString ( );
						dataGridViewStatistic.Rows[ j ].Cells[ 1 ].Value = tempNum;

						tempStr = dataGridViewStatistic.Rows[ j + 1 ].Cells[ 0 ].Value.ToString ( );
						dataGridViewStatistic.Rows[ j + 1 ].Cells[ 0 ].Value = dataGridViewStatistic.Rows[ j ].Cells[ 0 ].Value.ToString ( );
						dataGridViewStatistic.Rows[ j ].Cells[ 0 ].Value = tempStr;
					}
				}
			}
		}

		private void TextBoxSearch_TextChanged ( object sender, EventArgs e ) {
			// поиск в datagridview
			for ( int i = 0; i < dataGridViewStatistic.Rows.Count; i++ ) {
				try {
					if ( Regex.IsMatch ( dataGridViewStatistic.Rows[ i ].Cells[ dataGridViewStatistic.Columns[ comboBoxCells.Text ].Index ].Value.ToString ( ), $@"^{textBoxSearch.Text}", RegexOptions.Multiline ) ) {
						dataGridViewStatistic.Rows[ i ].Visible = true;
					} else {
						dataGridViewStatistic.Rows[ i ].Visible = false;
					}
				} catch {
					MessageBox.Show ( "Введенный символ недопустим" );
					break;
				}

			}
		}

		private void ComboBoxCells_SelectedIndexChanged ( object sender, EventArgs e ) {

			// автозаполнение textBoxSearch
			AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
			textBoxSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			textBoxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;


			for ( int dgvRow = 0; dgvRow < dataGridViewStatistic.RowCount; dgvRow++ ) {
				autoComplete.Add ( dataGridViewStatistic.Rows[ dgvRow ].Cells[ dataGridViewStatistic.Columns[ comboBoxCells.Text ].Index ].Value.ToString ( ) );
			}
			textBoxSearch.AutoCompleteCustomSource = autoComplete;
		}
	}
}
