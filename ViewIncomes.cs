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
    public partial class ViewIncomes : Form
    {
        public ViewIncomes()
        {
            InitializeComponent();
            DisplayIncomes();
            UpdateCurrentUserLabel();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Доход_и_Расход;Integrated Security=True");

        private void Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
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
        private void Income_Click(object sender, EventArgs e)
        {
            Income income = new Income();
            income.Show();
            this.Hide();
        }

        private void Incense_Click(object sender, EventArgs e)
        {
            Expence Inc = new Expence();
            Inc.Show();
            this.Hide();
        }

        private void PanelIncense_Click(object sender, EventArgs e)
        {
            ViewExpense VeXP = new ViewExpense();
            VeXP.Show();
            this.Hide();
        }
        private void DisplayIncomes()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select_Доход", con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var DS = new DataSet();
            sda.Fill(DS);
            IncDGV.DataSource = DS.Tables[0];
            con.Close();
        }
        private void Category_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat.Show();
            this.Hide();
        }
        private void PanelExpense_Click(object sender, EventArgs e)
        {
            ViewExpense ve = new ViewExpense();
            ve.Show();
            this.Hide();
        }
        private void IncDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == IncDGV.Columns["Update"].Index && e.RowIndex >= 0)
            {
                int selectId = (int)IncDGV.Rows[e.RowIndex].Cells["InId"].Value;

                // Проверка, что ячейки не пустые
                if (string.IsNullOrEmpty(IncDGV.Rows[e.RowIndex].Cells["InName"].Value.ToString()) || string.IsNullOrEmpty(IncDGV.Rows[e.RowIndex].Cells["IncAmount"].Value.ToString()) ||
                    string.IsNullOrEmpty(IncDGV.Rows[e.RowIndex].Cells["IncCategory"].Value.ToString()) || string.IsNullOrEmpty(IncDGV.Rows[e.RowIndex].Cells["IncDate"].Value.ToString()) ||
                    string.IsNullOrEmpty(IncDGV.Rows[e.RowIndex].Cells["IncDesciption"].Value.ToString()) || string.IsNullOrEmpty(IncDGV.Rows[e.RowIndex].Cells["IncUser"].Value.ToString()))
                {
                    MessageBox.Show("Заполните все ячейки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Получаем значения из ячеек
                string name = IncDGV.Rows[e.RowIndex].Cells["InName"].Value.ToString();
                int amount = Convert.ToInt32(IncDGV.Rows[e.RowIndex].Cells["IncAmount"].Value);
                string category = IncDGV.Rows[e.RowIndex].Cells["IncCategory"].Value.ToString();
                string date = IncDGV.Rows[e.RowIndex].Cells["IncDate"].Value.ToString();
                string description = IncDGV.Rows[e.RowIndex].Cells["IncDesciption"].Value.ToString();
                string user = IncDGV.Rows[e.RowIndex].Cells["IncUser"].Value.ToString();

                SqlCommand com = new SqlCommand("Доход_Update", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@IncId", selectId);
                com.Parameters.AddWithValue("@IncName", name);
                com.Parameters.AddWithValue("@IncAmount", amount);
                com.Parameters.AddWithValue("@IncCategory", category);
                com.Parameters.AddWithValue("@IncDate", date);
                com.Parameters.AddWithValue("@IncDescription", description);
                com.Parameters.AddWithValue("@IncUser", user);

                con.Open();
                com.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Запись успешно обновлена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Обновляем данные в DataGridView
                DisplayIncomes();
            }
            if (e.ColumnIndex == IncDGV.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту запись?", "БелФерм", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int selectId = (int)IncDGV.Rows[e.RowIndex].Cells["InId"].Value;
                    SqlCommand com = new SqlCommand("Delete_Доход", con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@id", selectId);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show($"Вы удалили запись под номером {selectId}");
                    IncDGV.Rows.RemoveAt(e.RowIndex);
                    // Удаляем данные в DataGridView
                    DisplayIncomes();

                }
            }
        }
        private void Print_Click(object sender, EventArgs e)
        {
            IncDGV.SelectAll();//вывод всех данных в Таблице
            DataObject copyDate = IncDGV.GetClipboardContent();
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

        private void SearchIncome_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT InName, IncAmount, IncCategory, IncDate, IncDesciption, IncUser FROM Income WHERE InName LIKE @keyword + '%'";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@keyword", SearchIncome.Text);
            DataTable table = new DataTable();

            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                IncDGV.DataSource = table;
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

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.ForeColor = SystemColors.Control;
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Red;
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
