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
  public partial class AboutForm : Form {
    public static AboutForm Instation;
    public AboutForm ( ) {
      InitializeComponent( );
      Instation = this;
    }

    private void AboutForm_Load ( object sender, EventArgs e ) {
      // Модальная форма «About» представляет краткую деловую информацию об авторе
      // и программе (с красивым логотипом и фотографией автора).

      label1.Text = "Автор программы: Ретунский Константин." +
          Environment.NewLine +
          "                           Студент II курса (пока ещё (☉｡☉)!)" +
          Environment.NewLine +
          "                           Тюменского Гос. Университета";

      label2.Text = "Программа \"ClassWork\" написана в рамках выполнения работы: " +
          Environment.NewLine +
          "         \"Лабораторная работа №7 «Дочерние формы SDI»\".";

      if ( BabyForm.Instation != null )
        BabyForm.Instation.LabelSizeAboutForm = AboutFormSize( );
    }

    private void button1_Click ( object sender, EventArgs e ) {
      Close( );
    }

    private void AboutForm_SizeChanged ( object sender, EventArgs e ) {
      if ( BabyForm.Instation != null )
        BabyForm.Instation.LabelSizeAboutForm = AboutFormSize( );
    }
    public string AboutFormSize ( ) {
      return "\"Ширина\":  " + Width.ToString( ) + Environment.NewLine +
          "\"Высота\":  " + Height.ToString( );
    }
  }
}
