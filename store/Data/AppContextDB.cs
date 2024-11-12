using Microsoft.EntityFrameworkCore;
using store.Models;

namespace store.Data
{
    public class AppContextDB : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public AppContextDB(DbContextOptions<AppContextDB> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // การเชื่อมโยง Order กับ Customer
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer) // แต่ละ Order มี Customer
                .WithMany(c => c.Orders) // Customer สามารถมีหลาย Orders
                .HasForeignKey(o => o.CustomerId); // เชื่อมโยงผ่าน CustomerId

            // การเชื่อมโยง OrderItem กับ Order
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderId);

            // การเชื่อมโยง OrderItem กับ Product
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Product)
                .WithMany()
                .HasForeignKey(oi => oi.ProductId);
        }
    }
}
