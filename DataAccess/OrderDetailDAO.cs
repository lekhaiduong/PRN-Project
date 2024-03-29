using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class OrderDetailDAO
    {
        //Using Singleton Pattern
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                    }
                    instance = new OrderDetailDAO();
                    return instance;
                }
            }
        }
        public IEnumerable<OrderDetail> GetOrderDetailList()
        {
            var OrderDetails = new List<OrderDetail>();
            try
            {
                using var context = new SmartketContext();
                OrderDetails = context.OrderDetails.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return OrderDetails;
        }
        //
        public IEnumerable<OrderDetail> GetOrderDetailByID(int OrderID)
        {
            var OrderDetails = new List<OrderDetail>();
            try
            {
                using var context = new SmartketContext();
                OrderDetails = context.OrderDetails
                    .Where(x=>x.OrderId == OrderID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return OrderDetails;
            ;
        }
        public OrderDetail GetOrderDetailByOrderIDAndProductID(int? OrderID, int? ProductID)
        {
            OrderDetail OrderDetail = null;
            try
            {
                using var context = new SmartketContext();
                OrderDetail = context.OrderDetails.SingleOrDefault(c => c.OrderId == OrderID && c.ProductId == ProductID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return OrderDetail;
        }
        public void AddNew(OrderDetail OrderDetail)
        {
            try
            {
                OrderDetail _OrderDetail = 
                    GetOrderDetailByOrderIDAndProductID(OrderDetail.OrderId
                    , OrderDetail.ProductId);
                if (_OrderDetail == null)
                {
                    using var context = new SmartketContext(); context.OrderDetails.Add(OrderDetail);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The OrderDetail is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //
        public void Update(OrderDetail OrderDetail)
        {
            try
            {
                OrderDetail _OrderDetail = 
                    GetOrderDetailByOrderIDAndProductID(OrderDetail.OrderId, OrderDetail.ProductId);
                if (_OrderDetail != null)
                {
                    using var context = new SmartketContext(); context.OrderDetails.Update(OrderDetail); context.SaveChanges();
                }
                else
                {
                    throw new Exception("The OrderDetail does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Remove(int OrderDetailID, int ProductID)
        {
            try
            {
                OrderDetail car = GetOrderDetailByOrderIDAndProductID(OrderDetailID, ProductID);
                if (car != null)
                {
                    using var context = new SmartketContext();
                    context.OrderDetails.Remove(car);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The OrderDetail does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//end Remove
    }
}
