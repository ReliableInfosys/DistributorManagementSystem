using DistributerManagementSystemModels;
using Microsoft.EntityFrameworkCore;

namespace DistributerManagementSystemRepository.Common
{
    public class DistributerManagementSystemContext : DbContext
    {
        public DistributerManagementSystemContext(DbContextOptions<DistributerManagementSystemContext> options) : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }

        public DbSet<Vendor> Vendors { get; set; }

        public DbSet<Retailer> Retailers { get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<Orderbook> Orderbooks { get; set; }

        public DbSet<ProductPurchaseOrderbook> ProductPurchaseOrderbook { get; set; }

        public DbSet<CreditManagement> CreditManagement { get; set; }
        public DbSet<ProductsCategory> ProductCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductsCategory>().HasData(
                new ProductsCategory { Name = "General Items", GSTPercentage = 0 },
                new ProductsCategory { Name = "Beverages", GSTPercentage = 18 },
                new ProductsCategory { Name = "Biscuits", GSTPercentage = 18 },
                new ProductsCategory { Name = "Cakes", GSTPercentage = 18 },
                new ProductsCategory { Name = "Spices", GSTPercentage = 5 },
                new ProductsCategory { Name = "Lahori Beverages", GSTPercentage = 12 },
                new ProductsCategory { Name = "Butter", GSTPercentage = 12 }


                );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            if (!optionsbuilder.IsConfigured)
            {
                optionsbuilder.UseSqlServer("Server=localhost;Database=DistributerManagementSystem;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
            }

        }

    }
}
