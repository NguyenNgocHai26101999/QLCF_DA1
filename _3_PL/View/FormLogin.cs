using _1_DAL.Models;
using _2_BUS.IService;
using _2_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _3_PL.View
{
    public partial class FormLogin : Form
    {
        private IAccountService _IAccountService;
        private Account _account;
        private List<Account> _LstAccount;
        public FormLogin()
        {
            InitializeComponent();
            _IAccountService = new AccountService();
            _account = new Account();
            _LstAccount = new List<Account>();
        }
        #region Events
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn rời khỏi ứng dụng", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public bool LogIn(string UserName, string PassWord)
        {
            if (_IAccountService.GetAccountFromDB().Where(c => c.UserName.ToLower().Trim() == UserName.ToLower().Trim() && c.PassWord == PassWord).ToList().Count() > 0)
            {
                return true;
            }
            return false;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text, passWord = txbPassWord.Text;
            if (userName.Trim() == string.Empty || passWord.Trim() == string.Empty)
            {
                lblErrorUserName.Visible = true;
                lblErrorPassWord.Visible = true;
            }
            else if (LogIn(userName.ToLower().Trim(), passWord.ToLower().Trim()))
            {

                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                var obj = _IAccountService.GetAccountFromDB().Where(c => c.UserName.ToLower().Trim() == txbUserName.Text.ToLower().Trim()).ToList()[0];
                obj.Status = 1;
                _IAccountService.UpdateAccount(obj);
                Form f = new FormMain();
                f.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void ckbRememberPass_CheckedChanged(object sender, EventArgs e)
        {
            string userName = txbUserName.Text, passWord = txbPassWord.Text;
            if (userName != "" && passWord != "")
            {
                if (ckbRememberPass.Checked)
                {
                    Properties.Settings.Default.UserName = userName;
                    Properties.Settings.Default.PassWord = passWord;
                    Properties.Settings.Default.Save();
                }
                else Properties.Settings.Default.Reset();
            }
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                txbUserName.Text = Properties.Settings.Default.UserName;
                txbPassWord.Text = Properties.Settings.Default.PassWord;
                ckbRememberPass.Checked = true;
            }
        }
        #endregion Events

    }
}
