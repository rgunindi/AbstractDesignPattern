using FurnitureApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace FurnitureApp.Context
{
    public sealed class FakeDbContext : DbContext
    {
        public DbSet<Chair> Chairs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("FurnitureDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chair>()
                .HasData(
                    new Chair
                    {
                        Id = Guid.NewGuid(), Name = "Modern Chair", Price = 100m,
                        Description = "A modern chair with four legs."
                    },
                    new Chair
                    {
                        Id = Guid.NewGuid(), Name = "Victorian Chair", Price = 200m,
                        Description = "A Victorian chair with six legs."
                    }
                );
        }
    }
}