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
    [Migration("20231126054737_AddInStoreProductTable")]
    partial class AddInStoreProductTable
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
                            Id = new Guid("e9c24bff-dfec-4485-97cd-ea1c1de850dc"),
                            Password = "123456",
                            Role = 1,
                            Status = 0,
                            Username = "admin"
                        },
                        new
                        {
                            Id = new Guid("f86570a1-dc93-445b-899c-eb376d6f7ab5"),
                            Password = "123456",
                            Role = 0,
                            Status = 0,
                            Username = "customer"
                        },
                        new
                        {
                            Id = new Guid("31e5e9a8-f0a5-48e5-b937-3c5393daf306"),
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

            modelBuilder.Entity("DataLayer.Entities.InStoreProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductInStores");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d5e9e49e-aef5-429b-9e1e-27f62d5e20d0"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0b"),
                            Quantity = 100,
                            Size = 40
                        },
                        new
                        {
                            Id = new Guid("8fcc6567-59be-49df-98d6-df9a7c95f54e"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0b"),
                            Quantity = 50,
                            Size = 41
                        },
                        new
                        {
                            Id = new Guid("4b7449b7-5219-4cf2-98e5-5a34d3dd1e60"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0b"),
                            Quantity = 20,
                            Size = 42
                        },
                        new
                        {
                            Id = new Guid("217073ab-ddcd-4ff9-83f0-561ff24340e2"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0b"),
                            Quantity = 10,
                            Size = 43
                        },
                        new
                        {
                            Id = new Guid("65248317-9a46-4b39-8be4-086df680d2e5"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0c"),
                            Quantity = 100,
                            Size = 40
                        },
                        new
                        {
                            Id = new Guid("dcd00d53-e2b3-4aad-8013-8a02efd6165c"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0c"),
                            Quantity = 50,
                            Size = 41
                        },
                        new
                        {
                            Id = new Guid("62b7e69a-05f8-4fd1-afb2-3f16c2ed810c"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0c"),
                            Quantity = 20,
                            Size = 42
                        },
                        new
                        {
                            Id = new Guid("a53a64e3-7b55-4ca7-89f4-c948e990e8bb"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0c"),
                            Quantity = 10,
                            Size = 43
                        },
                        new
                        {
                            Id = new Guid("f5898cf1-7c28-4a1e-ae35-bb13151b148c"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0d"),
                            Quantity = 100,
                            Size = 40
                        },
                        new
                        {
                            Id = new Guid("01ec8bdd-f18b-4737-bf0c-c136b3a31905"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0d"),
                            Quantity = 50,
                            Size = 41
                        },
                        new
                        {
                            Id = new Guid("ac74e045-5b2b-4625-a46f-0c4ea29193ba"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0d"),
                            Quantity = 20,
                            Size = 42
                        },
                        new
                        {
                            Id = new Guid("e3876280-9507-4998-a58e-4c3f4d7feb6e"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0d"),
                            Quantity = 10,
                            Size = 43
                        },
                        new
                        {
                            Id = new Guid("307b0aac-291f-4dac-884e-005d486d4b64"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0e"),
                            Quantity = 100,
                            Size = 40
                        },
                        new
                        {
                            Id = new Guid("d6c51133-b8a2-4fa2-90b3-a8d77f13f49a"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0e"),
                            Quantity = 50,
                            Size = 41
                        },
                        new
                        {
                            Id = new Guid("31983281-ecba-4fa4-a164-9562270d6049"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0e"),
                            Quantity = 20,
                            Size = 42
                        },
                        new
                        {
                            Id = new Guid("1c03198c-e4bd-4644-8977-ecff7afefb05"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0e"),
                            Quantity = 10,
                            Size = 43
                        },
                        new
                        {
                            Id = new Guid("23403174-9995-457a-b721-d184a1ee60f9"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0f"),
                            Quantity = 50,
                            Size = 39
                        },
                        new
                        {
                            Id = new Guid("fb3c5d2f-f91a-4ce0-ac79-fff4b7fc510d"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0f"),
                            Quantity = 100,
                            Size = 40
                        },
                        new
                        {
                            Id = new Guid("03340edb-51d5-4493-841c-11f06bd86cbf"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0f"),
                            Quantity = 50,
                            Size = 41
                        },
                        new
                        {
                            Id = new Guid("38d1674c-38d7-4945-94d0-73c808ba61b3"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0f"),
                            Quantity = 20,
                            Size = 42
                        },
                        new
                        {
                            Id = new Guid("5a7e7dd8-1d0c-4e14-ae28-98ed9d57da9e"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1a"),
                            Quantity = 50,
                            Size = 39
                        },
                        new
                        {
                            Id = new Guid("f0230887-6747-4ec7-a68b-f6ca219bb5d8"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1a"),
                            Quantity = 100,
                            Size = 40
                        },
                        new
                        {
                            Id = new Guid("033f00f8-543d-4bf0-9814-bd725fe3a238"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1a"),
                            Quantity = 50,
                            Size = 41
                        },
                        new
                        {
                            Id = new Guid("73a3d771-4d15-4a41-ae01-8cb784ba4fe0"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1b"),
                            Quantity = 50,
                            Size = 39
                        },
                        new
                        {
                            Id = new Guid("a8804243-d1f5-41d4-845b-ce39a1e7adee"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1b"),
                            Quantity = 100,
                            Size = 40
                        },
                        new
                        {
                            Id = new Guid("113fb710-5c97-4f4b-9a4e-e3379607459a"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1c"),
                            Quantity = 50,
                            Size = 39
                        },
                        new
                        {
                            Id = new Guid("1fe400f4-7209-4ed1-9e2c-a1e3b85ea130"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1c"),
                            Quantity = 100,
                            Size = 40
                        },
                        new
                        {
                            Id = new Guid("8bf9fcbb-32c1-482e-8343-cb1082469fae"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1c"),
                            Quantity = 50,
                            Size = 41
                        },
                        new
                        {
                            Id = new Guid("f3798d7d-5e7b-46e1-b835-39001d296df5"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1c"),
                            Quantity = 20,
                            Size = 42
                        },
                        new
                        {
                            Id = new Guid("500c6f5f-d265-4ee0-89a4-242c83362922"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1d"),
                            Quantity = 50,
                            Size = 39
                        },
                        new
                        {
                            Id = new Guid("96498e32-7cfa-4646-8f49-27ca356fe45f"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1d"),
                            Quantity = 100,
                            Size = 40
                        },
                        new
                        {
                            Id = new Guid("ff9fd3cf-d36b-4a72-bbe3-5e3fddd86a38"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1d"),
                            Quantity = 50,
                            Size = 41
                        },
                        new
                        {
                            Id = new Guid("fbe518f7-60bd-4c1e-b77e-23e02b9fdeba"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b14"),
                            Quantity = 50,
                            Size = 39
                        },
                        new
                        {
                            Id = new Guid("1d948b83-a954-410f-9fb3-64e5b3659e9f"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b14"),
                            Quantity = 100,
                            Size = 40
                        },
                        new
                        {
                            Id = new Guid("27b9e4f9-70f9-4e16-9a6e-39433f93dd80"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b14"),
                            Quantity = 50,
                            Size = 41
                        },
                        new
                        {
                            Id = new Guid("49eea858-cb8c-4d42-8e15-2c100d5f798b"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b15"),
                            Quantity = 50,
                            Size = 39
                        },
                        new
                        {
                            Id = new Guid("79b0fa32-1808-4add-aa9d-8fb2cafcb22f"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b15"),
                            Quantity = 100,
                            Size = 40
                        },
                        new
                        {
                            Id = new Guid("f0c042b9-d24a-418e-b926-0aa024a78069"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b15"),
                            Quantity = 50,
                            Size = 41
                        },
                        new
                        {
                            Id = new Guid("70f4116c-2615-4734-adea-4d95f4573779"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b15"),
                            Quantity = 20,
                            Size = 42
                        },
                        new
                        {
                            Id = new Guid("0c62ffae-37b1-4697-807f-2485379472c9"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b16"),
                            Quantity = 50,
                            Size = 39
                        },
                        new
                        {
                            Id = new Guid("19ea6354-e92e-41dc-9d32-7414cd1e633f"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b16"),
                            Quantity = 100,
                            Size = 40
                        },
                        new
                        {
                            Id = new Guid("66fcbe85-ff4e-47f1-8735-65c3298ab87b"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b16"),
                            Quantity = 50,
                            Size = 41
                        },
                        new
                        {
                            Id = new Guid("503d40dd-82a5-4c1e-af09-a57975993ba0"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b16"),
                            Quantity = 20,
                            Size = 42
                        });
                });

            modelBuilder.Entity("DataLayer.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FeedBackId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("FeedBackId")
                        .IsUnique()
                        .HasFilter("[FeedBackId] IS NOT NULL");

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

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0b"),
                            Brand = "Nike",
                            Catagories = "Shoes",
                            Color = "Purple",
                            Name = "Uzui Tengen",
                            PictureLink = "https://i.postimg.cc/B63gBjg1/Uzui-Tengen.jpg",
                            Price = 58m
                        },
                        new
                        {
                            Id = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0c"),
                            Brand = "Converse",
                            Catagories = "Shoes",
                            Color = "Black",
                            Name = "Spider-Verse",
                            PictureLink = "https://i.postimg.cc/908Y2JjG/Spider-Verse.png",
                            Price = 68m
                        },
                        new
                        {
                            Id = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0d"),
                            Brand = "Autry",
                            Catagories = "Shoes",
                            Color = "Silver",
                            Name = "Silver Serpent",
                            PictureLink = "https://i.postimg.cc/qRGGbpbD/Silver-Serpent.png",
                            Price = 49m
                        },
                        new
                        {
                            Id = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0e"),
                            Brand = "Nike",
                            Catagories = "Shoes",
                            Color = "Pink",
                            Name = "Sakura Blossom",
                            PictureLink = "https://i.postimg.cc/3wZQJYQg/Sakura-Blossom.jpg",
                            Price = 58m
                        },
                        new
                        {
                            Id = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0f"),
                            Brand = "Adidas",
                            Catagories = "Shoes",
                            Color = "Purple",
                            Name = "Nebula Burst",
                            PictureLink = "https://i.postimg.cc/SxXDSFRj/Nebula-Burst.jpg",
                            Price = 58m
                        },
                        new
                        {
                            Id = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1a"),
                            Brand = "Air Jordan",
                            Catagories = "Shoes",
                            Color = "Blue",
                            Name = "Lighting Thread",
                            PictureLink = "https://i.postimg.cc/vmfhnrWs/Lighting-Thread.png",
                            Price = 91m
                        },
                        new
                        {
                            Id = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1b"),
                            Brand = "Air Jordan",
                            Catagories = "Shoes",
                            Color = "Blue",
                            Name = "Enchanted Sponge Bob",
                            PictureLink = "https://i.postimg.cc/fWBKYT0J/Enchanted-Sponge-Bob.png",
                            Price = 63m
                        },
                        new
                        {
                            Id = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1c"),
                            Brand = "Nike",
                            Catagories = "Shoes",
                            Color = "Red",
                            Name = "Electric Dream",
                            PictureLink = "https://i.postimg.cc/m2pmW2b0/Electric-Dream.png",
                            Price = 78m
                        },
                        new
                        {
                            Id = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1d"),
                            Brand = "Puma",
                            Catagories = "Shoes",
                            Color = "Purple",
                            Name = "Crimson Blaze",
                            PictureLink = "https://i.postimg.cc/fR65k2SC/Crimson-Blaze.png",
                            Price = 46m
                        },
                        new
                        {
                            Id = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b14"),
                            Brand = "Nike",
                            Catagories = "Shoes",
                            Color = "Purple",
                            Name = "Airbrushed Sneakers",
                            PictureLink = "https://i.postimg.cc/VsR74W2s/Airbrushed-Sneakers.png",
                            Price = 99m
                        },
                        new
                        {
                            Id = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b15"),
                            Brand = "Converse",
                            Catagories = "Shoes",
                            Color = "Black",
                            Name = "Arkham Knight",
                            PictureLink = "https://i.postimg.cc/MHKmggg6/Arkham-Knight.png",
                            Price = 112m
                        },
                        new
                        {
                            Id = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b16"),
                            Brand = "Converse",
                            Catagories = "Shoes",
                            Color = "White",
                            Name = "Cute",
                            PictureLink = "https://i.postimg.cc/7YZKRTy3/Cute.jpg",
                            Price = 55m
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
                            Id = new Guid("1c4b8235-481d-4389-b78e-7d741344969e"),
                            Price = 10m,
                            Type = "Clean"
                        },
                        new
                        {
                            Id = new Guid("b05c50b8-8cd9-48be-b5ca-4d1efe14dab2"),
                            Price = 20m,
                            Type = "Repair"
                        },
                        new
                        {
                            Id = new Guid("b39fe7fa-a271-4ecd-816e-1c789efe6cd2"),
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

            modelBuilder.Entity("DataLayer.Entities.InStoreProduct", b =>
                {
                    b.HasOne("DataLayer.Entities.Product", "Product")
                        .WithMany("InStoreProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Product_InStoreProduct");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DataLayer.Entities.Order", b =>
                {
                    b.HasOne("DataLayer.Entities.Account", "Account")
                        .WithMany("Orders")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Account_Order");

                    b.HasOne("DataLayer.Entities.FeedBack", "FeedBack")
                        .WithOne("Order")
                        .HasForeignKey("DataLayer.Entities.Order", "FeedBackId")
                        .HasConstraintName("FK_Order_Feedback");

                    b.Navigation("Account");

                    b.Navigation("FeedBack");
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

            modelBuilder.Entity("DataLayer.Entities.FeedBack", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("DataLayer.Entities.Order", b =>
                {
                    b.Navigation("Payment");

                    b.Navigation("Products");

                    b.Navigation("Services");
                });

            modelBuilder.Entity("DataLayer.Entities.Product", b =>
                {
                    b.Navigation("InStoreProducts");

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