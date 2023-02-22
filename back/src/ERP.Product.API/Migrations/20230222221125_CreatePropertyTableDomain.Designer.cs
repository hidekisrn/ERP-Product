﻿// <auto-generated />
using ERP.Product.Domain.Entities;
using ERP.Product.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ERP.Product.API.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20230222221125_CreatePropertyTableDomain")]
    partial class CreatePropertyTableDomain
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ERP.Product.Domain.Entities.Metadata", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<Property[]>("Properties")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.HasKey("Id");

                    b.ToTable("Metadatas");
                });

            modelBuilder.Entity("ERP.Product.Domain.Entities.PropertyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PropertyTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            Type = "Text"
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            Type = "Number"
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            Type = "Array"
                        },
                        new
                        {
                            Id = 4,
                            Description = "",
                            Type = "Property"
                        },
                        new
                        {
                            Id = 5,
                            Description = "",
                            Type = "URL"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
