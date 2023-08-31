using System.Runtime.InteropServices.JavaScript;
using FurnitureApp.Entities;
using FurnitureApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FurnitureApp.Context
{
    public sealed class FakeDbContext : DbContext
    {
        public DbSet<Chair> Chairs { get; set; }

        public FakeDbContext(DbContextOptions<FakeDbContext> options) : base(options)
        {
        }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("FurnitureDb");
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chair>()
                .HasData(
                    new Chair
                    {
                        Id = new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                        Name = "string",
                        Price = 0,
                        Description = "string",
                        ModelType = modelType.Modern
                    },
                    new Chair
                    {
                        Id = new Guid("56fef782-cbd2-4bb8-9af3-42b01879bf49"),
                        Name = "Victorian Chair",
                        Price = 200m,
                        Description = "A Victorian chair with six legs.",
                        ModelType = modelType.Victorian
                    }
                );
        }
    }
}