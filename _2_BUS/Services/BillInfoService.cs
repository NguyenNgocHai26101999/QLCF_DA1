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
    public class BillInfoService : IBillInfoService
    {
        private IBillInfoRepo _IbillInfoRepo;
        public BillInfoService()
        {
            _IbillInfoRepo = new BillInfoRepo();
        }

        public bool CreateBillInfo(BillInfo billInfo)
        {
            _IbillInfoRepo.CreateBillInfo(billInfo);
            return true;
        }

        public bool DeleteBillInfo(BillInfo billInfo)
        {
            _IbillInfoRepo.DeleteBillInfo(billInfo);
            return true;
        }

        public List<BillInfo> GetBillInfoFromDB()
        {
            return _IbillInfoRepo.GetBillInfoFromDB().ToList();
        }

        public bool UpdateBillInfo(BillInfo billInfo)
        {
            _IbillInfoRepo.UpdateBillInfo(billInfo);
            return true;
        }
    }
}
