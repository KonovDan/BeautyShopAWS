using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace View
{
    public partial class EditTableForm : Form
    {
        List<string> addColumns = new List<string>();
        List<string> deleteColumns = new List<string>();
        string currentTableName = "";

        OleDbConnection connection;
        public EditTableForm(OleDbConnection connection,string currentTableName)
        {
            this.currentTableName = currentTableName;
            this.connection = connection;
            InitializeComponent();
            listView_columnList.Columns.Add("Name");
            listView_columnList.Columns.Add("Type");
            listView_columnList.Columns.Add("Unique");
            listView_columnList.Columns.Add("Foreign key");

            foreach(string s in new List<string>() {
                "INT",
                "FLOAT",
                "DATE",
                "DATETIME",
                "TEXT"
            })
            {
                ToolStripMenuItem item = new ToolStripMenuItem(s);
                item.Size = new System.Drawing.Size(180, 22);
                item.Text = s;
                item.Click += new System.EventHandler(this.typeSelected);
                this.toolStripMenuItem_selectedType.DropDownItems.Add(item);
            }

            foreach (DataRow row in connection.GetSchema("Columns").Rows)
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
                    item.Text = $"{tableName}.{row["COLUMN_NAME"].ToString()}";
                    item.Click += new EventHandler((object sender, EventArgs e) =>
                    {
                        toolStripMenuItem2.Text = item.Text;
                    });
                    this.toolStripMenuItem2.DropDownItems.Add(item);
                }
            }


            this.textBox_tableName.Text = currentTableName;

            foreach (DataRow row in connection.GetSchema("Columns").Rows)
            {
                string tableName = row["TABLE_NAME"].ToString();

                if (!tableName.StartsWith("MSys") &&
                    !tableName.StartsWith("~") &&
                    !tableName.StartsWith("f") &&
                    !tableName.StartsWith("Switchboard"))
                {
                    if(tableName == currentTableName)
                    {
                        Console.WriteLine(row["DATA_TYPE"].ToString());
                        string type = "";
                        switch (row["DATA_TYPE"])
                        {
                            case 3: { type = "INT"; } break;
                            case 130: { type = "TEXT"; } break;
                        }
                        ListViewItem item = new ListViewItem();
                    item.Name = "item";
                    item.Text = $"{row["COLUMN_NAME"].ToString()}";
                        item.SubItems.Add(type);
                    listView_columnList.Items.Add(item);
                    }
                }
            }
        }
        private void addClick(object sender, EventArgs e)
        {
            if (toolStripMenuItem_selectedType.Text == "Type") return;
            ListViewItem item = new ListViewItem();
            item.Text = textBox_columnName.Text;
            item.SubItems.Add(toolStripMenuItem_selectedType.Text);
            item.SubItems.Add(checkBox_uniqueValue.Checked ? "YES" : "NO");
            item.SubItems.Add(toolStripMenuItem2.Text);
            listView_columnList.Items.Add(item);

            addColumns.Add(item.Text);

            toolStripMenuItem_selectedType.Text = "Type";
            textBox_columnName.Text = "";
            toolStripMenuItem2.Text = "None";
            checkBox_uniqueValue.Checked = false;

        }
        private void typeSelected(object sender, EventArgs e)
        {
            ToolStripItem obj = (ToolStripItem)sender;
            toolStripMenuItem_selectedType.Text = obj.Text;
        }
        private void createClick(object sender, EventArgs e)
        {
            OleDbCommand command;
           if (addColumns.Count > 0)
           {
                string cmd = $"ALTER TABLE {this.currentTableName} ADD ";

                Dictionary<string, string> foreignKeys = new Dictionary<string, string>() { };

                foreach (ListViewItem item in this.listView_columnList.Items)
                {
                    if (!addColumns.Contains(item.Text)) continue;
                    string line = item.Text;
                    line += " " + item.SubItems[1].Text;
                    foreach (ListViewItem item2 in listView_columnList.CheckedItems)
                    {
                        line += item2.Text == item.Text ? " PRIMARY KEY" : "";
                    }
                    line += item.SubItems[2].Text == "Yes" ? " UNIQUE" : "";
                    cmd += line + ", ";

                    if (item.SubItems[3].Text != "None")
                    {
                        foreignKeys[item.Text] = item.SubItems[3].Text;
                    }
                }
                cmd = cmd.Remove(cmd.Length - 2);
                cmd += ";";

                command = new OleDbCommand(cmd, this.connection);
                command.ExecuteScalar();
           }

            foreach (string column in deleteColumns)
            {
                Console.WriteLine();
                command = new OleDbCommand("" +
                    $"ALTER TABLE {this.currentTableName} DROP COLUMN {column};", this.connection);
                command.ExecuteScalar();
            }

            toolStripMenuItem_selectedType.Text = "Type";
            textBox_columnName.Text = "";
            toolStripMenuItem2.Text = "None";
            textBox_tableName.Text = "";
            checkBox_uniqueValue.Checked = false;

            listView_columnList.Items.Clear();
        }

        private void deleteField(object sender, EventArgs e)
        {
            var items = this.listView_columnList.SelectedItems;
            foreach (ListViewItem item in items)
            {
                deleteColumns.Add(item.Text);
                this.listView_columnList.Items.Remove(item);
            }
        }
    }
}
