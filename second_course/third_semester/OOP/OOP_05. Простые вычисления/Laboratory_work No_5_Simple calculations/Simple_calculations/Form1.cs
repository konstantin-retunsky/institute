using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_calculations {
  public partial class Form1 : Form {
    public Form1 ( ) {
      InitializeComponent( );
    }

    private void Form1_Load ( object sender, EventArgs e ) {
      Calculate( );
    }

    private void button1_Click ( object sender, EventArgs e ) {
      string dateTime = DateTime.Now.ToString("MM.dd.yyyy HH:mm:ss");

      FileStream fs;
      try {
        fs = new FileStream( "Log_Simple_calculations.txt", FileMode.Open );
      } catch ( Exception ) {
      }

      StreamWriter streamWriter = File.AppendText(@"\Log_Simple_calculations.txt");
      streamWriter.WriteLine( "-------------------------------------------------" );
      streamWriter.WriteLine( $"Константин Ретунский, {dateTime}" );
      streamWriter.WriteLine( "Вычисление периода колебания пружинного маятника." );
      streamWriter.WriteLine( $"Исходные данные  -  масса тела: {tbMass.Text} кг\n" +
          $"\t\t -  жесткость  пружины: {tbsPringStiffness.Text} Н/м" );

      try {
        double result = Math.Round( 2 * Math.PI * Math.Sqrt(
                    Convert.ToDouble(tbMass.Text) / Convert.ToDouble(tbsPringStiffness.Text)), 3);
        
        if ( ( Convert.ToDouble( tbMass.Text.ToString( ) ) < 0 | Convert.ToDouble( tbsPringStiffness.Text.ToString( ) ) < 0 )) {
          lbReturn.Text = $"Данные некорректны!";
        } else {
          lbReturn.Text = $"Период колебания пружинного маятника: {result} c";
        }
        
        streamWriter.WriteLine( $"Результат расчета -\n\t {lbReturn.Text}" );
      } catch ( Exception ) {
        lbReturn.Text = "Данные некоррктны!";
        streamWriter.WriteLine( lbReturn.Text );
      }
      streamWriter.WriteLine( );
      streamWriter.Close( );
    }

    private void tbMass_KeyPress ( object sender, KeyPressEventArgs e ) {

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

    private void tbMass_KeyDown ( object sender, KeyEventArgs e ) {
      int pos = ((TextBox)sender).SelectionStart;
      if ( e.Control && e.KeyCode == Keys.V ) {
        string stringPaste = Clipboard.GetText();
        double doublePaste;
        bool success = double.TryParse(stringPaste, out doublePaste);
        if ( success ) {
          ( ( TextBox ) sender ).Text += doublePaste.ToString( );
          ( ( TextBox ) sender ).SelectionStart = pos + stringPaste.Length;
        } else
          ( ( TextBox ) sender ).SelectionStart = pos;
      } else if ( e.Control && e.KeyCode == Keys.C ) {
        Clipboard.SetText( ( ( TextBox ) sender ).Text );
      }
    }

    private void Calculate ( ) {
      if ( tbMass.Text != "" && tbsPringStiffness.Text != "" ) {
        button1.Enabled = true;
      } else
        button1.Enabled = false;
    }

    private void tbMass_TextChanged ( object sender, EventArgs e ) {
      Calculate( );
    }
  }
}
