using System;
using System.Collections.Generic;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataLayer;

public partial class SswdatabaseContext : DbContext
{
	public SswdatabaseContext()
	{
	}

	public SswdatabaseContext(DbContextOptions<SswdatabaseContext> options)
		: base(options)
	{
	}

	public virtual DbSet<Account> Accounts { get; set; }

	public virtual DbSet<AccountDetail> AccountDetails { get; set; }

	public virtual DbSet<FeedBack> FeedBacks { get; set; }

	public virtual DbSet<Image> Images { get; set; }

	public virtual DbSet<OrderProduct> OderProducts { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

	public virtual DbSet<OrderService> OrderServices { get; set; }

	public virtual DbSet<Payment> Payments { get; set; }

	public virtual DbSet<Product> Products { get; set; }

	public virtual DbSet<InStoreProduct> ProductInStores { get; set; }

	public virtual DbSet<Service> Services { get; set; }


	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		// Account & AccountDetail: One-to-One
		modelBuilder.Entity<Account>()
			.HasOne(a => a.AccountDetail)
			.WithOne(ad => ad.Account)
			.HasForeignKey<AccountDetail>(ad => ad.AccountId)
			.HasConstraintName("FK_Account_AccountDetail");

		// FeedBack & Order: One-to-One
		modelBuilder.Entity<FeedBack>()
			.HasKey(f => f.Id);
		modelBuilder.Entity<FeedBack>()
			.HasOne(f => f.Order)
			.WithOne(o => o.FeedBack)
			.HasForeignKey<Order>(o => o.FeedBackId)
			.HasConstraintName("FK_Order_Feedback");

		// Image & Account: Many-to-One
		modelBuilder.Entity<Image>()
			.HasKey(i => i.Id);
		modelBuilder.Entity<Image>()
			.HasOne(i => i.Account)
			.WithMany(a => a.Images)
			.HasForeignKey(i => i.AccountId)
			.HasConstraintName("FK_Account_Image");

		// Order & Account: Many-to-One
		modelBuilder.Entity<Order>()
			.HasKey(o => o.Id);
		modelBuilder.Entity<Order>()
			.HasOne(o => o.Account)
			.WithMany(a => a.Orders)
			.HasForeignKey(o => o.AccountId)
			.HasConstraintName("FK_Account_Order");

		// Product & OrderProduct: Many-to-Many
		modelBuilder.Entity<OrderProduct>()
			.HasKey(op => new { op.OrderId, op.ProductId });
		modelBuilder.Entity<OrderProduct>()
			.HasOne(op => op.Product)
			.WithMany(p => p.Orders)
			.HasForeignKey(op => op.ProductId)
			.HasConstraintName("FK_Product_OrderProduct");
		modelBuilder.Entity<OrderProduct>()
			.HasOne(op => op.Order)
			.WithMany(o => o.Products)
			.HasForeignKey(op => op.OrderId)
			.HasConstraintName("FK_Order_OrderProduct");

		// Service & OrderService: Many-to-Many
		modelBuilder.Entity<OrderService>()
			.HasKey(os => new { os.OrderId, os.ServiceId });
		modelBuilder.Entity<OrderService>()
			.HasOne(os => os.Service)
			.WithMany(s => s.Orders)
			.HasForeignKey(os => os.ServiceId)
			.HasConstraintName("FK_Service_OrderService");
		modelBuilder.Entity<OrderService>()
			.HasOne(os => os.Order)
			.WithMany(o => o.Services)
			.HasForeignKey(os => os.OrderId)
			.HasConstraintName("FK_Order_OrderService");

		// Order & Payment: One-to-One
		modelBuilder.Entity<Payment>()
			.HasKey(p => p.OrderId);
		modelBuilder.Entity<Payment>()
			.HasOne(p => p.Order)
			.WithOne(o => o.Payment)
			.HasForeignKey<Payment>(p => p.OrderId)
			.HasConstraintName("FK_Order_Payment");

		// Product & InStoreProduct: One-to-Many
		modelBuilder.Entity<InStoreProduct>()
			.HasKey(ips => ips.Id);
		modelBuilder.Entity<InStoreProduct>()
			.HasOne(ips => ips.Product)
			.WithMany(p => p.InStoreProducts)
			.HasForeignKey(ips => ips.ProductId)
			.HasConstraintName("FK_Product_InStoreProduct");

		#region Data Seeding
		modelBuilder.Entity<Product>().HasData(new Product()
		{
			Id = Guid.Parse("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0b"),
			Name = "Uzui Tengen",
			Brand = "Nike",
			Color = "Purple",
			Price = 58,
			Catagories = "Shoes",
			PictureLink = "https://i.postimg.cc/B63gBjg1/Uzui-Tengen.jpg"
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId = Guid.Parse("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0b"),
			Size = 40,
			Quantity = 100
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId = Guid.Parse("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0b"),
			Size = 41,
			Quantity = 50
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId = Guid.Parse("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0b"),
			Size = 42,
			Quantity = 20
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId = Guid.Parse("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0b"),
			Size = 43,
			Quantity = 10
		});

		modelBuilder.Entity<Product>().HasData(new Product()
		{
			Id = Guid.Parse("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0c"),
			Name = "Spider-Verse",
			Brand = "Converse",
			Color = "Black",
			Price = 68,
			Catagories = "Shoes",
			PictureLink = "https://i.postimg.cc/908Y2JjG/Spider-Verse.png"
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId = Guid.Parse("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0c"),
			Size = 40,
			Quantity = 100
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId = Guid.Parse("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0c"),
			Size = 41,
			Quantity = 50
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId = Guid.Parse("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0c"),
			Size = 42,
			Quantity = 20
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId = Guid.Parse("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0c"),
			Size = 43,
			Quantity = 10
		});

		modelBuilder.Entity<Product>().HasData(new Product()
		{
			Id = Guid.Parse("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0d"),
			Name = "Silver Serpent",
			Brand = "Autry",
			Color = "Silver",
			Price = 49,
			Catagories = "Shoes",
			PictureLink = "https://i.postimg.cc/qRGGbpbD/Silver-Serpent.png"
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId = Guid.Parse("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0d"),
			Size = 40,
			Quantity = 100
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId = Guid.Parse("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0d"),
			Size = 41,
			Quantity = 50
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId = Guid.Parse("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0d"),
			Size = 42,
			Quantity = 20
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId = Guid.Parse("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0d"),
			Size = 43,
			Quantity = 10
		});

		modelBuilder.Entity<Product>().HasData(new Product()
		{
			Id = Guid.Parse("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0e"),
			Name = "Sakura Blossom",
			Brand = "Nike",
			Color = "Pink",
			Price = 58,
			Catagories = "Shoes",
			PictureLink = "https://i.postimg.cc/3wZQJYQg/Sakura-Blossom.jpg"
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId = Guid.Parse("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0e"),
			Size = 40,
			Quantity = 100
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId = Guid.Parse("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0e"),
			Size = 41,
			Quantity = 50
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId = Guid.Parse("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0e"),
			Size = 42,
			Quantity = 20
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId = Guid.Parse("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0e"),
			Size = 43,
			Quantity = 10
		});

		modelBuilder.Entity<Product>().HasData(new Product()
		{
			Id = Guid.Parse("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0f"),
			Name = "Nebula Burst",
			Brand = "Adidas",
			Color = "Purple",
			Price = 58,
			Catagories = "Shoes",
			PictureLink = "https://i.postimg.cc/SxXDSFRj/Nebula-Burst.jpg"
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId = Guid.Parse("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0f"),
			Size = 39,
			Quantity = 50
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId = Guid.Parse("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0f"),
			Size = 40,
			Quantity = 100
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId = Guid.Parse("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0f"),
			Size = 41,
			Quantity = 50
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId =  Guid.Parse("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0f"),
			Size = 42,
			Quantity = 20
		});

		modelBuilder.Entity<Product>().HasData(new Product()
		{
			Id = Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1a"),
			Name = "Lighting Thread",
			Brand = "Air Jordan",
			Color = "Blue",
			Price = 91,
			Catagories = "Shoes",
			PictureLink = "https://i.postimg.cc/vmfhnrWs/Lighting-Thread.png"
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId =  Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1a"),
			Size = 39,
			Quantity = 50
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId =  Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1a"),
			Size = 40,
			Quantity = 100
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId =  Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1a"),
			Size = 41,
			Quantity = 50
		});

		modelBuilder.Entity<Product>().HasData(new Product()
		{
			Id = Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1b"),
			Name = "Enchanted Sponge Bob",
			Brand = "Air Jordan",
			Color = "Blue",
			Price = 63,
			Catagories = "Shoes",
			PictureLink = "https://i.postimg.cc/fWBKYT0J/Enchanted-Sponge-Bob.png"
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId =  Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1b"),
			Size = 39,
			Quantity = 50
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId =  Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1b"),
			Size = 40,
			Quantity = 100
		});

		modelBuilder.Entity<Product>().HasData(new Product()
		{
			Id = Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1c"),
			Name = "Electric Dream",
			Brand = "Nike",
			Color = "Red",
			Price = 78,
			Catagories = "Shoes",
			PictureLink = "https://i.postimg.cc/m2pmW2b0/Electric-Dream.png"
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId =  Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1c"),
			Size = 39,
			Quantity = 50
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id = Guid.NewGuid(),
			ProductId =  Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1c"),
			Size = 40,
			Quantity = 100
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id =  Guid.NewGuid(),
			ProductId =  Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1c"),
			Size = 41,
			Quantity = 50
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id =  Guid.NewGuid(),
			ProductId =  Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1c"),
			Size = 42,
			Quantity = 20
		});

		modelBuilder.Entity<Product>().HasData(new Product()
		{
			Id = Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1d"),
			Name = "Crimson Blaze",
			Brand = "Puma",
			Color = "Purple",
			Price = 46,
			Catagories = "Shoes",
			PictureLink = "https://i.postimg.cc/fR65k2SC/Crimson-Blaze.png"
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id =  Guid.NewGuid(),
			ProductId =  Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1d"),
			Size = 39,
			Quantity = 50
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id =  Guid.NewGuid(),
			ProductId =  Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1d"),
			Size = 40,
			Quantity = 100
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id =  Guid.NewGuid(),
			ProductId =  Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1d"),
			Size = 41,
			Quantity = 50
		});

		modelBuilder.Entity<Product>().HasData(new Product()
		{
			Id = Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b14"),
			Name = "Airbrushed Sneakers",
			Brand = "Nike",
			Color = "Purple",
			Price = 99,
			Catagories = "Shoes",
			PictureLink = "https://i.postimg.cc/VsR74W2s/Airbrushed-Sneakers.png"
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id =  Guid.NewGuid(),
			ProductId =  Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b14"),
			Size = 39,
			Quantity = 50
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id =  Guid.NewGuid(),
			ProductId =  Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b14"),
			Size = 40,
			Quantity = 100
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id =  Guid.NewGuid(),
			ProductId =  Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b14"),
			Size = 41,
			Quantity = 50
		});

		modelBuilder.Entity<Product>().HasData(new Product()
		{
			Id = Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b15"),
			Name = "Arkham Knight",
			Brand = "Converse",
			Color = "Black",
			Price = 112,
			Catagories = "Shoes",
			PictureLink = "https://i.postimg.cc/MHKmggg6/Arkham-Knight.png"
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id =  Guid.NewGuid(),
			ProductId =  Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b15"),
			Size = 39,
			Quantity = 50
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id =  Guid.NewGuid(),
			ProductId = Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b15"),
			Size = 40,
			Quantity = 100
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id =  Guid.NewGuid(),
			ProductId = Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b15"),
			Size = 41,
			Quantity = 50
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id =  Guid.NewGuid(),
			ProductId = Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b15"),
			Size = 42,
			Quantity = 20
		});

		modelBuilder.Entity<Product>().HasData(new Product()
		{
			Id = Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b16"),
			Name = "Cute",
			Brand = "Converse",
			Color = "White",
			Price = 55,
			Catagories = "Shoes",
			PictureLink = "https://i.postimg.cc/7YZKRTy3/Cute.jpg"
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id =  Guid.NewGuid(),
			ProductId = Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b16"),
			Size = 39,
			Quantity = 50
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id =  Guid.NewGuid(), 
			ProductId = Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b16"),
			Size = 40,
			Quantity = 100
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id =  Guid.NewGuid(), 
			ProductId = Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b16"),
			Size = 41,
			Quantity = 50
		});
		modelBuilder.Entity<InStoreProduct>().HasData(new InStoreProduct()
		{
			Id =  Guid.NewGuid(), 
			ProductId = Guid.Parse("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b16"),
			Size = 42,
			Quantity = 20
		});

		modelBuilder.Entity<Service>().HasData(new Service()
		{
			Id = Guid.NewGuid(),
			Type = "Clean",
			Price = 10
		});
		modelBuilder.Entity<Service>().HasData(new Service()
		{
			Id = Guid.NewGuid(),
			Type = "Repair",
			Price = 20
		});
		modelBuilder.Entity<Service>().HasData(new Service()
		{
			Id = Guid.NewGuid(),
			Type = "Customize",
			Price = 30
		});

		modelBuilder.Entity<Account>().HasData(new Account()
		{
			Id = Guid.NewGuid(),
			Username = "admin",
			Password = "123456",
			Role = AccountRole.Admin,
			Status = AccountStatus.Active
		});
		modelBuilder.Entity<Account>().HasData(new Account()
		{
			Id= Guid.NewGuid(),
			Username = "customer",
			Password = "123456",
			Role = AccountRole.Customer,
			Status = AccountStatus.Active
		});
		modelBuilder.Entity<Account>().HasData(new Account()
		{
			Id = Guid.NewGuid(),
			Username = "staff",
			Password = "123456",
			Role = AccountRole.Staff,
			Status = AccountStatus.Active
		});
		#endregion
		OnModelCreatingPartial(modelBuilder);
	}

	partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
