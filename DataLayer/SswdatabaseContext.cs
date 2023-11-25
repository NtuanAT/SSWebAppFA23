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

	public virtual DbSet<OrderProduct> OrderProducts { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

	public virtual DbSet<OrderService> OrderServices { get; set; }

	public virtual DbSet<Payment> Payments { get; set; }

	public virtual DbSet<Product> Products { get; set; }

	public virtual DbSet<Service> Services { get; set; }


	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Account>().HasOne(a => a.AccountDetail).WithOne(a => a.Account)
			.HasConstraintName("FK_Account_AccountDetail");

		modelBuilder.Entity<FeedBack>().HasKey(f => f.Id);
		modelBuilder.Entity<FeedBack>().HasOne(f => f.Order).WithOne(o => o.FeedBack)
			.HasConstraintName("FK_Order_Feedback");

		modelBuilder.Entity<Image>().HasKey(i => i.Id);
		modelBuilder.Entity<Image>().HasOne(i => i.Account).WithMany(a => a.Images)
			.HasConstraintName("FK_Account_Image");

		modelBuilder.Entity<Order>().HasKey(o => o.Id);
		modelBuilder.Entity<Order>().HasOne(o => o.Account).WithMany(a => a.Orders)
			.HasConstraintName("FK_Account_Order");

		modelBuilder.Entity<Product>().HasKey(p => p.Id);
		modelBuilder.Entity<Service>().HasKey(s => s.Id);

		modelBuilder.Entity<OrderProduct>().HasKey(op => new { op.OrderId, op.ProductId });
		modelBuilder.Entity<OrderProduct>().HasOne(op => op.Product).WithMany(p => p.Orders)
			.HasConstraintName("FK_Product_OrderProduct");
		modelBuilder.Entity<OrderProduct>().HasOne(op => op.Order).WithMany(o => o.Products)
			.HasConstraintName("FK_Order_OrderProduct");

		modelBuilder.Entity<OrderService>().HasKey(os => new { os.OrderId, os.ServiceId });
		modelBuilder.Entity<OrderService>().HasOne(os => os.Service).WithMany(s => s.Orders)
			.HasConstraintName("FK_Service_OrderService");
		modelBuilder.Entity<OrderService>().HasOne(os => os.Order).WithMany(o => o.Services)
			.HasConstraintName("FK_Order_OrderService");

		modelBuilder.Entity<Payment>().HasKey(p => p.OrderId);
		modelBuilder.Entity<Payment>().HasOne(p => p.Order).WithOne(o => o.Payment)
			.HasConstraintName("FK_Order_Payment");

		#region Data Seeding
		modelBuilder.Entity<Product>().HasData(new Product()
		{
			Id = Guid.NewGuid(),
			Name = "Uzui Tengen",
			Brand = "Nike",
			Color = "Purple",
			Price = 58,
			Catagories = "Shoes",
			Size = 40,
			PictureLink = "https://i.postimg.cc/B63gBjg1/Uzui-Tengen.jpg"
		});
		modelBuilder.Entity<Product>().HasData(new Product()
		{
			Id = Guid.NewGuid(),
			Name = "Spider-Verse",
			Brand = "Converse",
			Color = "Black",
			Price = 68,
			Catagories = "Shoes",
			Size = 41,
			PictureLink = "https://i.postimg.cc/908Y2JjG/Spider-Verse.png"
		});
		modelBuilder.Entity<Product>().HasData(new Product()
		{
			Id = Guid.NewGuid(),
			Name = "Silver Serpent",
			Brand = "Autry",
			Color = "Silver",
			Price = 49,
			Catagories = "Shoes",
			Size = 39,
			PictureLink = "https://i.postimg.cc/qRGGbpbD/Silver-Serpent.png"
		});
		modelBuilder.Entity<Product>().HasData(new Product()
		{
			Id = Guid.NewGuid(),
			Name = "Nebula Burst",
			Brand = "Adidas",
			Color = "Purple",
			Price = 58,
			Catagories = "Shoes",
			Size = 38,
			PictureLink = "https://i.postimg.cc/SxXDSFRj/Nebula-Burst.jpg"
		});
		modelBuilder.Entity<Product>().HasData(new Product()
		{
			Id = Guid.NewGuid(),
			Name = "Lighting Thread",
			Brand = "Air Jordan",
			Color = "Blue",
			Price = 91,
			Catagories = "Shoes",
			Size = 42,
			PictureLink = "https://i.postimg.cc/vmfhnrWs/Lighting-Thread.png"
		});
		modelBuilder.Entity<Product>().HasData(new Product()
		{
			Id = Guid.NewGuid(),
			Name = "Enchanted Sponge Bob",
			Brand = "Air Jordan",
			Color = "Blue",
			Price = 63,
			Catagories = "Shoes",
			Size = 36,
			PictureLink = "https://i.postimg.cc/fWBKYT0J/Enchanted-Sponge-Bob.png"
		});
		modelBuilder.Entity<Product>().HasData(new Product()
		{
			Id = Guid.NewGuid(),
			Name = "Electric Dream",
			Brand = "Nike",
			Color = "Red",
			Price = 78,
			Catagories = "Shoes",
			Size = 43,
			PictureLink = "https://i.postimg.cc/m2pmW2b0/Electric-Dream.png"
		});
		modelBuilder.Entity<Product>().HasData(new Product()
		{
			Id = Guid.NewGuid(),
			Name = "Crimson Blaze",
			Brand = "Puma",
			Color = "Purple",
			Price = 46,
			Catagories = "Shoes",
			Size = 45,
			PictureLink = "https://i.postimg.cc/fR65k2SC/Crimson-Blaze.png"
		});
		modelBuilder.Entity<Product>().HasData(new Product()
		{
			Id = Guid.NewGuid(),
			Name = "Airbrushed Sneakers",
			Brand = "Nike",
			Color = "Purple",
			Price = 99,
			Catagories = "Shoes",
			Size = 35,
			PictureLink = "https://i.postimg.cc/VsR74W2s/Airbrushed-Sneakers.png"
		});
		modelBuilder.Entity<Product>().HasData(new Product()
		{
			Id = Guid.NewGuid(),
			Name = "Arkham Knight",
			Brand = "Converse",
			Color = "Black",
			Price = 112,
			Catagories = "Shoes",
			Size = 38,
			PictureLink = "https://i.postimg.cc/MHKmggg6/Arkham-Knight.png"
		});
		modelBuilder.Entity<Product>().HasData(new Product()
		{
			Id = Guid.NewGuid(),
			Name = "Cute",
			Brand = "Converse",
			Color = "White",
			Price = 55,
			Catagories = "Shoes",
			Size = 40,
			PictureLink = "https://i.postimg.cc/7YZKRTy3/Cute.jpg"
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
