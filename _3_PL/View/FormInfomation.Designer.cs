namespace _3_PL.View
{
    partial class FormInfomation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfomation));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnClose = new Button();
            btnMinimize = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblUserName = new Label();
            lblDisplayName = new Label();
            tbxpass = new TextBox();
            tbxrepass = new TextBox();
            tbxrepass2 = new TextBox();
            btnChange = new CustomButton.VBButton();
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
            panel1.Size = new Size(522, 41);
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
            btnClose.Location = new Point(490, 10);
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
            btnMinimize.Location = new Point(464, 10);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(20, 20);
            btnMinimize.TabIndex = 1;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(35, 64);
            label2.Name = "label2";
            label2.Size = new Size(140, 28);
            label2.TabIndex = 4;
            label2.Text = "Tên tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(35, 134);
            label3.Name = "label3";
            label3.Size = new Size(124, 28);
            label3.TabIndex = 5;
            label3.Text = "Tên hiển thị";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(35, 288);
            label4.Name = "label4";
            label4.Size = new Size(145, 28);
            label4.TabIndex = 6;
            label4.Text = "Mật khẩu mới";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(35, 216);
            label5.Name = "label5";
            label5.Size = new Size(102, 28);
            label5.TabIndex = 5;
            label5.Text = "Mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(35, 362);
            label6.Name = "label6";
            label6.Size = new Size(92, 28);
            label6.TabIndex = 7;
            label6.Text = "Nhập lại";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.BackColor = Color.Transparent;
            lblUserName.FlatStyle = FlatStyle.Flat;
            lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.ForeColor = Color.FromArgb(64, 0, 0);
            lblUserName.Location = new Point(196, 64);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(116, 28);
            lblUserName.TabIndex = 8;
            lblUserName.Text = "User Name";
            // 
            // lblDisplayName
            // 
            lblDisplayName.AutoSize = true;
            lblDisplayName.BackColor = Color.Transparent;
            lblDisplayName.FlatStyle = FlatStyle.Flat;
            lblDisplayName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDisplayName.ForeColor = Color.FromArgb(64, 0, 0);
            lblDisplayName.Location = new Point(196, 134);
            lblDisplayName.Name = "lblDisplayName";
            lblDisplayName.Size = new Size(144, 28);
            lblDisplayName.TabIndex = 9;
            lblDisplayName.Text = "Display Name";
            // 
            // tbxpass
            // 
            tbxpass.BackColor = Color.Tan;
            tbxpass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxpass.Location = new Point(196, 216);
            tbxpass.Name = "tbxpass";
            tbxpass.Size = new Size(240, 34);
            tbxpass.TabIndex = 22;
            // 
            // tbxrepass
            // 
            tbxrepass.BackColor = Color.Tan;
            tbxrepass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxrepass.Location = new Point(196, 288);
            tbxrepass.Name = "tbxrepass";
            tbxrepass.PasswordChar = '*';
            tbxrepass.Size = new Size(240, 34);
            tbxrepass.TabIndex = 23;
            // 
            // tbxrepass2
            // 
            tbxrepass2.BackColor = Color.Tan;
            tbxrepass2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxrepass2.Location = new Point(196, 362);
            tbxrepass2.Name = "tbxrepass2";
            tbxrepass2.PasswordChar = '*';
            tbxrepass2.Size = new Size(240, 34);
            tbxrepass2.TabIndex = 24;
            // 
            // btnChange
            // 
            btnChange.BackColor = Color.FromArgb(128, 64, 0);
            btnChange.BackgroundColor = Color.FromArgb(128, 64, 0);
            btnChange.BorderColor = Color.Red;
            btnChange.BorderRadius = 25;
            btnChange.BorderSize = 0;
            btnChange.FlatAppearance.BorderSize = 0;
            btnChange.FlatStyle = FlatStyle.Flat;
            btnChange.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnChange.ForeColor = Color.White;
            btnChange.Location = new Point(313, 453);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(171, 50);
            btnChange.TabIndex = 25;
            btnChange.Text = "Đổi mật khẩu";
            btnChange.TextColor = Color.White;
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            // 
            // FormInfomation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(522, 550);
            Controls.Add(btnChange);
            Controls.Add(tbxrepass2);
            Controls.Add(tbxrepass);
            Controls.Add(tbxpass);
            Controls.Add(lblDisplayName);
            Controls.Add(lblUserName);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInfomation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInfomation";
            Load += FormInfomation_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnClose;
        private Button btnMinimize;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblUserName;
        private Label lblDisplayName;
        private TextBox tbxpass;
        private TextBox tbxrepass;
        private TextBox tbxrepass2;
        private CustomButton.VBButton btnChange;
    }
}