using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork {
    public partial class SubsidiaryForm : Form {

        public static SubsidiaryForm Instance = null;
        public string LabelTextSubsidiaryForm { get { return label1.Text; } set { label1.Text = value; } }
        public ListBox ListBoxSubsidiaryForm { get { return listBox1; } }

        public SubsidiaryForm() {
            InitializeComponent();
            Instance = this;
        }

        public void ListBoxAddChildForm(ChildForm childForm) {
            listBox1.Items.Add(childForm);
            FrameForm.Instance.collectionMDIMenuStripFrameForm(listBox1);
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e) {
            if(listBox1.SelectedIndex >= 0) {
                Data.Label1SubsidiaryFormWrite();
                groupBox1.Enabled = true;
            }
            else
                groupBox1.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked) {
                Data.GetChildForm().WindowState = FormWindowState.Minimized;
            }            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked) {
                Data.GetChildForm().WindowState = FormWindowState.Maximized;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
                Data.GetChildForm().Hide();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
                Data.GetChildForm().Show();
        }

        private void button1_Click(object sender, EventArgs e) {
            Data.GetChildForm().Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            ChildForm childForm = Data.GetChildForm();
            if (childForm.ColorDialogChildForm.ShowDialog() == DialogResult.Cancel)
                return;
            childForm.BackColor = childForm.ColorDialogChildForm.Color;
        }

        private void SubsidiaryForm_FormClosing(object sender, FormClosingEventArgs e) {
            if(FrameForm.Instance != null) {
                Hide();
                e.Cancel = true;
            }
        }
    }
}
