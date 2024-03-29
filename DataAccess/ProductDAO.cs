using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class ProductDAO
    {
        //Using Singleton Pattern
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                    }
                    instance = new ProductDAO();
                    return instance;
                }
            }
        }
        public IEnumerable<Product> GetProductList()
        {
            var Products = new List<Product>();
            try
            {
                using var context = new SmartketContext();
                Products = context.Products.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Products;
        }
        //
        public Product GetProductByID(int ProductID)
        {
            Product Product = null;
            try
            {
                using var context = new SmartketContext();
                Product = context.Products.SingleOrDefault(c => c.ProductId == ProductID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Product;
        }
        public void AddNew(Product Product)
        {
            try
            {
                Product _Product = GetProductByID(Product.ProductId);
                if (_Product == null)
                {
                    using var context = new SmartketContext(); context.Products.Add(Product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The product is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //
        public void Update(Product Product)
        {
            try
            {
                Product _Product = GetProductByID(Product.ProductId);
                if (_Product != null)
                {
                    using var context = new SmartketContext(); context.Products.Update(Product); context.SaveChanges();
                }
                else
                {
                    throw new Exception("The product does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Remove(int ProductID)
        {
            try
            {
                Product car = GetProductByID(ProductID);
                if (car != null)
                {
                    using var context = new SmartketContext();
                    context.Products.Remove(car);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The product does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//end Remove
    }
}
