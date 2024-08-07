using Entities;
using Microsoft.EntityFrameworkCore;

namespace Databases;
public class MainDbContext : DbContext
{
    public MainDbContext(DbContextOptions<MainDbContext> options): base(options){

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
    //config dbset
    public DbSet<ProductEntity> products {get; set;}
    // public DbSet<UserEntity> users {get; set;}
}
