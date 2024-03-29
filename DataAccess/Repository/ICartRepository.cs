using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ICartRepository
    {
        IEnumerable<Cart> GetCarts();
        Cart GetCartByID(int UserID);
        void InsertCart(Cart Cart);
        void DeleteCart(int UserID);
        void UpdateCart(Cart Cart);
    }
}
