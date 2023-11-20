using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Windows.Forms;

namespace View
{
    public partial class LoginForm : Form
    {
        public bool state = false;
        string username = "";
        string userType = "";
        public LoginForm()
        {
            this.state = false;
            InitializeComponent();
        }
        private void Clear()
        {
            this.textBox_login.Text = "";
            this.textBox_password.Text = "";
        }
        private void button_login_Click(object sender, EventArgs e)
        {
            if (this.textBox_login.Text != "" && this.textBox_password.Text != "")
            {
                OleDbConnection connection = new OleDbConnection(ConfigurationManager.AppSettings.Get("connection_string"));
                connection.Open();
                OleDbDataReader reader = (new OleDbCommand(
                    $"SELECT * FROM Users WHERE id=\"{textBox_login.Text}\" " +
                    $"AND password=\"{textBox_password.Text}\";", connection)).ExecuteReader();
                
                if (reader.Read())
                {
                    this.username = reader[0].ToString();
                    this.userType = reader[2].ToString();
                    connection.Close();
                    Clear();
                    this.state = true;
                    this.Close();
                }
                else
                {
                    connection.Close();
                    Clear();
                }
            } else {
                Clear();
            }
        }
        private void button_cancel_Click(object sender, EventArgs e) => this.Close();

        public Dictionary<String, String> getData()
        {
            Dictionary<String, String> result = new Dictionary<string, string>() { };
            result["username"] = this.username;
            result["type"] = userType;
            return result;
        }
    }
}
