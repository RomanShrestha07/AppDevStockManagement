using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AppDevCW2.Models;

namespace AppDevCW2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AppDevCW2.Models.Category> Category { get; set; }
        public DbSet<AppDevCW2.Models.Item> Item { get; set; }
        public DbSet<AppDevCW2.Models.Stock> Stock { get; set; }
        public DbSet<AppDevCW2.Models.Purchase> Purchase { get; set; }
        public DbSet<AppDevCW2.Models.PurchaseDetail> PurchaseDetail { get; set; }
        public DbSet<AppDevCW2.Models.Customer> Customer { get; set; }
        public DbSet<AppDevCW2.Models.Sale> Sale { get; set; }
        public DbSet<AppDevCW2.Models.SaleDetail> SaleDetail { get; set; }
    }
}
