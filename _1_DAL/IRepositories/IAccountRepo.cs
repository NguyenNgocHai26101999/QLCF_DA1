using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface IAccountRepo
    {
        public List<Account> GetAccountFromDB();
        public bool CreateAccount(Account account);
        public bool UpdateAccount(Account account);
        public bool DeleteAccount(Account account);
    }
}
