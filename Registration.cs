using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs_BD
{
    public partial class Registration : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Доход_и_Расход;Integrated Security=True");
        private void Clear() 
        {
            UserText.Text = "";
            UserPass.Text = "";
            UserPhone.Text = "";
        }
        public Registration()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            if (UserText.Text == "" || UserPhone.Text == "" || UserPass.Text == "")
            {
                MessageBox.Show("Введите пожалуйста верно все данные чтобы зарегистрироваться");
            }
            else
            {
                try
                {
                    con.Open();
                    string UsName = UserText.Text, UsPhone = UserPhone.Text, UsPass= UserPass.Text;
                    DateTime dateTime = UserDate.Value.Date;
                    SqlCommand cmd = new SqlCommand("Пользователь_Insert'" + UsName + "','" + dateTime + "','" + UsPhone + "','" +UsPass + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Добавлен");
                    con.Close();
                    Clear();

                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login exp = new Login();
            exp.Show();
            this.Hide();
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Red;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.ForeColor = SystemColors.Control;
        }

        private void Hide_MouseLeave(object sender, EventArgs e)
        {
            Hide.ForeColor = SystemColors.Control;

        }

        private void Hide_MouseEnter(object sender, EventArgs e)
        {
            Hide.ForeColor = Color.Yellow;

        }
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
