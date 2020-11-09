using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using TesteNava.Data.Mappings;
using TesteNava.Domain.Models;

namespace TesteNava.Data.Context
{
    public class TesteNavaDbContext : DbContext
    {
        public TesteNavaDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }
        public DbSet<Seller> Sellers { get; set; }     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TesteNavaDbContext).Assembly);         

            base.OnModelCreating(modelBuilder);
        }
    }
}
