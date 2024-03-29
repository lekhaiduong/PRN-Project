using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void DeleteOrder(int OrderID)
        {
            OrderDAO.Instance.Remove(OrderID);
        }

        public Order GetOrderByID(int OrderID) => OrderDAO.Instance.GetOrderByID(OrderID);

        public IEnumerable<Order> GetOrders() => OrderDAO.Instance.GetOrderList();

        public void InsertOrder(Order Order)
        {
            OrderDAO.Instance.AddNew(Order);
        }

        public void UpdateOrder(Order Order)
        {
            OrderDAO.Instance.Update(Order);
        }
    }
}
