using Domain.Entities;
using Domain.Enums;

using Microsoft.EntityFrameworkCore;

namespace Data.DbContexts.AppDbContext;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Busket> Buskets { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                FullName = "Abdurahmonov Hojimurod",
                Email = "hojimurad2007@gmail.com",
                Gender = Gender.Male,
                Password = "6596443e7768f0c1ae055535783a3b6fcd3c2efb4fc0725336e31e087c4d10fc",
                Role = UserRole.SuperAdmin
            });
    }
}
