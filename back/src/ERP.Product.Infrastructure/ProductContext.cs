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

            modelbuilder.Entity<PropertyType>(e => e.HasData(
                new PropertyType()
                {
                    Id = 1,
                    Type = "Text"
                },
                new PropertyType()
                {
                    Id = 2,
                    Type = "Number"
                }, new PropertyType()
                {
                    Id = 3,
                    Type = "Array"
                }, new PropertyType()
                {
                    Id = 4,
                    Type = "Property"
                }, new PropertyType()
                {
                    Id = 5,
                    Type = "URL"
                }));
        }

        public DbSet<Metadata> Metadatas { get; set; }
        public DbSet<PropertyType> PropertyTypes { get; set; }
    }
}

