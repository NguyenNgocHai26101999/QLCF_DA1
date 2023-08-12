using _1_DAL.IRepositories;
using _1_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repositories
{
    public class BillInfoRepo : IBillInfoRepo
    {
        private QLCF_DA1Context DB;
        public BillInfoRepo()
        {
            DB = new QLCF_DA1Context();
        }

        public bool CreateBillInfo(BillInfo billInfo)
        {
            try
            {
                DB.BillInfos.Add(billInfo);
                DB.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteBillInfo(BillInfo billInfo)
        {
            try
            {
                DB.BillInfos.Remove(billInfo);
                DB.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<BillInfo> GetBillInfoFromDB()
        {
            return DB.BillInfos.AsNoTracking().ToList();
        }

        public bool UpdateBillInfo(BillInfo billInfo)
        {
            try
            {
                DB.BillInfos.Remove(billInfo);
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
