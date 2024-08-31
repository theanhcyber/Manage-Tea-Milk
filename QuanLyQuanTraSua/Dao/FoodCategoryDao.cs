using QuanLyQuanTraSua.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.Dao
{
    public class FoodCategoryDao
    {
        public FoodCategoryDao() { }
        private static FoodCategoryDao instance;
        private QuanLyQuanTraSuaContext con = new QuanLyQuanTraSuaContext();

        public static FoodCategoryDao Instance {
            get
            {
                if (instance == null)
                {
                    instance = new FoodCategoryDao();
                }
                return instance;
            }
                
            private set => instance = value; 
        }
        public List<FoodCategory> getAllCategoryFood()
        {
            List<FoodCategory> list = new List<FoodCategory>();
            list = con.FoodCategories.ToList();
            return list;
        }
        public int deleteFoodCategory(FoodCategory foodCategory)
        {
            int count = 0;
            try
            {
                con.FoodCategories.Remove(foodCategory);
                count = con.SaveChanges();
            }catch (Exception ex)
            {
                count = 0;
            }
            
            return count;
        }
        public int updateFoodCategory(FoodCategory category)
        {
            int count = 0;
            FoodCategory f = con.FoodCategories.First(x => x.NameCategory.Equals(category.NameCategory));
            if(f == null)
            {
                try
                {
                    con.FoodCategories.Update(category);
                    count = con.SaveChanges();
                }
                catch (Exception ex)
                {
                    count = 0;
                }
            }
            
            
            return count;
        }
        public int addFoodCategory(FoodCategory category)
        {
            int count = 0;
            FoodCategory f = con.FoodCategories.First(x => x.NameCategory.Equals(category.NameCategory));
            if(f == null)
            {
                con.FoodCategories.Add(category);
                count = con.SaveChanges();
            }
            
            return count;
        }
        public FoodCategory getFoodCategory(int id)
        {
            FoodCategory category = con.FoodCategories.Find(id);
            return category;
        }
        public FoodCategory getFoodCategoryByNameFull(string name)
        {
            FoodCategory f = con.FoodCategories.First(x => x.NameCategory.Equals(name));
            return f;
        }
    }
}
