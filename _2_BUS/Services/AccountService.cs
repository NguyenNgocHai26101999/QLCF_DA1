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
    public class AccountService : IAccountService
    {
        private IAccountRepo _IAccountRepo;
        private List<Account> _LstAccount;
        public AccountService()
        {
            _IAccountRepo = new AccountRepo();
            _LstAccount = new List<Account>();
        }
        public bool CreateAccount(Account account)
        {
            _IAccountRepo.CreateAccount(account);
            return true;
        }

        public bool DeleteAccount(Account account)
        {
            _IAccountRepo.DeleteAccount(account);
            return true;
        }

        public List<Account> GetAccountFromDB()
        {
            return _IAccountRepo.GetAccountFromDB().ToList();
        }

        public bool UpdateAccount(Account account)
        {
            _IAccountRepo.UpdateAccount(account);
            return true;
        }
    }
}
