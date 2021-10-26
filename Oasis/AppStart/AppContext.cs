using Oasis.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Oasis.AppStart
{
	public class AppContext : IdentityDbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Item> Items { get; set; }
		public DbSet<ItemTracker> ItemsTracker { get; set; }
		public DbSet<ShoppingList> ShoppingLists { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Graph> Graphs { get; set; }
		public DbSet<Review> Reviews { get; set; }
		public DbSet<ShoppingCart> ShoppingCart { get; set; }
		public AppContext(DbContextOptions<AppContext> options) : base(options)
		{
		}

		public AppContext()
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=ecommerce.sqlite");
		}
	}
}
