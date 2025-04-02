using FirstApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Student> StudentTable { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id = 101,
                    Name = "Steve",
                    Surname = "Smith",
                    Email = "ssusuuusis",
                    Phone = 8838339
                },
                new Student()
                {
                    Id = 102,
                    Name = "Sara",
                    Surname = "Smith",
                    Email = "ssusuuusis",
                    Phone = 8838339
                }
                );
        }
    }
}
