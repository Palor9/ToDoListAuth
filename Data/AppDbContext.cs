using Microsoft.EntityFrameworkCore;
using ToDoListAuth.Models;
using ToDoListAuth.Data;

namespace  ToDoListAuth.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}

