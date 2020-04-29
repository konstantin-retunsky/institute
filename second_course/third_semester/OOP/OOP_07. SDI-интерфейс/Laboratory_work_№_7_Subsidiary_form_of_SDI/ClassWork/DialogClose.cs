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
  public partial class DialogClose : Form {
    public bool resultClose = false;
    public DialogClose ( string text ) {
      InitializeComponent( );
      label1.Text += Environment.NewLine + $"\"{text}\" ?";
    }

    private void button3_Click ( object sender, EventArgs e ) {
      resultClose = true;
      Hide( );

    }

    private void button5_Click ( object sender, EventArgs e ) {
      resultClose = false;
      Hide( );
    }
  }
}
