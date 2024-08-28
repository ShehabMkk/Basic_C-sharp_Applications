using Microsoft.EntityFrameworkCore;

namespace Assignment_01_EF;

public class SchoolContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Topic> Topics { get; set; }
    public DbSet<Stud_Course> Stud_Courses { get; set; }
    public DbSet<Course_Inst> Course_Insts { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Truck> Trucks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.;Database=ITI;Integrated Security=True;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Student-Department (Many-to-One)
        modelBuilder.Entity<Student>()
            .HasOne(s => s.Department)
            .WithMany(d => d.Students)
            .HasForeignKey(s => s.Dep_Id);

        // Department-Instructor (One-to-One)
        modelBuilder.Entity<Instructor>()
            .HasOne(i => i.Department)
            .WithOne(d => d.Instructor)
            .HasForeignKey<Instructor>(i => i.Dept_Id);

        // Course-Topic (Many-to-One)
        modelBuilder.Entity<Course>()
            .HasOne(c => c.Topic)
            .WithMany(t => t.Courses)
            .HasForeignKey(c => c.Top_Id);

        // Stud_Course (Many-to-Many: Student-Course)
        modelBuilder.Entity<Stud_Course>()
            .HasKey(sc => new { sc.Stud_Id, sc.Course_Id });

        modelBuilder.Entity<Stud_Course>()
            .HasOne(sc => sc.Student)
            .WithMany(s => s.Stud_Courses)
            .HasForeignKey(sc => sc.Stud_Id);

        modelBuilder.Entity<Stud_Course>()
            .HasOne(sc => sc.Course)
            .WithMany(c => c.Stud_Courses)
            .HasForeignKey(sc => sc.Course_Id);

        // Course_Inst (Many-to-Many: Course-Instructor)
        modelBuilder.Entity<Course_Inst>()
            .HasKey(ci => new { ci.Course_Id, ci.Inst_Id });

        modelBuilder.Entity<Course_Inst>()
            .HasOne(ci => ci.Course)
            .WithMany(c => c.Course_Insts)
            .HasForeignKey(ci => ci.Course_Id);

        modelBuilder.Entity<Course_Inst>()
            .HasOne(ci => ci.Instructor)
            .WithMany(i => i.Course_Insts)
            .HasForeignKey(ci => ci.Inst_Id);
    }
}
