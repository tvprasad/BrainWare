using BrainWare.Data.Library.Models;
using Microsoft.EntityFrameworkCore;

namespace BrainWare.Data.Library
{
    public class DBContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Product> Products { get; set; }

        public DBContext(DbContextOptions options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasOne<Company>(o => o.Company)
                .WithMany(u => u.Orders).HasForeignKey(c => c.Company_id);

            modelBuilder.Entity<OrderProduct>().HasKey(sc => new { sc.Product_Id, sc.Order_Id });

            modelBuilder.Entity<OrderProduct>()
                .HasOne<Order>(sc => sc.Order)
                .WithMany(s => s.OrderProducts)
                .HasForeignKey(sc => sc.Order_Id);

            modelBuilder.Entity<OrderProduct>()
                .HasOne<Product>(sc => sc.Product)
                .WithMany(s => s.OrderProducts)
                .HasForeignKey(sc => sc.Product_Id);

        }


    }
}
