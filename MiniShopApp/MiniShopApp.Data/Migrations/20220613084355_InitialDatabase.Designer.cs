﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniShopApp.Data.Concrete.EfCore;

namespace MiniShopApp.Data.Migrations
{
    [DbContext(typeof(MiniShopContext))]
    [Migration("20220613084355_InitialDatabase")]
    partial class InitialDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("MiniShopApp.Entity.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("MiniShopApp.Entity.CardItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("ProductId");

                    b.ToTable("CardItems");
                });

            modelBuilder.Entity("MiniShopApp.Entity.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "Ürünlerimiz son teknoloji ile üretilmektedir.",
                            Name = "Telefon",
                            Url = "telefon"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description = "Ürünlerimiz son teknoloji ile üretilmektedir.",
                            Name = "Bilgisayar",
                            Url = "bilgisayar"
                        },
                        new
                        {
                            CategoryId = 3,
                            Description = "Ürünlerimiz son teknoloji ile üretilmektedir.",
                            Name = "Elektronik",
                            Url = "elektronik"
                        },
                        new
                        {
                            CategoryId = 4,
                            Description = "Ürünlerimiz son teknoloji ile üretilmektedir.",
                            Name = "Beyaz Eşya",
                            Url = "beyaz-esya"
                        });
                });

            modelBuilder.Entity("MiniShopApp.Entity.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConversationId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrderNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("OrderState")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PaymentId")
                        .HasColumnType("TEXT");

                    b.Property<int>("PaymentType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MiniShopApp.Entity.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("MiniShopApp.Entity.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHome")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bu telefon çok iyi bir telefon.",
                            ImageUrl = "1.png",
                            IsApproved = true,
                            IsHome = true,
                            Name = "Samsung S10",
                            Price = 15000m,
                            Url = "samsung-s10"
                        },
                        new
                        {
                            ProductId = 2,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bu telefon çok iyi bir telefon.",
                            ImageUrl = "2.png",
                            IsApproved = true,
                            IsHome = true,
                            Name = "Samsung S11",
                            Price = 16000m,
                            Url = "samsung-s11"
                        },
                        new
                        {
                            ProductId = 3,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bu telefon çok iyi bir telefon.",
                            ImageUrl = "3.png",
                            IsApproved = true,
                            IsHome = true,
                            Name = "Samsung S12",
                            Price = 17000m,
                            Url = "samsung-s12"
                        },
                        new
                        {
                            ProductId = 4,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bu telefon çok iyi bir telefon.",
                            ImageUrl = "4.png",
                            IsApproved = true,
                            IsHome = false,
                            Name = "Samsung S20",
                            Price = 18000m,
                            Url = "samsung-s20"
                        },
                        new
                        {
                            ProductId = 5,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bu telefon çok iyi bir telefon.",
                            ImageUrl = "5.png",
                            IsApproved = true,
                            IsHome = false,
                            Name = "Xaomi Redmi 9 Pro",
                            Price = 13000m,
                            Url = "xaomi-redmi-9-pro"
                        },
                        new
                        {
                            ProductId = 6,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bu telefon çok iyi bir telefon.",
                            ImageUrl = "6.png",
                            IsApproved = true,
                            IsHome = false,
                            Name = "Xaomi Redmi 10 Pro",
                            Price = 14000m,
                            Url = "xaomi-redmi-10-pro"
                        },
                        new
                        {
                            ProductId = 7,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bu telefon çok iyi bir telefon.",
                            ImageUrl = "7.png",
                            IsApproved = true,
                            IsHome = false,
                            Name = "Xaomi Redmi 11 Pro",
                            Price = 15000m,
                            Url = "xaomi-redmi-11-pro"
                        },
                        new
                        {
                            ProductId = 8,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bu telefon çok iyi bir telefon.",
                            ImageUrl = "8.png",
                            IsApproved = true,
                            IsHome = false,
                            Name = "Iphone XR",
                            Price = 12000m,
                            Url = "iphone-xr"
                        },
                        new
                        {
                            ProductId = 9,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bu telefon çok iyi bir telefon.",
                            ImageUrl = "9.png",
                            IsApproved = true,
                            IsHome = false,
                            Name = "Iphone 11",
                            Price = 13000m,
                            Url = "iphone-11"
                        },
                        new
                        {
                            ProductId = 10,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bu telefon çok iyi bir telefon.",
                            ImageUrl = "10.png",
                            IsApproved = true,
                            IsHome = false,
                            Name = "Iphone 12",
                            Price = 14000m,
                            Url = "iphone-12"
                        },
                        new
                        {
                            ProductId = 11,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bu telefon çok iyi bir telefon.",
                            ImageUrl = "11.png",
                            IsApproved = true,
                            IsHome = false,
                            Name = "Iphone 13",
                            Price = 15000m,
                            Url = "iphone-13"
                        },
                        new
                        {
                            ProductId = 12,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bu telefon çok iyi bir telefon.",
                            ImageUrl = "12.png",
                            IsApproved = true,
                            IsHome = false,
                            Name = "Iphone 13 Max",
                            Price = 16000m,
                            Url = "iphone-13-max"
                        },
                        new
                        {
                            ProductId = 13,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bu telefon çok iyi bir telefon.",
                            ImageUrl = "13.png",
                            IsApproved = true,
                            IsHome = false,
                            Name = "Huawei Mate 20 Pro",
                            Price = 20000m,
                            Url = "huawei-mate-20-pro"
                        });
                });

            modelBuilder.Entity("MiniShopApp.Entity.ProductCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            CategoryId = 2,
                            ProductId = 1
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            CategoryId = 2,
                            ProductId = 2
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 3
                        },
                        new
                        {
                            CategoryId = 4,
                            ProductId = 3
                        },
                        new
                        {
                            CategoryId = 2,
                            ProductId = 4
                        },
                        new
                        {
                            CategoryId = 2,
                            ProductId = 5
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 5
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 6
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 7
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 8
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 9
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 10
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 11
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 12
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 13
                        });
                });

            modelBuilder.Entity("MiniShopApp.Entity.CardItem", b =>
                {
                    b.HasOne("MiniShopApp.Entity.Card", "Card")
                        .WithMany("CardItems")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MiniShopApp.Entity.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MiniShopApp.Entity.OrderItem", b =>
                {
                    b.HasOne("MiniShopApp.Entity.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MiniShopApp.Entity.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MiniShopApp.Entity.ProductCategory", b =>
                {
                    b.HasOne("MiniShopApp.Entity.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MiniShopApp.Entity.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MiniShopApp.Entity.Card", b =>
                {
                    b.Navigation("CardItems");
                });

            modelBuilder.Entity("MiniShopApp.Entity.Category", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("MiniShopApp.Entity.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("MiniShopApp.Entity.Product", b =>
                {
                    b.Navigation("ProductCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
