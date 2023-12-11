using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class RegisterForm : Form
    {
        LoginForm login;
        public RegisterForm()
        {
            login = new LoginForm();
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
        }

        private void button_registration_Click(object sender, EventArgs e)
        {
            MD5 md5 = MD5.Create();
            List<byte> bytes = new List<byte>();
            foreach (char ch in textBox_password.Text) bytes.Add(Convert.ToByte(ch));
            byte[] hashed = md5.ComputeHash(bytes.ToArray());
            string result = "";
            foreach (byte b in hashed) result += Convert.ToString(b);
            OleDbConnection connection = new OleDbConnection(ConfigurationManager.AppSettings.Get("connection_string"));
            connection.Open();
            OleDbCommand command = new OleDbCommand($"INSERT INTO users ([ID], [password], [type]) VALUES (@Value1, @Value2, @Value3)", connection);
            command.Parameters.AddWithValue("@Value1",textBox_phone.Text );
            command.Parameters.AddWithValue("@Value2", result);
            command.Parameters.AddWithValue("@Value3", "user");
            command.ExecuteNonQuery();
            this.Close();
        }
    }
}
