using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork {
    static class ReadAndWrite_Iormation {
        static public Tuple<string, string[]> ReadFile() {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = @"D:\ValiuS\Desktop\OOP\OOP_08. MDI-интерфейс\Laboratory_work_№8_Multi-documented_ (MDI) _ applications";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    string filePath = openFileDialog.FileName;

                    return Tuple.Create(filePath,
                        File.ReadAllLines(filePath));
                }
            }
            return null;
        }
        static public bool SaveFileDialog(string[] textBoxLines, string fileName) {
            bool saveOk = false;
            var filePath = string.Empty;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog()) {
                saveFileDialog.InitialDirectory = @"D:\ValiuS\Desktop\OOP\OOP_08. MDI-интерфейс\Laboratory_work_№8_Multi-documented_ (MDI) _ applications";
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.FileName = fileName + ".txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                    filePath = saveFileDialog.FileName;
                    File.WriteAllLines(filePath, textBoxLines);
                    saveOk = true;
                }
            }
            return saveOk;
        }
        static public bool SaveFile(string filePath, string[] textBoxLines) {
            bool saveOk = false;
            try {
                File.WriteAllLines(filePath, textBoxLines);
                saveOk = true;
            }
            catch (Exception) {
                saveOk = false;
            }
            return saveOk;
        }
    }
}
