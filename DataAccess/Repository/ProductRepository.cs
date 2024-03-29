using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void DeleteProduct(int ProductID)
        {
            ProductDAO.Instance.Remove(ProductID);
        }

        public Product GetProductByID(int ProductID) => ProductDAO.Instance.GetProductByID(ProductID);

        public IEnumerable<Product> GetProducts() => ProductDAO.Instance.GetProductList();

        public void InsertProduct(Product product)
        {
            ProductDAO.Instance.AddNew(product);
        }

        public void UpdateProduct(Product product)
        {
            ProductDAO.Instance.Update(product);
        }
    }
}
