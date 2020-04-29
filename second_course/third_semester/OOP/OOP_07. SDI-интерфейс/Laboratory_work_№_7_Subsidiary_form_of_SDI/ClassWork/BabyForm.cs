using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork {
  public partial class BabyForm : Form {
    public static BabyForm Instation;
    public ColorDialog ColorDialogBabyForm {
      get {
        return colorDialog1;
      }
    }
    public string LabelMainForm {
      set {
        label2.Text = value;
      }
    }
    public string LabelSizeAboutForm {
      set {
        label3.Text = value;
      }
    }
    public BabyForm ( ) {
      InitializeComponent( );
      Instation = this;
    }

    private void BabyForm_LocationChanged ( object sender, EventArgs e ) {
      string location = "\"Top\":  " + Top.ToString() + Environment.NewLine +
                "\"Left\":  " + Left.ToString();
      MainForm.Instation.LabelCoordinatesBabyForm = location;
    }

    private void BabyForm_FormClosed ( object sender, FormClosedEventArgs e ) {
      MainForm.Instation.LabelCoordinatesBabyForm = "Координаты";
      MainForm.Instation.LabelSizeBabyForm = "Размеры";
    }

    private void BabyForm_SizeChanged ( object sender, EventArgs e ) {
      label1.Text = BabyFormSize( );
      MainForm.Instation.LabelSizeBabyForm = BabyFormSize( );
    }
    public string BabyFormSize ( ) {
      return "\"Ширина\":  " + Width.ToString( ) + Environment.NewLine +
          "\"Высота\":  " + Height.ToString( );
    }

    private void BabyForm_Load ( object sender, EventArgs e ) {
      BabyForm_SizeChanged( sender, e );
      if ( System.Windows.Forms.Application.OpenForms [ "MainForm" ] != null )
        label2.Text = MainForm.Instation.MainFormSize( );
      if ( System.Windows.Forms.Application.OpenForms [ "AboutForm" ] != null )
        label3.Text = AboutForm.Instation.AboutFormSize( );
    }

    private void BabyForm_FormClosing ( object sender, FormClosingEventArgs e ) {
      if ( System.Windows.Forms.Application.OpenForms [ "MainForm" ] != null ) {
        if ( MainForm.Instation.KillBabyForm ) {
          e.Cancel = !MainForm.Instation.KillBabyForm;
          MainForm.Instation.Focus( );
        }
        bool resultClose = MainForm.Instation.CanClose(this);
        if ( resultClose ) {
          e.Cancel = !resultClose;
          MainForm.Instation.Focus( );
        } else {
          e.Cancel = !resultClose;
          MainForm.Instation.Focus( );
          Focus( );
        }
      }
    }
  }
}
