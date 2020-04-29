using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework {
	 public partial class FormSearch:Form {
		  public FormSearch () {
				InitializeComponent();
		  }

		  private void FormSearch_Load (object sender, EventArgs e) {

				FormMain formMain = Owner as FormMain;

				DataGridView dgvFormSearch = new DataGridView();
				dgvFormSearch.DataSource = formMain.dataGridView.DataSource;


				this.Controls.Add(dgvFormSearch);
		  }
	 }
}
