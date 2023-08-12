namespace _3_PL.View
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnClose = new Button();
            btnMinimize = new Button();
            txbUserName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txbPassWord = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            lblErrorUserName = new Label();
            lblErrorPassWord = new Label();
            btnLogin = new CustomButton.VBButton();
            ckbRememberPass = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.Size = new Size(827, 41);
            panel1.TabIndex = 0;
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
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 10);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
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
            btnClose.Location = new Point(795, 13);
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
            btnMinimize.Location = new Point(769, 13);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(20, 20);
            btnMinimize.TabIndex = 1;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // txbUserName
            // 
            txbUserName.BackColor = Color.AntiqueWhite;
            txbUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbUserName.ForeColor = Color.FromArgb(64, 0, 0);
            txbUserName.Location = new Point(404, 136);
            txbUserName.Name = "txbUserName";
            txbUserName.PlaceholderText = "Tên đăng nhập";
            txbUserName.Size = new Size(390, 34);
            txbUserName.TabIndex = 1;
            txbUserName.Text = "Hainnph30689";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(404, 105);
            label2.Name = "label2";
            label2.Size = new Size(116, 28);
            label2.TabIndex = 3;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(404, 193);
            label3.Name = "label3";
            label3.Size = new Size(110, 28);
            label3.TabIndex = 5;
            label3.Text = "Pass Word";
            // 
            // txbPassWord
            // 
            txbPassWord.BackColor = Color.AntiqueWhite;
            txbPassWord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbPassWord.ForeColor = Color.FromArgb(64, 0, 0);
            txbPassWord.Location = new Point(404, 224);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.PasswordChar = '*';
            txbPassWord.PlaceholderText = "Mật khẩu";
            txbPassWord.Size = new Size(390, 34);
            txbPassWord.TabIndex = 4;
            txbPassWord.Text = "2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(558, 61);
            label4.Name = "label4";
            label4.Size = new Size(91, 32);
            label4.TabIndex = 6;
            label4.Text = "LOGIN";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(22, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(347, 273);
            panel2.TabIndex = 7;
            // 
            // lblErrorUserName
            // 
            lblErrorUserName.AutoSize = true;
            lblErrorUserName.BackColor = Color.Transparent;
            lblErrorUserName.FlatStyle = FlatStyle.Flat;
            lblErrorUserName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrorUserName.ForeColor = Color.FromArgb(192, 0, 0);
            lblErrorUserName.Location = new Point(404, 173);
            lblErrorUserName.Name = "lblErrorUserName";
            lblErrorUserName.Size = new Size(155, 20);
            lblErrorUserName.TabIndex = 8;
            lblErrorUserName.Text = "Không được để trống";
            lblErrorUserName.Visible = false;
            // 
            // lblErrorPassWord
            // 
            lblErrorPassWord.AutoSize = true;
            lblErrorPassWord.BackColor = Color.Transparent;
            lblErrorPassWord.FlatStyle = FlatStyle.Flat;
            lblErrorPassWord.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrorPassWord.ForeColor = Color.FromArgb(192, 0, 0);
            lblErrorPassWord.Location = new Point(404, 261);
            lblErrorPassWord.Name = "lblErrorPassWord";
            lblErrorPassWord.Size = new Size(155, 20);
            lblErrorPassWord.TabIndex = 9;
            lblErrorPassWord.Text = "Không được để trống";
            lblErrorPassWord.Visible = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(128, 64, 0);
            btnLogin.BackgroundColor = Color.FromArgb(128, 64, 0);
            btnLogin.BorderColor = Color.Red;
            btnLogin.BorderRadius = 25;
            btnLogin.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(623, 284);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(171, 50);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "LOGIN";
            btnLogin.TextColor = Color.White;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // ckbRememberPass
            // 
            ckbRememberPass.AutoSize = true;
            ckbRememberPass.BackColor = Color.Transparent;
            ckbRememberPass.FlatStyle = FlatStyle.Flat;
            ckbRememberPass.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ckbRememberPass.ForeColor = Color.Maroon;
            ckbRememberPass.Location = new Point(404, 293);
            ckbRememberPass.Name = "ckbRememberPass";
            ckbRememberPass.Size = new Size(213, 29);
            ckbRememberPass.TabIndex = 11;
            ckbRememberPass.Text = "Remember password";
            ckbRememberPass.UseVisualStyleBackColor = false;
            ckbRememberPass.CheckedChanged += ckbRememberPass_CheckedChanged;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(827, 368);
            Controls.Add(ckbRememberPass);
            Controls.Add(btnLogin);
            Controls.Add(lblErrorPassWord);
            Controls.Add(lblErrorUserName);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txbPassWord);
            Controls.Add(label2);
            Controls.Add(txbUserName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginFrm";
            Load += FormLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnMinimize;
        private Button btnClose;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txbUserName;
        private Label label2;
        private Label label3;
        private TextBox txbPassWord;
        private Label label4;
        private Panel panel2;
        private Label lblErrorUserName;
        private Label lblErrorPassWord;
        private CustomButton.VBButton btnLogin;
        private CheckBox ckbRememberPass;
    }
}