using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace View
{
    public partial class MainForm : Form
    {
        public readonly OleDbConnection connection = new OleDbConnection(ConfigurationManager.AppSettings.Get("connection_string"));
        string currentTableName;
        public MainForm()
        {
            this.connection.Open();

            #region Initialization
            InitializeComponent();
            #endregion

            #region Update view
            updateTableList();
            dataGridView1.CellValueChanged += new DataGridViewCellEventHandler(
                (object sender, DataGridViewCellEventArgs args) =>
                    {
                        if (connection.State != ConnectionState.Open) connection.Open();
                        OleDbCommand command;
                        string values_s = "";
                        string columns_s = "";
                        string ID = "";
                        List<string> fields = new List<string>() { };
                        List<string> values = new List<string>() { };
                        foreach (DataRow row in connection.GetSchema("Columns").Rows) if (row["TABLE_NAME"].ToString() == currentTableName)
                            {
                                if (ID=="") ID = row["COLUMN_NAME"].ToString();
                                fields.Add(row["COLUMN_NAME"].ToString());
                            }
                        foreach (DataGridViewCell cell in this.dataGridView1.Rows[args.RowIndex].Cells) values.Add(cell.Value.ToString());
                        if (values[0] != "")
                        {
                            for (int i = 1; i < fields.Count; ++i)
                            {
                                values_s += fields[i] + "=" + "\"" + (values[i] != "" ? values[i] : "NULL") + "\"";
                                if (i != fields.Count - 1) values_s += ", ";
                            }
                            command = new OleDbCommand($"UPDATE {currentTableName} SET {values_s} WHERE ID={values[0]};", connection);
                        }
                        else
                        {
                            int i = 0;
                            if (ID == "ID") i = 1;
                            for (; i < values.Count; ++i)
                            {
                                columns_s += fields[i] + ", ";
                                values_s += (values[i]!=""? "\"" + values[i] + "\"" : "NULL")  + ", ";
                            }
                            columns_s = columns_s.Remove(columns_s.Length - 2, 2);
                            values_s = values_s.Remove(values_s.Length - 2, 2);
                            command = new OleDbCommand($"INSERT INTO {currentTableName}({columns_s}) VALUES ({values_s});", connection);
                        }
                        command.ExecuteNonQuery();
                        updatedatagridview();
                     });
            #endregion
        }

  
        private void updatedatagridview()
        {
            DataTable dataTable = new DataTable();
            new OleDbDataAdapter($"SELECT * FROM {currentTableName}", connection).Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void deleteRow(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                try
                {
                    OleDbCommand command = new OleDbCommand(
                        $"DELETE FROM {currentTableName} WHERE id={row.Cells[0].Value};",
                        connection);
                    command.ExecuteNonQuery();
                }
                catch { }
            }
            updatedatagridview();
        }

        private void updateTableList()
        {
            this.tableToolStripMenuItem.DropDownItems.Clear();
            foreach (DataRow row in connection.GetSchema("Tables").Rows)
            {
                string tableName = row["TABLE_NAME"].ToString();

                if (!tableName.StartsWith("MSys") &&
                    !tableName.StartsWith("~") &&
                    !tableName.StartsWith("f") &&
                    !tableName.StartsWith("Switchboard"))
                {
                    ToolStripMenuItem item = new ToolStripMenuItem();
                    item.Name = "item";
                    item.Size = new System.Drawing.Size(180, 22);
                    item.Text = tableName;
                    item.Click += new EventHandler((object sender, EventArgs e) =>
                    {
                        this.currentTableName = tableName;
                        updatedatagridview();
                    });
                    this.tableToolStripMenuItem.DropDownItems.Add(item);
                }
            }
            this.tableToolStripMenuItem.DropDownItems[0].PerformClick();
        }

        private void createTable(object sender, EventArgs e)
        {
            CreateTableForm form = new CreateTableForm(this.connection);
            form.ShowDialog();
            updateTableList();
        }
        private void editTable(object sender, EventArgs e)
        {
            EditTableForm form = new EditTableForm(this.connection, currentTableName);
            form.ShowDialog();
            updateTableList();
        }

        private void deleteTable(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();
            new OleDbCommand($"DROP TABLE [{currentTableName}];", connection).ExecuteNonQuery();
            updateTableList();
        }

        private void login()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (loginForm.state)
            {
                Dictionary<String, String> loginData = loginForm.getData();
            }
            else this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e) => login();
    }
}
