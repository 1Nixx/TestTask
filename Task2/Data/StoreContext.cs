using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Reflection;
using System.Xml.Linq;
using Task2.Models;

namespace Task2.Data
{
	public class StoreContext : DbContext
	{
		public StoreContext(DbContextOptions<StoreContext> options) : base(options)
		{

		}

		public DbSet<Shop> Shops { get; set; }
		public DbSet<Item> Items { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Shop>()
				.Property(p => p.Name)
				.IsRequired();
			modelBuilder.Entity<Shop>()
				.Property(p => p.Address)
				.IsRequired();
			modelBuilder.Entity<Shop>()
				.Property(p => p.WorkingHours)
				.IsRequired();
			modelBuilder.Entity<Shop>()
				.HasMany(p => p.Items)
				.WithOne()
				.IsRequired();

			modelBuilder.Entity<Item>()
				.Property(p => p.Name)
				.IsRequired();
			modelBuilder.Entity<Item>()
				.Property(p => p.Description)
				.IsRequired();
			
		}
	}
}
