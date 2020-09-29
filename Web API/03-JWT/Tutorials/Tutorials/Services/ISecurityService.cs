using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorials.Models;

namespace Tutorials.Services
{
    public interface ISecurityService
    {
        bool VerifyUserPassword(User user,string Password);
        JwtResponse IssueJwtToken(User user);
    }
}
