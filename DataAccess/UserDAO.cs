using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class UserDAO
    {
        //Using Singleton Pattern
        private static UserDAO instance = null;
        private static readonly object instanceLock = new object();
        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                    }
                    instance = new UserDAO();
                    return instance;
                }
            }
        }
        public IEnumerable<User> GetUserList()
        {
            var Users = new List<User>();
            try
            {
                using var context = new SmartketContext();
                Users = context.Users.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Users;
        }
        //
        public User GetUserByID(int UserID)
        {
            User User = null;
            try
            {
                using var context = new SmartketContext();
                User = context.Users.SingleOrDefault(c => c.UserId == UserID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return User;
        }
        public void AddNew(User User)
        {
            try
            {
                User _User = GetUserByID(User.UserId);
                if (_User == null)
                {
                    using var context = new SmartketContext(); context.Users.Add(User);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The User is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //
        public void Update(User User)
        {
            try
            {
                User _User = GetUserByID(User.UserId);
                if (_User != null)
                {
                    using var context = new SmartketContext(); context.Users.Update(User); context.SaveChanges();
                }
                else
                {
                    throw new Exception("The User does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Remove(int UserID)
        {
            try
            {
                User car = GetUserByID(UserID);
                if (car != null)
                {
                    using var context = new SmartketContext();
                    context.Users.Remove(car);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The User does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//end Remove
    }
}
