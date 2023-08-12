using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IService
{
    public interface ICategoryService
    {
        public List<FoodCategory> GetCategoryFromDB();
        public bool CreateCategory(FoodCategory category);
        public bool UpdateCategory(FoodCategory category);
        public bool DeleteCategory(FoodCategory category);
    }
}
