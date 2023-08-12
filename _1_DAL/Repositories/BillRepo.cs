using _1_DAL.IRepositories;
using _1_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repositories
{
    public class BillRepo : IbillRepo
    {
        private QLCF_DA1Context DB;
        public BillRepo()
        {
            DB = new QLCF_DA1Context();
        }
        public bool CreateBill(Bill bill)
        {
            try
            {
                DB.Bills.Add(bill);
                DB.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteBill(Bill bill)
        {
            try
            {
                DB.Bills.Remove(bill);
                DB.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Bill> GetBillFromDB()
        {
            return DB.Bills.AsNoTracking().ToList();
        }

        public bool UpdateBill(Bill bill)
        {
            try
            {
                DB.Bills.Update(bill);
                DB.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


    }
}
