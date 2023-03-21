using Guna.UI2.WinForms;
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
using Excel = Microsoft.Office.Interop.Excel;

namespace Curs_BD
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            GetToInc();
            GetToExp();
            GetNumExp();
            GetNumInc();
            GetDateInc();
            GetDateExp();
            GetMaxINC();
            GetMaxEXP();            
            GetMinINC();
            GetMinEXP();
            UpdateCurrentUserLabel();
            GetBalance();
            GetMaxEpxCat();
            GetMaxIncCat();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Доход_и_Расход;Integrated Security=True");
        private void IncomeButt_Click(object sender, EventArgs e)
        {
            Income income=new Income();
            income.Show();
            this.Hide();
        }

        private void Expense_Click(object sender, EventArgs e)
        {
            Expence exp= new Expence();
            exp.Show();
            this.Hide();
        }

        private void PanelIncome_Click(object sender, EventArgs e)
        {
            ViewIncomes vInc= new ViewIncomes();
            vInc.Show();
            this.Hide();
        }

        private void PanelExpense_Click(object sender, EventArgs e)
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
        double Incom, Expens;//
        private void GetToInc() 
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select_СуммаДохода'" + Login.User + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Incom = Convert.ToDouble(dt.Rows[0][0].ToString());
                TotalInc.Text = dt.Rows[0][0].ToString() + " BYN";
                con.Close();
            }
            catch (Exception ex) 
            {
                con.Close();
            }
        }
        private void GetToExp() 
        {
            try 
            { 
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select_СуммаРасхода'" + Login.User+ "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Expens = Convert.ToDouble(dt.Rows[0][0].ToString());
                TotalExp.Text =  dt.Rows[0][0].ToString() + " BYN";
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
            }

        }
        private void GetBalance()
        {
            double Balance = Incom-Expens;
            Balances.Text = Balance.ToString("F2") + " BYN";
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

        private void GetNumExp()
        {
            try 
            { 
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select_CountExp'" + Login.User + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                NumbExp.Text = dt.Rows[0][0].ToString();
                con.Close();
   
            }
            catch (Exception ex)
            {
                con.Close();
            }
        }
        private void GetNumInc()
        {
            try 
            { 
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select_CountInc'" + Login.User + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                NumbInc.Text = dt.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
            }
        }
        private void GetDateInc()
        {
            try 
            { 
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select_DateInc'" + Login.User + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DateIncLast.Text = dt.Rows[0][0].ToString();
                DateLastInc.Text = dt.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
            }
        }
        private void GetDateExp()
        {
            try 
            { 
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select_DateExp'" + Login.User + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DateExpLast.Text = dt.Rows[0][0].ToString();
                DateLastExp.Text = dt.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
            }
        }
        private void GetMaxINC()
        {
            try 
            { 
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select_MaxInc'" + Login.User + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MaxInc.Text = dt.Rows[0][0].ToString() + " BYN";
                con.Close(); 
            }
            catch (Exception ex)
            {
                con.Close();
            }
        }
        private void GetMaxEXP()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select_MaxExp'" + Login.User + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MaxExp.Text = dt.Rows[0][0].ToString() + " BYN";
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
            }
        }
        private void GetMinINC()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select_MinInc'" + Login.User + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MinInc.Text = dt.Rows[0][0].ToString() + " BYN";
            con.Close();

        }
        private void GetMinEXP()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select_MinExp'" + Login.User + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MinExp.Text = dt.Rows[0][0].ToString() + " BYN";
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
            }
        }
        private void GetMaxEpxCat()
        {
            try 
            { 
                con.Open();
                string InnerQuery = "SelectMaxCatExp";
                DataTable dt1= new DataTable();
                SqlDataAdapter sda1=new SqlDataAdapter(InnerQuery, con);
                sda1.Fill(dt1);
                //string query= "select ExpCategory from Expense where ExpAmount'" + dt1.Rows[0][0].ToString()+"'" +Login.User+"'";
                string query= "SelectMaxПоРасходу'" + dt1.Rows[0][0].ToString()+"'";
                SqlDataAdapter sda=new SqlDataAdapter(query, con);
                DataTable dt2= new DataTable();
                sda.Fill(dt2);
                BestExpCategory.Text = dt2.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
            }
        }
        private void GetMaxIncCat()
        {
            try 
            {
                con.Open();
                string InnerQuery = "SelectMaxCatInc";
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, con);
                sda1.Fill(dt1);
                //string query= "select ExpCategory from Expense where ExpAmount'" + dt1.Rows[0][0].ToString()+"'" +Login.User+"'";
                string query = "SelectMaxПоДоходу'" + dt1.Rows[0][0].ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt2 = new DataTable();
                sda.Fill(dt2);
                BestIncCategory.Text = dt2.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
         
            Excel.Application excel = new Excel.Application();

          
            // Создание диалога выбора файла
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Save Report File";
            saveFileDialog.ShowDialog();

            // Проверка выбранного пути и названия файла
            if (!string.IsNullOrEmpty(saveFileDialog.FileName))
            {
                // Создание новой рабочей книги
                Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);

                // Создание нового листа
                Excel.Worksheet sheet = (Excel.Worksheet)workbook.ActiveSheet;

                // Задание заголовка доходы
                sheet.Cells[1, 1] = "Общие доходы";
                sheet.Cells[1, 2] = "Транзакций";
                sheet.Cells[1, 3] = "Дата последней транзакции";

                // Заполнение данными
                sheet.Cells[2, 1] = TotalInc.Text;
                sheet.Cells[2, 2] = NumbInc.Text;
                sheet.Cells[2, 3] = DateIncLast.Text;
                // Задание заголовка расходы
                sheet.Cells[3, 1] = "Общие расходы";
                sheet.Cells[3, 2] = "Транзакций";
                sheet.Cells[3, 3] = "Дата последней транзакции";
                // Заполнение данными
                sheet.Cells[4, 1] = TotalExp.Text;
                sheet.Cells[4, 2] = NumbExp.Text;
                sheet.Cells[4, 3] = DateExpLast.Text;               
                //
                sheet.Cells[5, 1] = "Максимальная сумма дохода";
                sheet.Cells[5, 2] = "Максимальная сумма расходов";
                sheet.Cells[5, 3] = "Минимальная сумма доходов";
                sheet.Cells[5, 4] = "Минимальная сумма расходов";
                sheet.Cells[5, 5] = "Последняя сумма доходов";
                sheet.Cells[5, 6] = "Последняя сумма расходов";
                sheet.Cells[5, 7] = "Лучшая категория доходов";
                sheet.Cells[5, 8] = "Лучшая категория расходов";

                // Заполнение данными
                sheet.Cells[6, 1] = MaxInc.Text;
                sheet.Cells[6, 2] = MaxExp.Text;
                sheet.Cells[6, 3] = MinInc.Text;
                sheet.Cells[6, 4] = MinExp.Text;
                sheet.Cells[6, 5] = DateLastInc.Text;
                sheet.Cells[6, 6] = DateLastExp.Text;
                sheet.Cells[6, 7] = BestIncCategory.Text;
                sheet.Cells[6, 8] = BestExpCategory.Text;

                sheet.Cells[7, 1] = "Баланс";

                sheet.Cells[8, 1] = Balances.Text;

                // Стилизация ячеек
                Excel.Range range = sheet.Range[sheet.Cells[1, 1], sheet.Cells[8, 8]];
                range.Font.Bold = true;
                range.Columns.AutoFit();

                // Сохранение отчета
                workbook.SaveAs(saveFileDialog.FileName);

                // Закрытие приложения Excel
                excel.Quit();
            }

        }

        private void Information_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программное средство Доход и Расход Фермерского хозяйства предназначено для учета доходов и расходов, а также контроля финансовой деятельности фермерских хозяйств. " +
                "Оно может использоваться для учета доходов и расходов в различных сферах деятельности, таких как растениеводство, животноводство, птицеводство и т.д. " +
                "В программном средстве можно создавать различные категории доходов и расходов, добавлять новые записи, просматривать статистику и отчеты, " +
                "а также экспортировать данные в различные форматы для дальнейшей обработки." +
                "Вам представленно главное меню где показаны все расчеты доходов и расходов выполняемым определенным пользователем." +
                "\nВ боковой панели указаны:" +
                "\n-Доходы: открывает окно где вы можете добавлять свои доходы" +
                "\n-Расходы: открывает окно где вы можете добавлять свои расходы" +
                "\n-Панель дохода: открывает панель ваших добавленных доходов, а также можете изменить ваш доход и удалить его если нет в его значении" +
                "\n-Панель расхода: открывает панель ваших добавленных расходов, а также можете изменить ваш расход и удалить его если нет в его значении" +
                "\n-Категории: открывает окно где вы можете добавлять свои категории определенных доходов и расходов", "О приложении", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Hide_MouseEnter(object sender, EventArgs e)
        {
            Hide.ForeColor = Color.Yellow;

        }

        private void Hide_MouseLeave(object sender, EventArgs e)
        {
            Hide.ForeColor = SystemColors.Control;

        }

        private void Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Information_MouseLeave(object sender, EventArgs e)
        {
            Information.ForeColor = SystemColors.Control;
        }

        private void Information_MouseEnter(object sender, EventArgs e)
        {
            Hide.ForeColor = Color.Aqua;
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

        private void bunifuPanel1_MouseMove(object sender, MouseEventArgs e)
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

        private void bunifuPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

        }

        private void Exit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Уверены что хотите выйти?", "БелФерм",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login exp = new Login();
                exp.Show();
                this.Hide();
            }
        }
    }
}
