using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class CategoryDAO
    {
        //Using Singleton Pattern
        private static CategoryDAO instance = null;
        private static readonly object instanceLock = new object();
        public static CategoryDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                    }
                    instance = new CategoryDAO();
                    return instance;
                }
            }
        }
        public IEnumerable<Category> GetCategoryList()
        {
            var Categorys = new List<Category>();
            try
            {
                using var context = new SmartketContext();
                Categorys = context.Categories.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Categorys;
        }
        //
        public Category GetCategoryByID(int CategoryID)
        {
            Category Category = null;
            try
            {
                using var context = new SmartketContext();
                Category = context.Categories.SingleOrDefault(c => c.CategoryId == CategoryID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Category;
        }
        public int GetCategoryIDByName(string CategoryName)
        {
            Category Category = null;
            try
            {
                using var context = new SmartketContext();
                Category = context.Categories.SingleOrDefault(c => c.CategoryName == CategoryName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Category.CategoryId;
        }
        public void AddNew(Category Category)
        {
            try
            {
                Category _Category = GetCategoryByID(Category.CategoryId);
                if (_Category == null)
                {
                    using var context = new SmartketContext(); context.Categories.Add(Category);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Category is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //
        public void Update(Category Category)
        {
            try
            {
                Category _Category = GetCategoryByID(Category.CategoryId);
                if (_Category != null)
                {
                    using var context = new SmartketContext(); context.Categories.Update(Category); context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Category does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Remove(int CategoryID)
        {
            try
            {
                Category car = GetCategoryByID(CategoryID);
                if (car != null)
                {
                    using var context = new SmartketContext();
                    context.Categories.Remove(car);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Category does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//end Remove
    }
}
