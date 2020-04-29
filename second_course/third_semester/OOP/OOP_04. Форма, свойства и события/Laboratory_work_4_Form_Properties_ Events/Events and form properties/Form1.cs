using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;

namespace Events_and_form_properties {
  public partial class Form1 : Form {

    private bool flagBackColor = true;
    private bool flagColorFromArgb = false;
    private string titleText = "Л.р. №2, Ретунский Константин. ";
    private double WidthWindow = SystemParameters.PrimaryScreenWidth;
    private double HeightWindow = SystemParameters.PrimaryScreenHeight;
    public Form1 ( ) {
      InitializeComponent( );
      ToolTip toolTip = new ToolTip();
      toolTip.SetToolTip( this, "Моя первая формочка!" );
    }

    private void Window_MouseMove ( object sender, System.Windows.Forms.MouseEventArgs e ) {
      if ( flagBackColor ) {
        double x = (double)e.X / Size.Width * 255;
        double y = (double)e.Y / Size.Height * 255;
        BackColor = Color.FromArgb( ( int ) x, ( int ) y, ( int ) y );

        if ( flagColorFromArgb ) {
          Text = string.Format( "({0}), {1}, {2}) {3}", ( int ) x, ( int ) y, ( int ) y, titleText );
        } else
          Text = titleText;
      }
    }

    private void Window_KeyDown ( object sender, System.Windows.Forms.KeyEventArgs e ) {
      if ( Keyboard.IsKeyDown( Key.LeftAlt ) && Keyboard.IsKeyDown( Key.LeftCtrl ) && Keyboard.IsKeyDown( Key.C ) ) {
        if ( flagBackColor )
          flagBackColor = false;
        else
          flagBackColor = true;
      } else if ( Keyboard.IsKeyDown( Key.LeftCtrl ) && Keyboard.IsKeyDown( Key.D ) ) {
        if ( flagColorFromArgb )
          flagColorFromArgb = false;
        else
          flagColorFromArgb = true;
      } else if ( e.KeyCode == Keys.Space ) {
        Location = new System.Drawing.Point( ( int ) WidthWindow / 2 - Width / 2,
            ( int ) HeightWindow / 2 - Height / 2 );
      } else if ( Keyboard.IsKeyDown( Key.LeftAlt ) ) {
        switch ( e.KeyCode ) {
          case Keys.Up: {
            Top = 0;
            break;
          }
          case Keys.Down: {
            Top = ( int ) HeightWindow - Height;
            break;
          }
          case Keys.Left: {
            Left = 0;
            break;
          }
          case Keys.Right: {
            Left = ( int ) WidthWindow - Width;
            break;
          }
        }
      } else if ( Keyboard.IsKeyDown( Key.LeftCtrl ) ) {
        switch ( e.KeyCode ) {
          case Keys.Up: {
            Opacity += 0.05;
            break;
          }
          case Keys.Down: {
            Opacity -= 0.05;
            break;
          }
        }

      } else {
        switch ( e.KeyCode ) {
          case Keys.Up:
          if ( Top > 0.0 )
            Top -= 5;
          break;
          case Keys.Down:
          if ( Top + Height < HeightWindow )
            Top += 5;
          break;
          case Keys.Left:
          if ( Left > 0.0 )
            Left -= 5;
          break;
          case Keys.Right:
          if ( Left + Width < WidthWindow )
            Left += 5;
          break;
        }
      }
    }

    private static void WinShutdown ( ) {
      if ( System.Windows.MessageBox.Show( "Закрыть приложение ?", "Вопрос", MessageBoxButton.YesNo, MessageBoxImage.Warning ) == MessageBoxResult.Yes ) {
        System.Windows.Forms.Application.Exit( );
      }
    }

    private void Form1_PreviewKeyDown ( object sender, PreviewKeyDownEventArgs e ) {
      if ( ( Keyboard.IsKeyDown( Key.LeftAlt ) && ( Keyboard.IsKeyDown( Key.X ) ) || e.KeyCode == Keys.F10 ) ) {
        WinShutdown( );
      }
    }

    private void Form1_MouseDoubleClick ( object sender, System.Windows.Forms.MouseEventArgs e ) {
      WinShutdown( );
    }

    private void Form1_SizeChanged ( object sender, EventArgs e ) {
      if ( Text.IndexOf( "Высота: " ) != -1 )
        Text = Text.Remove( Text.IndexOf( "Высота" ) );
      Text += "Высота: " + Height.ToString( ) + " " + "Ширина: " + Width.ToString( );
    }

    private void Form1_MouseDown ( object sender, System.Windows.Forms.MouseEventArgs e ) {
      if ( e.Button == MouseButtons.Middle ) {
        Location = new System.Drawing.Point( System.Windows.Forms.Cursor.Position.X - Width / 2,
            System.Windows.Forms.Cursor.Position.Y - Height / 2 );
      } else if ( e.Button == MouseButtons.Left ) {
        if ( Keyboard.IsKeyDown( Key.LeftShift ) ) {
          if ( Width < WidthWindow ) {
            Width = Width - 5;
            Left += 2;
          }
          if ( Height < HeightWindow ) {
            Height = Height - 5;
            Top += 2;
          }
        } else {
          if ( Width < WidthWindow ) {
            Width = Width + 5;
            Left -= 2;
          }
          if ( Height < HeightWindow ) {
            Height = Height + 5;
            Top -= 2;
          }
        }
      }
    }

    private void Form1_KeyUp ( object sender, System.Windows.Forms.KeyEventArgs e ) {

    }

    private void Form1_MouseLeave ( object sender, EventArgs e ) {
      if ( flagBackColor ) {
        BackColor = Color.Yellow;
      }
    }
  }
}
