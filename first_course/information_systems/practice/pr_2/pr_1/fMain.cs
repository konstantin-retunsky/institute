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
            dgv.Columns.Add("symbols", "Буквы");
            dgv.Columns.Add("px", "px");
            dgv.Rows.Add(2);
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e) {

            dgv.Columns.Remove("words");
            dgv.Columns.Add("symbols", "Буквы");
            dgv.Columns.Remove("px");
            dgv.Columns.Add("px", "Px");
            dgv.Rows.Clear();
            dgv.Rows.Add(2);
            label.Visible = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            if(Convert.ToString(dgv.Rows[0].Cells[0].Value).Length == 1 & Convert.ToString(dgv.Rows[1].Cells[0].Value).Length == 1 &
               Convert.ToString(dgv.Rows[0].Cells[0].Value) != Convert.ToString(dgv.Rows[1].Cells[0].Value)) {

                if(( double.Parse(dgv.Rows[0].Cells[1].Value.ToString()) + double.Parse(dgv.Rows[1].Cells[1].Value.ToString()) ) == 1) {
                    string[] words = { dgv.Rows[0].Cells[0].Value.ToString(), dgv.Rows[1].Cells[0].Value.ToString(),
                                   dgv.Rows[0].Cells[1].Value.ToString(), dgv.Rows[1].Cells[1].Value.ToString() };
                    double sum = new double();

                    dgv.Rows.Clear();
                    dgv.Columns.Remove("symbols");
                    dgv.Columns.Remove("px");

                    dgv.Columns.Add("words", "Слова");
                    dgv.Columns.Add("px", "px");
                    dgv.Rows.Add(4);

                    dgv.Rows[0].Cells[0].Value = words[0] + words[0];
                    dgv.Rows[1].Cells[0].Value = words[1] + words[1];
                    dgv.Rows[2].Cells[0].Value = words[0] + words[1];
                    dgv.Rows[3].Cells[0].Value = words[1] + words[0];

                    dgv.Rows[0].Cells[1].Value = double.Parse(words[2]) * double.Parse(words[2]);
                    dgv.Rows[1].Cells[1].Value = double.Parse(words[3]) * double.Parse(words[3]);
                    dgv.Rows[2].Cells[1].Value = double.Parse(words[2]) * double.Parse(words[3]);
                    dgv.Rows[3].Cells[1].Value = double.Parse(words[2]) * double.Parse(words[3]);
                    
                    for(int i = 0; i < dgv.Rows.Count; i++) {
                        sum += -( double.Parse(dgv.Rows[i].Cells[1].Value.ToString()) * Math.Log(double.Parse(dgv.Rows[i].Cells[1].Value.ToString()), 2) );
                    }
                    label.Visible = true;
                    label.Text = Math.Round(sum,2).ToString();
                    for(int i = 0; i < dgv.Rows.Count; i++) {
                        /*if(dgv.Rows[i].Cells[1].Value.ToString() == "0") {
                            dgv.Rows[i].Cells[1].Value = "вероятность 0";
                        } else
                        */if(dgv.Rows[i].Cells[1].Value.ToString() == "1") {
                            label.Text = "H(x) = 0";
                        }
                    }
                    
                }  else {
                    MessageBox.Show("Поля заполнены не правильно");
                }
            } else {
                MessageBox.Show("Поля заполнены не правильно");
            }
        }

    }
}

