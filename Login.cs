using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs_BD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Доход_и_Расход;Integrated Security=True");
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public static string User;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (UsName.Text == "" || UsPass.Text == "")
            {
                MessageBox.Show("Введите ваш логин и пароль");
            }
            else 
            {
                con.Open();
                string usname = UsName.Text;
                string password = UsPass.Text;
                SqlDataAdapter sda = new SqlDataAdapter("SELECT_Users'" + usname + "','" + password + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    User=UsName.Text;
                    Dashboard obj = new Dashboard();
                    obj.Show();
                    this.Hide();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Не правильный ввод пароля или Имя логина");
                    UsName.Text = "";
                    UsPass.Text = "";

                }
                con.Close();
            }
        
        
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private void LoginPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void LoginPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void LoginPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Red;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.ForeColor = SystemColors.Control;
        }

        private void Hide_MouseEnter(object sender, EventArgs e)
        {
            Hide.ForeColor = Color.Yellow;
        }

        private void Hide_MouseLeave(object sender, EventArgs e)
        {
            Hide.ForeColor = SystemColors.Control;
        }
    }
}
