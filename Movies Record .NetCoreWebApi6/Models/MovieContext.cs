using Microsoft.EntityFrameworkCore;

namespace Movies_Record_.NetCoreWebApi6.Models
{
    public class MovieContext: DbContext
    {

        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        DbSet<Movie> Movies { get; set; } = null!;
    }
}
