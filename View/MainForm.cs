using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;



namespace View
{
    public partial class MainForm : Form
    {
        public readonly bool isReady;
        public readonly OleDbConnection connection;
        string view = "work";
        string currentUnitType;
        string username;
        string mode = "user";
        public MainForm()
        {
            #region Initialization
            InitializeComponent();
            this.connection = new OleDbConnection(ConfigurationManager.AppSettings.Get("connection_string"));
            this.connection.Open();
            #endregion


            this.radioButton_Click(null, null);
            Button btn = new Button();
            btn.Location = new System.Drawing.Point(10, 10);
            btn.Name = "fghgfgfgffghg";
            btn.Size = new System.Drawing.Size(193, 23);
            btn.UseVisualStyleBackColor = true;

            //this.button_login.Location = new System.Drawing.Point(63, 64);
            //this.button_login.Name = "button_login";
            //this.button_login.Size = new System.Drawing.Size(193, 23);
            //this.button_login.TabIndex = 2;
            //this.button_login.Text = "Вход";
            //this.button_login.UseVisualStyleBackColor = true;
            //this.button_login.Click += new System.EventHandler(this.button_login_Click);

        }

        private void setViewMode(object sender, EventArgs e)
        {
            if (sender == this.аналитикаToolStripMenuItem)
            {
                this.panel4.Visible = false;
            }
            if (sender == this.рабочийToolStripMenuItem)
            {
                this.panel4.Visible = true;
            }
        }

        private void login()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (loginForm.state)
            {
                Dictionary<String, String> loginData = loginForm.getData();
                this.username = loginData["username"];
                setUserMode(loginData["type"]);
            }
            else this.Close();
        }

        private void column_click(object sender, EventArgs e)
        {
            System.Windows.Forms.ColumnClickEventArgs args = (System.Windows.Forms.ColumnClickEventArgs)e;
            string s = this.listView1.Columns[args.Column].Text;

            List<ListViewItem> toSort = new List<ListViewItem>() { };
            foreach (ListViewItem item in this.listView1.Items) toSort.Add(item);
            toSort.Sort((ListViewItem a, ListViewItem b) => { return a.SubItems[args.Column].Text.CompareTo(b.SubItems[args.Column].Text); });
            this.listView1.Items.Clear();
            foreach (ListViewItem item in toSort) this.listView1.Items.Add(item);
        }
        private void setUserMode(string mode)
        {
            
            switch (mode)
            {
                case "user":
                    {
                        this.ToolStripMenuItem_edit.Visible = false;
                        this.ToolStripMenuItem_delete.Visible = false;
                        this.listView1.CheckBoxes = false;
                        this.radioButton4.Visible = false;
                    }
                    break;
                case "administrator":
                    {
                        this.ToolStripMenuItem_edit.Visible = true;
                        this.ToolStripMenuItem_delete.Visible = true;
                        this.listView1.CheckBoxes = true;
                        this.radioButton4.Visible = true;
                    }
                    break;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            OleDbCommand command;
            ManageForm form;
            switch (this.currentUnitType)
            {
                default:
                case "Orders": form = new ManageForm("Orders"); break;
                case "Services": form = new ManageForm("Services"); break;
                case "Clients": form = new ManageForm("Clients"); break;
                case "Users": form = new ManageForm("Users"); break;
            }
            form.ShowDialog();
            if (form.state)
            {
                Dictionary<String, object> data = form.getData();
                string keys = "";
                string values = "";
                foreach (String key in data.Keys)
                {
                    keys += key + ", ";
                    if (data[key] is String) values += $"\"{data[key]}\", ";
                    else if(data[key] is IEnumerable<String>) { 
                    
                    }                                                                //IMPLEMENT ME PLS
                }
                keys = keys.Remove(keys.Count() - 2);
                values = values.Remove(values.Count() - 2);
                string c = $"INSERT INTO {this.currentUnitType} ({keys}) VALUES ({values});";
                command = new OleDbCommand(c, this.connection);
                command.ExecuteNonQuery();
                this.radioButton_Click(null, null);
            }
        }
        private void ToolStripMenuItem_logout_click(object sender, EventArgs e)
        {
            this.Hide();
            login();
            this.Show();

        }
        private void radioButton_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            this.listView1.Columns.Clear();
            ColumnHeader idHeader = new ColumnHeader("ID");
            idHeader.Width = 50;
            idHeader.Text = "ID";
            this.listView1.Columns.Add(idHeader);
            OleDbCommand command = null;
            if (this.radioButton1.Checked)
            {
                this.currentUnitType = "Orders";

                ColumnHeader timeHeader = new ColumnHeader("Время");
                timeHeader.Width = 150;
                timeHeader.Text = "Время";
                this.listView1.Columns.Add(timeHeader);

                ColumnHeader clientHeader = new ColumnHeader("Клиент");
                clientHeader.Width = 150;
                clientHeader.Text = "Клиент";
                this.listView1.Columns.Add(clientHeader);

                command = new OleDbCommand($"SELECT * FROM {currentUnitType}", this.connection);
            }
            else if (this.radioButton2.Checked)
            {
                this.currentUnitType = "Services";

                ColumnHeader titleHeader = new ColumnHeader("Название");
                titleHeader.Width = 150;
                titleHeader.Text = "Название";
                this.listView1.Columns.Add(titleHeader);

                ColumnHeader priceHeader = new ColumnHeader("Цена");
                priceHeader.Width = 50;
                priceHeader.Text = "Цена";
                this.listView1.Columns.Add(priceHeader);

                command = new OleDbCommand($"SELECT * FROM {currentUnitType}", this.connection);
            }
            else if (this.radioButton3.Checked)
            {
                this.currentUnitType = "Clients";

                ColumnHeader nameHeader = new ColumnHeader("Имя");
                nameHeader.Width = 100;
                nameHeader.Text = "Имя";
                this.listView1.Columns.Add(nameHeader);

                ColumnHeader secondNameHeader = new ColumnHeader("Фамилия");
                secondNameHeader.Width = 100;
                secondNameHeader.Text = "Фамилия";
                this.listView1.Columns.Add(secondNameHeader);

                ColumnHeader phoneNumberHeader = new ColumnHeader("Контактный номер");
                phoneNumberHeader.Width = 150;
                phoneNumberHeader.Text = "Контактный номер";
                this.listView1.Columns.Add(phoneNumberHeader);

                command = new OleDbCommand($"SELECT * FROM {currentUnitType}", this.connection);
            }
            else if (this.radioButton4.Checked)
            {
                this.currentUnitType = "Users";

                this.listView1.Columns.Clear();

                ColumnHeader usernameHeader = new ColumnHeader("Username");
                usernameHeader.Width = 100;
                usernameHeader.Text = "Username";
                this.listView1.Columns.Add(usernameHeader);

                ColumnHeader secondNameHeader = new ColumnHeader("Account type");
                secondNameHeader.Width = 100;
                secondNameHeader.Text = "Account type";
                this.listView1.Columns.Add(secondNameHeader);


                command = new OleDbCommand($"SELECT id, type FROM {currentUnitType}", this.connection);
            }
            if (!(command is null))
            {
                OleDbDataReader cursor = command.ExecuteReader();
                while (cursor.Read())
                {
                    ListViewItem item = new ListViewItem(cursor[0].ToString());
                    for (int i = 1; i < cursor.FieldCount; ++i)
                    {
                        item.SubItems.Add(new ListViewItem.ListViewSubItem(item, (cursor[i].ToString())));
                    }
                    this.listView1.Items.Add(item);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            OleDbCommand command;
            foreach (ListViewItem item in this.listView1.CheckedItems)
            {
                try
                {
                    int id = Convert.ToInt32(item.Text.Split(' ')[0]);
                    command = new OleDbCommand($"DELETE FROM {this.currentUnitType} WHERE id={item.Text.Split(' ')[0]};", this.connection);
                    command.ExecuteNonQuery();
                }
                catch
                {
                    command = new OleDbCommand($"DELETE FROM {this.currentUnitType} WHERE id=\"{item.Text.Split(' ')[0]}\";", this.connection);
                    command.ExecuteNonQuery();
                }
            }
            this.radioButton_Click(null, null);
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            OleDbCommand command;
            foreach (ListViewItem item in this.listView1.CheckedItems)
            {

            
            ManageForm form;
            switch (this.currentUnitType)
            {
                default:
                case "Orders": form = new ManageForm("Orders"); break;
                case "Services": form = new ManageForm("Services"); break;
                case "Clients": form = new ManageForm("Clients"); break;
                case "Users": form = new ManageForm("Users"); break;
            }
            form.ShowDialog();
            if (form.state)
            {
                Dictionary<String, object> data = form.getData();
                string result = "";
                foreach (String key in data.Keys)
                {
                    if (data[key] == "") continue;
                        try
                        {
                            result += $"{key}={Convert.ToInt32(data[key])}, ";
                        } catch
                        {
                            result += $"{key}=\"{data[key]}\", ";
                        }
                }
                result = result.Remove(result.Count() - 2);
                    string c = $"UPDATE {this.currentUnitType} SET {result} WHERE id={item.Text};";
                command = new OleDbCommand(c, this.connection);
                command.ExecuteNonQuery();
                this.radioButton_Click(null, null);
            }
            }
            this.radioButton_Click(null, null);
        }

        private void ToolStripMenuItem_exit_click(object sender, EventArgs e) => this.Close();

        private void MainForm_Load(object sender, EventArgs e)
        {
            login();
        }
    }
}
