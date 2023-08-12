using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface IFoodCategoryRepo
    {
        public List<FoodCategory> GetFoodCategoriesFromDB();
        public bool CreateFoodCategory(FoodCategory category);
        public bool UpdateFoodCategory(FoodCategory category);
        public bool DeleteFoodCategory(FoodCategory category);
    }
}
