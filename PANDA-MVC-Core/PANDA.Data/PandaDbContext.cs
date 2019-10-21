using Microsoft.EntityFrameworkCore;
using PANDA.Models;

namespace PANDA.Data
{
    public class PandaDbContext : DbContext
    {
        public PandaDbContext(DbContextOptions<PandaDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Receipt> Receipt { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Package> Packages { get; set; }

        public DbSet<PackageStatus> PackageStatuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Admin" },
                new Role { Id = 2, Name = "User" }
                );

            modelBuilder.Entity<PackageStatus>().HasData(
                new PackageStatus { Id = 1, Name = "Pending" },
                new PackageStatus { Id = 2, Name = "Shipped" },
                new PackageStatus { Id = 3, Name = "Delivered" },
                new PackageStatus { Id = 4, Name = "Acquired" }
                );
        }
    }
}
