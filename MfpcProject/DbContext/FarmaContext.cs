using Microsoft.EntityFrameworkCore;

namespace MfpcProject.Models
{
    public class FarmaContext : DbContext
    {
        public FarmaContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Application> Applications { get; set; }
        public DbSet<Calibrator> Calibrators { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Lot> Lots { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>().ToTable("Application");
            modelBuilder.Entity<Calibrator>().ToTable("Calibrator");
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Lot>().ToTable("Lot");
        }
    }
}
