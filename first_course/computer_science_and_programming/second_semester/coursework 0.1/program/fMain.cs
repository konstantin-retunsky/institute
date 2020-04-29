using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace program {

    public partial class fMain:Form {

        public static string           path = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\institute\\first course\\computer science and programming\\second semester\\coursework\\access\\coursework.mdb;";
        public static OleDbConnection  dbConnection = new OleDbConnection (path);
        public static OleDbDataAdapter dbAdapter = new OleDbDataAdapter();
        public static DataSet          dataSet = new DataSet();
        

        public fMain () {
            InitializeComponent();
        }

        private void FMain_Load (object sender, EventArgs e) {
            
            dbConnection.Open();
            treeView.Nodes.Add("Клиенты");
            treeView.Nodes.Add("Услуги");
            treeView.Nodes.Add("test");
            dbConnection.Close();
            dgv.AllowUserToDeleteRows = true;
            
        }

        private void TreeView_AfterSelect (object sender, TreeViewEventArgs e) {
            // заполняем dgv
            dbConnection.Open();
            dbAdapter = new OleDbDataAdapter("select * from" + "[" + treeView.SelectedNode.Text + "]", dbConnection);
            dbAdapter.Fill(dataSet, treeView.SelectedNode.Text);

            dgv.DataSource = dataSet.Tables[0];
            dataSet.Tables.Clear();
            dbConnection.Close();

            // блокируем сортировку dgv 
            foreach (DataGridViewColumn column in dgv.Columns) {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            this.dgv.AutoResizeColumns(
            DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        private void BtnDelete_Click (object sender, EventArgs e) {
            dbConnection.Open();
            dbAdapter = new OleDbDataAdapter("select * from" + "[" + treeView.SelectedNode.Text + "]", dbConnection);
            dbAdapter.Fill(dataSet, treeView.SelectedNode.Text);

            string query = $"DELETE FROM [{treeView.SelectedNode.Text}] WHERE [{fMain.dataSet.Tables[0].Columns[0]}]=?";
            OleDbCommand deleteCommand = new OleDbCommand(query, dbConnection);

            deleteCommand.Parameters.AddWithValue("@ID", int.Parse(dgv.Rows[dgv.CurrentCell.RowIndex].Cells[0].Value.ToString()));
            deleteCommand.ExecuteNonQuery();

            dataSet.Tables.Clear();
            dbAdapter.Fill(dataSet, treeView.SelectedNode.Text);
            dgv.DataSource = dataSet.Tables[0];
            dataSet.Tables.Clear();
            dbConnection.Close();
        }

        private void BtnAdd_Click (object sender, EventArgs e) {
            FormShowDialog(new FormAdd());
        }

        private void BtnEditing_Click (object sender, EventArgs e) {
            FormShowDialog(new FormEdit());
        }

        private void BtnSearch_Click (object sender, EventArgs e) {
            FormShowDialog(new FormSearch());
        }

        /// <summary>
        /// Открытие заданной формы с позицианированием по центру, у которой родитель fMain.
        /// </summary>
        public void FormShowDialog (Form form) {
            form.Owner = this;
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }
        private void BtnExit_Click (object sender, EventArgs e) {
            this.Close();
        }

        private void FMain_FormClosing (object sender, FormClosingEventArgs e) {
            if (dbConnection.State.ToString() == "Open") {
                dbConnection.Close();
            }
        }
    }
}
//string query = "UPDATE [test] SET [a]='" + "eeBoy" + "', [aa]='" + "eeBoy" + "', [aaa]='" + "suka" + "'  WHERE [idA]=" + "3";

//OleDbConnection connection= new OleDbConnection(path);
//connection.Open();
//OleDbCommand  dbCommand= new OleDbCommand(query, connection);
//dbCommand.CommandText = query;

//dbCommand.ExecuteNonQuery();
//connection.Close();
//using (var dbConnection = new OleDbConnection(path)) {
//    connection.Open();
//    using (OleDbCommand command = connection.CreateCommand()) {
//        command.CommandText = $"INSERT INTO [test] (a) values ('{"aaaa"}');";
//myOleDbCommand.CommandText = @"DELETE FROM Таблица1  WHERE ([№п/п] = '" + this.textBox1.Text + "');";
//        int numberOfUpdatedItems = command.ExecuteNonQuery();
//    }
//    connection.Close();
//}
//dataSet.Tables.Add((DataTable) dgv.DataSource);
// http://csharp.net-informations.com/datagridview/autogridview.htm
