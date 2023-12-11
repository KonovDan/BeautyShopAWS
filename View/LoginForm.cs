using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Security.Cryptography;
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

                MD5 md5 = MD5.Create();
                List<byte> bytes = new List<byte>();
                foreach (char ch in textBox_password.Text) bytes.Add(Convert.ToByte(ch));
                byte[] hashed = md5.ComputeHash(bytes.ToArray());
                string result = "";
                foreach (byte b in hashed) result += Convert.ToString(b);
                OleDbDataReader reader = (new OleDbCommand(
                    $"SELECT * FROM Users WHERE id=\"{textBox_login.Text}\" " +
                    $"AND password=\"{result}\";", connection)).ExecuteReader();

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
            }
            else
            {
                Clear();
            }
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            ClientView view  = new ClientView();
            this.Hide();
            view.ShowDialog();
            this.Close();
        }
        private void button_register_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            register.FormClosed += (s, args) => this.Show();


        }

        public Dictionary<String, String> getData()
        {
            Dictionary<String, String> result = new Dictionary<string, string>() { };
            result["username"] = this.username;
            result["type"] = userType;
            return result;
        }
    }
}
