using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data;

public class AppDbContext : DbContext
{

  public DbSet<Ticket> Tickets { get; set; }
  public DbSet<Customer> Customers { get; set; }

  public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
  {
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    base.OnModelCreating(modelBuilder);
  }
}
