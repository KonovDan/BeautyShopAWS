
using Microsoft.Office.Interop.Access.Dao;
using System;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace View
{
    public partial class ClientView : Form
    {
        string time;
        OleDbConnection connection = new OleDbConnection(ConfigurationManager.AppSettings.Get("connection_string"));
        public ClientView()
        {
            InitializeComponent();
            connection.Open();
            OleDbCommand command;
            OleDbDataReader reader;
            listView_time.Columns.Add("время");
            command = new OleDbCommand("SELECT * FROM masters;", connection);
            reader = command.ExecuteReader();

            listView_masters.Columns.Add("ID");
            listView_masters.Columns.Add("имя");
            listView_masters.Columns.Add("фамилия");
            while (reader.Read())
            {

                ListViewItem item = new ListViewItem();
                item.Text = reader[0].ToString();
                item.SubItems.Add(reader[1].ToString());
                item.SubItems.Add(reader[2].ToString());
                this.listView_masters.Items.Add(item);
            }
            command = new OleDbCommand("SELECT * FROM service;", connection);
            reader = command.ExecuteReader();

            listView_masters.Columns.Add("ID");
            listView_services.Columns.Add("название");
            listView_services.Columns.Add("цена");
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = reader[0].ToString();
                item.SubItems.Add(reader[1].ToString());
                item.SubItems.Add(reader[2].ToString());
                this.listView_services.Items.Add(item);
            }



            this.monthCalendar1.DateSelected += new DateRangeEventHandler(updateTimeList);
            this.FormClosed += new FormClosedEventHandler(ClientViewClose);
        }
        private void SendSmsNotification()
        {
            string accountSid = "";
            string authToken = "";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
            to: new PhoneNumber($"'+'+{textBox_phone}"),
            from: new PhoneNumber("+79937822497"),
            body: $"Вы записаны к {listView_masters.SelectedItems[0]} на {listView_time.SelectedItems[0]}."); ; ; ;

        }
        private void updateTimeList(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand("SELECT время FROM orders;", connection);
            OleDbDataReader reader = command.ExecuteReader();

            listView_time.Items.Clear();

            for (int i = 0; i < 24; ++i )
            {
                int hour = 8 + Convert.ToInt32(i / 2);
                int minute = 0 + 3 * ((i % 2));
                
                ListViewItem item = new ListViewItem($"{hour}:{minute}0:00");
                item.Text = $"{hour}:{minute}0";
                this.listView_time.Items.Add(item);
            }

            while (reader.Read())
            {
                string date = reader[0].ToString().Split(' ')[0];
                    this.time = reader[0].ToString().Split(' ')[1];

                if (date == monthCalendar1.SelectionEnd.Date.ToString().Split(' ')[0])
                {
                    
                    foreach(ListViewItem item in listView_time.Items)
                    {
                        if (item.Text == time.Remove(time.Length - 3)) listView_time.Items.Remove(item);
                    }
                }

            }
}

        private void ClientViewClose(object sender, EventArgs e)
        {
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("" +
                $"{textBox_firstName.Text}\n" +
                $"{textBox_lastName.Text}\n" +
                $"{textBox_phone.Text}\n" +
                $"{listView_masters.SelectedItems[0].Text}\n" +
                $"{listView_services.SelectedItems[0].Text}\n" +
                $"{listView_time.SelectedItems[0].Text}\n"
                );
            if (textBox_firstName.Text == "" ||
                textBox_lastName.Text == "" ||
                textBox_phone.Text == "" ||
                listView_masters.SelectedItems[0].Text == "" ||
                listView_services.SelectedItems[0].Text == "" ||
                listView_time.SelectedItems[0].Text == ""||
                monthCalendar1.SelectionEnd == null)
            {
                Console.WriteLine("ERROROEOROEro");
            }


            OleDbCommand command = new OleDbCommand("SELECT * FROM clients;", connection);
            OleDbDataReader reader = command.ExecuteReader();
            bool f1 = false;
            while (reader.Read())
            {
                if (reader[1].ToString() == textBox_firstName.Text &&
                    reader[2].ToString() == textBox_phone.Text)
                {
                    f1 = true;
                    break;
                }
            }
            if (!f1) {

                command = new OleDbCommand($"INSERT INTO clients(имя, контактный_номер) VALUES ('{textBox_firstName.Text}','{textBox_phone.Text}');", connection);
                command.ExecuteNonQuery();
            }
                command = new OleDbCommand($"SELECT ID FROM clients WHERE имя='{textBox_firstName.Text}' AND контактный_номер='{textBox_phone.Text}';", connection);
                reader = command.ExecuteReader();
                reader.Read();
                int ID = Convert.ToInt32(reader["ID"].ToString());




            command = new OleDbCommand($"INSERT INTO orders(время, client_id, master_id, service) VALUES " +
                $"('{monthCalendar1.SelectionEnd.Date.ToString().Split(' ')[0] + ' ' + listView_time.SelectedItems[0].Text + ":00"}','{ID}','{listView_masters.SelectedItems[0].Text}','{listView_services.SelectedItems[0].Text}');", connection);
            command.ExecuteNonQuery();

            updateTimeList(null, null);
        }
    }

}
