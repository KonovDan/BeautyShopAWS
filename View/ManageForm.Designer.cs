namespace View
{
    partial class ManageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_apply = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_secondName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_phoneNumber = new System.Windows.Forms.TextBox();
            this.groupBox_client = new System.Windows.Forms.GroupBox();
            this.groupBox_order = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_dateTime = new System.Windows.Forms.TextBox();
            this.textBox_client_id = new System.Windows.Forms.TextBox();
            this.label_client_id = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox_user = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_type = new System.Windows.Forms.TextBox();
            this.groupBox_service = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox_client.SuspendLayout();
            this.groupBox_order.SuspendLayout();
            this.groupBox_user.SuspendLayout();
            this.groupBox_service.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Location = new System.Drawing.Point(12, 12);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(193, 20);
            this.textBox_firstName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(12, 98);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 2;
            this.button_apply.Text = "Применить";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фамилия";
            // 
            // textBox_secondName
            // 
            this.textBox_secondName.Location = new System.Drawing.Point(12, 38);
            this.textBox_secondName.Name = "textBox_secondName";
            this.textBox_secondName.Size = new System.Drawing.Size(193, 20);
            this.textBox_secondName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Номер телефона";
            // 
            // textBox_phoneNumber
            // 
            this.textBox_phoneNumber.Location = new System.Drawing.Point(12, 64);
            this.textBox_phoneNumber.Name = "textBox_phoneNumber";
            this.textBox_phoneNumber.Size = new System.Drawing.Size(193, 20);
            this.textBox_phoneNumber.TabIndex = 6;
            // 
            // groupBox_client
            // 
            this.groupBox_client.Controls.Add(this.label1);
            this.groupBox_client.Controls.Add(this.textBox_firstName);
            this.groupBox_client.Controls.Add(this.textBox_secondName);
            this.groupBox_client.Controls.Add(this.label2);
            this.groupBox_client.Controls.Add(this.label3);
            this.groupBox_client.Controls.Add(this.textBox_phoneNumber);
            this.groupBox_client.Location = new System.Drawing.Point(0, 0);
            this.groupBox_client.Name = "groupBox_client";
            this.groupBox_client.Size = new System.Drawing.Size(316, 92);
            this.groupBox_client.TabIndex = 8;
            this.groupBox_client.TabStop = false;
            this.groupBox_client.Text = "groupBox1";
            // 
            // groupBox_order
            // 
            this.groupBox_order.Controls.Add(this.label4);
            this.groupBox_order.Controls.Add(this.textBox_dateTime);
            this.groupBox_order.Controls.Add(this.textBox_client_id);
            this.groupBox_order.Controls.Add(this.label_client_id);
            this.groupBox_order.Controls.Add(this.label6);
            this.groupBox_order.Controls.Add(this.textBox3);
            this.groupBox_order.Location = new System.Drawing.Point(0, 0);
            this.groupBox_order.Name = "groupBox_order";
            this.groupBox_order.Size = new System.Drawing.Size(316, 92);
            this.groupBox_order.TabIndex = 9;
            this.groupBox_order.TabStop = false;
            this.groupBox_order.Text = "groupBox1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Время";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_dateTime
            // 
            this.textBox_dateTime.Location = new System.Drawing.Point(12, 12);
            this.textBox_dateTime.Name = "textBox_dateTime";
            this.textBox_dateTime.Size = new System.Drawing.Size(193, 20);
            this.textBox_dateTime.TabIndex = 0;
            // 
            // textBox_client_id
            // 
            this.textBox_client_id.Location = new System.Drawing.Point(12, 38);
            this.textBox_client_id.Name = "textBox_client_id";
            this.textBox_client_id.Size = new System.Drawing.Size(193, 20);
            this.textBox_client_id.TabIndex = 4;
            // 
            // label_client_id
            // 
            this.label_client_id.AutoSize = true;
            this.label_client_id.Location = new System.Drawing.Point(211, 41);
            this.label_client_id.Name = "label_client_id";
            this.label_client_id.Size = new System.Drawing.Size(47, 13);
            this.label_client_id.TabIndex = 5;
            this.label_client_id.Text = "Client ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Услуги\r\n";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(193, 20);
            this.textBox3.TabIndex = 6;
            // 
            // groupBox_user
            // 
            this.groupBox_user.Controls.Add(this.label7);
            this.groupBox_user.Controls.Add(this.textBox_username);
            this.groupBox_user.Controls.Add(this.textBox_password);
            this.groupBox_user.Controls.Add(this.label_password);
            this.groupBox_user.Controls.Add(this.label9);
            this.groupBox_user.Controls.Add(this.textBox_type);
            this.groupBox_user.Location = new System.Drawing.Point(0, 0);
            this.groupBox_user.Name = "groupBox_user";
            this.groupBox_user.Size = new System.Drawing.Size(316, 92);
            this.groupBox_user.TabIndex = 10;
            this.groupBox_user.TabStop = false;
            this.groupBox_user.Text = "groupBox1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "username";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(12, 12);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(193, 20);
            this.textBox_username.TabIndex = 0;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(12, 38);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(193, 20);
            this.textBox_password.TabIndex = 4;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(211, 41);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(52, 13);
            this.label_password.TabIndex = 5;
            this.label_password.Text = "password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(213, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "type";
            // 
            // textBox_type
            // 
            this.textBox_type.Location = new System.Drawing.Point(12, 64);
            this.textBox_type.Name = "textBox_type";
            this.textBox_type.Size = new System.Drawing.Size(193, 20);
            this.textBox_type.TabIndex = 6;
            // 
            // groupBox_service
            // 
            this.groupBox_service.Controls.Add(this.label8);
            this.groupBox_service.Controls.Add(this.textBox_title);
            this.groupBox_service.Controls.Add(this.textBox_price);
            this.groupBox_service.Controls.Add(this.label10);
            this.groupBox_service.Location = new System.Drawing.Point(0, 0);
            this.groupBox_service.Name = "groupBox_service";
            this.groupBox_service.Size = new System.Drawing.Size(316, 92);
            this.groupBox_service.TabIndex = 10;
            this.groupBox_service.TabStop = false;
            this.groupBox_service.Text = "groupBox1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Услуга";
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(12, 12);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(193, 20);
            this.textBox_title.TabIndex = 0;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(12, 38);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(193, 20);
            this.textBox_price.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Цена";
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 133);
            this.Controls.Add(this.groupBox_service);
            this.Controls.Add(this.groupBox_client);
            this.Controls.Add(this.groupBox_order);
            this.Controls.Add(this.groupBox_user);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_apply);
            this.Name = "ManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage";
            this.groupBox_client.ResumeLayout(false);
            this.groupBox_client.PerformLayout();
            this.groupBox_order.ResumeLayout(false);
            this.groupBox_order.PerformLayout();
            this.groupBox_user.ResumeLayout(false);
            this.groupBox_user.PerformLayout();
            this.groupBox_service.ResumeLayout(false);
            this.groupBox_service.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_secondName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_phoneNumber;
        private System.Windows.Forms.GroupBox groupBox_client;
        private System.Windows.Forms.GroupBox groupBox_order;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_dateTime;
        private System.Windows.Forms.TextBox textBox_client_id;
        private System.Windows.Forms.Label label_client_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox_user;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_type;
        private System.Windows.Forms.GroupBox groupBox_service;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label10;
    }
}