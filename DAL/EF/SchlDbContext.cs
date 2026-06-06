using Microsoft.EntityFrameworkCore;

namespace DAL;

public class SchlDbContext : DbContext
{
    public SchlDbContext(DbContextOptions<SchlDbContext> options) : base(options){}

    public DbSet<User> Users {get; set;}
    public DbSet<Teacher> Teachers {get; set;}
    public DbSet<Student>Students {get; set;}
    public DbSet<Role> Roles {get; set;}
    public DbSet<Department> Departments {get; set;}
    public DbSet<CourseTeacher> CourseTeachers {get; set;}
    public DbSet<CourseStudent> CourseStudents {get; set;}
    public DbSet<CourseDepartment> CourseDepartments {get; set;}
    public DbSet<Course> Courses {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Role>().HasData(
            new Role {Id = 2, Name = "student"},
            new Role {Id = 3, Name = "teacher"}
        );
    }
}
