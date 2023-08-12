using _2_BUS.IService;
using _2_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL.View
{
    public partial class FormInfomation : Form

    {
        private IAccountService _serviceAccount;

        public FormInfomation()
        {
            InitializeComponent();
            _serviceAccount = new AccountService();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            var result = tbxpass.Text.Trim().ToLower();
            var obj = _serviceAccount.GetAccountFromDB().Where(x => x.Status == 1).ToList()[0];
            if (result != obj.PassWord)
            {
                MessageBox.Show("Mật khẩu cũ không đúng");
                return;
            }
            if (tbxrepass.Text.Trim().ToLower() == "" || tbxrepass.Text.Trim().ToLower() == null)
            {
                MessageBox.Show("Mật khẩu không được để trống");
                return;
            }
            if (tbxrepass2.Text.Trim().ToLower() == "" || tbxrepass2.Text.Trim().ToLower() == null)
            {
                MessageBox.Show("Mật khẩu không được để trống");
                return;
            }
            if (tbxrepass.Text.Trim().ToLower() != tbxrepass2.Text.Trim().ToLower())
            {
                MessageBox.Show("Mật khẩu nhập lại không đúng");
                return;
            }
            obj.PassWord = tbxrepass2.Text.Trim().ToLower();
            if (_serviceAccount.UpdateAccount(obj))
            {
                MessageBox.Show("Đổi mật khẩu thành công");
            }
            tbxpass.Clear();
            tbxrepass.Clear();
            tbxrepass2.Clear();
        }

        private void FormInfomation_Load(object sender, EventArgs e)
        {
            var obj = _serviceAccount.GetAccountFromDB().Where(x => x.Status == 1).ToList()[0];
            lblUserName.Text = obj.UserName.ToString();
            lblDisplayName.Text = obj.DisplayName.ToString();
        }
    }



}

