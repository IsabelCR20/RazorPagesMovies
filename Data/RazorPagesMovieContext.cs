using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovies.Data
{
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext (
            DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovies.Models.Movie> Movie { get; set; }
    }
}