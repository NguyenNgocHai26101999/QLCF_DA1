using _1_DAL.Models;
using _2_BUS.IService;
using _2_BUS.Services;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL.View
{
    public partial class FormHistory : Form
    {
        //LstBillInfo = DB.BillInfos.Where(c => c.IdBill == CurrentBill.Id).ToList();
        private int idWhenClick;
        private List<BillInfo> _billInfoCurrent;
        private List<BillInfo> _LstBillInfo;
        private Bill _billCurrent;
        private IBillService _billService = new BillService();
        private IFoodService _foodService = new FoodService();
        private int rowIndex;
        public FormHistory()
        {
            _LstBillInfo = new List<BillInfo>();
            _billInfoCurrent = new List<BillInfo>();
            _billCurrent = new Bill();
            InitializeComponent();
            LoadBill();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public void LoadBill()
        {
            var db = new QLCF_DA1Context();

            //|| p.DateCheckOut == null
            dgvBill.DataSource = db.Bills.Select(p => new
            {
                MãHóaĐơn = p.Id,
                NgàyTạo = p.DateCheckIn,
                TrạngThái = p.Status == 0 ? "Đã thanh toán" : "Chưa thanh toán",
                TổngTiền = p.BillInfos.Sum(i => (double?)i.IdFoodNavigation.Price * i.Count) ?? 0,
                GiảmGiá = p.Discount + "%",
                TổngHóaĐơn = p.BillInfos.Sum(i => (double?)i.IdFoodNavigation.Price * i.Count) * (100 - p.Discount) / 100 ?? 0
            }).ToList();
        }

        private void txbSearchFood_TextChanged(object sender, EventArgs e)
        {
            var db = new QLCF_DA1Context();

            //|| p.DateCheckOut == null
            //var Lst = _billInfoService.GetBillFromDB().Where(i=>i.Id.ToString().Contains(txbSearchFood.Text)).ToList();

            //chắc đc đó a

            dgvBill.DataSource = db.Bills.Where(i => i.Id.ToString().Contains(txbSearchFood.Text)).Select(p => new
            {
                MãHóaĐơn = p.Id,
                NgàyTạo = p.DateCheckIn,
                TrạngThái = p.Status == 0 ? "Đã thanh toán" : "Chưa thanh toán",
                TổngTiền = p.BillInfos.Sum(i => (double?)i.IdFoodNavigation.Price * i.Count) ?? 0,
                GiảmGiá = p.Discount + "%",
                TổngHóaĐơn = p.BillInfos.Sum(i => (double?)i.IdFoodNavigation.Price * i.Count) * (100 - p.Discount) / 100 ?? 0
            }).ToList();
        }

        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var db = new QLCF_DA1Context();
            idWhenClick = e.RowIndex;
            rowIndex = e.RowIndex;

            if (rowIndex == _billService.GetBillFromDB().Count || rowIndex == -1)
            {
                return;
            }
            idWhenClick = int.Parse(dgvBill.Rows[rowIndex].Cells["MãHóaĐơn"].Value.ToString());


            lblIDBill.Text = idWhenClick.ToString();

            _billCurrent = _billService.GetBillFromDB().Where(c => c.Id == idWhenClick).ToList()[0];


            var tmp = db.BillInfos.Where(c => c.IdBill == idWhenClick).ToList()[0];

            var b = new BillInfo();
            var f = _foodService.GetFoodFromDB().FirstOrDefault(c => c.Id == tmp.IdFood);
            b.IdBill = _billCurrent.Id;
            b.IdFood = f.Id;

            b.Count = db.BillInfos.Where(c => c.IdBill == idWhenClick).Count();
            _billInfoCurrent.Add(b);
            _LstBillInfo = _billInfoCurrent;

            //var billInfo = new BillInfo();
            //var f = _FoodService.GetFoodFromDB().FirstOrDefault(c => c.Name == FoodNameWhenClick);
            //billInfo.IdBill = CurrentBill.Id;
            //billInfo.IdFood = f.Id;
            //billInfo.Count = (int)nmNumFood.Value;
            //_BillInfoService.CreateBillInfo(billInfo);
            //CurrentBillInfo.Add(billInfo);
            //LstBillInfo = CurrentBillInfo;

            dgvBill.Rows[rowIndex].ContextMenuStrip = cmBill;

        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var db = new QLCF_DA1Context();
            Image img = Image.FromFile(Directory.GetCurrentDirectory() + @"\IMGSDA1\" + "HeaderBill.png");
            e.Graphics.DrawImage(img, 0, 0, img.Width, img.Height);
            e.Graphics.DrawString("Ngày: " + DateTime.Now.ToShortDateString(), new Font("Arial", 23, FontStyle.Regular), Brushes.Black, new Point(25, 190));
            var NguoiTao = db.Accounts.Where(c => c.Status == 1).ToList()[0].DisplayName;
            e.Graphics.DrawString("Người tạo: " + NguoiTao, new Font("Arial", 23, FontStyle.Regular), Brushes.Black, new Point(25, 230));
            e.Graphics.DrawString("----------------------------------------------------------------------------", new Font("Arial", 23, FontStyle.Regular), Brushes.Gray, new Point(25, 260));
            e.Graphics.DrawString("Tên món", new Font("Arial", 23, FontStyle.Regular), Brushes.Black, new Point(25, 290));
            e.Graphics.DrawString("SL", new Font("Arial", 23, FontStyle.Regular), Brushes.Black, new Point(550, 290));
            e.Graphics.DrawString("Thành tiền", new Font("Arial", 23, FontStyle.Regular), Brushes.Black, new Point(650, 290));
            e.Graphics.DrawString("----------------------------------------------------------------------------", new Font("Arial", 23, FontStyle.Regular), Brushes.Gray, new Point(25, 310));

            int yPos = 340;
            foreach (var f in _LstBillInfo.Where(c => c.Count > 0))
            {
                var foodName = _foodService.GetFoodFromDB().Where(c => c.Id == f.IdFood).ToList()[0].Name;
                var foodPrice = _foodService.GetFoodFromDB().Where(c => c.Id == f.IdFood).ToList()[0].Price;

                e.Graphics.DrawString(foodName, new Font("Arial", 23, FontStyle.Regular), Brushes.Black, new Point(25, yPos));
                e.Graphics.DrawString(f.Count.ToString(), new Font("Arial", 23, FontStyle.Regular), Brushes.Black, new Point(550, yPos));
                e.Graphics.DrawString((f.Count * foodPrice).ToString(), new Font("Arial", 23, FontStyle.Regular), Brushes.Black, new Point(650, yPos));

                yPos += 50;
            }
            e.Graphics.DrawString("----------------------------------------------------------------------------", new Font("Arial", 23, FontStyle.Regular), Brushes.Gray, new Point(25, yPos));
            e.Graphics.DrawString("Tổng cộng", new Font("Arial", 23, FontStyle.Regular), Brushes.Black, new Point(25, yPos + 50));
            double totalPrice1 = 0;
            foreach (var item in _billInfoCurrent)
            {
                var food1 = db.Foods.Find(item.IdFood);
                totalPrice1 += item.Count * food1.Price;
            }
            e.Graphics.DrawString(totalPrice1.ToString(), new Font("Arial", 23, FontStyle.Regular), Brushes.Black, new Point(650, yPos + 50));

            e.Graphics.DrawString("Giảm giá", new Font("Arial", 23, FontStyle.Regular), Brushes.Black, new Point(25, yPos + 100));
            var discount = db.Bills.FirstOrDefault(c => c.Id == idWhenClick).Discount;
            e.Graphics.DrawString(discount.ToString() + " %", new Font("Arial", 23, FontStyle.Regular), Brushes.Black, new Point(650, yPos + 100));

            var temp = dgvBill.Rows[rowIndex].Cells["TổngHóaĐơn"].Value.ToString();
            
            //var temp = (double.Parse(txbTotal.Text.Split(" ")[0])).ToString();
            temp = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", double.Parse(temp)) + "  ₫";

            e.Graphics.DrawString("Thanh toán", new Font("Arial", 23, FontStyle.Regular), Brushes.Black, new Point(25, yPos + 150));
            e.Graphics.DrawString(temp, new Font("Arial", 23, FontStyle.Regular), Brushes.Black, new Point(650, yPos + 150));

            e.Graphics.DrawString("Thankyou, See you again", new Font("Arial", 25, FontStyle.Regular), Brushes.Peru, new Point(250, yPos + 200));

            e.Graphics.DrawString("Mã hóa đơn: " + _billCurrent.Id, new Font("Arial", 23, FontStyle.Regular), Brushes.Black, new Point(250, yPos + 250));
        }
    }
}
