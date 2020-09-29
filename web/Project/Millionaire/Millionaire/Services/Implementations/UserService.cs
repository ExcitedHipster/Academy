
using Millionaire.Filters;
using Millionaire.Models;
using Millionaire.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Millionaire.Services.Implementations {
    public class UserService : IUserService {
        private readonly IRepository<User> _repository;
        public UserService(IRepository<User> Repository) {
            _repository = Repository;
        }
        public void Add(User user) {
            user.Password = Sha1Helper.HashPassword(user.Password + constants.Salt);
            _repository.Add(user);
        }


        public IEnumerable<User> GetAll() {
            return _repository.GetAll();
        }


    }
}
