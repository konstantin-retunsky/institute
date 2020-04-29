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

namespace HomeWork {
    public partial class ChildForm : Form {

        public static ChildForm Instance = null;
        public string filePath = string.Empty;
        public readonly DateTime InitializeDateTime;
        public DateTime SaveDateTime;
        public ColorDialog ColorDialogChildForm { get { return colorDialog1; } }

        public ChildForm() {
            InitializeDateTime = DateTime.Now;
            InitializeComponent();
            Instance = this;
        }
        public TextBox TextBoxChildForm { get { return textBox1; } }
        private void toolStripMenuItem3_Click(object sender, EventArgs e) {
            FrameForm frameForm = (FrameForm)MdiParent;
            frameForm.toolStripMenuItem3_Click(frameForm, e);
        }

        public void toolStripMenuItem4_Click(object sender, EventArgs e) {
            Tuple<string, string[]> result = ReadAndWrite_Iormation.ReadFile();

            if (result != null) {
                filePath = result.Item1;
                label1.Text = Path.GetFileNameWithoutExtension(result.Item1);
                textBox1.Lines = result.Item2;
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e) {
            toolStripMenuItem2_Click(sender, e);
            this.Close();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e) {
            FrameForm frameForm = (FrameForm)MdiParent;
            frameForm.toolStripMenuItem5_Click(frameForm, e);            
        }

        public void toolStripMenuItem2_Click(object sender, EventArgs e) {
            bool saveOk = ReadAndWrite_Iormation.SaveFileDialog(textBox1.Lines, Text);
            if (saveOk)
                SaveDateTime = DateTime.Now;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();
            textBox1.Refresh();
            Data.Label1SubsidiaryFormWrite();
        }

        private void ChildForm_Load(object sender, EventArgs e) {
        }

        private void ChildForm_LocationChanged(object sender, EventArgs e) {
            Data.Label1SubsidiaryFormWrite();
        }

        private void ChildForm_FormClosed_1(object sender, FormClosedEventArgs e) {
            Data.ListBoxRemoveChildForm(this);
        }
    }
}
