using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_6 {
  public partial class MainForm : Form {

    private List<Button> buttonsEdit;
    private Button currentButton;
    private Random random = new Random();
    private int tempIndex;
    public MainForm ( ) {
      InitializeComponent( );
      buttonsEdit = new List<Button>{
        button_save,
        button_add,
        button_delete
      };

      foreach ( Control btn in panel_menu.Controls ) {
        if ( btn.GetType( ) == typeof( Button ) & btn != button_showButtons ) {
          btn.Click += ( object sender, EventArgs e ) => {
            ActivateButton( sender );

            button_showButtons.BackColor = Color.FromArgb( 51, 51, 76 );
            foreach ( Button btnEdit in buttonsEdit ) {
              btnEdit.Visible = false;
            }

          };
        }
      }
    }

    private Color SelectThemeColor ( ) {
      int index = random.Next(ThemeColor.ColorList.Count);
      while ( tempIndex == index ) {
        index = random.Next( ThemeColor.ColorList.Count );
      }
      tempIndex = index;
      string color = ThemeColor.ColorList[index];
      return ColorTranslator.FromHtml( color );
    }
    private void ActivateButton ( object btnSender ) {
      if ( btnSender != null ) {
        if ( currentButton != ( Button ) btnSender ) {
          DisableButton( );
          Color color = SelectThemeColor();
          currentButton = ( Button ) btnSender;
          currentButton.BackColor = color;
          currentButton.ForeColor = Color.White;
          currentButton.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
          panel_logo.BackColor = ThemeColor.ChangeColorBrightness( color, -0.3 );
          panel_header.BackColor = color;

          label_header.Text = currentButton.Text;
        }
      }
    }
    private void DisableButton ( ) {

      foreach ( Control btn in panel_menu.Controls ) {
        if ( btn.GetType( ) == typeof( Button ) & btn != button_showButtons ) {
          btn.BackColor = Color.FromArgb( 51, 51, 76 );
          btn.ForeColor = Color.Gainsboro;
          btn.Font = new System.Drawing.Font( "Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
        }
      }
    }


    [DllImport( "user32.DLL", EntryPoint = "ReleaseCapture" )]
    private extern static void ReleaseCapture ( );
    [DllImport( "user32.DLL", EntryPoint = "SendMessage" )]
    private extern static void SendMessage ( System.IntPtr hWnd, int wMsg, int wParam, int lParam );
    private void panel_header_MouseDown ( object sender, MouseEventArgs e ) {
      ReleaseCapture( );
      SendMessage( this.Handle, 0x112, 0xf012, 0 );
    }

    private void panel_logo_MouseDown ( object sender, MouseEventArgs e ) {
      ReleaseCapture( );
      SendMessage( this.Handle, 0x112, 0xf012, 0 );
    }

    private void button_closeForm_Click ( object sender, EventArgs e ) {
      this.Close( );
    }

    private void button_minimize_Click ( object sender, EventArgs e ) {
      this.WindowState = FormWindowState.Minimized;
    }

    private void button_maximize_Click ( object sender, EventArgs e ) {
      _ = WindowState == FormWindowState.Normal ? this.WindowState = FormWindowState.Maximized : this.WindowState = FormWindowState.Normal;
    }

    private void button_showButtons_Click ( object sender, EventArgs e ) {


      foreach ( Button btn in buttonsEdit ) {
        if ( btn.Visible == true ) {
          btn.Visible = false;
        } else if ( btn.Visible == false ) {
          btn.Visible = true;
        }
      }
      Color color = ColorTranslator.FromHtml( ThemeColor.ColorList[tempIndex]);
      _ = button_showButtons.BackColor == color ? 
        button_showButtons.BackColor = Color.FromArgb( 51, 51, 76) :
        button_showButtons.BackColor = color;
      
      

      foreach ( Button btn in buttonsEdit ) {
        btn.BackColor = color;
      }
    }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseCafeDataSet.staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.databaseCafeDataSet.staff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseCafeDataSet.recipes". При необходимости она может быть перемещена или удалена.
            this.recipesTableAdapter.Fill(this.databaseCafeDataSet.recipes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseCafeDataSet.ingredients". При необходимости она может быть перемещена или удалена.
            this.ingredientsTableAdapter.Fill(this.databaseCafeDataSet.ingredients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseCafeDataSet.general_orders". При необходимости она может быть перемещена или удалена.
            this.general_ordersTableAdapter.Fill(this.databaseCafeDataSet.general_orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseCafeDataSet.final_orders". При необходимости она может быть перемещена или удалена.
            this.final_ordersTableAdapter.Fill(this.databaseCafeDataSet.final_orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseCafeDataSet.drinks". При необходимости она может быть перемещена или удалена.
            this.drinksTableAdapter.Fill(this.databaseCafeDataSet.drinks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseCafeDataSet.dishes". При необходимости она может быть перемещена или удалена.
            this.dishesTableAdapter.Fill(this.databaseCafeDataSet.dishes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseCafeDataSet.categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this.databaseCafeDataSet.categories);



            DataGridViewAllowUserToAddRows();
            DataGridVisible(null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridVisible(DGV_categories);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridVisible(DGV_dishes);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridVisible(DGV_drinks);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridVisible(DGV_final_orders);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridVisible(DGV_general_orders);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataGridVisible(DGV_ingredients);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataGridVisible(DGV_recipes);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataGridVisible(DGV_staff);
        }

        private void DataGridVisible(DataGridView dataGridView)
        {
            foreach (Control control in panel1.Controls)
            {
                if (control == dataGridView)
                    dataGridView.Visible = true;
                else if (control is DataGridView)
                    control.Visible = false;
            }
        }

        private void ButtonEnable()
        {
            button_save.Enabled = !button_save.Enabled;
            button_delete.Enabled = !button_delete.Enabled;
            button_add.Enabled = !button_add.Enabled;
        }

        private void DataGridViewAllowUserToAddRows()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is DataGridView & control.Visible)
                {
                    (control as DataGridView).AllowUserToAddRows = !(control as DataGridView).AllowUserToAddRows;
                }
            }
        }

        private DataGridView GetDataGridViewActive()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is DataGridView & control.Visible)
                {
                    return control as DataGridView;                    
                }
            }
            return null;
        }

        private void DataBaseUpdate()
        {
            try
            {
                var dataGridView = GetDataGridViewActive();
                if (dataGridView == DGV_categories)
                    this.categoriesTableAdapter.Update(this.databaseCafeDataSet.categories);
                else if (dataGridView == DGV_dishes)
                    this.dishesTableAdapter.Update(this.databaseCafeDataSet.dishes);
                else if (dataGridView == DGV_drinks)
                    this.drinksTableAdapter.Update(this.databaseCafeDataSet.drinks);
                else if (dataGridView == DGV_final_orders)
                    this.final_ordersTableAdapter.Update(this.databaseCafeDataSet.final_orders);
                else if (dataGridView == DGV_general_orders)
                    this.general_ordersTableAdapter.Update(this.databaseCafeDataSet.general_orders);
                else if (dataGridView == DGV_ingredients)
                    this.ingredientsTableAdapter.Update(this.databaseCafeDataSet.ingredients);
                else if (dataGridView == DGV_recipes)
                    this.recipesTableAdapter.Update(this.databaseCafeDataSet.recipes);
                else if (dataGridView == DGV_staff)
                    this.staffTableAdapter.Update(this.databaseCafeDataSet.staff);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //DataBaseUpdate();
        }

        private void button_add_Click_1(object sender, EventArgs e)
        {
            ButtonEnable();
            DataGridViewAllowUserToAddRows();
        }

        private void button_delete_Click_1(object sender, EventArgs e)
        {
            DataGridView dataGridView = GetDataGridViewActive();
            if (dataGridView != null)
            {
                int delet = dataGridView.SelectedCells[0].RowIndex;
                dataGridView.Rows.RemoveAt(delet);
            }

            DataBaseUpdate();
        }

        private void button_save_Click_1(object sender, EventArgs e)
        {
            ButtonEnable();
            DataGridViewAllowUserToAddRows();
            DataBaseUpdate();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.categoriesTableAdapter.Fill(this.databaseCafeDataSet.categories);
            this.dishesTableAdapter.Update(this.databaseCafeDataSet.dishes);
            this.drinksTableAdapter.Update(this.databaseCafeDataSet.drinks);
            this.final_ordersTableAdapter.Update(this.databaseCafeDataSet.final_orders);
            this.staffTableAdapter.Update(this.databaseCafeDataSet.staff);
            this.general_ordersTableAdapter.Update(this.databaseCafeDataSet.general_orders);
            this.ingredientsTableAdapter.Update(this.databaseCafeDataSet.ingredients);
            this.recipesTableAdapter.Update(this.databaseCafeDataSet.recipes);
        }
    }
}
