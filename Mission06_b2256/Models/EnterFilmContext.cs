using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mission06_b2256.Models
{
    public class EnterFilmContext : DbContext
    {
        public EnterFilmContext(DbContextOptions<EnterFilmContext> options) : base(options)
        {
            //Leave blank for now
        }

        public DbSet<ApplicationResponse> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    ApplicationID = 1,
                    Category = "Family",
                    Title = "Nim's Island",
                    Year = 2006,
                    Director = "Brendan Maher, Mark Levin, Jennifer Flackett",
                    Rating = "PG",
                    Edited = false
                },
                new ApplicationResponse
                {
                    ApplicationID = 2,
                    Category = "Miscellaneous",
                    Title = "Star Wars: Rise of the Assassins",
                    Year = 2014,
                    Director = "Bruyn Decker, Luke Maas, Spencer Lyman",
                    Rating = "NR",
                    LentTo = "Bruyn's Parents",
                    Notes = "A silly homemade film I [Bruyn] made with my cousins at a family reunion"
                },
                new ApplicationResponse
                {
                    ApplicationID = 3,
                    Category = "Action/Adventure",
                    Title = "Casino Royale",
                    Year = 2006,
                    Director = "Martin Campbell",
                    Rating = "PG-13",
                    Notes = "The best Bond Film"
                }
            ); ; ;
        }
    }
}
