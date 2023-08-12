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
    public class CategoryService : ICategoryService
    {
        private IFoodCategoryRepo _ICategoryRepo;
        public CategoryService()
        {
            _ICategoryRepo = new FoodCategoryRepo();
        }
        public bool CreateCategory(FoodCategory category)
        {
            _ICategoryRepo.CreateFoodCategory(category);
            return true;
        }

        public bool DeleteCategory(FoodCategory category)
        {
            _ICategoryRepo.DeleteFoodCategory(category);
            return true;
        }

        public List<FoodCategory> GetCategoryFromDB()
        {
            return _ICategoryRepo.GetFoodCategoriesFromDB().ToList();
        }

        public bool UpdateCategory(FoodCategory category)
        {
            _ICategoryRepo.UpdateFoodCategory(category);
            return true;
        }
    }
}
