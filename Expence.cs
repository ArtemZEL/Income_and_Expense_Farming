using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Curs_BD
{
    public partial class Expence : Form
    {
        public Expence()
        {
            InitializeComponent();
            GetToExp();
            UpdateCurrentUserLabel();
        }
        private void UpdateCurrentUserLabel()
        {
            if (Login.User != null)
            {
                USers.Text = $"Пользователь: {Login.User}";
            }
            else
            {
                USers.Text = "Ни один пользователь не вошел в систему";
            }
        }
        private void GetToExp()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select_СуммаРасхода'" + Login.User + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Exp.Text = dt.Rows[0][0].ToString() + " BYN";
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
            }

        }
        private void ClearText()
        {
            NameExp.Text = string.Empty;
            QuantityExp.Text = string.Empty;
            DescriptExp.Text = string.Empty;
            CategCom.SelectedIndex = 0;
            DateExp.Text = string.Empty;
            //DateAdd.Tex
        }
        private void Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

        private void Income_Click(object sender, EventArgs e)
        {
            Income inc=new Income();
            inc.Show();
            this.Hide();
        }

        private void PanelIncome_Click(object sender, EventArgs e)
        {
            ViewIncomes vinc= new ViewIncomes();
            vinc.Show();
            this.Hide();
        }

        private void PanelExp_Click(object sender, EventArgs e)
        {
            ViewExpense vexp=new ViewExpense();
            vexp.Show();
            this.Hide();
        }

        private void Category_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat.Show();
            this.Hide();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Доход_и_Расход;Integrated Security=True");

        private void AddExpense_Click(object sender, EventArgs e)
        {
            
            if (NameExp.Text == "" || QuantityExp.Text == "" || DescriptExp.Text == "" || CategCom.SelectedIndex == -1)
            {
                MessageBox.Show("Вы ввели не все данные об расходе");
            }
            else
            {
                try
                {
                    con.Open();
                    string ExpName = NameExp.Text;
                    double Amount = double.Parse(QuantityExp.Text);
                    QuantityExp.Text = Amount.ToString("F2");
                    string ExpCategory = CategCom.SelectedItem.ToString();
                    DateTime dateTime = DateTime.ParseExact(DateExp.Value.Date.ToString("dd.MM.yyyy"), "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    string ExpDescription = DescriptExp.Text;
                    string UserProf = Login.User;
                    SqlCommand cmd = new SqlCommand("Расход_Insert'" + ExpName + "'," + Amount + ",'" + ExpCategory + "','" + dateTime + "','" + ExpDescription + "','" + UserProf + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Добавлен новый расход");
                    con.Close();
                    GetToExp();
                    ClearText();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void Clears_Click(object sender, EventArgs e)
        {
            ClearText();
        }
        private void CategCom_DropDown(object sender, EventArgs e)
        {
            string sql = "SELECT CatExp FROM CategoryExp";
            SqlCommand command = new SqlCommand(sql, con);
            DataTable table = new DataTable();
            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                CategCom.Items.Clear();
                while (reader.Read())
                {
                    CategCom.Items.Add(reader["CatExp"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Уверены что хотите выйти?", "БелФерм",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login exp = new Login();
                exp.Show();
                this.Hide();
                //Application.Exit();
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Уверены что хотите выйти?", "БелФерм",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login exp = new Login();
                exp.Show();
                this.Hide();
                //Application.Exit();
            }
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

        private void Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private void guna2Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void guna2Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void bunifuPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void bunifuPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void bunifuPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
