using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace pr3 {

    public partial class fMain:Form {

        public fMain() {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e) {
            dgvInput.Columns.Add("symbols", "Буквы");
            dgvInput.Columns.Add("pxInput", "px");
            dgvResult.Columns.Add("words", "words");
            dgvResult.Columns.Add("pxResult", "px");
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            dgvInput.Rows.Clear();
            dgvResult.Rows.Clear();
            labelHx.Visible = false;
            tbText.Text = "";
            tbLength.Text = "";
        }
        private void btnCalc_Click(object sender, EventArgs e) {
            try {
                dgvResult.Rows.Clear();

                var letters = tbText.Text.Replace(",", ""); 
                //var wordLength = Convert.ToInt32(tbLength.Text);
                var word = new char[Convert.ToInt32(tbLength.Text)];
                double sum = new double();

                string[] arrSymbols = tbText.Text.Split(',').ToArray();
                double[] arrPx = new double[dgvInput.Rows.Count];
                for(int i = 0; i < dgvInput.Rows.Count; i++) {
                    arrPx[i] = double.Parse(dgvInput.Rows[i].Cells[1].Value.ToString());
                }

                if(arrPx.Sum() == 1) {
                    for(var i = 0; i < Math.Pow(letters.Length, Convert.ToInt32(tbLength.Text)); i++) {
                        var accum = i;
                        for(var j = word.Length - 1; j >= 0; j--) {
                            word[j] = letters[accum % letters.Length];
                            accum /= letters.Length;
                        }

                        dgvResult.Rows.Add();
                        dgvResult.Rows[i].Cells[0].Value = new string(word);

                        double temp = 1;
                        for(int j = 0; j < dgvResult.Rows[i].Cells[0].Value.ToString().Length; j++) {
                            for(int z = 0; z < arrSymbols.Length; z++) {
                                if(dgvResult.Rows[i].Cells[0].Value.ToString()[j] == Convert.ToChar(arrSymbols[z])) {
                                    temp *= arrPx[z];
                                }
                            }
                        }
                        
                        dgvResult.Rows[i].Cells[1].Value = Math.Round(temp,4);
                        if(double.Parse(dgvResult.Rows[i].Cells[1].Value.ToString()) > 0) {
                            sum += -( double.Parse(dgvResult.Rows[i].Cells[1].Value.ToString()) *
                                      Math.Log(double.Parse(dgvResult.Rows[i].Cells[1].Value.ToString()), 2) );
                            //MessageBox.Show(sum.ToString());
                            
                        } 
                    }
                    labelHx.Visible = true;
                    labelHx.Text = "H(x)= " + Math.Round(sum,4);
                } else {
                    MessageBox.Show("sum px = 1");
                }
            
            } catch {
                MessageBox.Show("404");
            }
        }

        private void tbText_TextChanged(object sender, EventArgs e) {
            string[] str = tbText.Text.Split(',');
            dgvInput.Rows.Add(str.Length);

            if(dgvInput.Rows.Count > str.Length) {
                dgvInput.RowCount = str.Length;
            }

            for(int i = 0; i < dgvInput.Rows.Count; i++) {
                dgvInput.Rows[i].Cells[0].Value = str[i];
            }
        }
    }
}