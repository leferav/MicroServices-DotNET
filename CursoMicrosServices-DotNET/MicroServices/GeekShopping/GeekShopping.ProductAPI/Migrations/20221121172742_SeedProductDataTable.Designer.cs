﻿// <auto-generated />
using GeekShopping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    [DbContext(typeof(MySQLContext))]
    [Migration("20221121172742_SeedProductDataTable")]
    partial class SeedProductDataTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GeekShopping.ProductAPI.Model.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("category_name");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("product");

                    b.HasData(
                        new
                        {
                            Id = 2L,
                            CategoryName = "T-shirt",
                            Description = "Description ID2",
                            ImageURL = "C:\\Users\\LeandroAvila\\Downloads\\ShoppingImages\\1_super_mario.jpg",
                            Name = "Name02",
                            Price = 69.9m
                        },
                        new
                        {
                            Id = 3L,
                            CategoryName = "T-shirt",
                            Description = "Description ID3",
                            ImageURL = "C:\\Users\\LeandroAvila\\Downloads\\ShoppingImages\\1_super_mario.jpg",
                            Name = "Name03",
                            Price = 69.9m
                        },
                        new
                        {
                            Id = 4L,
                            CategoryName = "T-shirt",
                            Description = "Description ID4",
                            ImageURL = "C:\\Users\\LeandroAvila\\Downloads\\ShoppingImages\\1_super_mario.jpg",
                            Name = "Name04",
                            Price = 69.9m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
