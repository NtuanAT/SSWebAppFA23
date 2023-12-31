﻿// <auto-generated />
using System;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataLayer.Migrations
{
    [DbContext(typeof(SswdatabaseContext))]
    partial class SswdatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("a6eb62e2-3d04-4bcc-8c03-62528503ba59"),
                            Password = "123456",
                            Role = 1,
                            Status = 0,
                            Username = "admin"
                        },
                        new
                        {
                            Id = new Guid("117e2ca0-ac44-4aeb-b406-d3e4b24764f2"),
                            Password = "123456",
                            Role = 0,
                            Status = 0,
                            Username = "customer"
                        },
                        new
                        {
                            Id = new Guid("1d906e11-843e-463f-a074-a69f88a6da3f"),
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
                            Id = new Guid("3075a4ab-0a3d-452e-92f6-fdf934a8b23f"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0b"),
                            Quantity = 100,
                            Size = 40
                        },
                        new
                        {
                            Id = new Guid("40b6b7dd-fd6e-4d09-87c6-a8f445e73217"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0b"),
                            Quantity = 50,
                            Size = 41
                        },
                        new
                        {
                            Id = new Guid("7e09d769-b46e-4397-98f9-8fd8cdf2d067"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0b"),
                            Quantity = 20,
                            Size = 42
                        },
                        new
                        {
                            Id = new Guid("62126987-002e-4231-a202-3463c0b6d0c7"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0b"),
                            Quantity = 10,
                            Size = 43
                        },
                        new
                        {
                            Id = new Guid("da665e8a-004a-4744-876c-a4bfd3efca66"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0c"),
                            Quantity = 100,
                            Size = 40
                        },
                        new
                        {
                            Id = new Guid("60a1febf-9e02-4257-b141-114a15769810"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0c"),
                            Quantity = 50,
                            Size = 41
                        },
                        new
                        {
                            Id = new Guid("94e5bb88-b280-4af8-926a-0d861ff25afd"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0c"),
                            Quantity = 20,
                            Size = 42
                        },
                        new
                        {
                            Id = new Guid("03a75d63-8983-44c5-a754-3e3ff127f17e"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0c"),
                            Quantity = 10,
                            Size = 43
                        },
                        new
                        {
                            Id = new Guid("4207743a-2c3e-4731-bb7f-dbc128210f40"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0d"),
                            Quantity = 100,
                            Size = 40
                        },
                        new
                        {
                            Id = new Guid("55762b56-418b-4432-bb16-7510ea147c1c"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0d"),
                            Quantity = 50,
                            Size = 41
                        },
                        new
                        {
                            Id = new Guid("698abb5e-16d1-4f7f-a346-1d0c7c1f54fc"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0d"),
                            Quantity = 20,
                            Size = 42
                        },
                        new
                        {
                            Id = new Guid("8aa65e2b-0e35-458c-af53-bdf5bd2d850a"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0d"),
                            Quantity = 10,
                            Size = 43
                        },
                        new
                        {
                            Id = new Guid("31ff6022-72f1-42f9-b13c-eaba7cd3f720"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0e"),
                            Quantity = 100,
                            Size = 40
                        },
                        new
                        {
                            Id = new Guid("763c7b5b-91ff-4002-ab8d-ad88c1b977f5"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0e"),
                            Quantity = 50,
                            Size = 41
                        },
                        new
                        {
                            Id = new Guid("3def1da9-0ebb-430c-a8c4-0a5c6184d000"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0e"),
                            Quantity = 20,
                            Size = 42
                        },
                        new
                        {
                            Id = new Guid("a0ba14a8-e2b5-4b6d-9b58-c9e69f6fbfe3"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0e"),
                            Quantity = 10,
                            Size = 43
                        },
                        new
                        {
                            Id = new Guid("7a9d063f-ee9f-4312-806a-8f9ae8aff814"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0f"),
                            Quantity = 50,
                            Size = 39
                        },
                        new
                        {
                            Id = new Guid("50f54c91-6b12-4689-b8ea-7b297e4709e6"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0f"),
                            Quantity = 100,
                            Size = 40
                        },
                        new
                        {
                            Id = new Guid("93447964-eb09-474f-93bc-6df5445a21fd"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0f"),
                            Quantity = 50,
                            Size = 41
                        },
                        new
                        {
                            Id = new Guid("8d845883-8f05-4a7e-85d6-6ab4cc3c5f31"),
                            ProductId = new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0f"),
                            Quantity = 20,
                            Size = 42
                        },
                        new
                        {
                            Id = new Guid("4ceddbbf-2347-4691-b33b-1d7e7b8b451d"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1a"),
                            Quantity = 50,
                            Size = 39
                        },
                        new
                        {
                            Id = new Guid("1b0209d9-1a4e-4d9d-956b-0300318f8209"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1a"),
                            Quantity = 100,
                            Size = 40
                        },
                        new
                        {
                            Id = new Guid("8133167a-61b2-4126-a8e7-65a890e1e235"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1a"),
                            Quantity = 50,
                            Size = 41
                        },
                        new
                        {
                            Id = new Guid("9f61b00d-c8c2-4c96-bd13-9e9d933d448f"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1b"),
                            Quantity = 50,
                            Size = 39
                        },
                        new
                        {
                            Id = new Guid("b8e03daa-bebe-40f4-a128-ca27da9c013f"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1b"),
                            Quantity = 100,
                            Size = 40
                        },
                        new
                        {
                            Id = new Guid("d4293eba-2b11-47ce-b520-7a1260d6ec1d"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1c"),
                            Quantity = 50,
                            Size = 39
                        },
                        new
                        {
                            Id = new Guid("539afa7e-cc0b-4034-bc0d-84e0036cb376"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1c"),
                            Quantity = 100,
                            Size = 40
                        },
                        new
                        {
                            Id = new Guid("e59ae021-63c5-43dd-bf7d-02b0ce9127a9"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1c"),
                            Quantity = 50,
                            Size = 41
                        },
                        new
                        {
                            Id = new Guid("ade5e87d-551d-4639-8159-2f78868de6b8"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1c"),
                            Quantity = 20,
                            Size = 42
                        },
                        new
                        {
                            Id = new Guid("14eb92b7-cf8c-4e8c-9689-53c15c0556a4"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1d"),
                            Quantity = 50,
                            Size = 39
                        },
                        new
                        {
                            Id = new Guid("7cff2765-0c5d-4554-b253-ace77fc4e12c"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1d"),
                            Quantity = 100,
                            Size = 40
                        },
                        new
                        {
                            Id = new Guid("32984a97-c983-4f32-a2cb-806b8471d164"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1d"),
                            Quantity = 50,
                            Size = 41
                        },
                        new
                        {
                            Id = new Guid("3adb4629-97cd-4aa4-a873-0d10c04ba432"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b14"),
                            Quantity = 50,
                            Size = 39
                        },
                        new
                        {
                            Id = new Guid("15fffc34-4395-47d8-86aa-db6c9fd8b433"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b14"),
                            Quantity = 100,
                            Size = 40
                        },
                        new
                        {
                            Id = new Guid("3f978159-0ca2-4d23-a961-765df2ced51b"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b14"),
                            Quantity = 50,
                            Size = 41
                        },
                        new
                        {
                            Id = new Guid("2e3c639e-853f-43a5-8f69-cbc3f3f2c509"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b15"),
                            Quantity = 50,
                            Size = 39
                        },
                        new
                        {
                            Id = new Guid("bdfe324e-dd95-4177-a6db-dc16b06cfa17"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b15"),
                            Quantity = 100,
                            Size = 40
                        },
                        new
                        {
                            Id = new Guid("3538c17a-7e34-4bd6-a4a4-5b90663c4d6f"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b15"),
                            Quantity = 50,
                            Size = 41
                        },
                        new
                        {
                            Id = new Guid("8445b3af-6aad-4ab2-89ef-c76ddb2b8a03"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b15"),
                            Quantity = 20,
                            Size = 42
                        },
                        new
                        {
                            Id = new Guid("ab1b34ad-33df-429e-b390-054c17d9c297"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b16"),
                            Quantity = 50,
                            Size = 39
                        },
                        new
                        {
                            Id = new Guid("3fb8e59a-2104-4256-b79d-328904a3ec87"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b16"),
                            Quantity = 100,
                            Size = 40
                        },
                        new
                        {
                            Id = new Guid("168220b2-a1ed-48ba-bb0f-20323e7a23e7"),
                            ProductId = new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b16"),
                            Quantity = 50,
                            Size = 41
                        },
                        new
                        {
                            Id = new Guid("02a84c5d-5c54-4152-a984-c56d9e2add16"),
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

                    b.Property<int>("Size")
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
                            Id = new Guid("be04671b-3dc8-4198-8a6a-e35a4a56ff15"),
                            Price = 10m,
                            Type = "Clean"
                        },
                        new
                        {
                            Id = new Guid("9a5b493d-7d0d-4cd7-bd23-f006636ee9a0"),
                            Price = 20m,
                            Type = "Repair"
                        },
                        new
                        {
                            Id = new Guid("2573361f-ffdc-4817-bc6c-1114369e31da"),
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
