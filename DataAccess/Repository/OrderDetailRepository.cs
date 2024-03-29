using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailDetailRepository : IOrderDetailRepository
    {
        public void DeleteOrderDetail(int OrderDetailID, int ProductID)
        {
            OrderDetailDAO.Instance.Remove(OrderDetailID, ProductID);
        }

        public IEnumerable<OrderDetail>
            GetOrderDetailByID(int OrderDetailID) => OrderDetailDAO.Instance.GetOrderDetailByID(OrderDetailID);

        public IEnumerable<OrderDetail> GetOrderDetails() => OrderDetailDAO.Instance.GetOrderDetailList();

        public OrderDetail GetOrderDetailByOrderIDAndProductID(int OrderID, int ProductID)
            => OrderDetailDAO.Instance.GetOrderDetailByOrderIDAndProductID(OrderID, ProductID);

        public void InsertOrderDetail(OrderDetail OrderDetail)
        {
            OrderDetailDAO.Instance.AddNew(OrderDetail);
        }

        public void UpdateOrderDetail(OrderDetail OrderDetail)
        {
            OrderDetailDAO.Instance.Update(OrderDetail);
        }

    }
}
