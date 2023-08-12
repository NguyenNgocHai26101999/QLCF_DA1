namespace _3_PL.View
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnClose = new Button();
            btnMinimize = new Button();
            menuStrip1 = new MenuStrip();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            dgvBill = new DataGridView();
            label2 = new Label();
            cbCategory = new ComboBox();
            txbSearchFood = new TextBox();
            btnSearchFood = new CustomButton.VBButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            txbDiscount = new TextBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            txbReceived = new TextBox();
            label7 = new Label();
            pictureBox5 = new PictureBox();
            txbSurplus = new TextBox();
            label8 = new Label();
            pictureBox6 = new PictureBox();
            txbTotal = new TextBox();
            btnPay = new CustomButton.VBButton();
            btnExportBill = new CustomButton.VBButton();
            imageList1 = new ImageList(components);
            cmFood = new ContextMenuStrip(components);
            btnAddFood = new ToolStripMenuItem();
            btnDeleteFood = new ToolStripMenuItem();
            label3 = new Label();
            nmNumFood = new NumericUpDown();
            btnDiscount = new CustomButton.VBButton();
            btnExportSurplus = new CustomButton.VBButton();
            lblDisplayName = new Label();
            lblDisplayRole = new Label();
            pictureBox4 = new PictureBox();
            picClock = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox7 = new PictureBox();
            pictureBox16 = new PictureBox();
            label6 = new Label();
            lblFoodChoice = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            cmFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmNumFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
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
            panel1.Size = new Size(1686, 41);
            panel1.TabIndex = 1;
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
            btnClose.Location = new Point(1654, 12);
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
            btnMinimize.Location = new Point(1628, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(20, 20);
            btnMinimize.TabIndex = 1;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { thôngTinTàiKhoảnToolStripMenuItem, quảnLýToolStripMenuItem, trợGiúpToolStripMenuItem });
            menuStrip1.Location = new Point(12, 269);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(509, 36);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.Image = (Image)resources.GetObject("thôngTinTàiKhoảnToolStripMenuItem.Image");
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(216, 32);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            thôngTinTàiKhoảnToolStripMenuItem.Click += thôngTinTàiKhoảnToolStripMenuItem_Click;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.Image = (Image)resources.GetObject("quảnLýToolStripMenuItem.Image");
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(198, 32);
            quảnLýToolStripMenuItem.Text = "Quản lý cửa hàng";
            quảnLýToolStripMenuItem.Click += quảnLýToolStripMenuItem_Click;
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.Image = (Image)resources.GetObject("trợGiúpToolStripMenuItem.Image");
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(87, 32);
            trợGiúpToolStripMenuItem.Text = "Help";
            // 
            // dgvBill
            // 
            dataGridViewCellStyle11.BackColor = Color.Tan;
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = Color.Tan;
            dataGridViewCellStyle11.SelectionForeColor = Color.Black;
            dgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBill.BackgroundColor = Color.Tan;
            dgvBill.BorderStyle = BorderStyle.None;
            dgvBill.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBill.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.Peru;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.Peru;
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.Tan;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = Color.Tan;
            dataGridViewCellStyle13.SelectionForeColor = Color.Black;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dgvBill.DefaultCellStyle = dataGridViewCellStyle13;
            dgvBill.EnableHeadersVisualStyles = false;
            dgvBill.Location = new Point(12, 390);
            dgvBill.Name = "dgvBill";
            dgvBill.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.Tan;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = Color.Tan;
            dataGridViewCellStyle14.SelectionForeColor = Color.Black;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dgvBill.RowHeadersVisible = false;
            dgvBill.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = Color.Tan;
            dataGridViewCellStyle15.ForeColor = Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = Color.Tan;
            dataGridViewCellStyle15.SelectionForeColor = Color.Black;
            dgvBill.RowsDefaultCellStyle = dataGridViewCellStyle15;
            dgvBill.RowTemplate.Height = 29;
            dgvBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBill.Size = new Size(873, 229);
            dgvBill.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 347);
            label2.Name = "label2";
            label2.Size = new Size(56, 28);
            label2.TabIndex = 5;
            label2.Text = "Oder";
            // 
            // cbCategory
            // 
            cbCategory.BackColor = Color.Tan;
            cbCategory.FlatStyle = FlatStyle.Flat;
            cbCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(1064, 347);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(148, 36);
            cbCategory.TabIndex = 13;
            cbCategory.Text = "--Danh mục--";
            cbCategory.TextChanged += cbCategory_TextChanged;
            // 
            // txbSearchFood
            // 
            txbSearchFood.BackColor = Color.Tan;
            txbSearchFood.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbSearchFood.Location = new Point(1218, 349);
            txbSearchFood.Name = "txbSearchFood";
            txbSearchFood.Size = new Size(357, 34);
            txbSearchFood.TabIndex = 14;
            // 
            // btnSearchFood
            // 
            btnSearchFood.BackColor = Color.FromArgb(128, 64, 0);
            btnSearchFood.BackgroundColor = Color.FromArgb(128, 64, 0);
            btnSearchFood.BorderColor = Color.Red;
            btnSearchFood.BorderRadius = 15;
            btnSearchFood.BorderSize = 0;
            btnSearchFood.FlatAppearance.BorderSize = 0;
            btnSearchFood.FlatStyle = FlatStyle.Flat;
            btnSearchFood.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchFood.ForeColor = Color.White;
            btnSearchFood.Location = new Point(1581, 347);
            btnSearchFood.Name = "btnSearchFood";
            btnSearchFood.Size = new Size(93, 37);
            btnSearchFood.TabIndex = 15;
            btnSearchFood.Text = "Tìm kiếm";
            btnSearchFood.TextColor = Color.White;
            btnSearchFood.UseVisualStyleBackColor = false;
            btnSearchFood.Click += btnSearchFood_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Location = new Point(891, 390);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(783, 534);
            flowLayoutPanel1.TabIndex = 16;
            // 
            // txbDiscount
            // 
            txbDiscount.BackColor = Color.Tan;
            txbDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbDiscount.Location = new Point(114, 707);
            txbDiscount.Name = "txbDiscount";
            txbDiscount.Size = new Size(240, 34);
            txbDiscount.TabIndex = 18;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(33, 679);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 62);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(114, 676);
            label4.Name = "label4";
            label4.Size = new Size(90, 28);
            label4.TabIndex = 20;
            label4.Text = "Giảm giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(469, 676);
            label5.Name = "label5";
            label5.Size = new Size(133, 28);
            label5.TabIndex = 23;
            label5.Text = "Tiền khách trả";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(388, 679);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 62);
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // txbReceived
            // 
            txbReceived.BackColor = Color.Tan;
            txbReceived.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbReceived.Location = new Point(469, 707);
            txbReceived.Name = "txbReceived";
            txbReceived.Size = new Size(240, 34);
            txbReceived.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(469, 817);
            label7.Name = "label7";
            label7.Size = new Size(102, 28);
            label7.TabIndex = 29;
            label7.Text = "Tiền trả lại";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(388, 824);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(64, 62);
            pictureBox5.TabIndex = 28;
            pictureBox5.TabStop = false;
            // 
            // txbSurplus
            // 
            txbSurplus.BackColor = Color.Tan;
            txbSurplus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbSurplus.Location = new Point(469, 852);
            txbSurplus.Name = "txbSurplus";
            txbSurplus.Size = new Size(240, 34);
            txbSurplus.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(114, 817);
            label8.Name = "label8";
            label8.Size = new Size(95, 28);
            label8.TabIndex = 32;
            label8.Text = "Tổng tiền";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(33, 824);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(64, 62);
            pictureBox6.TabIndex = 31;
            pictureBox6.TabStop = false;
            // 
            // txbTotal
            // 
            txbTotal.BackColor = Color.Tan;
            txbTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbTotal.Location = new Point(114, 852);
            txbTotal.Name = "txbTotal";
            txbTotal.ReadOnly = true;
            txbTotal.Size = new Size(240, 34);
            txbTotal.TabIndex = 30;
            txbTotal.TextChanged += txbTotal_TextChanged;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.MidnightBlue;
            btnPay.BackgroundColor = Color.MidnightBlue;
            btnPay.BorderColor = Color.Red;
            btnPay.BorderRadius = 25;
            btnPay.BorderSize = 0;
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(752, 872);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(133, 52);
            btnPay.TabIndex = 35;
            btnPay.Text = "THANH TOÁN";
            btnPay.TextColor = Color.White;
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnExportBill
            // 
            btnExportBill.BackColor = Color.DarkGreen;
            btnExportBill.BackgroundColor = Color.DarkGreen;
            btnExportBill.BorderColor = Color.Red;
            btnExportBill.BorderRadius = 25;
            btnExportBill.BorderSize = 0;
            btnExportBill.FlatAppearance.BorderSize = 0;
            btnExportBill.FlatStyle = FlatStyle.Flat;
            btnExportBill.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportBill.ForeColor = Color.White;
            btnExportBill.Location = new Point(752, 814);
            btnExportBill.Name = "btnExportBill";
            btnExportBill.Size = new Size(133, 52);
            btnExportBill.TabIndex = 36;
            btnExportBill.Text = "IN HÓA ĐƠN";
            btnExportBill.TextColor = Color.White;
            btnExportBill.UseVisualStyleBackColor = false;
            btnExportBill.Click += btnExportBill_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // cmFood
            // 
            cmFood.ImageScalingSize = new Size(20, 20);
            cmFood.Items.AddRange(new ToolStripItem[] { btnAddFood, btnDeleteFood });
            cmFood.Name = "contextMenuStrip1";
            cmFood.Size = new Size(120, 56);
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = Color.Tan;
            btnAddFood.Image = (Image)resources.GetObject("btnAddFood.Image");
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(119, 26);
            btnAddFood.Text = "Thêm";
            btnAddFood.Click += btnAddFood_Click;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.BackColor = Color.Tan;
            btnDeleteFood.Image = (Image)resources.GetObject("btnDeleteFood.Image");
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(119, 26);
            btnDeleteFood.Text = "Xóa";
            btnDeleteFood.Click += btnDeleteFood_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(891, 353);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 38;
            label3.Text = "Số lượng";
            // 
            // nmNumFood
            // 
            nmNumFood.BackColor = Color.Tan;
            nmNumFood.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nmNumFood.Location = new Point(989, 350);
            nmNumFood.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmNumFood.Name = "nmNumFood";
            nmNumFood.Size = new Size(69, 34);
            nmNumFood.TabIndex = 39;
            nmNumFood.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnDiscount
            // 
            btnDiscount.BackColor = Color.FromArgb(128, 64, 0);
            btnDiscount.BackgroundColor = Color.FromArgb(128, 64, 0);
            btnDiscount.BorderColor = Color.Red;
            btnDiscount.BorderRadius = 15;
            btnDiscount.BorderSize = 0;
            btnDiscount.FlatAppearance.BorderSize = 0;
            btnDiscount.FlatStyle = FlatStyle.Flat;
            btnDiscount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiscount.ForeColor = Color.White;
            btnDiscount.Location = new Point(114, 747);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(240, 28);
            btnDiscount.TabIndex = 40;
            btnDiscount.Text = "Giảm giá";
            btnDiscount.TextColor = Color.White;
            btnDiscount.UseVisualStyleBackColor = false;
            btnDiscount.Click += btnDiscount_Click;
            // 
            // btnExportSurplus
            // 
            btnExportSurplus.BackColor = Color.FromArgb(128, 64, 0);
            btnExportSurplus.BackgroundColor = Color.FromArgb(128, 64, 0);
            btnExportSurplus.BorderColor = Color.Red;
            btnExportSurplus.BorderRadius = 15;
            btnExportSurplus.BorderSize = 0;
            btnExportSurplus.FlatAppearance.BorderSize = 0;
            btnExportSurplus.FlatStyle = FlatStyle.Flat;
            btnExportSurplus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportSurplus.ForeColor = Color.White;
            btnExportSurplus.Location = new Point(469, 747);
            btnExportSurplus.Name = "btnExportSurplus";
            btnExportSurplus.Size = new Size(240, 28);
            btnExportSurplus.TabIndex = 41;
            btnExportSurplus.Text = "Xuất tiền thừa";
            btnExportSurplus.TextColor = Color.White;
            btnExportSurplus.UseVisualStyleBackColor = false;
            btnExportSurplus.Click += btnExportSurplus_Click;
            // 
            // lblDisplayName
            // 
            lblDisplayName.AutoSize = true;
            lblDisplayName.BackColor = Color.Transparent;
            lblDisplayName.FlatStyle = FlatStyle.Flat;
            lblDisplayName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisplayName.ForeColor = Color.DarkRed;
            lblDisplayName.Location = new Point(1490, 269);
            lblDisplayName.Name = "lblDisplayName";
            lblDisplayName.Size = new Size(111, 28);
            lblDisplayName.TabIndex = 42;
            lblDisplayName.Text = "Tên hiển thị";
            // 
            // lblDisplayRole
            // 
            lblDisplayRole.AutoSize = true;
            lblDisplayRole.BackColor = Color.Transparent;
            lblDisplayRole.FlatStyle = FlatStyle.Flat;
            lblDisplayRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisplayRole.ForeColor = Color.MidnightBlue;
            lblDisplayRole.Location = new Point(1490, 297);
            lblDisplayRole.Name = "lblDisplayRole";
            lblDisplayRole.Size = new Size(82, 28);
            lblDisplayRole.TabIndex = 43;
            lblDisplayRole.Text = "Chức vụ";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.ErrorImage = null;
            pictureBox4.Location = new Point(1444, 269);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 56);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // picClock
            // 
            picClock.BackColor = Color.Transparent;
            picClock.BackgroundImageLayout = ImageLayout.Stretch;
            picClock.Location = new Point(1464, 47);
            picClock.Name = "picClock";
            picClock.Size = new Size(210, 210);
            picClock.TabIndex = 44;
            picClock.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Location = new Point(12, 47);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(225, 210);
            pictureBox7.TabIndex = 45;
            pictureBox7.TabStop = false;
            // 
            // pictureBox16
            // 
            pictureBox16.BackgroundImage = (Image)resources.GetObject("pictureBox16.BackgroundImage");
            pictureBox16.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox16.Location = new Point(243, 47);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(1215, 210);
            pictureBox16.TabIndex = 54;
            pictureBox16.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(891, 310);
            label6.Name = "label6";
            label6.Size = new Size(160, 28);
            label6.TabIndex = 55;
            label6.Text = "Món đang chọn: ";
            // 
            // lblFoodChoice
            // 
            lblFoodChoice.AutoSize = true;
            lblFoodChoice.BackColor = Color.Transparent;
            lblFoodChoice.FlatStyle = FlatStyle.Flat;
            lblFoodChoice.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFoodChoice.ForeColor = Color.Green;
            lblFoodChoice.Location = new Point(1057, 310);
            lblFoodChoice.Name = "lblFoodChoice";
            lblFoodChoice.Size = new Size(27, 27);
            lblFoodChoice.TabIndex = 56;
            lblFoodChoice.Text = "...";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1686, 968);
            Controls.Add(lblFoodChoice);
            Controls.Add(label6);
            Controls.Add(pictureBox7);
            Controls.Add(picClock);
            Controls.Add(pictureBox16);
            Controls.Add(pictureBox4);
            Controls.Add(lblDisplayRole);
            Controls.Add(lblDisplayName);
            Controls.Add(btnPay);
            Controls.Add(btnExportSurplus);
            Controls.Add(btnDiscount);
            Controls.Add(nmNumFood);
            Controls.Add(label3);
            Controls.Add(btnExportBill);
            Controls.Add(label8);
            Controls.Add(pictureBox6);
            Controls.Add(txbTotal);
            Controls.Add(label7);
            Controls.Add(pictureBox5);
            Controls.Add(txbSurplus);
            Controls.Add(label5);
            Controls.Add(pictureBox3);
            Controls.Add(txbReceived);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(txbDiscount);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnSearchFood);
            Controls.Add(txbSearchFood);
            Controls.Add(cbCategory);
            Controls.Add(label2);
            Controls.Add(dgvBill);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMain";
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            cmFood.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmNumFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnClose;
        private Button btnMinimize;
        private System.Windows.Forms.Timer timer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private DataGridView dgvBill;
        private Label label2;
        private ComboBox cbCategory;
        private TextBox txbSearchFood;
        private CustomButton.VBButton btnSearchFood;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txbDiscount;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox3;
        private TextBox txbReceived;
        private Label label7;
        private PictureBox pictureBox5;
        private TextBox txbSurplus;
        private Label label8;
        private PictureBox pictureBox6;
        private TextBox txbTotal;
        private CustomButton.VBButton btnPay;
        private CustomButton.VBButton btnExportBill;
        private Label clock;
        private ImageList imageList1;
        private ContextMenuStrip cmFood;
        private ToolStripMenuItem btnAddFood;
        private ToolStripMenuItem btnDeleteFood;
        private Label label3;
        private NumericUpDown nmNumFood;
        private CustomButton.VBButton btnDiscount;
        private CustomButton.VBButton btnExportSurplus;
        private Label lblDisplayName;
        private Label lblDisplayRole;
        private PictureBox pictureBox4;
        private PictureBox picClock;
        private PictureBox pictureBox7;
        private PictureBox pictureBox16;
        private Label label6;
        private Label lblFoodChoice;
    }
}