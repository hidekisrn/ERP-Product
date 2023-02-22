using System;
using Microsoft.EntityFrameworkCore;
using ERP.Product.Domain.Entities;

namespace ERP.Product.Infrastructure
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<Metadata>(e =>
            {
                e.Property(d => d.Properties).IsRequired();
            });
        }

        public DbSet<Metadata> Metadatas { get; set; }
    }
}

