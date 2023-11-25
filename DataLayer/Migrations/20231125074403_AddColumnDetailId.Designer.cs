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
    [Migration("20231125074403_AddColumnDetailId")]
    partial class AddColumnDetailId
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

                    b.Property<Guid?>("DetailId")
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
                            Id = new Guid("bdcc8ef2-f6b4-42e9-8302-4d3b4bbd582c"),
                            Password = "123456",
                            Role = 1,
                            Status = 0,
                            Username = "admin"
                        },
                        new
                        {
                            Id = new Guid("5b939815-302a-4da3-826b-6fb9d5cb2f7e"),
                            Password = "123456",
                            Role = 0,
                            Status = 0,
                            Username = "customer"
                        },
                        new
                        {
                            Id = new Guid("07a0fc21-f6bd-4501-8eb3-67ab79dde6ae"),
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

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

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
                            Id = new Guid("cc5defbc-65df-4ec2-9d23-1566a8f325b0"),
                            Brand = "Nike",
                            Catagories = "Shoes",
                            Color = "Purple",
                            Name = "Uzui Tengen",
                            PictureLink = "https://i.postimg.cc/B63gBjg1/Uzui-Tengen.jpg",
                            Price = 58m,
                            Size = 40.0
                        },
                        new
                        {
                            Id = new Guid("b8115ff4-4e79-48a6-aae9-7e465c4c14ce"),
                            Brand = "Converse",
                            Catagories = "Shoes",
                            Color = "Black",
                            Name = "Spider-Verse",
                            PictureLink = "https://i.postimg.cc/908Y2JjG/Spider-Verse.png",
                            Price = 68m,
                            Size = 41.0
                        },
                        new
                        {
                            Id = new Guid("9d305c18-98ae-45c3-99f5-26245d8aea7b"),
                            Brand = "Autry",
                            Catagories = "Shoes",
                            Color = "Silver",
                            Name = "Silver Serpent",
                            PictureLink = "https://i.postimg.cc/qRGGbpbD/Silver-Serpent.png",
                            Price = 49m,
                            Size = 39.0
                        },
                        new
                        {
                            Id = new Guid("52190f3e-9b17-4c86-8357-bccc37e4ea1a"),
                            Brand = "Adidas",
                            Catagories = "Shoes",
                            Color = "Purple",
                            Name = "Nebula Burst",
                            PictureLink = "https://i.postimg.cc/SxXDSFRj/Nebula-Burst.jpg",
                            Price = 58m,
                            Size = 38.0
                        },
                        new
                        {
                            Id = new Guid("c64ad7fd-a3ed-4ed0-a129-c5d54860f553"),
                            Brand = "Air Jordan",
                            Catagories = "Shoes",
                            Color = "Blue",
                            Name = "Lighting Thread",
                            PictureLink = "https://i.postimg.cc/vmfhnrWs/Lighting-Thread.png",
                            Price = 91m,
                            Size = 42.0
                        },
                        new
                        {
                            Id = new Guid("13d92877-feda-4dfa-9138-3939c5b7f99a"),
                            Brand = "Air Jordan",
                            Catagories = "Shoes",
                            Color = "Blue",
                            Name = "Enchanted Sponge Bob",
                            PictureLink = "https://i.postimg.cc/fWBKYT0J/Enchanted-Sponge-Bob.png",
                            Price = 63m,
                            Size = 36.0
                        },
                        new
                        {
                            Id = new Guid("e45ad433-d44e-4430-a388-3e062f67a54b"),
                            Brand = "Nike",
                            Catagories = "Shoes",
                            Color = "Red",
                            Name = "Electric Dream",
                            PictureLink = "https://i.postimg.cc/m2pmW2b0/Electric-Dream.png",
                            Price = 78m,
                            Size = 43.0
                        },
                        new
                        {
                            Id = new Guid("b234aca6-40b1-42e9-9c57-8b1a6c30d620"),
                            Brand = "Puma",
                            Catagories = "Shoes",
                            Color = "Purple",
                            Name = "Crimson Blaze",
                            PictureLink = "https://i.postimg.cc/fR65k2SC/Crimson-Blaze.png",
                            Price = 46m,
                            Size = 45.0
                        },
                        new
                        {
                            Id = new Guid("9d7bb671-cf9a-4b36-b9e2-4cefeda3a1d9"),
                            Brand = "Nike",
                            Catagories = "Shoes",
                            Color = "Purple",
                            Name = "Airbrushed Sneakers",
                            PictureLink = "https://i.postimg.cc/VsR74W2s/Airbrushed-Sneakers.png",
                            Price = 99m,
                            Size = 35.0
                        },
                        new
                        {
                            Id = new Guid("b99cd9da-c037-4739-b9f6-e8e04a9c400f"),
                            Brand = "Converse",
                            Catagories = "Shoes",
                            Color = "Black",
                            Name = "Arkham Knight",
                            PictureLink = "https://i.postimg.cc/MHKmggg6/Arkham-Knight.png",
                            Price = 112m,
                            Size = 38.0
                        },
                        new
                        {
                            Id = new Guid("4e902198-21fb-4e5c-8484-7360fcafda8b"),
                            Brand = "Converse",
                            Catagories = "Shoes",
                            Color = "White",
                            Name = "Cute",
                            PictureLink = "https://i.postimg.cc/7YZKRTy3/Cute.jpg",
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
                            Id = new Guid("60c24cc2-75b8-4fee-bfc6-8f84c9e1595e"),
                            Price = 10m,
                            Type = "Clean"
                        },
                        new
                        {
                            Id = new Guid("ead83624-297c-4644-bb1c-c5be04ff343c"),
                            Price = 20m,
                            Type = "Repair"
                        },
                        new
                        {
                            Id = new Guid("30170c96-7a43-49e1-b839-3a7f50b00d97"),
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
