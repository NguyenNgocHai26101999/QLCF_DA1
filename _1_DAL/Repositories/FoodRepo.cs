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
    public class FoodRepo : IFoodRepo
    {
        private QLCF_DA1Context DB;
        private List<Food> _LstFood;
        public FoodRepo()
        {
            DB = new QLCF_DA1Context();
            _LstFood = new List<Food>();
        }
        public bool CreateFood(Food food)
        {
            try
            {
                DB.Foods.Add(food);
                DB.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteFood(Food food)
        {
            try
            {
                DB.Foods.Remove(food);
                DB.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Food> GetFoodFromDB()
        {
            return DB.Foods.AsNoTracking().ToList();
        }

        public bool UpdateFood(Food food)
        {
            try
            {
                DB.Foods.Update(food);
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
