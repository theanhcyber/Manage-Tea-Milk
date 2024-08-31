using Microsoft.EntityFrameworkCore;
using QuanLyQuanTraSua.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.Dao
{
    public class FoodDao
    {
        private static FoodDao instance;
        private QuanLyQuanTraSuaContext con = new QuanLyQuanTraSuaContext();
        private FoodDao() { }

        public static FoodDao Instance {
            get
            {
                if (instance == null)
                {
                    instance = new FoodDao();
                }
                return instance;
            }
            set => instance = value;
        }
        public List<Food> getAllFood()
        {
            List<Food> listFood = con.Foods.Include(x => x.IdCategoryNavigation).ToList();
            return listFood;
        }
        public List<Food> getFoodByCategory(int categoryId)
        {
            List<Food> listfood = con.Foods.Include(x => x.IdCategoryNavigation).Where(x => x.IdCategory == categoryId).ToList();
            return listfood;
        }
        public Food getFoodByid(int id)
        {
            Food f = con.Foods.Include(f => f.IdCategoryNavigation).First(x => x.IdFood == id);
            return f;
        }
        public List<Food> getListFoodByName(string name)
        {
            List<Food> list = new List<Food>();
            try
            {
                list = con.Foods.Include(p => p.IdCategoryNavigation).Where(x => x.NameFood.Contains(name)).ToList();
            } catch (Exception ex)
            {
                list = null;
            }
            return list;
        }
        public int updateFood(Food food)
        {
            Food list = null;
            int count = 0;
            try
            {
                list = con.Foods.First(x => x.NameFood.Equals(food.NameFood));
            } catch (Exception ex)
            {
                list = null;
            }

            if (list == null)
            {
                con.Foods.Update(food);
                count = con.SaveChanges();
            }
            return count;
        }
        public int addFood(Food food)
        {

            Food list = null;
            int count = 0;
            try
            {
                list = con.Foods.First(x => x.NameFood.Equals(food.NameFood));
            }
            catch (Exception ex)
            {
                list = null;
            }

            if (list == null)
            {
                con.Foods.Add(food);
                count = con.SaveChanges();
            }
            return count;
        }
        public int removeFood(Food f)
        {
            int count = 0; 
            try
            {
                con.Foods.Remove(f);
                count = con.SaveChanges();
            }
            catch(Exception ex) 
            { 
            count = 0;
            }
                
            
            return count;
        }
    }
}
