using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr_1 {
    public partial class fMain:Form {
        public fMain() {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e) {
        
        }

        private void btnNum_n_Click(object sender, EventArgs e) {

            if(tbNum.Text.All(char.IsDigit) & !string.IsNullOrEmpty(tbNum.Text)) {
                dgv.Rows.Add(short.Parse(tbNum.Text));
                for(short i = 0; i < dgv.Rows.Count; i++) {
                    dgv.Rows[i].Cells[0].Value = i + 1;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e) {

            if(dgv.Rows.Count != 0) {
                dgv.Rows.RemoveAt(dgv.CurrentCell.RowIndex);
                for(short i = 0; i < dgv.Rows.Count; i++) {
                    dgv.Rows[i].Cells[0].Value = i + 1;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            dgv.Rows.Clear();
        }

        private void btnCalculate_Click(object sender, EventArgs e) {

            double sum = new double();
            double diffNum = new double();
            bool boolen = new bool();

            try {
                for(short i = 0; i < dgv.Rows.Count; i++) {
                    diffNum += double.Parse(dgv.Rows[i].Cells[1].Value.ToString());
                    if(double.Parse(dgv.Rows[i].Cells[1].Value.ToString()) == 1) {
                        boolen = true;
                    }
                }

                if(diffNum == 1 ) {
                    for(short i = 0; i < dgv.Rows.Count; i++) {
                        if(boolen == false & double.Parse(dgv.Rows[i].Cells[1].Value.ToString()) > 0) { 
                            sum += -( double.Parse(dgv.Rows[i].Cells[1].Value.ToString()) * Math.Log(double.Parse(dgv.Rows[i].Cells[1].Value.ToString()), 2) );

                        } else {
                            MessageBox.Show("Исправьте введенные значения", "Некорректный ввод", MessageBoxButtons.OK);
                            break;
                        }
                    }
                    if(boolen == false) { 
                    MessageBox.Show("H(x) = " + Math.Round(sum,2));
                    }
                } else {
                    MessageBox.Show("Исправьте введенные значения", "Некорректный ввод", MessageBoxButtons.OK);
                }
            } catch {
                MessageBox.Show("Исправьте введенные значения", "Некорректный ввод", MessageBoxButtons.OK);
            }
        }
    }
}

