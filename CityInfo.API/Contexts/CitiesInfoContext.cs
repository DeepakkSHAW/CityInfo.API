using CityInfo.API.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Contexts
{
    public class CitiesInfoContext : DbContext
    {
        public DbSet<Cities> cityInfos { get; set; }
        public CitiesInfoContext(DbContextOptions<CitiesInfoContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cities>().HasData(
            new Cities()
            {
                CityID = 1,
                CityName = "Calcutta",
                ShortDescription = "some description",
                CountryID = 1
            },
            new Cities()
            {
                   CityID = 2,
                   CityName = "Melbourne",
                   ShortDescription = "Melbourne description",
                   CountryID = 2
            },
            new Cities()  { CityID = 3, CityName = "Tula", ShortDescription = "Tula description",   CountryID = 3}
           );

            modelBuilder.Entity<Countries>().HasData
                (
                new Countries { CountryID = 1, CountryName = "India", SomeDetails ="Empty" },
                new Countries { CountryID = 2, CountryName = "Australia", SomeDetails = "Empty" },
                new Countries { CountryID = 3, CountryName = "Russia", SomeDetails = "Empty" }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
