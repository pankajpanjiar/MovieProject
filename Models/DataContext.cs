using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Models
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {            
        }

        public DbSet<Movie> Movie { get; set; }
    }
}