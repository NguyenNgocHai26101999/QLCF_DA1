using _1_DAL.Models;
using _2_BUS.IService;
using _2_BUS.Services;
using CustomButton;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL.View
{
    public partial class FormMain : Form
    {
        private PictureBox pic = new PictureBox();
        private FoodService _FoodService;
        private AccountService _AccountService;
        private Account _account;
        private CategoryService _CategoryService;
        private BillService _BillService;
        private BillInfoService _BillInfoService;
        private string FoodNameWhenClick = "";
        private Bill CurrentBill;
        private List<BillInfo> CurrentBillInfo;
        private List<BillInfo> LstBillInfo;
        private QLCF_DA1Context DB = new QLCF_DA1Context();
        public FormMain()
        {
            InitializeComponent();
            _FoodService = new FoodService();
            _AccountService = new AccountService();
            _account = new Account();
            _CategoryService = new CategoryService();
            _BillInfoService = new BillInfoService();
            _BillService = new BillService();
            LstBillInfo = new List<BillInfo>();
            btnExportBill.BackColor = Color.Gray;
            btnExportBill.Enabled = false;
            ShowListFood();
            ShowBill();
            //testt
            //abc
        }
        #region Events       

        private void btnClose_Click(object sender, EventArgs e)
        {

            if (dgvBill.Rows.Count > 1)
            {
                if (MessageBox.Show("Hủy oder và thoát", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var obj = _AccountService.GetAccountFromDB().Where(c => c.Status == 1).ToList()[0];
                    obj.Status = 0;
                    _AccountService.UpdateAccount(obj);

                    var db = new QLCF_DA1Context();
                    var billInfor = db.BillInfos.Where(c => c.IdBill == CurrentBill.Id);
                    db.BillInfos.RemoveRange(billInfor);
                    db.Bills.Remove(CurrentBill);
                    db.SaveChanges();

                    this.Close();
                    FormLogin f = new FormLogin();
                    f.Show();
                    return;
                }
                else if (MessageBox.Show("Hủy oder và thoát", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }
            if (MessageBox.Show("Thoát", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes || CurrentBill == null)
            {
                var obj = _AccountService.GetAccountFromDB().Where(c => c.Status == 1).ToList()[0];
                obj.Status = 0;
                _AccountService.UpdateAccount(obj);
                this.Close();
                FormLogin f = new FormLogin();
                f.Show();
            }
            else if (MessageBox.Show("Hủy oder và thoát", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        void ShowBill()
        {
            //dgvBill.DataSource = _BillInfoService.GetBillInfoFromDB().Where(c => c.IdFoodNavigation.Name == FoodNameWhenClick).Select(p => new { TenMon = p.IdFood, SoLuong = p.Count, DonGia = p.IdFoodNavigation.Price, ThanhTien = p.Count * p.IdFoodNavigation.Price, MaHoaDon = p.IdBillNavigation.Id }).ToList();
            //var lstBill = _BillInfoService.GetBillInfoFromDB().ToList();
            dgvBill.Rows.Clear();
            dgvBill.ColumnCount = 5;
            dgvBill.Columns[0].Name = "ID";
            dgvBill.Columns[1].Name = "Tên món";
            dgvBill.Columns[2].Name = "Số lượng";
            dgvBill.Columns[3].Name = "Đơn giá";
            dgvBill.Columns[4].Name = "Thành tiền";
            if (LstBillInfo == null)
            {
                dgvBill.DataSource = null;
                return;
            }
            foreach (var f in LstBillInfo.Where(c => c.Count > 0))
            {
                var foodName = _FoodService.GetFoodFromDB().Where(c => c.Id == f.IdFood).ToList()[0].Name;
                var foodPrice = _FoodService.GetFoodFromDB().Where(c => c.Id == f.IdFood).ToList()[0].Price;

                dgvBill.Rows.Add(f.Id, foodName, f.Count, foodPrice, f.Count * foodPrice);
            }


        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {

            if (FoodNameWhenClick != "")
            {
                btnDiscount.Enabled = true;
                btnExportSurplus.Enabled = true;
                btnExportBill.Enabled = true;
                btnExportBill.BackColor = Color.DarkGreen;

                if (CurrentBill == null)
                {
                    CurrentBill = new Bill();
                    CurrentBill.DateCheckIn = DateTime.Now;
                    CurrentBill.IdTable = 1;
                    CurrentBill.Discount = 0;
                    CurrentBill.Status = 1;
                    _BillService.CreateBill(CurrentBill);
                    ShowBill();

                }

                CurrentBillInfo = _BillInfoService.GetBillInfoFromDB().Where(c => c.IdBill == CurrentBill.Id).ToList();

                foreach (var i in CurrentBillInfo)
                {
                    var food = _FoodService.GetFoodFromDB().FirstOrDefault(c => c.Id == i.IdFood);
                    if (food.Name == FoodNameWhenClick)
                    {
                        i.Count += (int)nmNumFood.Value;
                        DB.BillInfos.FirstOrDefault(c => c.Id == i.Id).Count += (int)nmNumFood.Value;
                        DB.SaveChanges();
                        LstBillInfo = DB.BillInfos.Where(c => c.IdBill == CurrentBill.Id).ToList();
                        ShowBill();
                        double totalPrice1 = 0;
                        foreach (var item in CurrentBillInfo)
                        {
                            var food1 = DB.Foods.Find(item.IdFood);
                            totalPrice1 += item.Count * food.Price;
                        }
                        txbTotal.Text = totalPrice1.ToString();
                        return;
                    }
                }

                var billInfo = new BillInfo();
                var f = _FoodService.GetFoodFromDB().FirstOrDefault(c => c.Name == FoodNameWhenClick);
                billInfo.IdBill = CurrentBill.Id;
                billInfo.IdFood = f.Id;
                billInfo.Count = (int)nmNumFood.Value;
                _BillInfoService.CreateBillInfo(billInfo);
                CurrentBillInfo.Add(billInfo);
                LstBillInfo = CurrentBillInfo;

                double totalPrice = 0;
                foreach (var item in CurrentBillInfo)
                {
                    var food = DB.Foods.Find(item.IdFood);
                    totalPrice += item.Count * food.Price;
                }
                txbTotal.Text = totalPrice.ToString();
                ShowBill();

            }
            else { MessageBox.Show("Chọn món muốn thêm !"); return; }

        }
        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if (LstBillInfo.Count() <= 0)
            {
                return;
            }

            //var obj = DB.BillInfos.FirstOrDefault(c => c.IdBill == CurrentBill.Id);


            if (FoodNameWhenClick != "")
            {
                double totalPrice1 = 0;


                foreach (var i in CurrentBillInfo)
                {
                    var food = _FoodService.GetFoodFromDB().FirstOrDefault(c => c.Id == i.IdFood);

                    if (food.Name == FoodNameWhenClick)
                    {


                        if (i.Count < 0 || double.Parse(nmNumFood.Value.ToString()) > i.Count)
                        {
                            i.Count = 0;
                            DB.BillInfos.FirstOrDefault(c => c.Id == i.Id).Count = 0;
                            DB.SaveChanges();
                            LstBillInfo = DB.BillInfos.Where(c => c.IdBill == CurrentBill.Id).ToList();
                            totalPrice1 -= i.Count * food.Price;
                        }
                        else
                        {
                            i.Count -= (int)nmNumFood.Value;

                            DB.BillInfos.FirstOrDefault(c => c.Id == i.Id).Count -= (int)nmNumFood.Value;
                            DB.SaveChanges();

                            LstBillInfo = DB.BillInfos.Where(c => c.IdBill == CurrentBill.Id).ToList();
                            totalPrice1 -= i.Count * food.Price;
                        }

                    }


                    txbTotal.Text = totalPrice1.ToString();
                    ShowBill();
                }



            }
            else return;
        }
        void ShowListFood()
        {
            flowLayoutPanel1.Controls.Clear();

            var tmpList = _FoodService.GetFoodFromDB().Where(c => c.Status == 0).ToList();


            foreach (var f in tmpList)
            {
                Button btnFoodItem = new Button() { Width = 180, Height = 260 };
                btnFoodItem.Font = new Font("Regular", 10);

                btnFoodItem.BackColor = Color.Peru;


                if (f.Images != "" || f.Images != null)
                {
                    PictureBox pic = new PictureBox();

                    if (f.Images == "")
                    {
                        pic.BackgroundImage = null;
                    }
                    else
                    {
                        pic.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + @"\IMGSDA1\" + f.Images);
                    }
                    pic.Width = 160; pic.Height = 160;
                    pic.Top = 10;
                    pic.Left = 10;
                    pic.Anchor = AnchorStyles.Top;
                    pic.BackgroundImageLayout = ImageLayout.Stretch;
                    btnFoodItem.Controls.Add(pic);
                }

                btnFoodItem.Text = f.Name + "\n" + f.Price + "\n" + " ";
                btnFoodItem.TextAlign = ContentAlignment.BottomCenter;

                btnFoodItem.TextImageRelation = TextImageRelation.ImageAboveText;
                btnFoodItem.Click += DisplayBtn_Click;


                btnFoodItem.ContextMenuStrip = cmFood;

                flowLayoutPanel1.AutoScroll = true;
                flowLayoutPanel1.Controls.Add(btnFoodItem);
            }
        }



        private void cbCategory_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            var foodCategoryID = (from c in _CategoryService.GetCategoryFromDB()
                                  where c.Name.ToLower() == cbCategory.Text.ToLower()
                                  select c.Id).FirstOrDefault();
            var tmpList = _FoodService.GetFoodFromDB().Where(c => c.IdCategory == foodCategoryID && c.Status == 0).ToList();
            if (cbCategory.Text == "Toàn bộ")
            {
                tmpList = _FoodService.GetFoodFromDB().ToList();
            }
            foreach (var f in tmpList)
            {
                Button btnFoodItem = new Button() { Width = 180, Height = 260 };
                btnFoodItem.Font = new Font("Regular", 9);

                btnFoodItem.BackColor = Color.Peru;


                if (f.Images != "" || f.Images != null)
                {
                    PictureBox pic = new PictureBox();
                    if (f.Images == "")
                    {
                        pic.BackgroundImage = null;
                    }
                    else
                    {
                        pic.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + @"\IMGSDA1\" + f.Images);
                    }
                    pic.Width = 160; pic.Height = 160;
                    pic.Top = 10;
                    pic.Left = 10;
                    pic.Anchor = AnchorStyles.Top;
                    pic.BackgroundImageLayout = ImageLayout.Stretch;
                    btnFoodItem.Controls.Add(pic);
                }

                btnFoodItem.Text = f.Name + "\n" + f.Price + "\n" + " ";
                btnFoodItem.TextAlign = ContentAlignment.BottomCenter;

                btnFoodItem.TextImageRelation = TextImageRelation.ImageAboveText;

                btnFoodItem.Click += DisplayBtn_Click;


                btnFoodItem.ContextMenuStrip = cmFood;


                flowLayoutPanel1.AutoScroll = true;
                flowLayoutPanel1.Controls.Add(btnFoodItem);
            }
        }


        private void DisplayBtn_Click(object? sender, EventArgs e)
        {
            FoodNameWhenClick = (sender as Button).Text.Split("\n")[0];
            lblFoodChoice.Text = FoodNameWhenClick;
        }
        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = _AccountService.GetAccountFromDB().FirstOrDefault(c => c.Status == 1);

            if (obj.Type == 1)
            {
                Form f = new FormManagement();
                f.ShowDialog();

            }

            else
                MessageBox.Show("Không có quyền truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

            btnDiscount.Enabled = false;
            btnExportSurplus.Enabled = false;



            timer1.Start();

            var CurrentAcc = _AccountService.GetAccountFromDB().FirstOrDefault(a => a.Status == 1);
            lblDisplayName.Text = CurrentAcc.DisplayName;

            lblDisplayRole.Text = CurrentAcc.Type == 1 ? "(" + "Quản lý" + ")" : "(" + "Nhân viên" + ")";


            cbCategory.DisplayMember = "--Danh mục--";
            foreach (var item in _CategoryService.GetCategoryFromDB().Select(c => c.Name).ToList())
            {
                cbCategory.Items.Add(item);
            }
            cbCategory.Items.Add("Toàn bộ");




        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            //var foodCategoryID = (from c in _CategoryService.GetCategoryFromDB()
            //                      where c.Name.ToLower() == cbCategory.Text.ToLower()
            //                      select c.Id).FirstOrDefault();
            var tmpList = _FoodService.GetFoodFromDB().Where(c => c.Name.ToLower().Trim().Contains(txbSearchFood.Text.ToLower()) && c.Status == 0);

            foreach (var f in tmpList)
            {
                Button btnFoodItem = new Button() { Width = 180, Height = 260 };
                btnFoodItem.Font = new Font("Regular", 9);

                btnFoodItem.BackColor = Color.Peru;


                if (f.Images != "" || f.Images != null)
                {
                    PictureBox pic = new PictureBox();
                    if (f.Images == "")
                    {
                        pic.BackgroundImage = null;
                    }
                    else
                    {
                        pic.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + @"\IMGSDA1\" + f.Images);

                    }
                    pic.Width = 160; pic.Height = 160;
                    pic.Top = 10;
                    pic.Left = 10;
                    pic.Anchor = AnchorStyles.Top;
                    pic.BackgroundImageLayout = ImageLayout.Stretch;
                    btnFoodItem.Controls.Add(pic);
                }

                btnFoodItem.Text = f.Name + "\n" + f.Price + "\n" + " ";
                btnFoodItem.TextAlign = ContentAlignment.BottomCenter;

                btnFoodItem.TextImageRelation = TextImageRelation.ImageAboveText;
                btnFoodItem.Click += DisplayBtn_Click;

                btnFoodItem.ContextMenuStrip = cmFood;

                flowLayoutPanel1.AutoScroll = true;
                flowLayoutPanel1.Controls.Add(btnFoodItem);
            }
        }
        private void btnDiscount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận giảm giá", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CurrentBill == null)
                {
                    return;
                }
                Regex rg = new Regex(@"[\d]");
                if (rg.IsMatch(txbDiscount.Text) != true)
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txbDiscount.Text.ToLower().Trim() == "")
                {
                    MessageBox.Show("Không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (double.Parse(txbDiscount.Text) > 100 || double.Parse(txbDiscount.Text) < 0)
                {
                    MessageBox.Show("Giảm giá không lớn hơn 100 % và nhỏ hơn 0 %", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                double totalPrice = 0;
                foreach (var item in CurrentBillInfo)
                {
                    var food = DB.Foods.Find(item.IdFood);
                    totalPrice += item.Count * food.Price;
                }
                txbTotal.Text = (totalPrice * (100 - double.Parse(txbDiscount.Text)) / 100).ToString() + " " + "VNĐ";
                DB.Bills.FirstOrDefault(c => c.Id == CurrentBill.Id).Discount = double.Parse(txbDiscount.Text);
                DB.SaveChanges();
                ShowBill();
            }
        }
        private void btnExportSurplus_Click(object sender, EventArgs e)
        {
            Regex rg = new Regex(@"[\d]");
            if (dgvBill.Rows.Count < 1)
            {
                return;
            }
            if (txbTotal.Text.Trim() == "" || txbTotal.Text.Trim() == null || txbReceived.Text.Trim() == "" || txbReceived.Text.Trim() == null)
            {
                return;
            }
            if (double.Parse(txbReceived.Text) < 0)
            {
                return;
            }

            if ((txbReceived.Text.Trim() != null && txbReceived.Text.Trim() != ""))
            {
                if (rg.IsMatch(txbReceived.Text))
                {
                    txbSurplus.Text = (double.Parse(txbReceived.Text) - double.Parse(txbTotal.Text.Split(" ")[0])).ToString() + " " + "VNĐ";
                    ShowBill();
                }
            }
            else return;
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            //var tmp = _BillService.GetBillFromDB().Where(c => c.Status == 1).ToList()[0].Status;
            //foreach (var item in _BillService.GetBillFromDB().ToList())
            //{
            //    if (item.Status == tmp)
            //    {
            //        _BillService.DeleteBill(item);
            //    }
            //}

            if (CurrentBill == null)
            {
                MessageBox.Show("Chưa có hóa đơn được tạo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show($"" +
                $"Xác nhận thanh toán mã hóa đơn {CurrentBill.Id} \n" +
                $"Tổng hóa đơn: {txbTotal.Text.Split(" ")[0]} VNĐ",
                "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btnExportBill.Enabled = false;
                btnExportBill.BackColor = Color.Gray;
                btnExportSurplus.Enabled = false;
                btnDiscount.Enabled = false;

                CurrentBill.DateCheckOut = DateTime.Now;
                CurrentBill.Status = 0;
                if (txbDiscount.Text == null || txbDiscount.Text == "")
                {
                    CurrentBill.Discount = 0;
                }
                else CurrentBill.Discount = double.Parse(txbDiscount.Text);



                _BillService.UpdateBill(CurrentBill);
                CurrentBill = null;
                CurrentBillInfo = null;
                LstBillInfo = null;

                //ShowBill();
                dgvBill.ColumnCount = 0;

                txbDiscount.Clear();
                txbReceived.Clear();
                txbSurplus.Clear();
                txbTotal.Clear();
            }
        }
        private void txbTotal_TextChanged(object sender, EventArgs e)
        {
            double totalPrice = 0;
            if (txbTotal.Text == "".Trim() || CurrentBillInfo.Count <= 0)
            {
                return;
            }
            foreach (var item in CurrentBillInfo)
            {
                var food = DB.Foods.Find(item.IdFood);
                totalPrice += item.Count * food.Price;
            }
            if (txbDiscount.Text == "".Trim())
            {
                txbDiscount.Text = "0";
            }
            txbTotal.Text = (totalPrice * (100 - double.Parse(txbDiscount.Text)) / 100).ToString() + " " + "VNĐ";

            if (txbReceived.Text == "".Trim())
            {
                return;
            }
            txbSurplus.Text = (double.Parse(txbReceived.Text) - double.Parse(txbTotal.Text.Split(" ")[0])).ToString() + " " + "VNĐ";
            ShowBill();
        }
        private void btnExportBill_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            picClock.BackgroundImage = GUIClock.ClockImage(400, 400);
            picClock.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfomation f = new FormInfomation();
            f.ShowDialog();

        }
        #endregion Events





        private void txbDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Ngăn các ký tự đầu vào không phải là số
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txbReceived_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
