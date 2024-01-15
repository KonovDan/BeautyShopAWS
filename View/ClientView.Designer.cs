namespace View
{
    partial class ClientView
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
            this.listView_masters = new System.Windows.Forms.ListView();
            this.listView_services = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.listView_time = new System.Windows.Forms.ListView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // listView_masters
            // 
            this.listView_masters.HideSelection = false;
            this.listView_masters.Location = new System.Drawing.Point(119, 12);
            this.listView_masters.MultiSelect = false;
            this.listView_masters.Name = "listView_masters";
            this.listView_masters.Size = new System.Drawing.Size(357, 151);
            this.listView_masters.TabIndex = 0;
            this.listView_masters.UseCompatibleStateImageBehavior = false;
            this.listView_masters.View = System.Windows.Forms.View.Details;
            // 
            // listView_services
            // 
            this.listView_services.HideSelection = false;
            this.listView_services.Location = new System.Drawing.Point(482, 38);
            this.listView_services.MultiSelect = false;
            this.listView_services.Name = "listView_services";
            this.listView_services.Size = new System.Drawing.Size(308, 293);
            this.listView_services.TabIndex = 1;
            this.listView_services.UseCompatibleStateImageBehavior = false;
            this.listView_services.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Записаться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Location = new System.Drawing.Point(12, 12);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(100, 20);
            this.textBox_firstName.TabIndex = 3;
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Location = new System.Drawing.Point(12, 38);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(100, 20);
            this.textBox_lastName.TabIndex = 4;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(12, 64);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(100, 20);
            this.textBox_phone.TabIndex = 5;
            // 
            // listView_time
            // 
            this.listView_time.HideSelection = false;
            this.listView_time.Location = new System.Drawing.Point(358, 169);
            this.listView_time.MultiSelect = false;
            this.listView_time.Name = "listView_time";
            this.listView_time.Size = new System.Drawing.Size(118, 162);
            this.listView_time.TabIndex = 6;
            this.listView_time.UseCompatibleStateImageBehavior = false;
            this.listView_time.View = System.Windows.Forms.View.Details;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(119, 169);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(482, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(563, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(645, 12);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // ClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 335);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.listView_time);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox_lastName);
            this.Controls.Add(this.textBox_firstName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView_services);
            this.Controls.Add(this.listView_masters);
            this.Name = "ClientView";
            this.Text = "ClientView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_masters;
        private System.Windows.Forms.ListView listView_services;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.ListView listView_time;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}