using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    internal interface IOrderDetailRepository
    {
        IEnumerable<OrderDetail> GetOrderDetails();
        IEnumerable<OrderDetail> GetOrderDetailByID(int OrderID);
        OrderDetail GetOrderDetailByOrderIDAndProductID(int OrderID, int ProductID);
        void InsertOrderDetail(OrderDetail OrderDetail);
        void DeleteOrderDetail(int OrderID, int ProductID);
        void UpdateOrderDetail(OrderDetail OrderDetail);
    }
}
