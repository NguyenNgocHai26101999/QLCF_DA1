using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IService
{
    public interface IFoodService
    {
        public List<Food> GetFoodFromDB();
        public bool CreateAccount(Food food);
        public bool DeleteAccount(Food food);
        public bool UpdateAccount(Food food);
    }
}
