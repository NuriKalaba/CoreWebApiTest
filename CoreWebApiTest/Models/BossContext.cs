using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApiTest.Models {
	public class BossContext: DbContext {
		public BossContext() { }
		public BossContext(DbContextOptions<BossContext> options) : base(options) { }
		public virtual DbSet<Account> Account { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			/*
			modelBuilder.Entity<Blog>(entity =>
			{
				entity.Property(e => e.Url).IsRequired();
			});

			modelBuilder.Entity<Post>(entity =>
			{
				entity.HasOne(d => d.Blog)
					.WithMany(p => p.Post)
					.HasForeignKey(d => d.BlogId);
			});
			*/
		}
	}
}
