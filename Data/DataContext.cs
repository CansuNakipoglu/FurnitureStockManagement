using FurnitureStockManagement.Entities;
using Microsoft.EntityFrameworkCore;

namespace FurnitureStockManagement.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stock>().ToTable("Stocks", "Inventory");
            modelBuilder.Entity<Item>().ToTable("Items", "Inventory");
            modelBuilder.Entity<Color>().ToTable("Colors", "Master");
            modelBuilder.Entity<User>().ToTable("Users", "Master");
        }

    }
}