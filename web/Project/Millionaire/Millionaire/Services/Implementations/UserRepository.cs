
using Millionaire.Filters;
using Millionaire.Models;
using Millionaire.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Millionaire.Services.Implementations {
    public class UserRepository : IRepository<User> {
        private List<User> _users = new List<User>
        {
            new User{UserName="admin", Password=Sha1Helper.HashPassword("admin"+constants.Salt)}
        };

        public void Add(User user) {
            _users.Add(user);
        }

        public IEnumerable<User> GetAll() {
            return _users;
        }

        public void Save() {
            throw new NotImplementedException();
        }

        public void Update(User item) {
            throw new NotImplementedException();
        }
    }
}
