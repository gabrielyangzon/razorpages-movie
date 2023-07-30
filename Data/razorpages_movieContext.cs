using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razorpages_movie.Models;

namespace razorpages_movie.Data
{
    public class razorpages_movieContext : DbContext
    {
        public razorpages_movieContext(DbContextOptions<razorpages_movieContext> options)
            : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("movie");
        }

        public DbSet<razorpages_movie.Models.Movie> Movie { get; set; } = default!;
    }
}
