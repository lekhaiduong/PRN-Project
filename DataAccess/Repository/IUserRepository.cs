using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        User GetUserByID(int UserID);
        void InsertUser(User user);
        void DeleteUser(int UserID);
        void UpdateUser(User user);

    }
}
