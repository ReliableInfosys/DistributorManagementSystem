﻿using DistributerManagementSystemModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributerManagementSystemRepository.Common
{
    public class DistributerManagementSystemContext : DbContext
    {
        public DistributerManagementSystemContext(DbContextOptions<DistributerManagementSystemContext> options): base(options)
        {
            
        }

        public DbSet<Users> Users { get; set; }

        public DbSet<Vendor> Vendors { get; set; }

        public DbSet<Retailer> Retailers { get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<Orderbook> Orderbooks { get; set; }

        public DbSet<ProductPurchaseOrderbook> ProductPurchaseOrderbook { get; set; }

        public DbSet<CreditManagement> CreditManagement { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory { Id = 1, Name="General Items", GSTPercentage=0 },
                new ProductCategory { Id = 2, Name = "Beverages", GSTPercentage=18 },
                new ProductCategory { Id = 3, Name = "Biscuits" , GSTPercentage=18},
                new ProductCategory { Id = 4, Name = "Cakes", GSTPercentage=18 },
                new ProductCategory { Id = 5, Name = "Spices", GSTPercentage=5 },
                new ProductCategory { Id = 6, Name = "Lahori Beverages", GSTPercentage=12 },
                new ProductCategory { Id = 7, Name = "Butter", GSTPercentage=12 }


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
