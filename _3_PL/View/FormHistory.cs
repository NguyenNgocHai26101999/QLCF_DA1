using _1_DAL.Models;
using _2_BUS.Services;
using Microsoft.VisualBasic;
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
    public partial class FormHistory : Form
    {
        private BillService _billInfoService = new BillService();
        public FormHistory()
        {
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
    }
}
