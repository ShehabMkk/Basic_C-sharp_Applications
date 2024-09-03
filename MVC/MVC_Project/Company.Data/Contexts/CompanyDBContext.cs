using System.Reflection;
using Company.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Company.Data.Contexts;

public class CompanyDBContext : DbContext
{
    public CompanyDBContext(DbContextOptions<CompanyDBContext> options) : base(options)
    {
        
    }
    
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlServer(@"Server=.;Database=Company;Integrated Security=True;TrustServerCertificate=True;");
    // }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Employee>()
            .HasOne(e => e.Department)
            .WithMany(d => d.Employees)
            .HasForeignKey(e => e.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<Employee>().Property(e => e.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<Department>().Property(d => d.Id).ValueGeneratedOnAdd();
    }
}