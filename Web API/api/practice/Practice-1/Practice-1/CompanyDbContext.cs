using Microsoft.EntityFrameworkCore;
using Practice_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_1
{
    public class CompanyDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Emploies { get; set; }

        public CompanyDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasKey(x => x.Id);
            modelBuilder.Entity<Company>()
                .Property(c => c.Name)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Employee>().HasKey(x => x.Id);
            modelBuilder.Entity<Employee>()
                .Property(c => c.Name)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<Employee>()
                .Property(c => c.Email)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<Employee>()
                .Property(c => c.Phone)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<Employee>()
                 .Property(c => c.CompanyId)
                 .IsRequired();

            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "TBC"
                }
            );
            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 2,
                    Name = "Bank of Georgia"
                }
            );
            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 3,
                    Name = "Dunder mifflin"
                }
            );
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Gigi",
                    Email = "gigi10@gmail.com",
                    Phone = "995-75-75-75",
                    CompanyId = 1
                }
            );
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 2,
                    Name = "Lika",
                    Email = "Lika_lika@gmail.com",
                    Phone = "456-35-23-43",
                    CompanyId = 1
                }
            );
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 3,
                    Name = "Tekla",
                    Email = "Tekla-Tek-Tek@gmail.com",
                    Phone = "123-12-32-44",

                    CompanyId = 3
                }
            );
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 4,
                    Name = "Pam",
                    Email = "Pam@gmail.com",
                    Phone = "234156454",
                    CompanyId = 1
                }
            );
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 5,
                    Name = "Andrii",
                    Email = "Andrii@gmail.com",
                    Phone = "1234-234-234",
                    CompanyId = 4
                }
            );
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 6,
                    Name = "Sergii",
                    Email = "Sergii@gmail.com",
                    Phone = "123-544-123",
                    CompanyId = 4
                }
            );
        }
    }
}
