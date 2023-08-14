using _1_DAL.Models;
using _2_BUS.IService;
using _2_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//using QLCF_DA1Context = _1_DAL.Models.QLCF_DA1Context;

namespace _3_PL.View
{
    public partial class FormManagement : Form
    {
        private CategoryService _categoryService;
        private FoodService _foodService;
        private IAccountService _accountService;
        private BillService _billService;
        private BillInfoService _billInfoService;
        private QLCF_DA1Context _QLCFDA1Context;

        private int idClick;
        public FormManagement()
        {
            InitializeComponent();
            _foodService = new FoodService();
            _categoryService = new CategoryService();
            _accountService = new AccountService();
            _billService = new BillService();
            _billInfoService = new BillInfoService();
            _QLCFDA1Context = new QLCF_DA1Context();
            LoadDgvFood();
            LoadDgvFoodCategories();
            LoadAccount();
            LoadDgvBill();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormManagement_Load(object sender, EventArgs e)
        {
            cbStatusFood.Items.Add("Bán");
            cbStatusFood.Items.Add("Dừng bán");
            cbCategoryFood.DataSource = _categoryService.GetCategoryFromDB().Select(c => c.Name).ToList();
            btnEditFood.Enabled = false;
            btnEditCa.Enabled = false;
            btnUpdateAccount.Enabled = false;
            btnXoaAccount.Enabled = false;
        }

        #region FoodCategories
        public void LoadDgvFoodCategories()
        {
            var fc = _categoryService.GetCategoryFromDB().ToList();
            int stt = 1;
            dgvCategoryFood.Rows.Clear();
            dgvCategoryFood.ColumnCount = 3;
            dgvCategoryFood.Columns[0].Name = "STT";
            dgvCategoryFood.Columns[1].Name = "ID";
            dgvCategoryFood.Columns[2].Name = "Tên danh mục";
            foreach (var i in fc)
            {
                dgvCategoryFood.Rows.Add(stt++, i.Id, i.Name);
            }
        }
        private void dgvCategoryFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditCa.Enabled = true;

            int rowIndex = e.RowIndex;

            if (rowIndex == _categoryService.GetCategoryFromDB().Count || rowIndex == -1)
            {
                return;
            }

            btnEditFood.Enabled = true;
            btnEditFood.BackColor = Color.SaddleBrown;

            idClick = int.Parse(dgvCategoryFood.Rows[rowIndex].Cells["ID"].Value.ToString());
            var food = _categoryService.GetCategoryFromDB().FirstOrDefault(c => c.Id == idClick);

            txbIDFCategory.Text = food.Id.ToString();
            txbFoodName.Text = food.Name;
            txbNameCategory.Text = food.Name;

        }
        private void btnAddCa_Click(object sender, EventArgs e)
        {
            var obj = new _1_DAL.Models.FoodCategory();

            obj.Name = txbNameCategory.Text;
            if (txbNameCategory.Text.Trim().ToLower() == "" || txbNameCategory.Text.Trim().ToLower() == null)
            {
                MessageBox.Show("Danh mục không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var foods = _categoryService.GetCategoryFromDB().ToList();
            foreach (var i in foods)
            {
                if (i.Name.ToLower().Trim() == txbNameCategory.Text.ToLower().Trim())
                {
                    MessageBox.Show("Danh mục đã tồn tại trong hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (_categoryService.CreateCategory(obj))
            {
                MessageBox.Show("Thêm thành công");
            }
            LoadDgvFoodCategories();



        }

        private void btnEditCa_Click(object sender, EventArgs e)
        {
            var obj = _categoryService.GetCategoryFromDB().FirstOrDefault(c => c.Id == idClick);

            obj.Name = txbNameCategory.Text;
            if (txbNameCategory.Text.Trim().ToLower() == "" || txbNameCategory.Text.Trim().ToLower() == null)
            {
                MessageBox.Show("Danh mục không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var foods = _categoryService.GetCategoryFromDB().ToList();
            //foreach (var i in foods)
            //{
            //    if (i.Name.ToLower().Trim() == txbNameCategory.Text.ToLower().Trim())
            //    {
            //        MessageBox.Show("Danh mục đã tồn tại trong hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //}
            //var db2 = new QLCF_DA1Context();
            _categoryService.UpdateCategory(obj);

            //db2.SaveChanges();

            MessageBox.Show("Sửa thành công");

            LoadDgvFoodCategories();
        }

        #endregion

        #region Foods
        public void LoadDgvFood()
        {
            //var db = new QLCF_DA1Context();
            //var tmp = db.FoodCategories.ToList();
            int stt = 1;
            dgvFood.Rows.Clear();
            dgvFood.ColumnCount = 7;
            dgvFood.Columns[0].Name = "STT";
            dgvFood.Columns[1].Name = "ID món";
            dgvFood.Columns[2].Name = "Tên món";
            dgvFood.Columns[3].Name = "Tên danh mục";
            dgvFood.Columns[4].Name = "Giá";
            dgvFood.Columns[5].Name = "Trạng thái";
            dgvFood.Columns[6].Name = "Ảnh";
            foreach (var f in _foodService.GetFoodFromDB())
            {
                var CategoryName = _categoryService.GetCategoryFromDB().Where(c => c.Id == f.IdCategory).ToList()[0].Name;
                dgvFood.Rows.Add(stt++, f.Id, f.Name, CategoryName, f.Price, f.Status == 0 ? "Bán" : "Dừng bán", f.Images);

            }
        }
        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            int stt = 1;
            dgvFood.Rows.Clear();
            dgvFood.ColumnCount = 7;
            dgvFood.Columns[0].Name = "STT";
            dgvFood.Columns[1].Name = "ID món";
            dgvFood.Columns[2].Name = "Tên món";
            dgvFood.Columns[3].Name = "Tên danh mục";
            dgvFood.Columns[4].Name = "Giá";
            dgvFood.Columns[5].Name = "Trạng thái";
            dgvFood.Columns[6].Name = "Ảnh";
            var lstSearch = _foodService.GetFoodFromDB().Where(c => c.Name.ToLower().Trim().Contains(txbSearch.Text.ToLower().Trim()));
            foreach (var f in lstSearch)
            {
                var CategoryName = _categoryService.GetCategoryFromDB().Where(c => c.Id == f.IdCategory).ToList()[0].Name;
                dgvFood.Rows.Add(stt++, f.Id, f.Name, CategoryName, f.Price, f.Status == 0 ? "Bán" : "Dừng bán", f.Images);

            }
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            //var appPath = Directory.GetCurrentDirectory()+@"\IMG\";
            //if (result == DialogResult)
            //{
            //    File.Copy(openFileDialog1.FileName, appPath + openFileDialog1.SafeFileName);
            //}

            MessageBox.Show(openFileDialog1.FileName);
            if (openFileDialog1.FileName == null || openFileDialog1.FileName == "")
            {
                return;
            }
            using (Stream st = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "IMGSDA1", Path.GetFileName($"{openFileDialog1.FileName}")), FileMode.Open, FileAccess.Read, FileShare.Read))
            {
            }
            //if (File.Exists(Path.GetFileName($"{openFileDialog1.FileName}")))
            //{
            //    File.Delete(Path.GetFileName($"{openFileDialog1.FileName}"));
            //}
            picFood.BackgroundImage = Image.FromFile(openFileDialog1.FileName);

            btnHinh.Text = openFileDialog1.FileName.Split(@"\")[5];
        }
        private void btnEditFood_Click(object sender, EventArgs e)
        {
            var fc = _categoryService.GetCategoryFromDB().FirstOrDefault(c => c.Name == cbCategoryFood.Text).Id;
            var food = _foodService.GetFoodFromDB().FirstOrDefault(c => c.Id == idClick);

            if (txbFoodName.Text.Trim() == "")
            {
                MessageBox.Show("Tên món không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var foods = _foodService.GetFoodFromDB().ToList();
            food.Name = txbFoodName.Text;
            food.IdCategory = fc;

            food.Price = float.Parse(nmPriceFood.Value.ToString());
            food.Status = cbStatusFood.Text == "Bán" ? 0 : 1;

            MessageBox.Show(food.Status.ToString());

            food.Images = openFileDialog1.SafeFileName;
            food.Images = btnHinh.Text;
            //foreach (var i in foods)
            //{
            //    if (i.Name == txbFoodName.Text.ToLower().Trim())
            //    {
            //        MessageBox.Show("Món đã tồn tại trong hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //}
            var db = new QLCF_DA1Context();

            db.Foods.Update(food);
            db.SaveChanges();

            txbFoodName.Clear();
            txbIDFood.Clear();
            cbCategoryFood.SelectedIndex = 0;
            nmPriceFood.Value = 0;
            //cbStatusFood.SelectedIndex = 0;
            btnEditFood.Enabled = false;
            MessageBox.Show("Sửa thành công");


            LoadDgvFood();
        }
        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditFood.Enabled = true;

            int rowIndex = e.RowIndex;

            if (rowIndex == _foodService.GetFoodFromDB().Count || rowIndex == -1)
            {
                return;
            }
            idClick = int.Parse(dgvFood.Rows[rowIndex].Cells["ID món"].Value.ToString());
            var food = _foodService.GetFoodFromDB().FirstOrDefault(c => c.Id == idClick);
            var fc = _categoryService.GetCategoryFromDB().FirstOrDefault(c => c.Id == food.IdCategory);
            string fcName;
            if (fc != null)
            {
                fcName = fc.Name;
            }
            else fcName = "";
            txbIDFood.Text = food.Id.ToString();
            txbFoodName.Text = food.Name;
            nmPriceFood.Text = food.Price.ToString();
            cbCategoryFood.Text = fcName;
            btnHinh.Text = food.Images;

            if (food.Images == "" || food.Images == null)
            {
                picFood.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + @"\IMGSDA1\" + "white.png");
                return;
            }

            //using (Stream st = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "IMGSDA1", Path.GetFileName($"{openFileDialog1.FileName}")), FileMode.OpenOrCreate))
            //{

            //}   

            picFood.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + @"\IMGSDA1\" + btnHinh.Text);

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thêm món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {


                if (txbFoodName.Text.Trim() == "")
                {
                    MessageBox.Show("Tên món không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var foods = _foodService.GetFoodFromDB().ToList();
                foreach (var i in foods)
                {
                    if (i.Name.Trim().ToLower() == txbFoodName.Text.ToLower().Trim())
                    {
                        MessageBox.Show("Món đã tồn tại trong hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                var fc = _categoryService.GetCategoryFromDB().FirstOrDefault(c => c.Name == cbCategoryFood.Text).Id;
                var food = new _1_DAL.Models.Food();
                food.Name = txbFoodName.Text;

                food.IdCategory = fc;

                food.Price = float.Parse(nmPriceFood.Value.ToString());
                food.Status = 0;
                //btnHinh.Text = openFileDialog1.SafeFileName;
                food.Images = openFileDialog1.SafeFileName;
                food.Images = btnHinh.Text;



                if (_foodService.CreateAccount(food))
                {
                    txbFoodName.Clear();
                    txbIDFood.Clear();
                    cbCategoryFood.SelectedIndex = 0;
                    nmPriceFood.Value = 0;
                    cbStatusFood.SelectedIndex = 0;
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadDgvFood();

            }

        }
        #endregion

        #region Account
        public void LoadAccount()
        {

            int stt = 1;
            dgvAccount.Rows.Clear();
            dgvAccount.ColumnCount = 5;
            dgvAccount.Columns[0].Name = "STT";
            dgvAccount.Columns[1].Name = "User Name";
            dgvAccount.Columns[2].Name = "Display Name";
            dgvAccount.Columns[3].Name = "PassWord";
            dgvAccount.Columns[4].Name = "Type";

            foreach (var f in _accountService.GetAccountFromDB())
            {
                //var result = tmp.Where(c => c.Id == f.IdCategory).ToList()[0].Name;
                dgvAccount.Rows.Add(stt++, f.UserName, f.DisplayName, f.PassWord, f.Type == 1 ? "Admin" : "Nhân Viên");
            }
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdateAccount.Enabled = true;
            btnXoaAccount.Enabled = true;

            string NameWhenClick = e.RowIndex.ToString();
            int rowIndex = e.RowIndex;

            if (rowIndex == _accountService.GetAccountFromDB().Count || rowIndex == -1)
            {
                return;
            }
            NameWhenClick = dgvAccount.Rows[rowIndex].Cells["User Name"].Value.ToString();
            var food = _accountService.GetAccountFromDB().FirstOrDefault(c => c.UserName == NameWhenClick);

            tbxUser.Text = food.UserName.ToString();
            tbxDisplay.Text = food.DisplayName;
            tbxpass.Text = food.PassWord;
            if (food.Type == 1)
            {
                tbxtype.Text = "Admin";
            }
            else
            {
                tbxtype.Text = "Nhân Viên";
            }

        }
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            var obj = new _1_DAL.Models.Account();

            obj.UserName = tbxUser.Text;
            if (tbxUser.Text.Trim().ToLower() == "" || tbxUser.Text.Trim().ToLower() == null)
            {
                MessageBox.Show("Tên tài khoản không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            obj.DisplayName = tbxDisplay.Text;
            if (tbxDisplay.Text.Trim().ToLower() == "" || tbxDisplay.Text.Trim().ToLower() == null)
            {
                MessageBox.Show("Tên hiển thị không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            obj.PassWord = tbxpass.Text.Trim().ToLower();
            if (tbxpass.Text.ToLower() == "" || tbxpass.Text.ToLower() == null)
            {
                MessageBox.Show("Mật khẩu không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            obj.Type = 0;


            var account = _accountService.GetAccountFromDB().ToList();
            foreach (var i in account)
            {
                if (i.UserName.ToLower().Trim() == tbxUser.Text.ToLower().Trim())
                {
                    MessageBox.Show("Tài khoản đã tồn tại trong hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (i.DisplayName.ToLower().Trim() == tbxDisplay.Text.ToLower().Trim())
                {
                    MessageBox.Show("Tên hiển thị đã tồn tại trong hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (_accountService.CreateAccount(obj))
            {
                MessageBox.Show("Thêm thành công");
            }
            LoadAccount();
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            var nameWhenClick = tbxUser.Text.Trim().ToLower();
            var obj = _accountService.GetAccountFromDB().FirstOrDefault(c => c.UserName.Trim().ToLower() == nameWhenClick);



            if (tbxUser.Text.Trim().ToLower() == "" || tbxUser.Text.Trim().ToLower() == null)
            {
                MessageBox.Show("Tên tài khoản không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            obj.DisplayName = tbxDisplay.Text;
            if (tbxDisplay.Text.Trim().ToLower() == "" || tbxDisplay.Text.Trim().ToLower() == null)
            {
                MessageBox.Show("Tên hiển thị không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            obj.PassWord = tbxpass.Text.Trim().ToLower();
            if (tbxpass.Text.ToLower() == "" || tbxpass.Text.ToLower() == null)
            {
                MessageBox.Show("Mật khẩu không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //var account = _accountService.GetAccountFromDB().ToList();
            //foreach (var i in account)
            //{
            //    if (i.DisplayName.ToLower().Trim() == tbxDisplay.Text.ToLower().Trim())
            //    {
            //        MessageBox.Show("Tên hiển thị đã tồn tại trong hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //}

            QLCF_DA1Context db = new QLCF_DA1Context();
            db.Update(obj);
            db.SaveChanges();
            tbxDisplay.Clear();
            tbxUser.Clear();
            tbxpass.Clear();
            tbxtype.Clear();
            btnUpdateAccount.Enabled = false;
            btnXoaAccount.Enabled = false;
            MessageBox.Show("Sửa thành công");

            LoadAccount();
        }
        private void btnXoaAccount_Click(object sender, EventArgs e)
        {
            var nameWhenClick = tbxUser.Text.Trim().ToLower();
            var obj = _accountService.GetAccountFromDB().FirstOrDefault(c => c.UserName.Trim().ToLower() == nameWhenClick);
            if (obj.Type == 1)
            {
                MessageBox.Show("Tài khoản không được phép xóa");
                return;
            }
            if (_accountService.DeleteAccount(obj))
            {
                tbxDisplay.Clear();
                tbxUser.Clear();
                tbxpass.Clear();
                tbxtype.Clear();
                btnUpdateAccount.Enabled = false;
                btnXoaAccount.Enabled = false;
                MessageBox.Show("Xóa thành công");
            }
            LoadAccount();
        }
        private void tbxUser_TextChanged(object sender, EventArgs e)
        {
            btnUpdateAccount.Enabled = false;
            btnXoaAccount.Enabled = false;
        }
        #endregion

        #region Bills
        public void LoadDgvBill()
        {
            var db = new QLCF_DA1Context();
            DateTime dateStart = DateTime.Parse(dtpStart.Value.ToShortDateString());
            DateTime dateEnd = DateTime.Parse(dtpEnd.Value.ToShortDateString());
            //|| p.DateCheckOut == null
            dgvBill.DataSource = db.Bills.Where(p => p.DateCheckIn >= dateStart && (p.DateCheckOut <= dateEnd)).Select(p => new
            {
                MãHóaĐơn = p.Id,
                NgàyTạo = p.DateCheckIn,
                TrạngThái = p.Status == 0 ? "Đã thanh toán" : "Chưa thanh toán",
                TổngTiền = p.BillInfos.Sum(i => (double?)i.IdFoodNavigation.Price * i.Count) ?? 0,
                GiảmGiá = p.Discount + "%",
                TổngHóaĐơn = p.BillInfos.Sum(i => (double?)i.IdFoodNavigation.Price * i.Count) * (100 - p.Discount) / 100 ?? 0
            }).ToList();

        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            LoadDgvBill();
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            LoadDgvBill();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            var db = new QLCF_DA1Context();
            DateTime dateStart = DateTime.Parse(dtpStart.Value.ToShortDateString());
            DateTime dateEnd = DateTime.Parse(dtpEnd.Value.ToShortDateString());

            double sum = 0;
            for (int i = 0; i < dgvBill.Rows.Count; i++)
            {
                sum += double.Parse(dgvBill.Rows[i].Cells["TổngHóaĐơn"].Value.ToString());
                if (dgvBill.Rows[i].Cells["TrạngThái"].Value.ToString() == "Chưa thanh toán")
                {
                    sum = sum - double.Parse(dgvBill.Rows[i].Cells["TổngHóaĐơn"].Value.ToString());
                }
            }

            //string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", value)

            lblSoHoaDon.Text = dgvBill.Rows.Count.ToString();
            lblTongTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", sum) + " VNĐ";
        }

        #endregion

    }
}
