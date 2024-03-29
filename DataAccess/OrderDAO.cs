using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class OrderDAO
    {
        //Using Singleton Pattern
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                    }
                    instance = new OrderDAO();
                    return instance;
                }
            }
        }
        public IEnumerable<Order> GetOrderList()
        {
            var Orders = new List<Order>();
            try
            {
                using var context = new SmartketContext();
                Orders = context.Orders.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Orders;
        }
        //
        public Order GetOrderByID(int OrderID)
        {
            Order Order = null;
            try
            {
                using var context = new SmartketContext();
                Order = context.Orders.SingleOrDefault(c => c.OrderId == OrderID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Order;
        }
        public void AddNew(Order Order)
        {
            try
            {
                Order _Order = GetOrderByID(Order.OrderId);
                if (_Order == null)
                {
                    using var context = new SmartketContext(); context.Orders.Add(Order);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Order is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //
        public void Update(Order Order)
        {
            try
            {
                Order _Order = GetOrderByID(Order.OrderId);
                if (_Order != null)
                {
                    using var context = new SmartketContext(); context.Orders.Update(Order); context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Order does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Remove(int OrderID)
        {
            try
            {
                Order car = GetOrderByID(OrderID);
                if (car != null)
                {
                    using var context = new SmartketContext();
                    context.Orders.Remove(car);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Order does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//end Remove
    }
}
