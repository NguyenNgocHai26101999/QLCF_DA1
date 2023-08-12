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
    public class AccountRepo : IAccountRepo
    {
        private QLCF_DA1Context DB;
        private List<Account> _LstAccount;
        public AccountRepo()
        {
            DB = new QLCF_DA1Context();
            _LstAccount = new List<Account>();
        }
        public List<Account> GetAccountFromDB()
        {
            return DB.Accounts.AsNoTracking().ToList();
        }

        public bool CreateAccount(Account account)
        {
            try
            {
                DB.Accounts.Add(account);
                DB.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool UpdateAccount(Account account)
        {
            try
            {
                DB.Accounts.Update(account);
                DB.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteAccount(Account account)
        {
            try
            {
                DB.Accounts.Remove(account);
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
