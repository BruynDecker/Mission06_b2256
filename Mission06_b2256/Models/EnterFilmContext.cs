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
        public DbSet<category> Categorys { get; set; }


        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<category>().HasData(
                new category { CategoryID = 1, CategoryName = "Action/Adventure" },
                new category { CategoryID = 2, CategoryName = "Comedy" },
                new category { CategoryID = 3, CategoryName = "Drama" },
                new category { CategoryID = 4, CategoryName = "Family" },
                new category { CategoryID = 5, CategoryName = "Horror/Suspense" },
                new category { CategoryID = 6, CategoryName = "miscellaneous" },
                new category { CategoryID = 7, CategoryName = "Television" },
                new category { CategoryID = 8, CategoryName = "VHS" }
                );
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    FilmID = 1,
                    CategoryID = 4,
                    Title = "Nim's Island",
                    Year = 2006,
                    Director = "Brendan Maher, Mark Levin, Jennifer Flackett",
                    Rating = "PG",
                    Edited = false
                },
                new ApplicationResponse
                {
                    FilmID = 2,
                    CategoryID = 6,
                    Title = "Star Wars: Rise of the Assassins",
                    Year = 2014,
                    Director = "Bruyn Decker, Luke Maas, Spencer Lyman",
                    Rating = "NR",
                    LentTo = "Bruyn's Parents",
                    Notes = "A silly homemade film I [Bruyn] made with my cousins at a family reunion"
                },
                new ApplicationResponse
                {
                    FilmID = 3,
                    CategoryID = 1,
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
