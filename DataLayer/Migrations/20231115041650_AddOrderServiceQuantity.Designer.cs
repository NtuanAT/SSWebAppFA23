﻿// <auto-generated />
using System;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataLayer.Migrations
{
    [DbContext(typeof(SswdatabaseContext))]
    [Migration("20231115041650_AddOrderServiceQuantity")]
    partial class AddOrderServiceQuantity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataLayer.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d2376e25-52f2-431d-85ed-0d453f1e9570"),
                            Password = "123456",
                            Role = 1,
                            Status = 0,
                            Username = "admin"
                        },
                        new
                        {
                            Id = new Guid("1527e96c-5cfd-4883-a475-4feb357014e3"),
                            Password = "123456",
                            Role = 0,
                            Status = 0,
                            Username = "customer"
                        },
                        new
                        {
                            Id = new Guid("4b224db4-473b-4740-9a16-38ae436dad82"),
                            Password = "123456",
                            Role = 2,
                            Status = 0,
                            Username = "staff"
                        });
                });

            modelBuilder.Entity("DataLayer.Entities.AccountDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.ToTable("AccountDetails");
                });

            modelBuilder.Entity("DataLayer.Entities.FeedBack", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Rate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("FeedBacks");
                });

            modelBuilder.Entity("DataLayer.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Accessory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Drawing")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KindofPaint")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Style")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("DataLayer.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DataLayer.Entities.OrderProduct", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OderProducts");
                });

            modelBuilder.Entity("DataLayer.Entities.OrderService", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ServiceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ServiceId");

                    b.HasIndex("ServiceId");

                    b.ToTable("OrderServices");
                });

            modelBuilder.Entity("DataLayer.Entities.Payment", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Method")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("DataLayer.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Catagories")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double>("Size")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("31b97292-19b4-48d9-aaf4-6f55d4ca2a30"),
                            Brand = "Nike",
                            Catagories = "Shoes",
                            Color = "Purple",
                            Name = "Uzui Tengen",
                            PictureLink = "",
                            Price = 58m,
                            Size = 40.0
                        },
                        new
                        {
                            Id = new Guid("a5165b79-b50b-4440-a1ab-cf8fa248efc4"),
                            Brand = "Converse",
                            Catagories = "Shoes",
                            Color = "Black",
                            Name = "Spider-Verse",
                            PictureLink = "",
                            Price = 68m,
                            Size = 41.0
                        },
                        new
                        {
                            Id = new Guid("62ff70e7-af58-47ee-b4a6-6c4cdf91f81a"),
                            Brand = "Autry",
                            Catagories = "Shoes",
                            Color = "Silver",
                            Name = "Silver Serpent",
                            PictureLink = "",
                            Price = 49m,
                            Size = 39.0
                        },
                        new
                        {
                            Id = new Guid("6175e609-a360-44a6-ac91-5a0752737d03"),
                            Brand = "Adidas",
                            Catagories = "Shoes",
                            Color = "Purple",
                            Name = "Nebula Burst",
                            PictureLink = "",
                            Price = 58m,
                            Size = 38.0
                        },
                        new
                        {
                            Id = new Guid("46b1ec3e-65b1-40a1-bcd8-4fa79b80dd74"),
                            Brand = "Air Jordan",
                            Catagories = "Shoes",
                            Color = "Blue",
                            Name = "Lighting Thread",
                            PictureLink = "",
                            Price = 91m,
                            Size = 42.0
                        },
                        new
                        {
                            Id = new Guid("1883c618-b0d1-46aa-a27a-d891a6bba4de"),
                            Brand = "Air Jordan",
                            Catagories = "Shoes",
                            Color = "Blue",
                            Name = "Enchanted Sponge Bob",
                            PictureLink = "",
                            Price = 63m,
                            Size = 36.0
                        },
                        new
                        {
                            Id = new Guid("1a2aac64-40c0-4bc6-950c-a8f21197a313"),
                            Brand = "Nike",
                            Catagories = "Shoes",
                            Color = "Red",
                            Name = "Electric Dream",
                            PictureLink = "",
                            Price = 78m,
                            Size = 43.0
                        },
                        new
                        {
                            Id = new Guid("68a4fdce-40fb-4c59-9c87-ac66466dd824"),
                            Brand = "Puma",
                            Catagories = "Shoes",
                            Color = "Purple",
                            Name = "Crimson Blaze",
                            PictureLink = "",
                            Price = 46m,
                            Size = 45.0
                        },
                        new
                        {
                            Id = new Guid("2e42e077-1e74-4ea3-8320-e0a18900d8af"),
                            Brand = "Nike",
                            Catagories = "Shoes",
                            Color = "Purple",
                            Name = "Airbrushed Sneakers",
                            PictureLink = "",
                            Price = 99m,
                            Size = 35.0
                        },
                        new
                        {
                            Id = new Guid("bbdb608a-ead9-48ba-913d-e2ce24b4d371"),
                            Brand = "Converse",
                            Catagories = "Shoes",
                            Color = "Black",
                            Name = "Arkham Knight",
                            PictureLink = "",
                            Price = 112m,
                            Size = 38.0
                        },
                        new
                        {
                            Id = new Guid("40628a83-cd4c-4a75-8152-36c863005ce7"),
                            Brand = "Converse",
                            Catagories = "Shoes",
                            Color = "White",
                            Name = "Cute",
                            PictureLink = "",
                            Price = 55m,
                            Size = 40.0
                        });
                });

            modelBuilder.Entity("DataLayer.Entities.Service", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7ff262de-d146-46f8-bc30-92bb2f4faa7c"),
                            Price = 10m,
                            Type = "Clean"
                        },
                        new
                        {
                            Id = new Guid("fc4a485e-2c43-4d0d-9395-8cb2b368fcde"),
                            Price = 20m,
                            Type = "Repair"
                        },
                        new
                        {
                            Id = new Guid("c4b0323d-9241-4bf5-9ec4-89e88ff92fc0"),
                            Price = 30m,
                            Type = "Customize"
                        });
                });

            modelBuilder.Entity("DataLayer.Entities.AccountDetail", b =>
                {
                    b.HasOne("DataLayer.Entities.Account", "Account")
                        .WithOne("AccountDetail")
                        .HasForeignKey("DataLayer.Entities.AccountDetail", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Account_AccountDetail");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("DataLayer.Entities.FeedBack", b =>
                {
                    b.HasOne("DataLayer.Entities.Order", "Order")
                        .WithOne("FeedBack")
                        .HasForeignKey("DataLayer.Entities.FeedBack", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Order_Feedback");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("DataLayer.Entities.Image", b =>
                {
                    b.HasOne("DataLayer.Entities.Account", "Account")
                        .WithMany("Images")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Account_Image");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("DataLayer.Entities.Order", b =>
                {
                    b.HasOne("DataLayer.Entities.Account", "Account")
                        .WithMany("Orders")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Account_Order");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("DataLayer.Entities.OrderProduct", b =>
                {
                    b.HasOne("DataLayer.Entities.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Order_OrderProduct");

                    b.HasOne("DataLayer.Entities.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Product_OrderProduct");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DataLayer.Entities.OrderService", b =>
                {
                    b.HasOne("DataLayer.Entities.Order", "Order")
                        .WithMany("Services")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Order_OrderService");

                    b.HasOne("DataLayer.Entities.Service", "Service")
                        .WithMany("Orders")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Service_OrderService");

                    b.Navigation("Order");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("DataLayer.Entities.Payment", b =>
                {
                    b.HasOne("DataLayer.Entities.Order", "Order")
                        .WithOne("Payment")
                        .HasForeignKey("DataLayer.Entities.Payment", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Order_Payment");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("DataLayer.Entities.Account", b =>
                {
                    b.Navigation("AccountDetail");

                    b.Navigation("Images");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DataLayer.Entities.Order", b =>
                {
                    b.Navigation("FeedBack");

                    b.Navigation("Payment");

                    b.Navigation("Products");

                    b.Navigation("Services");
                });

            modelBuilder.Entity("DataLayer.Entities.Product", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DataLayer.Entities.Service", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
