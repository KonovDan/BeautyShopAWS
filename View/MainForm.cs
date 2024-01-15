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
                        Dictionary<string, string> FAKEPEACEOFCAKE = new Dictionary<string, string>();
                        int PAPAYA = 0;
                        foreach (DataGridViewCell cell in dataGridView1.Rows[args.RowIndex].Cells)
                        {
                            FAKEPEACEOFCAKE[dataGridView1.Columns[PAPAYA].Name] = cell.Value.ToString();
                            PAPAYA++;
                        }

                        try
                        {
                            if (dataGridView1.Rows[args.RowIndex].Cells[0].Value.ToString() != "")
                            {
                                foreach (string columnName in FAKEPEACEOFCAKE.Keys)
                                {

                                    if (FAKEPEACEOFCAKE[columnName].Equals("") || columnName == "ID") continue;
                                    if(FAKEPEACEOFCAKE[columnName].Contains('/'))
                                    {
                                        List<string> values = FAKEPEACEOFCAKE[columnName].Split('/').ToList();
                                        values_s += columnName + "=" + "\"" + values[0] + "-" + values[1] + "-" + values[2] + "\", ";
                                    } else
                                    {

                                    values_s += columnName + "=" + "\"" + FAKEPEACEOFCAKE[columnName] + "\", ";
                                    }
                                }
                                values_s = values_s.Remove(values_s.Length - 2, 2);
                                Console.WriteLine(dataGridView1.Rows[args.RowIndex].Cells[0].Value);
                                command = new OleDbCommand($"UPDATE {currentTableName} SET {values_s} WHERE ID={dataGridView1.Rows[args.RowIndex].Cells[0].Value.ToString()};", connection);

                            }
                            else
                            {
                                foreach (string columnName in FAKEPEACEOFCAKE.Keys)
                                {
                                    if (FAKEPEACEOFCAKE[columnName].Equals("")) continue;
                                    columns_s += columnName + ", ";
                                    values_s += "\"" + FAKEPEACEOFCAKE[columnName] + "\"" + ", ";
                                }
                                columns_s = columns_s.Remove(columns_s.Length - 2, 2);
                                values_s = values_s.Remove(values_s.Length - 2, 2);
                                command = new OleDbCommand($"INSERT INTO {currentTableName}({columns_s}) VALUES ({values_s});", connection);
                            }
                            command.ExecuteNonQuery();
                            updatedatagridview();
                        } catch
                        {

                        }
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
