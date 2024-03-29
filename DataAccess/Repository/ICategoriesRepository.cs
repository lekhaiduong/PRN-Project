using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ICategoriesRepository
    {
        IEnumerable<Category> GetCategorys();
        Category GetCategoryByID(int CategoryID);
        void InsertCategory(Category Category);
        void DeleteCategory(int CategoryID);
        void UpdateCategory(Category Category);
         int GetCategoryIDByName(string Name);
    }
}
