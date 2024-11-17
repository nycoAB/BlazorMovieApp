using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;
using MovieApp.Models;

namespace MovieApp.Data
{
    public class MovieAppContext : DbContext
    {
        public MovieAppContext (DbContextOptions<MovieAppContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().HasData
                (
                new Movie
                {
                    Id = 1,
                    Title = "Mad Max",
                    Genre = "Sci-fi (Cyberpunk)",
                    ReleaseDate = new DateOnly(1979, 4, 12) ,
                    Price = 2.51M,
                },
                
                new Movie
                {
                    Id= 2,
                    Title = "Mad Max: Fury Road",
                    ReleaseDate = new DateOnly(2015, 5, 15),
                    Genre = "Sci-fi (Cyberpunk)",
                    Price = 8.43M
                });
        }
    }
}
