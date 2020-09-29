using Millionaire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Millionaire.Services.Interfaces {
        public interface IAuthService {
            bool IsUserValid(User user, out string token);
            bool isTokenValid(string token);
        }
}
