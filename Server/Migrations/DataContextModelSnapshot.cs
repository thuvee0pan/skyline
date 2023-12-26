﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using skyline.Server.Data;

#nullable disable

namespace skyline.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("skyline.Shared.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("skyline.Shared.CartItem", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ProductId", "ProductTypeId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("skyline.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Deleted = false,
                            Name = "Commercial Aircraft",
                            Url = "/categories/commercial-aircraft",
                            Visible = true
                        },
                        new
                        {
                            Id = 2,
                            Deleted = false,
                            Name = "Private Jets",
                            Url = "/categories/private-jets",
                            Visible = true
                        },
                        new
                        {
                            Id = 3,
                            Deleted = false,
                            Name = "Cargo Planes",
                            Url = "/categories/cargo-planes",
                            Visible = true
                        });
                });

            modelBuilder.Entity("skyline.Shared.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("skyline.Shared.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("skyline.Shared.OrderItem", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId", "ProductId", "ProductTypeId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("skyline.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Featured")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Deleted = false,
                            Description = "A versatile commercial jet",
                            Featured = true,
                            ImageUrl = "https://example.com/main-image.jpg",
                            Title = "Raythos C-320 Jet",
                            Visible = true
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Deleted = false,
                            Description = "A sleek and efficient light jet, perfect for quick business trips.",
                            Featured = false,
                            ImageUrl = "https://example.com/lightjet-main.jpg",
                            Title = "Raythos Light Jet X200",
                            Visible = true
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Deleted = false,
                            Description = "Spacious and luxurious, ideal for longer journeys and larger groups.",
                            Featured = true,
                            ImageUrl = "https://example.com/midsizejet-main.jpg",
                            Title = "Raythos Midsize Jet M500",
                            Visible = true
                        });
                });

            modelBuilder.Entity("skyline.Shared.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("BasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specifications")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BasePrice = 90000000m,
                            Description = "A state-of-the-art commercial jet designed for efficiency and comfort.",
                            ImageUrl = "https://example.com/images/raythos-c320.jpg",
                            Name = "Raythos C-320",
                            Specifications = "Capacity: 150-180 passengers, Range: 5,000 nautical miles, Cruise Speed: 560 mph"
                        },
                        new
                        {
                            Id = 2,
                            BasePrice = 40000000m,
                            Description = "Luxurious and high-performing, perfect for business or leisure travel.",
                            ImageUrl = "https://example.com/images/raythos-p200.jpg",
                            Name = "Raythos P-200",
                            Specifications = "Capacity: 8-12 passengers, Range: 3,000 nautical miles, Cruise Speed: 600 mph"
                        },
                        new
                        {
                            Id = 3,
                            BasePrice = 70000000m,
                            Description = "Designed for cargo transport, offering an optimal balance of payload capacity and efficiency.",
                            ImageUrl = "https://example.com/images/cargomaster500.jpg",
                            Name = "Raythos Cargomaster 500",
                            Specifications = "Payload: 50,000 kg, Range: 4,000 nautical miles, Cargo Volume: 400 m³"
                        });
                });

            modelBuilder.Entity("skyline.Shared.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("ProductId", "ProductTypeId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("ProductVariants");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 1,
                            Deleted = false,
                            OriginalPrice = 95000000m,
                            Price = 90000000m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 2,
                            Deleted = false,
                            OriginalPrice = 85000000m,
                            Price = 80000000m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 1,
                            Deleted = false,
                            OriginalPrice = 95000000m,
                            Price = 90000000m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 2,
                            Deleted = false,
                            OriginalPrice = 85000000m,
                            Price = 80000000m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 3,
                            ProductTypeId = 3,
                            Deleted = false,
                            OriginalPrice = 95000000m,
                            Price = 90000000m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 3,
                            ProductTypeId = 2,
                            Deleted = false,
                            OriginalPrice = 85000000m,
                            Price = 80000000m,
                            Visible = true
                        });
                });

            modelBuilder.Entity("skyline.Shared.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("skyline.Shared.Address", b =>
                {
                    b.HasOne("skyline.Shared.User", null)
                        .WithOne("Address")
                        .HasForeignKey("skyline.Shared.Address", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("skyline.Shared.Image", b =>
                {
                    b.HasOne("skyline.Shared.Product", null)
                        .WithMany("Images")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("skyline.Shared.OrderItem", b =>
                {
                    b.HasOne("skyline.Shared.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("skyline.Shared.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("skyline.Shared.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("skyline.Shared.Product", b =>
                {
                    b.HasOne("skyline.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("skyline.Shared.ProductVariant", b =>
                {
                    b.HasOne("skyline.Shared.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("skyline.Shared.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("skyline.Shared.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("skyline.Shared.Product", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Variants");
                });

            modelBuilder.Entity("skyline.Shared.User", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}