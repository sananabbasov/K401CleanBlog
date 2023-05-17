using System;
using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}

		public DbSet<Article> Articles { get; set; }
		public DbSet<Author> Authors { get; set; }
	}
}

