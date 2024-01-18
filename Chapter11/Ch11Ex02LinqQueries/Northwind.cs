using Microsoft.EntityFrameworkCore;

namespace Ch11Ex02LinqQueries;

public class Northwind : DbContext {
    public DbSet<Customer> Customers { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        string path = Path.Combine(Environment.CurrentDirectory, "Northwind.db");

        optionsBuilder.UseSqlite($"Filename={path}");
    }
}