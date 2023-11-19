using CurdAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CurdAPI.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Admins> Admins { get; set; }
        public DbSet<TodoList> TodoList { get; set; }
    }
}
