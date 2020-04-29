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

namespace ClassWork {
  public partial class MainForm : Form {
    public static MainForm Instation;
    private BabyForm babyForm;
    private AboutForm aboutForm;
    private double WidthWindow = SystemParameters.PrimaryScreenWidth;
    private double HeightWindow = SystemParameters.PrimaryScreenHeight;
    private bool killBabyForm = false;

    public bool KillBabyForm {
      get {
        return killBabyForm;
      }
    }
    public string LabelCoordinatesBabyForm {
      set {
        label2.Text = value;
      }
    }
    public string LabelSizeBabyForm {
      set {
        label3.Text = value;
      }
    }
    public MainForm ( ) {
      InitializeComponent( );
      Instation = this;
    }
    public void ButtonEnabled ( ) {
      if ( System.Windows.Forms.Application.OpenForms [ "BabyForm" ] != null ) {
        button2.Enabled = !button2.Enabled;
        button1.Enabled = !button1.Enabled;
      }
    }

    private void button1_Click ( object sender, EventArgs e ) {
      babyForm = new BabyForm( );
      babyForm.Show( );
      ButtonEnabled( );
    }

    private void button4_Click ( object sender, EventArgs e ) {
      aboutForm = new AboutForm( );
      aboutForm.ShowDialog( );
    }

    private void button2_Click ( object sender, EventArgs e ) {
      if ( System.Windows.Forms.Application.OpenForms [ "BabyForm" ] != null ) {
        BabyForm.Instation.Close( );
      }
    }

    private void button3_Click ( object sender, EventArgs e ) {
      if ( System.Windows.Forms.Application.OpenForms [ "AboutForm" ] != null )
        aboutForm.Close( );
    }

    private void checkBox1_CheckedChanged ( object sender, EventArgs e ) {
      CheckBox checkBox = (CheckBox)sender;
      if ( System.Windows.Forms.Application.OpenForms [ "BabyForm" ] != null ) {
        if ( checkBox.Checked ) {
          babyForm.Show( );
        } else {
          babyForm.Hide( );
        }
      }
    }

    private void checkBox2_CheckedChanged ( object sender, EventArgs e ) {
      CheckBox checkBox = (CheckBox)sender;
      if ( checkBox.Checked ) {
        if ( System.Windows.Forms.Application.OpenForms [ "BabyForm" ] != null )
          babyForm.Visible = true;
      }
    }

    private void checkBox3_CheckedChanged ( object sender, EventArgs e ) {
      CheckBox checkBox = (CheckBox)sender;
      if ( checkBox.Checked ) {
        if ( System.Windows.Forms.Application.OpenForms [ "BabyForm" ] != null )
          babyForm.Visible = false;
      }
    }

    private void checkBox6_CheckStateChanged ( object sender, EventArgs e ) {
      CheckBox checkBox = (CheckBox)sender;
      if ( checkBox.Checked ) {
        button4.Enabled = true;
        button4_Click( sender, e );
      } else {
        button4.Enabled = false;
      }
    }

    private void checkBox5_CheckedChanged ( object sender, EventArgs e ) {
      CheckBox checkBox = (CheckBox)sender;
      if ( checkBox.Checked ) {
        if ( System.Windows.Forms.Application.OpenForms [ "AboutForm" ] != null )
          aboutForm.Visible = true;
      }
    }

    private void checkBox4_CheckedChanged ( object sender, EventArgs e ) {
      CheckBox checkBox = (CheckBox)sender;
      if ( checkBox.Checked ) {
        if ( System.Windows.Forms.Application.OpenForms [ "AboutForm" ] != null )
          aboutForm.Visible = false;
      }
    }

    private void radioButton1_CheckedChanged ( object sender, EventArgs e ) {
      RadioButton radioButton = (RadioButton)sender;
      if ( radioButton.Checked ) {
        if ( System.Windows.Forms.Application.OpenForms [ "BabyForm" ] != null )
          babyForm.WindowState = FormWindowState.Minimized;
      }
    }

    private void radioButton2_CheckedChanged ( object sender, EventArgs e ) {
      RadioButton radioButton = (RadioButton)sender;
      if ( radioButton.Checked ) {
        if ( System.Windows.Forms.Application.OpenForms [ "BabyForm" ] != null )
          babyForm.WindowState = FormWindowState.Maximized;
      }
    }

    private void radioButton3_CheckedChanged ( object sender, EventArgs e ) {
      RadioButton radioButton = (RadioButton)sender;
      if ( radioButton.Checked ) {
        if ( System.Windows.Forms.Application.OpenForms [ "BabyForm" ] != null )
          babyForm.WindowState = FormWindowState.Normal;
      }
    }

    private void radioButton6_CheckedChanged ( object sender, EventArgs e ) {
      RadioButton radioButton = (RadioButton)sender;
      if ( radioButton.Checked ) {
        if ( System.Windows.Forms.Application.OpenForms [ "AboutForm" ] != null )
          aboutForm.WindowState = FormWindowState.Minimized;
      }
    }

    private void radioButton5_CheckedChanged ( object sender, EventArgs e ) {
      RadioButton radioButton = (RadioButton)sender;
      if ( radioButton.Checked ) {
        if ( System.Windows.Forms.Application.OpenForms [ "AboutForm" ] != null )
          aboutForm.WindowState = FormWindowState.Maximized;
      }
    }

    private void radioButton4_CheckedChanged ( object sender, EventArgs e ) {
      RadioButton radioButton = (RadioButton)sender;
      if ( radioButton.Checked ) {
        if ( System.Windows.Forms.Application.OpenForms [ "AboutForm" ] != null )
          aboutForm.WindowState = FormWindowState.Normal;
      }
    }

    private void textBox1_KeyPress ( object sender, KeyPressEventArgs e ) {
      if ( System.Windows.Forms.Application.OpenForms [ "BabyForm" ] != null )
        babyForm.Text = textBox1.Text;
    }

    private void button3_Click_1 ( object sender, EventArgs e ) {
      if ( System.Windows.Forms.Application.OpenForms [ "BabyForm" ] != null ) {
        if ( babyForm.Width < WidthWindow ) {
          babyForm.Width = babyForm.Width + 5;
          babyForm.Left -= 2;
        }
        if ( babyForm.Height < HeightWindow ) {
          babyForm.Height = babyForm.Height + 5;
          babyForm.Top -= 2;
        }
      }

    }

    private void button5_Click ( object sender, EventArgs e ) {
      if ( System.Windows.Forms.Application.OpenForms [ "BabyForm" ] != null ) {
        if ( babyForm.Width < WidthWindow ) {
          babyForm.Width = babyForm.Width - 5;
          babyForm.Left += 2;
        }
        if ( babyForm.Height < HeightWindow ) {
          babyForm.Height = babyForm.Height - 5;
          babyForm.Top += 2;
        }
      }
    }

    private void button6_Click ( object sender, EventArgs e ) {
      if ( System.Windows.Forms.Application.OpenForms [ "BabyForm" ] != null ) {
        if ( babyForm.ColorDialogBabyForm.ShowDialog( ) == DialogResult.Cancel )
          return;
        babyForm.BackColor = babyForm.ColorDialogBabyForm.Color;
        babyForm.Focus( );
      }
    }

    private void button7_Click ( object sender, EventArgs e ) {
      if ( System.Windows.Forms.Application.OpenForms [ "BabyForm" ] != null ) {
        killBabyForm = true;
        babyForm.Close( );
      }
      groupBox1.Enabled = false;
    }

    private void MainForm_SizeChanged ( object sender, EventArgs e ) {
      if ( System.Windows.Forms.Application.OpenForms [ "BabyForm" ] != null )
        babyForm.LabelMainForm = MainFormSize( );
    }
    public string MainFormSize ( ) {
      return "\"Ширина\":  " + Width.ToString( ) + Environment.NewLine +
          "\"Высота\":  " + Height.ToString( );
    }

    public bool CanClose ( Form f ) {
      DialogClose dialogClose = new DialogClose(f.Text);
      dialogClose.ShowDialog( );
      bool resultClose = dialogClose.resultClose;
      dialogClose.Close( );
      if ( resultClose )
        ButtonEnabled( );
      return resultClose;
    }

    private void MainForm_FormClosing ( object sender, FormClosingEventArgs e ) {
      e.Cancel = !CanClose( this );
    }

  }
}
