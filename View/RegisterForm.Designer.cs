namespace View
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_surname2 = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.button_registration = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.sirname = new System.Windows.Forms.Label();
            this.surname2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(312, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заполните поля";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(317, 85);
            this.textBox_name.Multiline = true;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(173, 31);
            this.textBox_name.TabIndex = 1;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(317, 141);
            this.textBox_surname.Multiline = true;
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(173, 28);
            this.textBox_surname.TabIndex = 2;
            // 
            // textBox_surname2
            // 
            this.textBox_surname2.Location = new System.Drawing.Point(317, 198);
            this.textBox_surname2.Multiline = true;
            this.textBox_surname2.Name = "textBox_surname2";
            this.textBox_surname2.Size = new System.Drawing.Size(173, 30);
            this.textBox_surname2.TabIndex = 3;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(317, 258);
            this.textBox_email.Multiline = true;
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(173, 32);
            this.textBox_email.TabIndex = 4;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(317, 322);
            this.textBox_phone.Multiline = true;
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(173, 32);
            this.textBox_phone.TabIndex = 5;
            // 
            // button_registration
            // 
            this.button_registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_registration.Location = new System.Drawing.Point(281, 451);
            this.button_registration.Name = "button_registration";
            this.button_registration.Size = new System.Drawing.Size(243, 32);
            this.button_registration.TabIndex = 6;
            this.button_registration.Text = "Зарегистрироваться";
            this.button_registration.UseVisualStyleBackColor = true;
            this.button_registration.Click += new System.EventHandler(this.button_registration_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(213, 85);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(57, 25);
            this.name.TabIndex = 7;
            this.name.Text = "Имя";
            // 
            // sirname
            // 
            this.sirname.AutoSize = true;
            this.sirname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sirname.Location = new System.Drawing.Point(191, 141);
            this.sirname.Name = "sirname";
            this.sirname.Size = new System.Drawing.Size(110, 25);
            this.sirname.TabIndex = 8;
            this.sirname.Text = "Фамилия";
            // 
            // surname2
            // 
            this.surname2.AutoSize = true;
            this.surname2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname2.Location = new System.Drawing.Point(189, 198);
            this.surname2.Name = "surname2";
            this.surname2.Size = new System.Drawing.Size(112, 25);
            this.surname2.TabIndex = 9;
            this.surname2.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(213, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "e-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(195, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Телефон";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(317, 387);
            this.textBox_password.Multiline = true;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(173, 33);
            this.textBox_password.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(198, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Пароль";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 585);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.surname2);
            this.Controls.Add(this.sirname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button_registration);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_surname2);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "Регистраия";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_surname2;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Button button_registration;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label sirname;
        private System.Windows.Forms.Label surname2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label4;
    }
}