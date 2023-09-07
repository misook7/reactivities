using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        // reference Activities table in db
        public DbSet<Activity> Activities { get; set; }
        

    }
}