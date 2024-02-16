using Microsoft.EntityFrameworkCore;

namespace Mission06_Koelliker.Models
{
    public class MyMoviesContext : DbContext
    {
        public MyMoviesContext(DbContextOptions<MyMoviesContext> options) : base (options) 
        { 

        }
        public DbSet<Movies> Movies { get; set; }
    }
}
