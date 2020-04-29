using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Babeshin
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Name == "doc")
            {
                try
                {
                    System.Diagnostics.Process.Start(@"КУРСОВАЯ.docx");
                }
                catch(Exception ex)
                { MessageBox.Show(ex.Message, "Ошибка");  }
            }
            else if (treeView1.SelectedNode.Name == "access")
            {
                try
                {
                    System.Diagnostics.Process.Start(@"Бабешин.accdb");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
            else if (treeView1.SelectedNode.Name == "excel")
            {
                try
                {
                    System.Diagnostics.Process.Start(@"Бабешин(Библиотека).xlsm");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }

        }
    }
}
