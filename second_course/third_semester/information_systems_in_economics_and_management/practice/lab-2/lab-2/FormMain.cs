using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2 {

  public partial class FormMain : Form {

    public FormMain ( ) {
      InitializeComponent( );
    }

    private void FormMain_Load ( object sender, EventArgs e ) {

      dgvCoreCosts.Rows.Add( );
      dgvCoreCosts.Rows [ dgvCoreCosts.Rows.Count - 1 ].Cells [ 0 ].Value = "Итог:";

      dgvFunction.Rows.Add( 2 );
      dgvFunction.Rows [ dgvFunction.Rows.Count - 1 ].Cells [ 0 ].Value = "В долях:";
      dgvFunction.Rows [ dgvFunction.Rows.Count - 2 ].Cells [ 0 ].Value = "Итог:";

      dgvComparisonMatrix.Rows.Add( );
      dgvComparisonMatrix.Rows [ dgvComparisonMatrix.Rows.Count - 1 ].Cells [ 0 ].Value = "Итог:";

      for ( int i = 2; i < dgvCoreCosts.ColumnCount; i += 2 ) {
        dgvCoreCosts.Columns [ i ].ReadOnly = true;
        if ( i == dgvCoreCosts.ColumnCount - 2 ) {
          dgvCoreCosts.Columns [ dgvCoreCosts.ColumnCount - 1 ].ReadOnly = true;
        }
      }

      for ( int row = 0; row < dgvComparisonMatrix.RowCount; row++ ) {
        for ( int column = 0; column < dgvComparisonMatrix.ColumnCount; column++ ) {

        }
      }

    } //FormMain_Load


    private void numericBoxStructuralElement_ValueChanged ( object sender, EventArgs e ) {

      int valueStructuralElement = int.Parse(numericBoxStructuralElement.Value.ToString());

      if ( valueStructuralElement > 0 ) {
        dgvCoreCosts.Rows.Clear( );
        dgvCoreCosts.Rows.Add( );
        dgvCoreCosts.Rows [ dgvCoreCosts.Rows.Count - 1 ].Cells [ 0 ].Value = "Итог:";
        dgvCoreCosts.Rows.Insert( 0, valueStructuralElement );

        for ( int i = 0; i < dgvCoreCosts.Rows.Count - 1; i++ ) {
          dgvCoreCosts.Rows [ i ].Cells [ 0 ].Value = $"Элемент-{ i + 1 }";
        }

        dgvFunction.Rows.Clear( );
        dgvFunction.Rows.Add( 2 );
        dgvFunction.Rows [ dgvFunction.Rows.Count - 1 ].Cells [ 0 ].Value = "В долях:";
        dgvFunction.Rows [ dgvFunction.Rows.Count - 2 ].Cells [ 0 ].Value = "Итог:";

        dgvFunction.Rows.Insert( 0, valueStructuralElement * 2 );

        for ( int i = 0; i < dgvFunction.Rows.Count / 2 - 1; i++ ) {
          dgvFunction.Rows [ i * 2 ].Cells [ 0 ].Value = $"Элемент-{ i }";
        }
      }
    } // numericBoxStructuralElement_ValueChanged

    private void numericBoxFunctions_ValueChanged ( object sender, EventArgs e ) {

      int valueBoxFunctions = int.Parse(numericBoxFunctions.Value.ToString());

      if ( valueBoxFunctions > 0 ) {

        dgvComparisonMatrix.Columns.Clear( );
        dgvComparisonMatrix.Columns.Add( "", "" );
        dgvComparisonMatrix.Columns.Add( "Сумма ряда", "Сумма ряда" );
        dgvComparisonMatrix.Columns.Add( "Доля значимости", "Доля значимости" );
        dgvComparisonMatrix.Rows.Add( valueBoxFunctions + 1 );

        for ( int i = 0; i < dgvComparisonMatrix.Rows.Count - 1; i++ ) {
          DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
          dataGridViewTextBoxColumn.HeaderText = $"Функция-{( dgvComparisonMatrix.Rows.Count - 1 ) - i }";
          dgvComparisonMatrix.Columns.Insert( 1, dataGridViewTextBoxColumn );

        }

        for ( int i = 0; i < dgvComparisonMatrix.Rows.Count - 1; i++ ) {
          dgvComparisonMatrix.Rows [ i ].Cells [ 0 ].Value = $"Функция-{i + 1}";
          dgvComparisonMatrix.Rows [ i ].Cells [ i + 1 ].Value = "0";
          dgvComparisonMatrix.Rows [ i ].Cells [ i + 1 ].Style.BackColor = Color.FromArgb( 223, 225, 230 );
          dgvComparisonMatrix.Rows [ i ].Cells [ i + 1 ].ReadOnly = true;
        }

        dgvComparisonMatrix.Columns [ dgvComparisonMatrix.ColumnCount - 1 ].ReadOnly = true;
        dgvComparisonMatrix.Columns [ dgvComparisonMatrix.ColumnCount - 2 ].ReadOnly = true;
        dgvComparisonMatrix.Rows [ dgvComparisonMatrix.Rows.Count - 1 ].Cells [ 0 ].Value = "Итог:";


        int countDgvFunction = dgvFunction.Columns.Count;

        if ( dgvFunction.Columns.Count > 2 ) {
          for ( int i = 2; i < countDgvFunction; i++ ) {
            dgvFunction.Columns.RemoveAt( 2 );
          }

        }
        for ( int i = 0; i < valueBoxFunctions; i++ ) {
          dgvFunction.Columns.Add( $"Функция-{i + 1}", $"Функция-{i + 1}" );
        }
        dgvComparisonMatrix.Rows [ dgvComparisonMatrix.RowCount - 1 ].ReadOnly = true;
      }
    } //numericBoxFunctions_ValueChanged

    private void buttonCalculate_Click ( object sender, EventArgs e ) {

      /*
       dgvCoreCosts
      */

      bool checkOne = true;


      for ( int i = 0; i < int.Parse( numericBoxStructuralElement.Value.ToString( ) ); i++ ) {
        for ( int j = 1; j <= 7; j += 2 ) {
          if ( dgvCoreCosts.Rows [ i ].Cells [ j ].Value == null ) {
            checkOne = false;
          }
        }
      }

      for ( int i = 0; i < int.Parse( numericBoxStructuralElement.Value.ToString( ) ); i++ ) {
        for ( int j = 1; j <= 7; j += 2 ) {
          if ( dgvCoreCosts.Rows [ i ].Cells [ j ].Value == null ) {
            checkOne = false;
          }
        }
      }

      double systemCost = double.Parse( numericBoxSystemCost.Value.ToString( ) );

      if ( checkOne ) {


        double sumDays = default;
        int indexSumRow = dgvCoreCosts.RowCount - 1;

        dgvCoreCosts.Rows [ indexSumRow ].ReadOnly = true;

        for ( int column = 1; column < dgvCoreCosts.ColumnCount - 2; column += 2 ) {

          double columnSum = default;

          for ( int row = 0; row < dgvCoreCosts.RowCount - 1; row++ ) {
            columnSum += double.Parse( dgvCoreCosts.Rows [ row ].Cells [ column ].Value.ToString( ) );
          }

          sumDays += columnSum;
          dgvCoreCosts.Rows [ indexSumRow ].Cells [ column ].Value = columnSum.ToString( );
        }


        double priceDay = systemCost / sumDays;
        indexSumRow = dgvCoreCosts.RowCount - 1;

        for ( int column = 2; column < dgvCoreCosts.ColumnCount - 1; column += 2 ) {

          double columnSum = default;

          for ( int row = 0; row < dgvCoreCosts.RowCount - 1; row++ ) {

            double numberOfDays = double.Parse(dgvCoreCosts.Rows[ row ].Cells[ column - 1 ].Value.ToString());
            columnSum += numberOfDays * priceDay;

            dgvCoreCosts.Rows [ row ].Cells [ column ].Value = Math.Round( priceDay * numberOfDays, 2 );
          }

          dgvCoreCosts.Rows [ indexSumRow ].Cells [ column ].Value = Math.Round( columnSum, 2 );
        }


        int lastIndexColumn = dgvCoreCosts.ColumnCount - 1;

        for ( int row = 0; row < dgvCoreCosts.RowCount; row++ ) {

          double rowSum = default;

          for ( int column = 2; column < dgvCoreCosts.ColumnCount; column += 2 ) {
            rowSum += double.Parse( dgvCoreCosts.Rows [ row ].Cells [ column ].Value.ToString( ) );
          }
          dgvCoreCosts.Rows [ row ].Cells [ lastIndexColumn ].Value = rowSum;
        }
      } else {
        MessageBox.Show( "Данные таблице \"Затраты для основных структурных элементов\" заполнены неверно" );
      }
      ///*
      // dgvComparisonMatrix
      // */
      bool checkedCell = true;
      for ( int row = 0; row < dgvComparisonMatrix.RowCount - 1; row++ ) {

        double sumRow = default;

        for ( int column = 1; column < dgvComparisonMatrix.ColumnCount - 2; column++ ) {

          if ( dgvComparisonMatrix.Rows [ row ].Cells [ column ].Value != null & dgvComparisonMatrix.Rows [ column - 1 ].Cells [ row + 1 ].Value != null ) {

            double indexRowColumn = double.Parse(dgvComparisonMatrix.Rows [ row ].Cells [ column ].Value.ToString( ));
            double indexColumnRow = double.Parse(dgvComparisonMatrix.Rows [ column - 1 ].Cells [ row + 1 ].Value.ToString( ));
            sumRow += indexRowColumn;

            if ( !( indexColumnRow + indexRowColumn == 10 ) & row != column - 1 ) {
              checkedCell = false;

            }

          } else {
            checkedCell = false;
          }
        }
        dgvComparisonMatrix.Rows [ row ].Cells [ dgvComparisonMatrix.ColumnCount - 2 ].Value = sumRow;
      }

      if ( checkedCell ) {
        for ( int column = 1; column < dgvComparisonMatrix.ColumnCount - 1; column++ ) {
          double sumColumn = default;
          for ( int row = 0; row < dgvComparisonMatrix.RowCount - 1; row++ ) {
            double indexColumnRow = double.Parse(dgvComparisonMatrix.Rows [ row ].Cells [ column ].Value.ToString( ));
            sumColumn += indexColumnRow;
          }
          dgvComparisonMatrix.Rows [ dgvComparisonMatrix.RowCount - 1 ].Cells [ column ].Value = sumColumn;
        }

        double sum = double.Parse( dgvComparisonMatrix.Rows[dgvComparisonMatrix.RowCount - 1].Cells[dgvComparisonMatrix.ColumnCount - 2].Value.ToString( ) );

        for ( int i = 0; i < dgvComparisonMatrix.RowCount; i++ ) {
          double temp = double.Parse(dgvComparisonMatrix.Rows[ i ].Cells[dgvComparisonMatrix.ColumnCount - 2].Value.ToString());
          dgvComparisonMatrix.Rows [ i ].Cells [ dgvComparisonMatrix.ColumnCount - 1 ].Value = Math.Round( temp / sum, 2 );
        }

        int kostil = default;
        for ( int i = 0; i < dgvFunction.RowCount - 2; i += 2 ) {
          dgvFunction.Rows [ i ].Cells [ 1 ].Value = dgvCoreCosts.Rows [ kostil ].Cells [ dgvCoreCosts.ColumnCount - 1 ].Value.ToString( );
          kostil++;
        }

        dgvFunction.Rows [ dgvFunction.RowCount - 1 ].Cells [ 1 ].Value = 1;
        dgvFunction.Rows [ dgvFunction.RowCount - 2 ].Cells [ 1 ].Value = systemCost;


        bool checkTwo = true;
        for ( int i = 0; i < dgvFunction.Rows.Count - 2; i += 2 ) {
          for ( int j = 2; j < dgvFunction.Columns.Count; j++ ) {
            if ( dgvFunction.Rows [ i ].Cells [ j ].Value == null ) {
              //checkTwo = false;
              dgvFunction.Rows [ i ].Cells [ j ].Value = "0";
            }
          }
        }
        if ( checkTwo ) {
          for ( int i = 0; i < dgvFunction.RowCount - 2; i += 2 ) {
            for ( int j = 2; j < dgvFunction.ColumnCount; j++ ) {
              dgvFunction.Rows [ i + 1 ].Cells [ j ].Value = double.Parse( dgvFunction.Rows [ i ].Cells [ j ].Value.ToString( ) ) * double.Parse( dgvFunction.Rows [ i ].Cells [ 1 ].Value.ToString( ) );
            }
          }

          for ( int i = 2; i < dgvFunction.ColumnCount; i++ ) {
            sum = 0;
            for ( int j = 1; j < dgvFunction.RowCount - 1; j += 2 ) {
              sum += double.Parse( dgvFunction.Rows [ j ].Cells [ i ].Value.ToString( ) );
            }
            dgvFunction.Rows [ dgvFunction.RowCount - 2 ].Cells [ i ].Value = sum;
          }
          for ( int i = 2; i < dgvFunction.ColumnCount; i++ ) {
            dgvFunction.Rows [ dgvFunction.RowCount - 1 ].Cells [ i ].Value = Math.Round( double.Parse( dgvFunction.Rows [ dgvFunction.RowCount - 2 ].Cells [ i ].Value.ToString( ) ) / double.Parse( dgvFunction.Rows [ dgvFunction.RowCount - 2 ].Cells [ 1 ].Value.ToString( ) ), 2 );
          }



          for ( int i = 0; i < ( int ) numericBoxFunctions.Value; i++ ) {
            chart.Series [ 0 ].Points.AddXY( i + 1, decimal.Parse( dgvFunction [ i + 2, 2 * ( int ) numericBoxStructuralElement.Value + 1 ].Value.ToString( ) ) );
            chart.Series [ 1 ].Points.AddXY( i + 1, decimal.Parse( dgvComparisonMatrix.Rows [ i ].Cells [ dgvComparisonMatrix.ColumnCount - 1 ].Value.ToString( ) ) );
          }
        } else {
          MessageBox.Show( "Данные в таблице \"Совмещенная модель определения стоимости функций\" заполнены некорректно" );
        }

      } else {
        MessageBox.Show( "Данные в таблице \"Матрица парных сравнений значимости функций\" заполнены некорректно" );
      }




    } // buttonCalculate_Click

    private void dgvComparisonMatrix_CellValueChanged ( object sender, DataGridViewCellEventArgs e ) {
      for ( int row = 0; row < dgvComparisonMatrix.RowCount - 1; row++ ) {
        for ( int cell = 1; cell < dgvComparisonMatrix.ColumnCount - 2; cell++ ) {

          if ( dgvComparisonMatrix.Rows [ row ].Cells [ cell ].Value != null ) {
            if ( double.Parse( dgvComparisonMatrix.Rows [ row ].Cells [ cell ].Value.ToString( ) ) > 10 & row != ( cell - 1 ) ) {
              MessageBox.Show( "Данные введены некорректно" );
              dgvComparisonMatrix.Rows [ row ].Cells [ cell ].Value = "0";
            } else if ( row != ( cell - 1 ) ) {
              dgvComparisonMatrix.Rows [ cell - 1 ].Cells [ row + 1 ].Value = 10 - double.Parse( dgvComparisonMatrix.Rows [ row ].Cells [ cell ].Value.ToString( ) );
            }
          }
        }
      }
    }

    private void dgvCoreCosts_CellValueChanged ( object sender, DataGridViewCellEventArgs e ) {
      int sum = 0;
      for ( int row = 0; row < dgvCoreCosts.RowCount - 1; row++ ) {
        for ( int cell = 1; cell < dgvCoreCosts.ColumnCount - 2; cell += 2 ) {
          if ( dgvCoreCosts.Rows [ row ].Cells [ cell ].Value != null ) {
            sum += int.Parse( dgvCoreCosts.Rows [ row ].Cells [ cell ].Value.ToString( ) );
          }
        }
      }
      sumDays.Value = sum;
    }
  }
}
