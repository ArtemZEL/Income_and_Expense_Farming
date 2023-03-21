namespace Curs_BD
{
    partial class Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Hide = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.USers = new Bunifu.UI.WinForms.BunifuLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.PanelExp = new Guna.UI2.WinForms.Guna2Button();
            this.PanelInc = new Guna.UI2.WinForms.Guna2Button();
            this.Expense = new Guna.UI2.WinForms.Guna2Button();
            this.Income = new Guna.UI2.WinForms.Guna2Button();
            this.Dashboard = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtIncomeCat = new Guna.UI2.WinForms.Guna2TextBox();
            this.Close = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvExpense = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.DeleteExp = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvIncome = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.AddCatExpense = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExpenseCat = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddCatIncome = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // Hide
            // 
            this.Hide.AutoSize = true;
            this.Hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hide.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Hide.Location = new System.Drawing.Point(1461, -7);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(34, 46);
            this.Hide.TabIndex = 6;
            this.Hide.Text = "-";
            this.Hide.Click += new System.EventHandler(this.Hide_Click);
            this.Hide.MouseEnter += new System.EventHandler(this.Hide_MouseEnter);
            this.Hide.MouseLeave += new System.EventHandler(this.Hide_MouseLeave);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Navy;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.DarkGreen;
            this.bunifuPanel1.BorderRadius = 0;
            this.bunifuPanel1.BorderThickness = 0;
            this.bunifuPanel1.Controls.Add(this.USers);
            this.bunifuPanel1.Controls.Add(this.guna2Button1);
            this.bunifuPanel1.Controls.Add(this.label2);
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Controls.Add(this.guna2Button6);
            this.bunifuPanel1.Controls.Add(this.PanelExp);
            this.bunifuPanel1.Controls.Add(this.PanelInc);
            this.bunifuPanel1.Controls.Add(this.Expense);
            this.bunifuPanel1.Controls.Add(this.Income);
            this.bunifuPanel1.Controls.Add(this.Dashboard);
            this.bunifuPanel1.Controls.Add(this.guna2PictureBox1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(296, 821);
            this.bunifuPanel1.TabIndex = 10;
            this.bunifuPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuPanel1_MouseDown);
            this.bunifuPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bunifuPanel1_MouseMove);
            this.bunifuPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bunifuPanel1_MouseUp);
            // 
            // USers
            // 
            this.USers.AllowParentOverrides = false;
            this.USers.AutoEllipsis = false;
            this.USers.Cursor = System.Windows.Forms.Cursors.Default;
            this.USers.CursorType = System.Windows.Forms.Cursors.Default;
            this.USers.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.USers.ForeColor = System.Drawing.Color.Cyan;
            this.USers.Location = new System.Drawing.Point(9, 111);
            this.USers.Name = "USers";
            this.USers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.USers.Size = new System.Drawing.Size(38, 25);
            this.USers.TabIndex = 10;
            this.USers.Text = "User";
            this.USers.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.USers.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(3, 579);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(304, 56);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Категория";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.UseTransparentBackground = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(107, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Хозяйство";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(107, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фермерское";
            // 
            // guna2Button6
            // 
            this.guna2Button6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2Button6.Animated = true;
            this.guna2Button6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button6.BorderColor = System.Drawing.Color.White;
            this.guna2Button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button6.Image")));
            this.guna2Button6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button6.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button6.Location = new System.Drawing.Point(0, 769);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(293, 48);
            this.guna2Button6.TabIndex = 2;
            this.guna2Button6.Text = "Выйти";
            this.guna2Button6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button6.UseTransparentBackground = true;
            // 
            // PanelExp
            // 
            this.PanelExp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PanelExp.Animated = true;
            this.PanelExp.BackColor = System.Drawing.Color.Transparent;
            this.PanelExp.BorderColor = System.Drawing.Color.White;
            this.PanelExp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelExp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PanelExp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PanelExp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PanelExp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PanelExp.FillColor = System.Drawing.Color.Transparent;
            this.PanelExp.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.PanelExp.ForeColor = System.Drawing.Color.White;
            this.PanelExp.Image = ((System.Drawing.Image)(resources.GetObject("PanelExp.Image")));
            this.PanelExp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PanelExp.ImageSize = new System.Drawing.Size(40, 40);
            this.PanelExp.Location = new System.Drawing.Point(0, 505);
            this.PanelExp.Name = "PanelExp";
            this.PanelExp.Size = new System.Drawing.Size(307, 57);
            this.PanelExp.TabIndex = 2;
            this.PanelExp.Text = "Панель расхода";
            this.PanelExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PanelExp.UseTransparentBackground = true;
            this.PanelExp.Click += new System.EventHandler(this.PanelExp_Click);
            // 
            // PanelInc
            // 
            this.PanelInc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PanelInc.Animated = true;
            this.PanelInc.BackColor = System.Drawing.Color.Transparent;
            this.PanelInc.BorderColor = System.Drawing.Color.White;
            this.PanelInc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelInc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PanelInc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PanelInc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PanelInc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PanelInc.FillColor = System.Drawing.Color.Transparent;
            this.PanelInc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.PanelInc.ForeColor = System.Drawing.Color.White;
            this.PanelInc.Image = ((System.Drawing.Image)(resources.GetObject("PanelInc.Image")));
            this.PanelInc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PanelInc.ImageSize = new System.Drawing.Size(40, 40);
            this.PanelInc.Location = new System.Drawing.Point(0, 418);
            this.PanelInc.Name = "PanelInc";
            this.PanelInc.Size = new System.Drawing.Size(304, 66);
            this.PanelInc.TabIndex = 2;
            this.PanelInc.Text = "Панель дохода";
            this.PanelInc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PanelInc.UseTransparentBackground = true;
            this.PanelInc.Click += new System.EventHandler(this.PanelInc_Click);
            // 
            // Expense
            // 
            this.Expense.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Expense.Animated = true;
            this.Expense.BackColor = System.Drawing.Color.Transparent;
            this.Expense.BorderColor = System.Drawing.Color.White;
            this.Expense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Expense.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Expense.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Expense.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Expense.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Expense.FillColor = System.Drawing.Color.Transparent;
            this.Expense.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.Expense.ForeColor = System.Drawing.Color.White;
            this.Expense.Image = ((System.Drawing.Image)(resources.GetObject("Expense.Image")));
            this.Expense.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Expense.ImageSize = new System.Drawing.Size(40, 40);
            this.Expense.Location = new System.Drawing.Point(-2, 332);
            this.Expense.Name = "Expense";
            this.Expense.Size = new System.Drawing.Size(304, 60);
            this.Expense.TabIndex = 2;
            this.Expense.Text = "Расход";
            this.Expense.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Expense.UseTransparentBackground = true;
            this.Expense.Click += new System.EventHandler(this.Expense_Click);
            // 
            // Income
            // 
            this.Income.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Income.Animated = true;
            this.Income.BackColor = System.Drawing.Color.Transparent;
            this.Income.BorderColor = System.Drawing.Color.White;
            this.Income.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Income.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Income.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Income.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Income.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Income.FillColor = System.Drawing.Color.Transparent;
            this.Income.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.Income.ForeColor = System.Drawing.Color.White;
            this.Income.Image = ((System.Drawing.Image)(resources.GetObject("Income.Image")));
            this.Income.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Income.ImageSize = new System.Drawing.Size(40, 40);
            this.Income.Location = new System.Drawing.Point(0, 240);
            this.Income.Name = "Income";
            this.Income.Size = new System.Drawing.Size(307, 69);
            this.Income.TabIndex = 2;
            this.Income.Text = "Доход";
            this.Income.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Income.UseTransparentBackground = true;
            this.Income.Click += new System.EventHandler(this.Income_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Dashboard.Animated = true;
            this.Dashboard.BackColor = System.Drawing.Color.Transparent;
            this.Dashboard.BorderColor = System.Drawing.Color.White;
            this.Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Dashboard.FillColor = System.Drawing.Color.Transparent;
            this.Dashboard.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.Dashboard.ForeColor = System.Drawing.Color.White;
            this.Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("Dashboard.Image")));
            this.Dashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Dashboard.ImageSize = new System.Drawing.Size(40, 40);
            this.Dashboard.Location = new System.Drawing.Point(0, 158);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(307, 67);
            this.Dashboard.TabIndex = 2;
            this.Dashboard.Text = "Приборная панель";
            this.Dashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Dashboard.UseTransparentBackground = true;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(98, 87);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // txtIncomeCat
            // 
            this.txtIncomeCat.BorderRadius = 15;
            this.txtIncomeCat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIncomeCat.DefaultText = "";
            this.txtIncomeCat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIncomeCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIncomeCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIncomeCat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIncomeCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIncomeCat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtIncomeCat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIncomeCat.Location = new System.Drawing.Point(366, 170);
            this.txtIncomeCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIncomeCat.Name = "txtIncomeCat";
            this.txtIncomeCat.PasswordChar = '\0';
            this.txtIncomeCat.PlaceholderText = "";
            this.txtIncomeCat.SelectedText = "";
            this.txtIncomeCat.Size = new System.Drawing.Size(342, 41);
            this.txtIncomeCat.TabIndex = 7;
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Close.Location = new System.Drawing.Point(1514, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(31, 29);
            this.Close.TabIndex = 6;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(360, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 36);
            this.label6.TabIndex = 13;
            this.label6.Text = "Название дохода";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.guna2Panel1.Controls.Add(this.dgvExpense);
            this.guna2Panel1.Controls.Add(this.dgvIncome);
            this.guna2Panel1.Controls.Add(this.AddCatExpense);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.txtExpenseCat);
            this.guna2Panel1.Controls.Add(this.AddCatIncome);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.txtIncomeCat);
            this.guna2Panel1.Controls.Add(this.Hide);
            this.guna2Panel1.Controls.Add(this.Close);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1541, 821);
            this.guna2Panel1.TabIndex = 11;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseDown);
            this.guna2Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseMove);
            this.guna2Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseUp);
            // 
            // dgvExpense
            // 
            this.dgvExpense.AllowCustomTheming = false;
            this.dgvExpense.AllowUserToAddRows = false;
            this.dgvExpense.AllowUserToDeleteRows = false;
            this.dgvExpense.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvExpense.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExpense.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvExpense.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExpense.ColumnHeadersHeight = 40;
            this.dgvExpense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeleteExp});
            this.dgvExpense.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvExpense.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvExpense.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvExpense.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvExpense.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvExpense.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvExpense.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvExpense.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvExpense.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvExpense.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvExpense.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvExpense.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvExpense.CurrentTheme.Name = null;
            this.dgvExpense.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvExpense.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvExpense.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvExpense.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvExpense.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpense.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExpense.EnableHeadersVisualStyles = false;
            this.dgvExpense.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvExpense.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvExpense.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvExpense.HeaderForeColor = System.Drawing.Color.White;
            this.dgvExpense.Location = new System.Drawing.Point(939, 294);
            this.dgvExpense.Name = "dgvExpense";
            this.dgvExpense.RowHeadersVisible = false;
            this.dgvExpense.RowHeadersWidth = 51;
            this.dgvExpense.RowTemplate.Height = 40;
            this.dgvExpense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpense.Size = new System.Drawing.Size(360, 450);
            this.dgvExpense.TabIndex = 20;
            this.dgvExpense.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvExpense.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpense_CellContentClick);
            // 
            // DeleteExp
            // 
            this.DeleteExp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeleteExp.HeaderText = "";
            this.DeleteExp.Image = ((System.Drawing.Image)(resources.GetObject("DeleteExp.Image")));
            this.DeleteExp.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.DeleteExp.MinimumWidth = 3;
            this.DeleteExp.Name = "DeleteExp";
            this.DeleteExp.Width = 3;
            // 
            // dgvIncome
            // 
            this.dgvIncome.AllowCustomTheming = false;
            this.dgvIncome.AllowUserToAddRows = false;
            this.dgvIncome.AllowUserToDeleteRows = false;
            this.dgvIncome.AllowUserToOrderColumns = true;
            this.dgvIncome.AllowUserToResizeColumns = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvIncome.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIncome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIncome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIncome.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvIncome.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIncome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvIncome.ColumnHeadersHeight = 40;
            this.dgvIncome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.dgvIncome.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvIncome.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvIncome.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvIncome.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvIncome.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvIncome.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvIncome.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvIncome.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvIncome.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvIncome.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvIncome.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvIncome.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvIncome.CurrentTheme.Name = null;
            this.dgvIncome.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvIncome.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvIncome.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvIncome.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvIncome.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIncome.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvIncome.EnableHeadersVisualStyles = false;
            this.dgvIncome.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvIncome.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvIncome.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvIncome.HeaderForeColor = System.Drawing.Color.White;
            this.dgvIncome.Location = new System.Drawing.Point(366, 294);
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.RowHeadersVisible = false;
            this.dgvIncome.RowHeadersWidth = 51;
            this.dgvIncome.RowTemplate.Height = 40;
            this.dgvIncome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncome.Size = new System.Drawing.Size(342, 450);
            this.dgvIncome.TabIndex = 20;
            this.dgvIncome.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvIncome.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIncome_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.MinimumWidth = 3;
            this.Delete.Name = "Delete";
            this.Delete.Width = 3;
            // 
            // AddCatExpense
            // 
            this.AddCatExpense.Animated = true;
            this.AddCatExpense.BackColor = System.Drawing.Color.Transparent;
            this.AddCatExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCatExpense.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddCatExpense.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddCatExpense.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddCatExpense.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddCatExpense.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.AddCatExpense.ForeColor = System.Drawing.Color.White;
            this.AddCatExpense.Image = ((System.Drawing.Image)(resources.GetObject("AddCatExpense.Image")));
            this.AddCatExpense.Location = new System.Drawing.Point(939, 225);
            this.AddCatExpense.Name = "AddCatExpense";
            this.AddCatExpense.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.AddCatExpense.Size = new System.Drawing.Size(60, 54);
            this.AddCatExpense.TabIndex = 19;
            this.AddCatExpense.Click += new System.EventHandler(this.AddCatExpense_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(933, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 36);
            this.label7.TabIndex = 17;
            this.label7.Text = "Название расхода";
            // 
            // txtExpenseCat
            // 
            this.txtExpenseCat.BorderRadius = 15;
            this.txtExpenseCat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExpenseCat.DefaultText = "";
            this.txtExpenseCat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtExpenseCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtExpenseCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtExpenseCat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtExpenseCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtExpenseCat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtExpenseCat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtExpenseCat.Location = new System.Drawing.Point(939, 170);
            this.txtExpenseCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExpenseCat.Name = "txtExpenseCat";
            this.txtExpenseCat.PasswordChar = '\0';
            this.txtExpenseCat.PlaceholderText = "";
            this.txtExpenseCat.SelectedText = "";
            this.txtExpenseCat.Size = new System.Drawing.Size(360, 41);
            this.txtExpenseCat.TabIndex = 16;
            // 
            // AddCatIncome
            // 
            this.AddCatIncome.Animated = true;
            this.AddCatIncome.BackColor = System.Drawing.Color.Transparent;
            this.AddCatIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCatIncome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddCatIncome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddCatIncome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddCatIncome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddCatIncome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.AddCatIncome.ForeColor = System.Drawing.Color.White;
            this.AddCatIncome.Image = ((System.Drawing.Image)(resources.GetObject("AddCatIncome.Image")));
            this.AddCatIncome.Location = new System.Drawing.Point(366, 225);
            this.AddCatIncome.Name = "AddCatIncome";
            this.AddCatIncome.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.AddCatIncome.Size = new System.Drawing.Size(60, 54);
            this.AddCatIncome.TabIndex = 15;
            this.AddCatIncome.Click += new System.EventHandler(this.AddCatIncome_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Heavy", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(302, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(456, 43);
            this.label3.TabIndex = 5;
            this.label3.Text = "Добавь свою категорию";
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 821);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Hide;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button PanelExp;
        private Guna.UI2.WinForms.Guna2Button PanelInc;
        private Guna.UI2.WinForms.Guna2Button Expense;
        private Guna.UI2.WinForms.Guna2Button Income;
        private Guna.UI2.WinForms.Guna2Button Dashboard;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtIncomeCat;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CircleButton AddCatExpense;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtExpenseCat;
        private Guna.UI2.WinForms.Guna2CircleButton AddCatIncome;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvIncome;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvExpense;
        private System.Windows.Forms.DataGridViewImageColumn DeleteExp;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private Bunifu.UI.WinForms.BunifuLabel USers;
    }
}