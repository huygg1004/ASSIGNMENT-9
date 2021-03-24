using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3_Movie.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            MoviesContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<MoviesContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Movies.Any())
            {
                context.Movies.AddRange(

                    new Movies
                    {
                        Category = "Action",
                        Title = "Spiderman HomeComing",
                        Year = "2017",
                        Director = "Jon Watts",
                        Rating = "PG-13",
                        Edited = true,
                        LentTo = "Huy Doan",
                        Notes = "This is one of the best Spiderman movie ever"
                    },
                     new Movies
                     {
                         Category = "Action",
                         Title = "Avengers Infinity War",
                         Year = "2018",
                         Director = "The Russo Brothers",
                         Rating = "PG-13",
                         Edited = true,
                         LentTo = "John Kennedy",
                         Notes = "The best avengers Movies"
                     }
                    );

                //save all changes
                context.SaveChanges();
            }
        }
    }
}
