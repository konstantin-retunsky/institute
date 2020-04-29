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
    public partial class FrameForm : Form {
        public static FrameForm Instance = null;
        public int mdiChildrenCount = 1;

        public void collectionMDIMenuStripFrameForm(ListBox listBox) {
            collectionMDIForm.DropDownItems.Clear();
            foreach(var n in listBox.Items) {
                ChildForm s = (ChildForm)n;
                collectionMDIForm.DropDownItems.Add(s.Text);
            }
        }
        public FrameForm() {
            InitializeComponent();
            Instance = this;
        }

        private void ShowChildForm() {
            ChildForm childForm = new ChildForm();
            childForm.MdiParent = this;
            childForm.Text += " " + mdiChildrenCount.ToString();
            mdiChildrenCount++;
            childForm.Show();

            SubsidiaryForm.Instance.ListBoxAddChildForm(childForm);
        }

        public void toolStripMenuItem3_Click(object sender, EventArgs e) {
            ShowChildForm();
        }

        public void toolStripMenuItem4_Click(object sender, EventArgs e) {
            ShowChildForm();
            ChildForm.Instance.toolStripMenuItem4_Click(sender, e);
        }

        public void toolStripMenuItem5_Click(object sender, EventArgs e) {
            Save_All_Click(sender, e);
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
            foreach (ChildForm childForm in MdiChildren) {
                childForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void FrameForm_Load(object sender, EventArgs e) {
            SubsidiaryForm subsidiaryForm = new SubsidiaryForm();
        }

        private void FrameForm_LocationChanged(object sender, EventArgs e) {
            if(ChildForm.Instance != null)
                Data.Label1SubsidiaryFormWrite();
        }

        private void New_6_Click(object sender, EventArgs e) {
            int countChildForm = 6;
            for(int i = 0; i < countChildForm; i++) {
                ShowChildForm();
            }
        }

        private void Save_as_Click(object sender, EventArgs e) {
            if(Data.GetChildForm() != null)
                    Data.GetChildForm().toolStripMenuItem2_Click(sender, e);
        }

        private void Save_All_Click(object sender, EventArgs e) { 
            foreach (ChildForm childForm in MdiChildren) {
                if (childForm.filePath != "") {
                    bool saveOk = ReadAndWrite_Iormation.SaveFile(
                        childForm.filePath, childForm.TextBoxChildForm.Lines);
                    if (saveOk)
                        childForm.SaveDateTime = DateTime.Now;
                }

                else {
                    bool saveOk = ReadAndWrite_Iormation.SaveFileDialog(
                        childForm.TextBoxChildForm.Lines, childForm.Text);
                    if (saveOk)
                        childForm.SaveDateTime = DateTime.Now;                   
                }                    
            }
        }

        private void Set_Pink_Color_Click(object sender, EventArgs e) {
            if(ActiveMdiChild != null)
                    ActiveMdiChild.BackColor = Color.Pink;
        }

        private void Set_Random_Color_Click(object sender, EventArgs e) {
            Random random = new Random();
            foreach (ChildForm childForm in MdiChildren) {
                childForm.BackColor = Color.FromArgb(
                    random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            }
        }

        private void Restore_all_Click(object sender, EventArgs e) {
            foreach (ChildForm childForm in MdiChildren) {
                childForm.WindowState = FormWindowState.Normal;
            }
        }

        private void Close_all_Click(object sender, EventArgs e) {
            foreach (ChildForm childForm in MdiChildren) {
                childForm.Close();
            }
        }

        private void Info_Click(object sender, EventArgs e) {
            if (SubsidiaryForm.Instance != null)
                SubsidiaryForm.Instance.Show();
        }

        private void List_From_Other_Click(object sender, EventArgs e) {
            ListFromOtherForm listFromOtherForm = new ListFromOtherForm();
            listFromOtherForm.Show();
        }
    }
}
