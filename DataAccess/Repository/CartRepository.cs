using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CartRepository : ICartRepository
    {
        public void DeleteCart(int UserID)
        {
            CartDAO.Instance.Remove(UserID);
        }

        public Cart GetCartByID(int UserID) => CartDAO.Instance.GetCartByID(UserID);

        public IEnumerable<Cart> GetCarts() => CartDAO.Instance.GetCartList();

        public void InsertCart(Cart Cart)
        {
            CartDAO.Instance.AddNew(Cart);
        }

        public void UpdateCart(Cart Cart)
        {
            CartDAO.Instance.Update(Cart);
        }
    }
}
