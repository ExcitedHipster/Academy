using Planner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planner.Services.Interfaces
{
    public interface IAuthService
    {
        bool IsUserValid(User user, out string token);

        bool IsTokenValid(string token);
    }
}
