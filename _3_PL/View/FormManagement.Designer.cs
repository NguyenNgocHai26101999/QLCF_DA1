namespace _3_PL.View
{
    partial class FormManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManagement));
            DataGridViewCellStyle dataGridViewCellStyle46 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle47 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle48 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle49 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle50 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle51 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle52 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle53 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle54 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnClose = new Button();
            btnMinimize = new Button();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            nmPriceFood = new NumericUpDown();
            dgvFood = new DataGridView();
            btnHinh = new CustomButton.VBButton();
            label7 = new Label();
            btnEditFood = new CustomButton.VBButton();
            btnAddFood = new CustomButton.VBButton();
            btnOpenFile = new CustomButton.VBButton();
            cbStatusFood = new ComboBox();
            cbCategoryFood = new ComboBox();
            txbFoodName = new TextBox();
            txbIDFood = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            picFood = new PictureBox();
            tabPage2 = new TabPage();
            btnEditCa = new CustomButton.VBButton();
            btnAddCa = new CustomButton.VBButton();
            txbNameCategory = new TextBox();
            txbIDFCategory = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label8 = new Label();
            dgvCategoryFood = new DataGridView();
            tabPage3 = new TabPage();
            tbxtype = new TextBox();
            btnXoaAccount = new CustomButton.VBButton();
            label15 = new Label();
            label14 = new Label();
            tbxpass = new TextBox();
            btnUpdateAccount = new CustomButton.VBButton();
            btnAddAccount = new CustomButton.VBButton();
            tbxDisplay = new TextBox();
            tbxUser = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            dgvAccount = new DataGridView();
            tabPage4 = new TabPage();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmPriceFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFood).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoryFood).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnMinimize);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1058, 41);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ErrorImage = null;
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 10);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 3;
            label1.Text = "Coffee";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(1026, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(20, 20);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.BackgroundImage = (Image)resources.GetObject("btnMinimize.BackgroundImage");
            btnMinimize.BackgroundImageLayout = ImageLayout.Stretch;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Location = new Point(1000, 10);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(20, 20);
            btnMinimize.TabIndex = 1;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(tabControl1);
            panel2.Location = new Point(3, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(1055, 645);
            panel2.TabIndex = 3;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(9, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1034, 642);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.Controls.Add(nmPriceFood);
            tabPage1.Controls.Add(dgvFood);
            tabPage1.Controls.Add(btnHinh);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(btnEditFood);
            tabPage1.Controls.Add(btnAddFood);
            tabPage1.Controls.Add(btnOpenFile);
            tabPage1.Controls.Add(cbStatusFood);
            tabPage1.Controls.Add(cbCategoryFood);
            tabPage1.Controls.Add(txbFoodName);
            tabPage1.Controls.Add(txbIDFood);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(picFood);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1026, 609);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Món";
            // 
            // nmPriceFood
            // 
            nmPriceFood.BackColor = Color.Tan;
            nmPriceFood.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nmPriceFood.Location = new Point(516, 27);
            nmPriceFood.Maximum = new decimal(new int[] { -402653185, -1613725636, 54210108, 0 });
            nmPriceFood.Name = "nmPriceFood";
            nmPriceFood.Size = new Size(246, 27);
            nmPriceFood.TabIndex = 43;
            // 
            // dgvFood
            // 
            dgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFood.BackgroundColor = Color.Tan;
            dataGridViewCellStyle46.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = Color.Peru;
            dataGridViewCellStyle46.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle46.ForeColor = Color.Black;
            dataGridViewCellStyle46.SelectionBackColor = Color.Peru;
            dataGridViewCellStyle46.SelectionForeColor = Color.Black;
            dataGridViewCellStyle46.WrapMode = DataGridViewTriState.True;
            dgvFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle46;
            dgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle47.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = Color.Tan;
            dataGridViewCellStyle47.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle47.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle47.SelectionBackColor = Color.Peru;
            dataGridViewCellStyle47.SelectionForeColor = Color.Black;
            dataGridViewCellStyle47.WrapMode = DataGridViewTriState.False;
            dgvFood.DefaultCellStyle = dataGridViewCellStyle47;
            dgvFood.EnableHeadersVisualStyles = false;
            dgvFood.Location = new Point(3, 327);
            dgvFood.Name = "dgvFood";
            dgvFood.ReadOnly = true;
            dataGridViewCellStyle48.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = Color.Tan;
            dataGridViewCellStyle48.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle48.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle48.SelectionBackColor = Color.Peru;
            dataGridViewCellStyle48.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle48.WrapMode = DataGridViewTriState.True;
            dgvFood.RowHeadersDefaultCellStyle = dataGridViewCellStyle48;
            dgvFood.RowHeadersWidth = 51;
            dgvFood.RowTemplate.Height = 29;
            dgvFood.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFood.Size = new Size(1017, 276);
            dgvFood.TabIndex = 42;
            dgvFood.CellClick += dgvFood_CellClick;
            // 
            // btnHinh
            // 
            btnHinh.BackColor = Color.DarkSalmon;
            btnHinh.BackgroundColor = Color.DarkSalmon;
            btnHinh.BorderColor = Color.Red;
            btnHinh.BorderRadius = 15;
            btnHinh.BorderSize = 0;
            btnHinh.FlatAppearance.BorderSize = 0;
            btnHinh.FlatStyle = FlatStyle.Flat;
            btnHinh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHinh.ForeColor = Color.White;
            btnHinh.Location = new Point(793, 198);
            btnHinh.Name = "btnHinh";
            btnHinh.Size = new Size(227, 28);
            btnHinh.TabIndex = 41;
            btnHinh.TextColor = Color.White;
            btnHinh.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(6, 296);
            label7.Name = "label7";
            label7.Size = new Size(146, 28);
            label7.TabIndex = 39;
            label7.Text = "Danh sách món";
            // 
            // btnEditFood
            // 
            btnEditFood.BackColor = Color.FromArgb(128, 64, 0);
            btnEditFood.BackgroundColor = Color.FromArgb(128, 64, 0);
            btnEditFood.BorderColor = Color.Red;
            btnEditFood.BorderRadius = 15;
            btnEditFood.BorderSize = 0;
            btnEditFood.FlatAppearance.BorderSize = 0;
            btnEditFood.FlatStyle = FlatStyle.Flat;
            btnEditFood.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditFood.ForeColor = Color.White;
            btnEditFood.Location = new Point(481, 233);
            btnEditFood.Name = "btnEditFood";
            btnEditFood.Size = new Size(88, 40);
            btnEditFood.TabIndex = 36;
            btnEditFood.Text = "Sửa";
            btnEditFood.TextColor = Color.White;
            btnEditFood.UseVisualStyleBackColor = false;
            btnEditFood.Click += btnEditFood_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = Color.FromArgb(128, 64, 0);
            btnAddFood.BackgroundColor = Color.FromArgb(128, 64, 0);
            btnAddFood.BorderColor = Color.Red;
            btnAddFood.BorderRadius = 15;
            btnAddFood.BorderSize = 0;
            btnAddFood.FlatAppearance.BorderSize = 0;
            btnAddFood.FlatStyle = FlatStyle.Flat;
            btnAddFood.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddFood.ForeColor = Color.White;
            btnAddFood.Location = new Point(387, 232);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(88, 40);
            btnAddFood.TabIndex = 35;
            btnAddFood.Text = "Thêm";
            btnAddFood.TextColor = Color.White;
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // btnOpenFile
            // 
            btnOpenFile.BackColor = Color.FromArgb(128, 64, 0);
            btnOpenFile.BackgroundColor = Color.FromArgb(128, 64, 0);
            btnOpenFile.BorderColor = Color.Red;
            btnOpenFile.BorderRadius = 15;
            btnOpenFile.BorderSize = 0;
            btnOpenFile.FlatAppearance.BorderSize = 0;
            btnOpenFile.FlatStyle = FlatStyle.Flat;
            btnOpenFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOpenFile.ForeColor = Color.White;
            btnOpenFile.Location = new Point(793, 232);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(227, 28);
            btnOpenFile.TabIndex = 34;
            btnOpenFile.Text = "Chọn ảnh";
            btnOpenFile.TextColor = Color.White;
            btnOpenFile.UseVisualStyleBackColor = false;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // cbStatusFood
            // 
            cbStatusFood.BackColor = Color.Tan;
            cbStatusFood.FormattingEnabled = true;
            cbStatusFood.Items.AddRange(new object[] { "Bán", "Dừng bán" });
            cbStatusFood.Location = new Point(516, 88);
            cbStatusFood.Name = "cbStatusFood";
            cbStatusFood.Size = new Size(246, 28);
            cbStatusFood.TabIndex = 23;
            cbStatusFood.Text = "Bán";
            // 
            // cbCategoryFood
            // 
            cbCategoryFood.BackColor = Color.Tan;
            cbCategoryFood.FormattingEnabled = true;
            cbCategoryFood.Location = new Point(114, 159);
            cbCategoryFood.Name = "cbCategoryFood";
            cbCategoryFood.Size = new Size(280, 28);
            cbCategoryFood.TabIndex = 21;
            cbCategoryFood.Text = "Danh mục";
            // 
            // txbFoodName
            // 
            txbFoodName.BackColor = Color.Tan;
            txbFoodName.Location = new Point(114, 88);
            txbFoodName.Name = "txbFoodName";
            txbFoodName.Size = new Size(280, 27);
            txbFoodName.TabIndex = 20;
            // 
            // txbIDFood
            // 
            txbIDFood.BackColor = Color.Tan;
            txbIDFood.Location = new Point(114, 27);
            txbIDFood.Name = "txbIDFood";
            txbIDFood.ReadOnly = true;
            txbIDFood.Size = new Size(280, 27);
            txbIDFood.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(412, 88);
            label6.Name = "label6";
            label6.Size = new Size(98, 28);
            label6.TabIndex = 6;
            label6.Text = "Trạng thái";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(469, 27);
            label5.Name = "label5";
            label5.Size = new Size(41, 28);
            label5.TabIndex = 5;
            label5.Text = "Giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(8, 159);
            label4.Name = "label4";
            label4.Size = new Size(100, 28);
            label4.TabIndex = 4;
            label4.Text = "Danh mục";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 88);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 3;
            label3.Text = "Tên món";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(77, 28);
            label2.Name = "label2";
            label2.Size = new Size(31, 28);
            label2.TabIndex = 2;
            label2.Text = "ID";
            // 
            // picFood
            // 
            picFood.BackgroundImageLayout = ImageLayout.Stretch;
            picFood.Location = new Point(793, 6);
            picFood.Name = "picFood";
            picFood.Size = new Size(227, 220);
            picFood.TabIndex = 1;
            picFood.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.Controls.Add(btnEditCa);
            tabPage2.Controls.Add(btnAddCa);
            tabPage2.Controls.Add(txbNameCategory);
            tabPage2.Controls.Add(txbIDFCategory);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(dgvCategoryFood);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1026, 609);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Danh mục món";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEditCa
            // 
            btnEditCa.BackColor = Color.FromArgb(128, 64, 0);
            btnEditCa.BackgroundColor = Color.FromArgb(128, 64, 0);
            btnEditCa.BorderColor = Color.Red;
            btnEditCa.BorderRadius = 15;
            btnEditCa.BorderSize = 0;
            btnEditCa.FlatAppearance.BorderSize = 0;
            btnEditCa.FlatStyle = FlatStyle.Flat;
            btnEditCa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditCa.ForeColor = Color.White;
            btnEditCa.Location = new Point(508, 229);
            btnEditCa.Name = "btnEditCa";
            btnEditCa.Size = new Size(88, 40);
            btnEditCa.TabIndex = 50;
            btnEditCa.Text = "Sửa";
            btnEditCa.TextColor = Color.White;
            btnEditCa.UseVisualStyleBackColor = false;
            btnEditCa.Click += btnEditCa_Click;
            // 
            // btnAddCa
            // 
            btnAddCa.BackColor = Color.FromArgb(128, 64, 0);
            btnAddCa.BackgroundColor = Color.FromArgb(128, 64, 0);
            btnAddCa.BorderColor = Color.Red;
            btnAddCa.BorderRadius = 15;
            btnAddCa.BorderSize = 0;
            btnAddCa.FlatAppearance.BorderSize = 0;
            btnAddCa.FlatStyle = FlatStyle.Flat;
            btnAddCa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddCa.ForeColor = Color.White;
            btnAddCa.Location = new Point(414, 228);
            btnAddCa.Name = "btnAddCa";
            btnAddCa.Size = new Size(88, 40);
            btnAddCa.TabIndex = 49;
            btnAddCa.Text = "Thêm";
            btnAddCa.TextColor = Color.White;
            btnAddCa.UseVisualStyleBackColor = false;
            btnAddCa.Click += btnAddCa_Click;
            // 
            // txbNameCategory
            // 
            txbNameCategory.BackColor = Color.Tan;
            txbNameCategory.Location = new Point(118, 99);
            txbNameCategory.Name = "txbNameCategory";
            txbNameCategory.Size = new Size(280, 27);
            txbNameCategory.TabIndex = 48;
            // 
            // txbIDFCategory
            // 
            txbIDFCategory.BackColor = Color.Tan;
            txbIDFCategory.Location = new Point(118, 38);
            txbIDFCategory.Name = "txbIDFCategory";
            txbIDFCategory.ReadOnly = true;
            txbIDFCategory.Size = new Size(280, 27);
            txbIDFCategory.TabIndex = 47;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(33, 99);
            label9.Name = "label9";
            label9.Size = new Size(78, 28);
            label9.TabIndex = 46;
            label9.Text = "Tên DM";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(81, 39);
            label10.Name = "label10";
            label10.Size = new Size(31, 28);
            label10.TabIndex = 45;
            label10.Text = "ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(3, 296);
            label8.Name = "label8";
            label8.Size = new Size(192, 28);
            label8.TabIndex = 44;
            label8.Text = "Danh sách danh mục";
            // 
            // dgvCategoryFood
            // 
            dgvCategoryFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategoryFood.BackgroundColor = Color.Tan;
            dataGridViewCellStyle49.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle49.BackColor = Color.Peru;
            dataGridViewCellStyle49.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle49.ForeColor = Color.Black;
            dataGridViewCellStyle49.SelectionBackColor = Color.Peru;
            dataGridViewCellStyle49.SelectionForeColor = Color.Black;
            dataGridViewCellStyle49.WrapMode = DataGridViewTriState.True;
            dgvCategoryFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle49;
            dgvCategoryFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle50.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle50.BackColor = Color.Tan;
            dataGridViewCellStyle50.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle50.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle50.SelectionBackColor = Color.Peru;
            dataGridViewCellStyle50.SelectionForeColor = Color.Black;
            dataGridViewCellStyle50.WrapMode = DataGridViewTriState.False;
            dgvCategoryFood.DefaultCellStyle = dataGridViewCellStyle50;
            dgvCategoryFood.EnableHeadersVisualStyles = false;
            dgvCategoryFood.Location = new Point(6, 327);
            dgvCategoryFood.Name = "dgvCategoryFood";
            dgvCategoryFood.ReadOnly = true;
            dataGridViewCellStyle51.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle51.BackColor = Color.Tan;
            dataGridViewCellStyle51.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle51.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle51.SelectionBackColor = Color.Peru;
            dataGridViewCellStyle51.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle51.WrapMode = DataGridViewTriState.True;
            dgvCategoryFood.RowHeadersDefaultCellStyle = dataGridViewCellStyle51;
            dgvCategoryFood.RowHeadersWidth = 51;
            dgvCategoryFood.RowTemplate.Height = 29;
            dgvCategoryFood.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoryFood.Size = new Size(1014, 276);
            dgvCategoryFood.TabIndex = 43;
            dgvCategoryFood.CellClick += dgvCategoryFood_CellClick;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = (Image)resources.GetObject("tabPage3.BackgroundImage");
            tabPage3.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage3.Controls.Add(tbxtype);
            tabPage3.Controls.Add(btnXoaAccount);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(tbxpass);
            tabPage3.Controls.Add(btnUpdateAccount);
            tabPage3.Controls.Add(btnAddAccount);
            tabPage3.Controls.Add(tbxDisplay);
            tabPage3.Controls.Add(tbxUser);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(dgvAccount);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1026, 609);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Tài khoản";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbxtype
            // 
            tbxtype.BackColor = Color.Tan;
            tbxtype.Location = new Point(724, 83);
            tbxtype.Name = "tbxtype";
            tbxtype.ReadOnly = true;
            tbxtype.Size = new Size(280, 27);
            tbxtype.TabIndex = 65;
            // 
            // btnXoaAccount
            // 
            btnXoaAccount.BackColor = Color.FromArgb(128, 64, 0);
            btnXoaAccount.BackgroundColor = Color.FromArgb(128, 64, 0);
            btnXoaAccount.BorderColor = Color.Red;
            btnXoaAccount.BorderRadius = 15;
            btnXoaAccount.BorderSize = 0;
            btnXoaAccount.FlatAppearance.BorderSize = 0;
            btnXoaAccount.FlatStyle = FlatStyle.Flat;
            btnXoaAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoaAccount.ForeColor = Color.White;
            btnXoaAccount.Location = new Point(647, 250);
            btnXoaAccount.Name = "btnXoaAccount";
            btnXoaAccount.Size = new Size(88, 40);
            btnXoaAccount.TabIndex = 64;
            btnXoaAccount.Text = "Xóa";
            btnXoaAccount.TextColor = Color.White;
            btnXoaAccount.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(572, 79);
            label15.Name = "label15";
            label15.Size = new Size(130, 28);
            label15.TabIndex = 62;
            label15.Text = "Type Account";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(572, 21);
            label14.Name = "label14";
            label14.Size = new Size(97, 28);
            label14.TabIndex = 61;
            label14.Text = "PassWord";
            // 
            // tbxpass
            // 
            tbxpass.BackColor = Color.Tan;
            tbxpass.Location = new Point(724, 22);
            tbxpass.Name = "tbxpass";
            tbxpass.Size = new Size(280, 27);
            tbxpass.TabIndex = 59;
            // 
            // btnUpdateAccount
            // 
            btnUpdateAccount.BackColor = Color.FromArgb(128, 64, 0);
            btnUpdateAccount.BackgroundColor = Color.FromArgb(128, 64, 0);
            btnUpdateAccount.BorderColor = Color.Red;
            btnUpdateAccount.BorderRadius = 15;
            btnUpdateAccount.BorderSize = 0;
            btnUpdateAccount.FlatAppearance.BorderSize = 0;
            btnUpdateAccount.FlatStyle = FlatStyle.Flat;
            btnUpdateAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateAccount.ForeColor = Color.White;
            btnUpdateAccount.Location = new Point(494, 250);
            btnUpdateAccount.Name = "btnUpdateAccount";
            btnUpdateAccount.Size = new Size(88, 40);
            btnUpdateAccount.TabIndex = 58;
            btnUpdateAccount.Text = "Sửa";
            btnUpdateAccount.TextColor = Color.White;
            btnUpdateAccount.UseVisualStyleBackColor = false;
            // 
            // btnAddAccount
            // 
            btnAddAccount.BackColor = Color.FromArgb(128, 64, 0);
            btnAddAccount.BackgroundColor = Color.FromArgb(128, 64, 0);
            btnAddAccount.BorderColor = Color.Red;
            btnAddAccount.BorderRadius = 15;
            btnAddAccount.BorderSize = 0;
            btnAddAccount.FlatAppearance.BorderSize = 0;
            btnAddAccount.FlatStyle = FlatStyle.Flat;
            btnAddAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddAccount.ForeColor = Color.White;
            btnAddAccount.Location = new Point(341, 250);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(88, 40);
            btnAddAccount.TabIndex = 57;
            btnAddAccount.Text = "Thêm";
            btnAddAccount.TextColor = Color.White;
            btnAddAccount.UseVisualStyleBackColor = false;
            // 
            // tbxDisplay
            // 
            tbxDisplay.BackColor = Color.Tan;
            tbxDisplay.Location = new Point(174, 83);
            tbxDisplay.Name = "tbxDisplay";
            tbxDisplay.Size = new Size(280, 27);
            tbxDisplay.TabIndex = 56;
            // 
            // tbxUser
            // 
            tbxUser.BackColor = Color.Tan;
            tbxUser.Location = new Point(174, 22);
            tbxUser.Name = "tbxUser";
            tbxUser.Size = new Size(280, 27);
            tbxUser.TabIndex = 55;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(22, 83);
            label11.Name = "label11";
            label11.Size = new Size(133, 28);
            label11.TabIndex = 54;
            label11.Text = "Display Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(33, 18);
            label12.Name = "label12";
            label12.Size = new Size(108, 28);
            label12.TabIndex = 53;
            label12.Text = "User Name";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(5, 280);
            label13.Name = "label13";
            label13.Size = new Size(192, 28);
            label13.TabIndex = 52;
            label13.Text = "Danh sách danh mục";
            // 
            // dgvAccount
            // 
            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccount.BackgroundColor = Color.Tan;
            dataGridViewCellStyle52.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle52.BackColor = Color.Peru;
            dataGridViewCellStyle52.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle52.ForeColor = Color.Black;
            dataGridViewCellStyle52.SelectionBackColor = Color.Peru;
            dataGridViewCellStyle52.SelectionForeColor = Color.Black;
            dataGridViewCellStyle52.WrapMode = DataGridViewTriState.True;
            dgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle52;
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle53.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle53.BackColor = Color.Tan;
            dataGridViewCellStyle53.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle53.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle53.SelectionBackColor = Color.Peru;
            dataGridViewCellStyle53.SelectionForeColor = Color.Black;
            dataGridViewCellStyle53.WrapMode = DataGridViewTriState.False;
            dgvAccount.DefaultCellStyle = dataGridViewCellStyle53;
            dgvAccount.EnableHeadersVisualStyles = false;
            dgvAccount.Location = new Point(8, 311);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.ReadOnly = true;
            dataGridViewCellStyle54.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle54.BackColor = Color.Tan;
            dataGridViewCellStyle54.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle54.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle54.SelectionBackColor = Color.Peru;
            dataGridViewCellStyle54.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle54.WrapMode = DataGridViewTriState.True;
            dgvAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle54;
            dgvAccount.RowHeadersWidth = 51;
            dgvAccount.RowTemplate.Height = 29;
            dgvAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAccount.Size = new Size(1014, 276);
            dgvAccount.TabIndex = 51;
            dgvAccount.CellClick += dgvAccount_CellClick;
            // 
            // tabPage4
            // 
            tabPage4.BackgroundImage = (Image)resources.GetObject("tabPage4.BackgroundImage");
            tabPage4.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1026, 609);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Doanh thu";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1058, 695);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormManagement";
            Load += FormManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmPriceFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFood).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoryFood).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnClose;
        private Button btnMinimize;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox picFood;
        private Label label6;
        private TextBox txbFoodName;
        private TextBox txbIDFood;
        private ComboBox cbStatusFood;
        private ComboBox cbCategoryFood;
        private CustomButton.VBButton btnOpenFile;
        private CustomButton.VBButton btnAddFood;
        private Label label7;
        private CustomButton.VBButton btnEditFood;
        private OpenFileDialog openFileDialog1;
        private DataGridView dgvFood;
        private CustomButton.VBButton btnHinh;
        private NumericUpDown nmPriceFood;
        private CustomButton.VBButton btnEditCa;
        private CustomButton.VBButton btnAddCa;
        private TextBox txbNameCategory;
        private TextBox txbIDFCategory;
        private Label label9;
        private Label label10;
        private Label label8;
        private DataGridView dgvCategoryFood;
        private CustomButton.VBButton btnUpdateAccount;
        private CustomButton.VBButton btnAddAccount;
        private TextBox tbxDisplay;
        private TextBox tbxUser;
        private Label label11;
        private Label label12;
        private Label label13;
        private DataGridView dgvAccount;
        private Label label15;
        private Label label14;
        private TextBox tbxpass;
        private TextBox tbxtype;
        private CustomButton.VBButton btnXoaAccount;
    }
}