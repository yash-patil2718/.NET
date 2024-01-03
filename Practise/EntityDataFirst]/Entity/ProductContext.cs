using BOL;
using Microsoft.EntityFrameworkCore;
namespace DLL;
public class ProductContext : DbContext
{
  public DbSet<Product> Pls { get; set; }
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    string constring = @"server=192.168.10.150;port=3306;user=dac15;password=welcome;database=dac15";
    optionsBuilder.UseMySQL(constring);
  }
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    modelBuilder.Entity<Product>(entity =>
    {
      entity.HasKey(e => e.Pid);
      entity.Property(e => e.Pnm);
      entity.Property(e => e.Qyt);
      entity.Property(e => e.Price);

    });
    modelBuilder.Entity<Product>().ToTable("product");
  }

}