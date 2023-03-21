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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Curs_BD
{
    public partial class Income : Form
    {
        public Income()
        {
            InitializeComponent();
            GetToInc();
            UpdateCurrentUserLabel();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Доход_и_Расход;Integrated Security=True");
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



        private void GetToInc()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select_СуммаДохода'" + Login.User + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //Incom = Convert.ToDouble(dt.Rows[0][0].ToString());
                Inc.Text = dt.Rows[0][0].ToString() + " BYN";
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
            }
        }
        private void Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dash=new Dashboard();
            dash.Show();
            this.Hide();
        }

        private void Expense_Click(object sender, EventArgs e)
        {
            Expence exp = new Expence();
            exp.Show();
            this.Hide();
        }

        private void PanelInc_Click(object sender, EventArgs e)
        {
            ViewIncomes vInc = new ViewIncomes();
            vInc.Show();
            this.Hide();
        }

        private void PanelExp_Click(object sender, EventArgs e)
        {
            ViewExpense vExp = new ViewExpense();
            vExp.Show();
            this.Hide();
        }

        private void Category_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat.Show();
            this.Hide();
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Red;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            // вернуть цвет фона к исходному при выходе курсора мыши
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
        private void ClearText() {
            NameInc.Text=string.Empty;
            Quantity.Text=string.Empty;
            Description.Text=string.Empty;
            categ.SelectedIndex = 0;
            DateAdd.Text=string.Empty;
            //DateAdd.Tex
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if ( NameInc.Text == "" || Quantity.Text == "" || Description.Text == ""|| categ.SelectedIndex==-1)
            {
                MessageBox.Show("Вы ввели не все данные об доходе");
            }
            else
            {
                try
                {
                    con.Open();
                    string IncName = NameInc.Text;
                    double Amount=double.Parse(Quantity.Text);
                    Quantity.Text = Amount.ToString("F2");
                    string IncCategory = categ.SelectedItem.ToString();
                    DateTime dateTime = DateTime.ParseExact(DateAdd.Value.Date.ToString("dd.MM.yyyy"), "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    string IncDescription = Description.Text;
                    string UserProf = Login.User;
                    SqlCommand cmd = new SqlCommand("Доход_Insert'" + IncName + "'," + Amount + ",'" + IncCategory + "','" + dateTime + "','" + IncDescription + "','" + UserProf + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Добавлен новый доход");
                    con.Close();
                    GetToInc();
                    ClearText();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void categ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void categ_DropDown(object sender, EventArgs e)
        {
            string sql = "SELECT CatIncome FROM CategoryINC";
            SqlCommand command = new SqlCommand(sql, con);
            DataTable table = new DataTable();
            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                categ.Items.Clear();
                while (reader.Read())
                {
                    categ.Items.Add(reader["CatIncome"].ToString());
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

        private void Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void guna2Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void guna2Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
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
    }
}
