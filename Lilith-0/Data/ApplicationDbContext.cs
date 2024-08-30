using Lilith_0.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lilith_0.Data
{
    public class ApplicationDbContext : DbContext
    {
        //Entities
        public DbSet<Course> Courses { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Entity configuration
        }
    }
}
