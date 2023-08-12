using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface IFoodRepo
    {
        public List<Food> GetFoodFromDB();
        public bool CreateFood(Food food);
        public bool UpdateFood(Food food);
        public bool DeleteFood(Food food);
    }
}
