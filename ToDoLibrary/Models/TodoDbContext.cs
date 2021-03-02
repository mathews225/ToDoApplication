using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ToDoLibrary.Models {
	public class TodoDbContext : DbContext {

		public DbSet<Todo> Todos { get; set; }
		public DbSet<Category> Categories { get; set; }

		public TodoDbContext() { }

		protected override void OnConfiguring(DbContextOptionsBuilder builder) {
			if (!builder.IsConfigured) {
				var connectionString = "server=localhost\\sqlexpress;" +
					"database=TodoDb;" +
					"trusted_connection=true;";
				builder.UseSqlServer(connectionString);
			}
		}

		protected override void OnModelCreating(ModelBuilder builder) { }

	}
}
