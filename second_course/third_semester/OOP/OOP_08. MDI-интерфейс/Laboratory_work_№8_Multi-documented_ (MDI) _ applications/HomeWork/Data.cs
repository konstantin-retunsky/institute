using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork {
    static class Data {
        public static void Label1SubsidiaryFormWrite() {
            if (GetChildForm() != null) {
                SubsidiaryForm.Instance.LabelTextSubsidiaryForm =
                    InfoChildForm(GetChildForm());
            }
            else if (SubsidiaryForm.Instance != null)
                SubsidiaryForm.Instance.LabelTextSubsidiaryForm = "Данные по окнам.";

        }

        private static string InfoChildForm(ChildForm childForm) {
            string result;
            result = childForm.Text;
            result += "\n" + "Ширина: " + childForm.Width.ToString() + " Высота: " + childForm.Height.ToString();
            result += "\n" + "Положение на форме: " + childForm.Location.X.ToString() + "/" + childForm.Location.Y.ToString();
            result += "\n" + "Положение на экране: " + childForm.PointToScreen(childForm.Location).X.ToString() + "/" + childForm.PointToScreen(childForm.Location).Y.ToString();
            result += "\n" + Path.GetFileNameWithoutExtension(childForm.filePath);
            result += "\n" + childForm.TextBoxChildForm.Lines.Length.ToString();

            return result;
        }

        public static ChildForm GetChildForm() {
            if (SubsidiaryForm.Instance != null) {
                if (SubsidiaryForm.Instance.ListBoxSubsidiaryForm.SelectedIndex >= 0)
                    return (ChildForm)SubsidiaryForm.Instance.ListBoxSubsidiaryForm.SelectedItem;
            }
            return null;
        }

        public static void ListBoxRemoveChildForm(ChildForm childForm) {
            SubsidiaryForm.Instance.ListBoxSubsidiaryForm.Items.Remove(childForm);
            FrameForm.Instance.collectionMDIMenuStripFrameForm(SubsidiaryForm.Instance.ListBoxSubsidiaryForm);
            Label1SubsidiaryFormWrite();
        }
    }
}
