using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_documented___MDI____applications {
    public partial class FrameForm : Form {
        public FrameForm() {
            InitializeComponent();
        }

        public void toolStripMenuItem3_Click(object sender, EventArgs e) {
            ChildForm childForm = new ChildForm();
            childForm.MdiParent = this;
            childForm.Text += " " + MdiChildren.Length.ToString();
            childForm.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e) {
            string[] fileTxt = File.ReadAllLines("Новый текстовый документ.txt");
            ChildForm childForm = new ChildForm(fileTxt);
            childForm.MdiParent = this;
            childForm.Text += " " + MdiChildren.Length.ToString();
            childForm.Show();
        }

        public void toolStripMenuItem5_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e) {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e) {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e) {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e) {
            foreach(ChildForm childForm in MdiChildren) {
                childForm.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
