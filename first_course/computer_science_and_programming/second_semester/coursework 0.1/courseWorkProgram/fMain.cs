using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseWorkProgram {

    public partial class fMain:Form {

        public fMain () {
            InitializeComponent();
        }

        string path = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\institute\\computer science and programming\\second semester\\coursework\\access\\coursework.mdb;";
        OleDbConnection dbConnection;
        
        private void FMain_Load (object sender, EventArgs e) {

            dbConnection = new OleDbConnection(path);
            dbConnection.Open();

            DataTable dataTable = dbConnection.GetSchema("Tables");
            foreach (DataRow dr in dataTable.Rows) {
                string tableName = dr["TABLE_NAME"].ToString();
                if (tableName.Contains("Клиенты") | tableName.Contains("Услуги")) {
                    treeView.Nodes.Add(tableName);
                }
            }
        }

        private void TreeView_AfterSelect (object sender, TreeViewEventArgs e) {

            OleDbConnection dbConnection = new OleDbConnection(path);
            dbConnection.Open();

            OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter("select * from" + "[" + treeView.SelectedNode.Text +"]", dbConnection);

            DataSet dataSet = new DataSet();
            dbDataAdapter.Fill(dataSet, treeView.SelectedNode.Text);
            dgv.DataSource = dataSet.Tables[0];
        }


        private void BtnExit_Click (object sender, EventArgs e) {
            Close();
        }


        private void BtnSave_Click (object sender, EventArgs e) {
            
        }

        private void FMain_FormClosing (object sender, FormClosingEventArgs e) {
            dbConnection.Close();
        }
    }

}
