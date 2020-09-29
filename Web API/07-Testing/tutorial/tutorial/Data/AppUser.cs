using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tutorial.Data
{
    public class AppUser : IdentityUser
    {
        public bool LikesPizza { get; set; }

    }
}
