using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Models
{
    public class RazorPagesContext : DbContext
    {
        public RazorPagesMovieContext(DbContextOptions<RazorPagesMovie> options) : base(options)
        {

        }

        public DbSet<RazorPagesMovie.Models.Moive> Moive { get; set; }
    }
}