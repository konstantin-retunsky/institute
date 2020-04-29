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
    public partial class ChildForm : Form {
        public ChildForm() {
            InitializeComponent();
        }
        public ChildForm(string[] txt) {
            InitializeComponent();
            textBox1.Lines = File.ReadAllLines("Новый текстовый документ.txt");
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e) {
            FrameForm frameForm = (FrameForm)MdiParent;
            frameForm.toolStripMenuItem3_Click(frameForm, e);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e) {
            textBox1.Lines = File.ReadAllLines("Новый текстовый документ.txt");
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e) {
            FrameForm frameForm = (FrameForm)MdiParent;
            frameForm.toolStripMenuItem5_Click(frameForm, e);            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e) {
            File.WriteAllLines("Новый текстовый документ.txt", textBox1.Lines); 
        }
    }
}
