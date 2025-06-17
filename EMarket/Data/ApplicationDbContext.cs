using EMarket.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EMarket.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Categories> Categories => Set<Categories>();

    public DbSet<Goods> Goods => Set<Goods>();  

    public DbSet<Sales> Sales => Set<Sales>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder
            .Entity<Categories>()
            .Property(e => e.Created)
            .HasDefaultValueSql("now()");

        builder
           .Entity<Goods>()
           .Property(e => e.Created)
           .HasDefaultValueSql("now()");

        builder
           .Entity<Sales>()
           .Property(e => e.Created)
           .HasDefaultValueSql("now()");
    }
}
