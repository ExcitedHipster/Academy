using CarRentals.Helper;
using CarRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentals.Services.Implementation
{
    public class UserRepository : IRepository<User>
    {
        private List<User> _users = new List<User>
        { 
            new User{UserName="admin", Password=Sha1Helper.HashPassword("admin"+Constants.Salt)}
        };

        public void Add(User user)
        {
            _users.Add(user);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public void Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
