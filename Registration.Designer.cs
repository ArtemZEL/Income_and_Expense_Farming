namespace Curs_BD
{
    partial class Registration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.UserPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Hide = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.Login = new Guna.UI2.WinForms.Guna2Button();
            this.RegistrationBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UserPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserText = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.UserDate);
            this.panel1.Controls.Add(this.UserPass);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Hide);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.Login);
            this.panel1.Controls.Add(this.RegistrationBtn);
            this.panel1.Controls.Add(this.UserPhone);
            this.panel1.Controls.Add(this.UserText);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 736);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // UserDate
            // 
            this.UserDate.Animated = true;
            this.UserDate.BorderColor = System.Drawing.Color.Silver;
            this.UserDate.BorderRadius = 15;
            this.UserDate.Checked = true;
            this.UserDate.FillColor = System.Drawing.Color.FloralWhite;
            this.UserDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UserDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.UserDate.Location = new System.Drawing.Point(228, 218);
            this.UserDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.UserDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.UserDate.Name = "UserDate";
            this.UserDate.Size = new System.Drawing.Size(259, 48);
            this.UserDate.TabIndex = 15;
            this.UserDate.Value = new System.DateTime(2023, 2, 16, 20, 44, 49, 329);
            // 
            // UserPass
            // 
            this.UserPass.AutoRoundedCorners = true;
            this.UserPass.BorderColor = System.Drawing.Color.Black;
            this.UserPass.BorderRadius = 17;
            this.UserPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserPass.DefaultText = "";
            this.UserPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserPass.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.UserPass.ForeColor = System.Drawing.Color.Black;
            this.UserPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserPass.Location = new System.Drawing.Point(227, 437);
            this.UserPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserPass.Name = "UserPass";
            this.UserPass.PasswordChar = '\0';
            this.UserPass.PlaceholderForeColor = System.Drawing.Color.Black;
            this.UserPass.PlaceholderText = "";
            this.UserPass.SelectedText = "";
            this.UserPass.Size = new System.Drawing.Size(259, 36);
            this.UserPass.TabIndex = 13;
            this.UserPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(233, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 36);
            this.label8.TabIndex = 12;
            this.label8.Text = "Пароль";
            // 
            // Hide
            // 
            this.Hide.AutoSize = true;
            this.Hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hide.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Hide.Location = new System.Drawing.Point(626, -7);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(34, 46);
            this.Hide.TabIndex = 10;
            this.Hide.Text = "-";
            this.Hide.Click += new System.EventHandler(this.Hide_Click);
            this.Hide.MouseEnter += new System.EventHandler(this.Hide_MouseEnter);
            this.Hide.MouseLeave += new System.EventHandler(this.Hide_MouseLeave);
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Close.Location = new System.Drawing.Point(688, 5);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(31, 29);
            this.Close.TabIndex = 11;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.label6_Click);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // Login
            // 
            this.Login.Animated = true;
            this.Login.BorderRadius = 17;
            this.Login.BorderThickness = 1;
            this.Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(226, 621);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(253, 37);
            this.Login.TabIndex = 9;
            this.Login.Text = "Назад";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // RegistrationBtn
            // 
            this.RegistrationBtn.Animated = true;
            this.RegistrationBtn.BorderRadius = 17;
            this.RegistrationBtn.BorderThickness = 1;
            this.RegistrationBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RegistrationBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RegistrationBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RegistrationBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RegistrationBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.RegistrationBtn.ForeColor = System.Drawing.Color.White;
            this.RegistrationBtn.Location = new System.Drawing.Point(227, 540);
            this.RegistrationBtn.Name = "RegistrationBtn";
            this.RegistrationBtn.Size = new System.Drawing.Size(252, 37);
            this.RegistrationBtn.TabIndex = 9;
            this.RegistrationBtn.Text = "Зарегистрироваться";
            this.RegistrationBtn.Click += new System.EventHandler(this.RegistrationBtn_Click);
            // 
            // UserPhone
            // 
            this.UserPhone.AutoRoundedCorners = true;
            this.UserPhone.BorderColor = System.Drawing.Color.Black;
            this.UserPhone.BorderRadius = 17;
            this.UserPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserPhone.DefaultText = "";
            this.UserPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserPhone.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.UserPhone.ForeColor = System.Drawing.Color.Black;
            this.UserPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserPhone.Location = new System.Drawing.Point(227, 339);
            this.UserPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserPhone.Name = "UserPhone";
            this.UserPhone.PasswordChar = '\0';
            this.UserPhone.PlaceholderForeColor = System.Drawing.Color.Black;
            this.UserPhone.PlaceholderText = "";
            this.UserPhone.SelectedText = "";
            this.UserPhone.Size = new System.Drawing.Size(259, 36);
            this.UserPhone.TabIndex = 8;
            this.UserPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserText
            // 
            this.UserText.BorderColor = System.Drawing.Color.Black;
            this.UserText.BorderRadius = 15;
            this.UserText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserText.DefaultText = "";
            this.UserText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserText.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.UserText.ForeColor = System.Drawing.Color.Black;
            this.UserText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserText.Location = new System.Drawing.Point(227, 123);
            this.UserText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserText.Name = "UserText";
            this.UserText.PasswordChar = '\0';
            this.UserText.PlaceholderForeColor = System.Drawing.Color.Black;
            this.UserText.PlaceholderText = "";
            this.UserText.SelectedText = "";
            this.UserText.Size = new System.Drawing.Size(259, 36);
            this.UserText.TabIndex = 8;
            this.UserText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(233, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 36);
            this.label7.TabIndex = 6;
            this.label7.Text = "Номер телефона";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(233, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(233, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Регистрация";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 736);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Hide;
        private System.Windows.Forms.Label Close;
        private Guna.UI2.WinForms.Guna2Button Login;
        private Guna.UI2.WinForms.Guna2Button RegistrationBtn;
        private Guna.UI2.WinForms.Guna2TextBox UserText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox UserPass;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox UserPhone;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker UserDate;
    }
}