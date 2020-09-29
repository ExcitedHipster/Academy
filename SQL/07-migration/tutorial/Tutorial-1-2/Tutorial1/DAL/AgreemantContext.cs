using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial1.Models;

namespace Tutorial1.DAL
{
    public class AgreemantContext : DbContext
    {
        public DbSet<Agreemant> Agreemants { get; set; }
        public DbSet<Agreemant> Universities { get; set; }


        public AgreemantContext()
        {
            Database.EnsureCreated();
        }
        public AgreemantContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuiilder)
        {
            modelBuiilder.Entity<Agreemant>().HasKey(x => x.Id);
            modelBuiilder.Entity<University>().HasKey(x => x.Id);

            modelBuiilder.Entity<AgreemantUniversity>().HasKey(x => 
                         new { x.AgreemantId, x.UniversityId });//composite key

            modelBuiilder.Entity<AgreemantUniversity>().HasOne(x => x.Agreemant)
                .WithMany(x => x.AgreemantUniversities)
                .HasForeignKey(x => x.UniversityId);


            modelBuiilder.Entity<AgreemantUniversity>().HasOne(x => x.University)
                .WithMany(x => x.AgreemantUniversities)
                .HasForeignKey(x => x.AgreemantId);

            modelBuiilder.Entity<University>().HasData
                (
                 new University { Id = 1, Name = "Ivane Javakhishvili Tbilisi State University" },
                  new University { Id = 2, Name = "Tbilisi Independent University" },
                  new University { Id = 3, Name = "Tbilisi State Medical University" },
                   new University { Id = 4, Name = "Caucasus University" }



                );
        }
    }
}
