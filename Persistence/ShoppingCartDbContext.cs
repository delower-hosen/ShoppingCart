using Microsoft.EntityFrameworkCore;
using ShoppingCart.Domain.PrimaryEntities;

namespace ShoppingCart.Persistence
{
    public class ShoppingCartDbContext : DbContext
    {
        public ShoppingCartDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ShoppingCartDbContext).Assembly);
            modelBuilder.Entity<ProductInfo>().HasData(
                new ProductInfo
                {
                    Id = 1,
                    Name = "Test 1",
                    Description = "Test description 1",
                    Category = "Phone",
                    IsStockAvailable = true,
                    Price = 10
                },
                new ProductInfo
                {
                    Id = 2,
                    Name = "Test 2",
                    Description = "Test description 2",
                    Category = "Phone",
                    IsStockAvailable = true,
                    Price = 10
                }
               );
        }
        public DbSet<ProductInfo> ProductInfos { get; set; }
    }
}
