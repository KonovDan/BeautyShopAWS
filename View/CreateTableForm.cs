using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace View
{
    public partial class CreateTableForm : Form
    {
        OleDbConnection connection;
        public CreateTableForm(OleDbConnection connection)
        {
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
            string cmd = $"CREATE TABLE {this.textBox_tableName.Text} (";
            
            Dictionary<string,string> foreignKeys = new Dictionary<string, string>() { };

            foreach (ListViewItem item in this.listView_columnList.Items)
            {
                string line = item.Text;
                bool pk = false;
                foreach(ListViewItem item2 in listView_columnList.CheckedItems)
                {
                    pk = item2.Text == item.Text?true:false;
                } 
                line  += " " + (pk ? "COUNTER" : item.SubItems[1].Text);
                line +=  pk ? " PRIMARY KEY" : "";
                line += item.SubItems[2].Text == "Yes" ? " UNIQUE" : "";
                cmd += line + ", ";

                if (item.SubItems[3].Text != "None")
                {
                    foreignKeys[item.Text] = item.SubItems[3].Text;
                }
            }
            cmd = cmd.Remove(cmd.Length - 2);

            if (foreignKeys.Keys.Count != 0)
            {
                foreach (string key in foreignKeys.Keys)
                {
                    cmd += $", FOREIGN KEY ({key}) REFERENCES {foreignKeys[key].Split('.')[0]}({foreignKeys[key].Split('.')[1]})";
                }
            }
            cmd += ");";

            OleDbCommand command = new OleDbCommand(cmd, this.connection);
            command.ExecuteScalar();


                

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
                this.listView_columnList.Items.Remove(item);
            }
        }
    }
}
