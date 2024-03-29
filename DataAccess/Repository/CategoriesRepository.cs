using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CategoriesRepository : ICategoriesRepository
    {
        public void DeleteCategory(int CategoryID)
        {
            CategoryDAO.Instance.Remove(CategoryID);
        }

        public Category GetCategoryByID(int CategoryID) => CategoryDAO.Instance.GetCategoryByID(CategoryID);

        public int GetCategoryIDByName(string Name)
        {
            return CategoryDAO.Instance.GetCategoryIDByName(Name);
        }

        public IEnumerable<Category> GetCategorys() => CategoryDAO.Instance.GetCategoryList();

        public void InsertCategory(Category Category)
        {
            CategoryDAO.Instance.AddNew(Category);
        }

        public void UpdateCategory(Category Category)
        {
            CategoryDAO.Instance.Update(Category);
        }
    }
}
