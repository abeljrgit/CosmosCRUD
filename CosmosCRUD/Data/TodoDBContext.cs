using CosmosCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CosmosCRUD.Data
{
    public class TodoDBContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        public TodoDBContext()
        {

        }
        public TodoDBContext(DbContextOptions<TodoDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // configuring Todos
            modelBuilder.Entity<Todo>()
                .ToContainer("Todo")
                .HasPartitionKey(e => e.Id);
        }
    }
}
