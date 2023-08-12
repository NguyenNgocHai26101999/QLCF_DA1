using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface IBillInfoRepo
    {
        public List<BillInfo> GetBillInfoFromDB();
        public bool CreateBillInfo(BillInfo billInfo);
        public bool UpdateBillInfo(BillInfo billInfo);
        public bool DeleteBillInfo(BillInfo billInfo);
    }
}
