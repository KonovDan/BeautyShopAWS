using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace View
{
    public partial class ManageForm : Form
    {
        public bool state = false;
        public ManageForm(string unitType)
        {
            this.state = false;
            InitializeComponent();
            this.groupBox_client.Visible = false;
            this.groupBox_order.Visible = false;
            this.groupBox_user.Visible = false;
            this.groupBox_service.Visible = false;
            switch (unitType)
            {
                case "Users":
                    {
                        this.groupBox_user.Visible = true;
                    }
                    break;
                case "Orders":
                    {
  
                        this.groupBox_order.Visible = true;

                    }
                    break;
                case "Clients":
                    {
                        this.groupBox_client.Visible = true;

                    }
                    break;
                case "Services":
                    {

                        this.groupBox_service.Visible = true;
                    }
                    break;
            }
        }
        private void button_apply_Click(object sender, EventArgs e)
        {
            this.state = true;
            this.Close();
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Dictionary<String, object> getData()
        {
            Dictionary<String, object> result = new Dictionary<string, object>() { };
            result["имя"] = this.textBox_firstName.Text;
            result["фамилия"] = this.textBox_secondName.Text;
            result["контактный_номер"] = this.textBox_phoneNumber.Text;
            result["время"] = this.textBox_dateTime.Text;
            result["название"] = this.textBox_title.Text;
            result["цена"] = this.textBox_price.Text;

            return result;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
