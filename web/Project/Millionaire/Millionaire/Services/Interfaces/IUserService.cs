using Millionaire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Millionaire.Services.Interfaces {
    public interface IUserService {
        IEnumerable<User> GetAll();
        void Add(User user);
    }
}
