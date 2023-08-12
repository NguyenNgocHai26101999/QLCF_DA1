using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IService
{
    public interface IBillService
    {
        public List<Bill> GetBillFromDB();
        public bool CreateBill(Bill bill);
        public bool UpdateBill(Bill bill);
        public bool DeleteBill(Bill bill);
    }
}
