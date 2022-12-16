using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Task = API.Models.Task;

namespace API.DataInterface
{
    public class DBContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DBContext() : base() { }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<User> User { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=TodoApp.db;");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Task>().ToTable("Task");
            builder.Entity<User>().ToTable("User");
        }
    }
}
