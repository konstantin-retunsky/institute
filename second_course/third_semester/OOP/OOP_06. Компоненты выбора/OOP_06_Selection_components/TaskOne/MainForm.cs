using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskOne {
  public partial class MainForm : Form {
    public MainForm ( ) {
      InitializeComponent( );
    }

    private void radioButton5_CheckedChanged ( object sender, EventArgs e ) {
      RadioButton radioButton = (RadioButton)sender;
      if ( radioButton.Checked ) {
        textBox2.Enabled = false;
        groupBox6.Enabled = false;
        groupBox6.Visible = false;
        groupBox4.Enabled = true;
        groupBox4.Visible = true;
      }
    }

    private void radioButton6_CheckedChanged ( object sender, EventArgs e ) {
      RadioButton radioButton = (RadioButton)sender;
      if ( radioButton.Checked ) {
        textBox2.Enabled = true;
        groupBox6.Enabled = true;
        groupBox6.Visible = true;
        groupBox4.Enabled = false;
        groupBox4.Visible = false;
      }
    }
    private void button1_Click ( object sender, EventArgs e ) {

      if ( rbCtg.Checked & textBox1.Text == "0" ) {
        MessageBox.Show( "ctg(0) не существует" );
        
      } else {
        for ( int i = 0; i < 4; i++ ) {
          if ( groupBox4.Enabled != false & ( ( RadioButton ) groupBox4.Controls [ i ] ).Checked == true ) {
            textBox3.Text = Result( i + 1 ); //т.к. в цикле отсчет от 0, а в методе от 1
          }
          if ( groupBox6.Enabled != false & ( ( RadioButton ) groupBox6.Controls [ i ] ).Checked == true ) {
            // +1 т.к. в цикле отсчет от 0, а в методе от 1 // +4 т.к. второй контейнер
            textBox3.Text = Result( i + 1 + 4 );
          }

          if ( checkBoxFormula.Checked == true )
            labelFormula.Text = TextFormula( );
        }
      }
    }

    private string Result ( int indexRadioButton ) {
      switch ( indexRadioButton ) {
        case 1: {
          return Math.Sin( Convert.ToDouble( textBox1.Text ) ).ToString( );
        }
        case 2: {
          return Math.Cos( Convert.ToDouble( textBox1.Text ) ).ToString( );
        }
        case 3: {
          return Math.Tan( Convert.ToDouble( textBox1.Text ) ).ToString( );
        }
        case 4: {
          return ( 1.0 / Math.Tan( Convert.ToDouble( textBox1.Text ) ) ).ToString( );
        }
        case 5: {
          return ( Convert.ToDouble( textBox1.Text ) + Convert.ToDouble( textBox2.Text ) ).ToString( );
        }
        case 6: {
          return ( Convert.ToDouble( textBox1.Text ) - Convert.ToDouble( textBox2.Text ) ).ToString( );
        }
        case 7: {
          return ( Convert.ToDouble( textBox1.Text ) * Convert.ToDouble( textBox2.Text ) ).ToString( );
        }
        case 8: {
          if ( Convert.ToDouble( textBox2.Text ) == 0 ) {
            MessageBox.Show( "Деление на нуль!" );
            return string.Empty;
          }
          return ( Convert.ToDouble( textBox1.Text ) / Convert.ToDouble( textBox2.Text ) ).ToString( );
        }
        default:
        return string.Empty;
        ;
      }
    }

    private void checkBoxFormula_CheckedChanged ( object sender, EventArgs e ) {
      CheckBox checkBoxFormula = (CheckBox)sender;
      if ( checkBoxFormula.Checked ) {
        labelFormula.Visible = true;
        labelFormula.Text = TextFormula( );
      } else
        labelFormula.Visible = false;
    }

    private string TextFormula ( ) {
      string labelFormulaText = string.Empty;
      for ( int i = 0; i < 4; i++ ) {
        if ( groupBox4.Enabled != false & ( ( RadioButton ) groupBox4.Controls [ i ] ).Checked == true ) {
          labelFormulaText = groupBox4.Controls [ i ].Text;
          labelFormulaText = labelFormulaText.Replace( "x", textBox1.Text );
          labelFormulaText += " = " + textBox3.Text;
        }
        if ( groupBox6.Enabled != false & ( ( RadioButton ) groupBox6.Controls [ i ] ).Checked == true ) {
          string noName = textBox2.Text;
          if ( noName.Contains( "-" ) )
            noName = $"({noName})";
          switch ( i ) {
            case 0: {
              labelFormulaText = textBox1.Text + " + " + noName + " = " + textBox3.Text;
              break;
            }
            case 1: {
              labelFormulaText = textBox1.Text + " - " + noName + " = " + textBox3.Text;
              break;
            }
            case 2: {
              labelFormulaText = textBox1.Text + " * " + noName + " = " + textBox3.Text;
              break;
            }
            case 3: {
              labelFormulaText = textBox1.Text + " / " + noName + " = " + textBox3.Text;
              break;
            }
          }
        }
      }

      return labelFormulaText;
    }

    private void textBox_KeyPress ( object sender, KeyPressEventArgs e ) {

      int pos = ((TextBox)sender).SelectionStart;
      //ввод минуса
      if ( e.KeyChar == '-' ) {
        if ( ( ( TextBox ) sender ).Text.StartsWith( "-" ) ) {
          ( ( TextBox ) sender ).Text = ( ( TextBox ) sender ).Text.Substring( 1 );
          ( ( TextBox ) sender ).SelectionStart = pos - 1;
        } else {
          ( ( TextBox ) sender ).Text = "-" + ( ( TextBox ) sender ).Text;
          ( ( TextBox ) sender ).SelectionStart = pos + 1;
        }

        e.Handled = true;
        return;
      }
      //ввод точки (запятой)
      if ( ( ( ( TextBox ) sender ).Text.StartsWith( "." ) ) || ( ( ( TextBox ) sender ).Text.StartsWith( "," ) ) ) {
        // добавление лидирующего ноля
        ( ( TextBox ) sender ).Text = "0" + ( ( TextBox ) sender ).Text;
        ( ( TextBox ) sender ).SelectionStart = pos + 1;
      }

      if ( ( e.KeyChar == '.' ) || ( e.KeyChar == ',' ) ) {
        if ( ( ( TextBox ) sender ).Text.Contains( "." ) || ( ( TextBox ) sender ).Text.Contains( "," ) ) {
          e.Handled = true;
          return;
        }
        return;
      }

      // добавление лидирующего ноля и точки, при вводе более одного ноля вначале
      if ( ( ( ( TextBox ) sender ).Text.StartsWith( "0" ) ) && pos > 0 && e.KeyChar == '0' && !( ( ( TextBox ) sender ).Text.Contains( "." ) || ( ( TextBox ) sender ).Text.Contains( "," ) ) ) {
        ( ( TextBox ) sender ).Text = "0.";
        ( ( TextBox ) sender ).SelectionStart = pos + 1;
      }

      //ввод цифр
      if ( !( Char.IsDigit( e.KeyChar ) ) ) {
        if ( ( e.KeyChar != ( char ) Keys.Back ) ) {
          e.Handled = true;
        }
      }
    }
  }
}
