using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Department> Departments { get; set; }

    // Optional: Override OnModelCreating if you have custom entity configurations
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure your entities here if needed
    }
}
