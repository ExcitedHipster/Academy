using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorials.Helpers;
using Tutorials.Models;

namespace Tutorials.Data
{
    public class DbInitializer : IDbInitializer
    {
        private readonly AppDbContext _context;

        public DbInitializer(AppDbContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            _context.Database.EnsureCreated();

            var user = _context.Users.SingleOrDefault(x => x.UserName =="Saba");

            if (user != null) return;

            _context.Users.Add(
                new User { UserName = "Saba", HashedPassword = "very_secure_password".Hash() }
                );
            _context.Cars.AddRange(
                new Car { Name = "Merzzz", Age = 1980, MaxSpeed = 265, Mileage = 1234124 },
                new Car { Name = "BMVV", Age = 1977, MaxSpeed = 156, Mileage = 2342324 },
                new Car { Name = "Oudi", Age = 1999, MaxSpeed = 444, Mileage = 435354 },
                new Car { Name = "Apel", Age = 1997, MaxSpeed = 234, Mileage = 9087098 }
                );

            _context.SaveChanges();
        }
    }
}
