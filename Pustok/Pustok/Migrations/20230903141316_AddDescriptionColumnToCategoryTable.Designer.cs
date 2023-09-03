﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Pustok.Database;

#nullable disable

namespace Pustok.Migrations
{
    [DbContext(typeof(PustokDbContext))]
    [Migration("20230903141316_AddDescriptionColumnToCategoryTable")]
    partial class AddDescriptionColumnToCategoryTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Pustok.Database.Models.Basket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Baskets", (string)null);
                });

            modelBuilder.Entity("Pustok.Database.Models.BasketItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BasketId")
                        .HasColumnType("integer");

                    b.Property<int>("ColorId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("SizeId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("BasketId");

                    b.HasIndex("ColorId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SizeId");

                    b.ToTable("BasketItems", (string)null);
                });

            modelBuilder.Entity("Pustok.Database.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            CreatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Laundry",
                            UpdatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -2,
                            CreatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Fruts",
                            UpdatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -3,
                            CreatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Sport",
                            UpdatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -4,
                            CreatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Classic sport",
                            UpdatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("Pustok.Database.Models.CategoryProduct", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoryProducts", (string)null);
                });

            modelBuilder.Entity("Pustok.Database.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Color", (string)null);

                    b.HasData(
                        new
                        {
                            Id = -1,
                            CreatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Blue",
                            UpdatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -2,
                            CreatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Red",
                            UpdatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -3,
                            CreatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Green",
                            UpdatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -4,
                            CreatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Purple",
                            UpdatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -5,
                            CreatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Yellow",
                            UpdatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -6,
                            CreatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Black",
                            UpdatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("Pustok.Database.Models.EmailMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<List<string>>("Receipents")
                        .HasColumnType("text[]");

                    b.Property<string>("Subject")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("EmailMessages");
                });

            modelBuilder.Entity("Pustok.Database.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("PhysicalImageName")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Pustok.Database.Models.ProductColor", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("ColorId")
                        .HasColumnType("integer");

                    b.HasKey("ProductId", "ColorId");

                    b.HasIndex("ColorId");

                    b.ToTable("ProductColor");
                });

            modelBuilder.Entity("Pustok.Database.Models.ProductSize", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("SizeId")
                        .HasColumnType("integer");

                    b.HasKey("ProductId", "SizeId");

                    b.HasIndex("SizeId");

                    b.ToTable("ProductSize");
                });

            modelBuilder.Entity("Pustok.Database.Models.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Size", (string)null);

                    b.HasData(
                        new
                        {
                            Id = -1,
                            CreatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "X",
                            UpdatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -2,
                            CreatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "S",
                            UpdatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -3,
                            CreatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "XS",
                            UpdatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -4,
                            CreatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "L",
                            UpdatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -5,
                            CreatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "XL",
                            UpdatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -6,
                            CreatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "XXL",
                            UpdatedAt = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("Pustok.Database.Models.SlideBanner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Offer")
                        .HasColumnType("text");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.Property<string>("RedirectionUrl")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("SlideBanners");
                });

            modelBuilder.Entity("Pustok.Database.Models.BasketItem", b =>
                {
                    b.HasOne("Pustok.Database.Models.Basket", "Basket")
                        .WithMany("BasketItems")
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pustok.Database.Models.Color", "Color")
                        .WithMany("BasketItems")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pustok.Database.Models.Product", "Product")
                        .WithMany("BasketItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pustok.Database.Models.Size", "Size")
                        .WithMany("BasketItems")
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Basket");

                    b.Navigation("Color");

                    b.Navigation("Product");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("Pustok.Database.Models.CategoryProduct", b =>
                {
                    b.HasOne("Pustok.Database.Models.Category", "Category")
                        .WithMany("CategoryProducts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pustok.Database.Models.Product", "Product")
                        .WithMany("CategoryProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Pustok.Database.Models.ProductColor", b =>
                {
                    b.HasOne("Pustok.Database.Models.Color", "Color")
                        .WithMany("ProductColors")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pustok.Database.Models.Product", "Product")
                        .WithMany("ProductColors")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Pustok.Database.Models.ProductSize", b =>
                {
                    b.HasOne("Pustok.Database.Models.Product", "Product")
                        .WithMany("ProductSizes")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pustok.Database.Models.Size", "Size")
                        .WithMany("ProductSizes")
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("Pustok.Database.Models.Basket", b =>
                {
                    b.Navigation("BasketItems");
                });

            modelBuilder.Entity("Pustok.Database.Models.Category", b =>
                {
                    b.Navigation("CategoryProducts");
                });

            modelBuilder.Entity("Pustok.Database.Models.Color", b =>
                {
                    b.Navigation("BasketItems");

                    b.Navigation("ProductColors");
                });

            modelBuilder.Entity("Pustok.Database.Models.Product", b =>
                {
                    b.Navigation("BasketItems");

                    b.Navigation("CategoryProducts");

                    b.Navigation("ProductColors");

                    b.Navigation("ProductSizes");
                });

            modelBuilder.Entity("Pustok.Database.Models.Size", b =>
                {
                    b.Navigation("BasketItems");

                    b.Navigation("ProductSizes");
                });
#pragma warning restore 612, 618
        }
    }
}
