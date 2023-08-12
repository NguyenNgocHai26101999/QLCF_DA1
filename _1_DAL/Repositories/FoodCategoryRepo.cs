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
    public class FoodCategoryRepo : IFoodCategoryRepo
    {
        private QLCF_DA1Context DB;
        private List<FoodCategory> _LstFoodCategory;
        public FoodCategoryRepo()
        {
            DB = new QLCF_DA1Context();
            _LstFoodCategory = new List<FoodCategory>();
        }
        public bool CreateFoodCategory(FoodCategory category)
        {
            try
            {
                DB.FoodCategories.Add(category);
                DB.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteFoodCategory(FoodCategory category)
        {
            try
            {
                DB.FoodCategories.Remove(category);
                DB.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<FoodCategory> GetFoodCategoriesFromDB()
        {
            return DB.FoodCategories.AsNoTracking().ToList();
        }

        public bool UpdateFoodCategory(FoodCategory category)
        {
            try
            {
                DB.FoodCategories.Update(category);
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
