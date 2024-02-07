using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppAPIAssessment.Models;

namespace WebAppAPIAssessment.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext (DbContextOptions<MovieDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppAPIAssessment.Models.Movie> Movie { get; set; } = default!;
    }
}
