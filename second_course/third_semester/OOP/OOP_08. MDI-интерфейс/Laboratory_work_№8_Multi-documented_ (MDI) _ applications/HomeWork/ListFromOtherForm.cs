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
    public partial class ListFromOtherForm : Form {
        public ListFromOtherForm() {
            InitializeComponent();
        }

        private void ListFromOtherForm_Load(object sender, EventArgs e) {
            if (SubsidiaryForm.Instance != null) {
                ListBox collection = SubsidiaryForm.Instance.ListBoxSubsidiaryForm;
                List<string> result = new List<string>(); 
                for(int i = 0; i < collection.Items.Count; i++) {
                    ChildForm childForm = (ChildForm)collection.Items[i];
                    string name = "";
                    if (childForm.filePath != "")
                        name = Path.GetFileNameWithoutExtension(childForm.filePath);
                    else
                        name = childForm.Text;

                    result.Add($"----------- {name} -----------\n");
                    result.Add("Создана              " + childForm.InitializeDateTime.ToString("MM.dd.yyyy HH:mm:ss"));
                    result.Add("\nПоследнее сохранение " + childForm.SaveDateTime.ToString("MM.dd.yyyy HH:mm:ss"));
                    result.Add($"\nСодержит {childForm.TextBoxChildForm.Lines.Length} строки.\n");
                    if (childForm.TextBoxChildForm.Lines.Length > 0) {
                        int countText = 0;
                        try {
                            while (countText != 5) {
                                result.Add($"{countText + 1}. " +
                                    childForm.TextBoxChildForm.Lines[countText]);
                                countText++;
                            }
                        }
                        catch (Exception) {
                            throw;
                        }
                    }
                                       
                    result.Add("----------------------------------------------------------------");
                }
                foreach (string text in result)
                    textBox1.Text += text + Environment.NewLine;
            } 
        }
    }
}
