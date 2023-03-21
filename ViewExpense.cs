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
    public partial class ViewExpense : Form
    {
        public ViewExpense()
        {
            InitializeComponent();
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

        private void Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Доход_и_Расход;Integrated Security=True");
        private void DisplayExpense()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select_Расход", con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var DS = new DataSet();
            sda.Fill(DS);
            ExpDGV.DataSource = DS.Tables[0];
            con.Close();
        }
        private void Income_Click(object sender, EventArgs e)
        {
            Income income = new Income();
            income.Show();
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

        private void Category_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat.Show();
            this.Hide();
        }

        private void ExpDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ExpDGV.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту запись?", "БелФерм", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int selectId = (int)ExpDGV.Rows[e.RowIndex].Cells["EId"].Value;
                    SqlCommand com = new SqlCommand("Delete_Расход", con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@id", selectId);

                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();

                    ExpDGV.Rows.RemoveAt(e.RowIndex);
                    DisplayExpense();

                }
            }
            if (e.ColumnIndex == ExpDGV.Columns["Update"].Index && e.RowIndex >= 0)
            {
                int selectId = (int)ExpDGV.Rows[e.RowIndex].Cells["EId"].Value;

                // Проверка, что ячейки не пустые
                if (string.IsNullOrEmpty(ExpDGV.Rows[e.RowIndex].Cells["ExpName"].Value.ToString()) || string.IsNullOrEmpty(ExpDGV.Rows[e.RowIndex].Cells["ExpAmount"].Value.ToString()) ||
                    string.IsNullOrEmpty(ExpDGV.Rows[e.RowIndex].Cells["ExpCategory"].Value.ToString()) || string.IsNullOrEmpty(ExpDGV.Rows[e.RowIndex].Cells["ExpDate"].Value.ToString()) ||
                    string.IsNullOrEmpty(ExpDGV.Rows[e.RowIndex].Cells["ExpDesciption"].Value.ToString()) || string.IsNullOrEmpty(ExpDGV.Rows[e.RowIndex].Cells["ExpUser"].Value.ToString()))
                {
                    MessageBox.Show("Заполните все ячейки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Получаем значения из ячеек
                string name = ExpDGV.Rows[e.RowIndex].Cells["ExpName"].Value.ToString();
                int amount = Convert.ToInt32(ExpDGV.Rows[e.RowIndex].Cells["ExpAmount"].Value);
                string category = ExpDGV.Rows[e.RowIndex].Cells["ExpCategory"].Value.ToString();
                string date = ExpDGV.Rows[e.RowIndex].Cells["ExpDate"].Value.ToString();
                string description = ExpDGV.Rows[e.RowIndex].Cells["ExpDesciption"].Value.ToString();
                string user = ExpDGV.Rows[e.RowIndex].Cells["ExpUser"].Value.ToString();

                SqlCommand com = new SqlCommand("Расход_Update", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ExpId", selectId);
                com.Parameters.AddWithValue("@ExpName", name);
                com.Parameters.AddWithValue("@ExpAmount", amount);
                com.Parameters.AddWithValue("@ExpCategory", category);
                com.Parameters.AddWithValue("@ExpDate", date);
                com.Parameters.AddWithValue("@ExpDescription", description);
                com.Parameters.AddWithValue("@ExpUser", user);

                con.Open();
                com.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Запись успешно обновлена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Обновляем данные в DataGridView
                DisplayExpense();
            }
        }

        private void SearchExp_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT ExpName, ExpAmount, ExpCategory, ExpDate, ExpDesciption, ExpUser FROM Expense WHERE ExpName LIKE @keyword + '%'";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@keyword", SearchExp.Text);
            DataTable table = new DataTable();

            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                ExpDGV.DataSource = table;
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

        private void Print_Click(object sender, EventArgs e)
        {
            ExpDGV.SelectAll();//вывод всех данных в Таблице
            DataObject copyDate = ExpDGV.GetClipboardContent();
            if (copyDate != null) Clipboard.SetDataObject(copyDate);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object miseddate = System.Reflection.Missing.Value;
            xlWbook = xlapp.Workbooks.Add(miseddate);
            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();
            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
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

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Hide.ForeColor = Color.Red;
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
