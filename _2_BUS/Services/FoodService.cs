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
    public class FoodService : IFoodService
    {
        private IFoodRepo _IFoodRepo;
        private List<Food> _LstFood;
        public FoodService()
        {
            _IFoodRepo = new FoodRepo();
            _LstFood = new List<Food>();
        }

        public bool CreateAccount(Food food)
        {
            _IFoodRepo.CreateFood(food);
            return true;
        }

        public bool DeleteAccount(Food food)
        {
            _IFoodRepo.DeleteFood(food);
            return true;
        }

        public List<Food> GetFoodFromDB()
        {
            return _IFoodRepo.GetFoodFromDB().ToList();
        }

        public bool UpdateAccount(Food food)
        {
            _IFoodRepo.UpdateFood(food);
            return true;
        }
    }
}
