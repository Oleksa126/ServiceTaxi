using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceTaxi.Models;
using ServiceTaxiDAL.Interfaces;
using ServiceTaxi.Repository;

namespace ServiceTaxiDAL.Repository
{
    public class UserRepository : IUserRepository
    {

        private DataBaseContext _db;

        public UserRepository(DataBaseContext db)
        {
            _db = db;
        }

        public bool AddFeedback(Feedback feedback)
        {
            //_db.Users.(feedback);
            return true;
        }

        public bool CreateUser(User user)
        {
            _db.Users.Add(user);
            return true;
        }

        public User GetUser(int id)
        {
            return _db.Users.Find(id);
        }

        public bool UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
