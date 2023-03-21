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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
            DisplayIncomes();
            DisplayExpense();
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
        private void DisplayIncomes()
        {
            try
            {
                cons.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SelectCatInc", cons);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var DS = new DataSet();
                sda.Fill(DS);
                dgvIncome.DataSource = DS.Tables[0];
                cons.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        private void DisplayExpense()
        {
            cons.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SelectCatExp", cons);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var DS = new DataSet();
            sda.Fill(DS);
            dgvExpense.DataSource = DS.Tables[0];
            cons.Close();
        }
        SqlConnection cons = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Доход_и_Расход;Integrated Security=True");
        private void ClearText()
        {
            txtExpenseCat.Text = string.Empty;
            txtIncomeCat.Text = string.Empty;
        }
        private void AddCatIncome_Click(object sender, EventArgs e)
        {
            if (txtIncomeCat.Text == "")
            {
                MessageBox.Show("Пожалуйста введите название категории");
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Доход_и_Расход;Integrated Security=True"))
                    {
                        con.Open();
                        string categoryName = txtIncomeCat.Text;
                        SqlCommand cmd = new SqlCommand("ДоходКатегории_Insert'" + categoryName + "'", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Добавлена новая категория дохода");
                        ClearText();
                    }
                }
                
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // ошибка уникальности
                    {
                        MessageBox.Show("Эта категория уже существует!");
                    }
                    else
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                }
            }
            DisplayIncomes();
        }

        private void AddCatExpense_Click(object sender, EventArgs e)
        {


            if (txtExpenseCat.Text == "")
            {
                MessageBox.Show("Вы не заполнили строку");
            }
            else
            {
                try
                {
                    cons.Open();
                    string ExpNameCat = txtExpenseCat.Text;
                    SqlCommand cmd = new SqlCommand("РасходКатегории_Insert'" + ExpNameCat + "'", cons);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Добавлена новая категория расхода");
                    cons.Close();
                    ClearText();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            DisplayExpense();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

        private void Income_Click(object sender, EventArgs e)
        {

            Income exp = new Income();
            exp.Show();
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

        private void dgvIncome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvIncome.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту категорию?", "БелФерм", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int selectId = (int)dgvIncome.Rows[e.RowIndex].Cells["CatIncId"].Value;
                    SqlCommand com = new SqlCommand("Delete_КатегорииДоход", cons);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@id", selectId);
                    cons.Open();
                    com.ExecuteNonQuery();
                    MessageBox.Show($"Вы удалили под номером {selectId} категорию") ;
                    cons.Close();
                    dgvIncome.Rows.RemoveAt(e.RowIndex);
                    DisplayIncomes();

                }
            }
        }

        private void dgvExpense_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvExpense.Columns["DeleteExp"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту категорию?", "БелФерм", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int selectId = (int)dgvExpense.Rows[e.RowIndex].Cells["CatExpId"].Value;
                    SqlCommand com = new SqlCommand("Delete_КатегорииРасход", cons);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@id", selectId);
                    cons.Open();
                    com.ExecuteNonQuery();
                    MessageBox.Show($"Вы удалили под номером{selectId} категорию");
                    cons.Close();
                    dgvExpense.Rows.RemoveAt(e.RowIndex);
                    DisplayIncomes();

                }
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

        private void Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

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
