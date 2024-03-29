using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class UserRepository: IUserRepository
    {
        public void DeleteUser(int UserID)
        {
            UserDAO.Instance.Remove(UserID);
        }

        public User GetUserByID(int UserID) => UserDAO.Instance.GetUserByID(UserID);

        public IEnumerable<User> GetUsers() => UserDAO.Instance.GetUserList();

        public void InsertUser(User User)
        {
            UserDAO.Instance.AddNew(User);
        }

        public void UpdateUser(User User)
        {
            UserDAO.Instance.Update(User);
        }
    }
}
