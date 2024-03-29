using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class CartDAO
    {
        //Using Singleton Pattern
        private static CartDAO instance = null;
        private static readonly object instanceLock = new object();
        public static CartDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                    }
                    instance = new CartDAO();
                    return instance;
                }
            }
        }
        public IEnumerable<Cart> GetCartList()
        {
            var Carts = new List<Cart>();
            try
            {
                using var context = new SmartketContext();
                Carts = context.Carts.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Carts;
        }
        //
        public Cart GetCartByID(int? UserID)
        {
            Cart Cart = null;
            try
            {
                using var context = new SmartketContext();
                Cart = context.Carts.SingleOrDefault(c => c.UserId == UserID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Cart;
        }
        public void AddNew(Cart Cart)
        {
            try
            {
                Cart _Cart = GetCartByID(Cart.UserId);
                if (_Cart == null)
                {
                    using var context = new SmartketContext(); context.Carts.Add(Cart);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Cart is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //
        public void Update(Cart Cart)
        {
            try
            {
                Cart _Cart = GetCartByID(Cart.UserId);
                if (_Cart != null)
                {
                    using var context = new SmartketContext(); context.Carts.Update(Cart); context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Cart does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Remove(int CartID)
        {
            try
            {
                Cart car = GetCartByID(CartID);
                if (car != null)
                {
                    using var context = new SmartketContext();
                    context.Carts.Remove(car);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Cart does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//end Remove
    }
}
