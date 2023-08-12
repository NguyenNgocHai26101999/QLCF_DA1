using _1_DAL.IRepositories;
using _1_DAL.Models;
using _1_DAL.Repositories;
using _2_BUS.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Services
{
    public class BillService : IBillService
    {
        private IbillRepo _IbillRepo;
        public BillService()
        {
            _IbillRepo = new BillRepo();
        }
        public bool CreateBill(Bill bill)
        {
            _IbillRepo.CreateBill(bill);
            return true;
        }

        public bool DeleteBill(Bill bill)
        {
            _IbillRepo.DeleteBill(bill);
            return true;
        }

        public List<Bill> GetBillFromDB()
        {
            return _IbillRepo.GetBillFromDB().ToList();
        }

        public bool UpdateBill(Bill bill)
        {
            _IbillRepo.UpdateBill(bill);
            return true;
        }
    }
}
