using System.ComponentModel.DataAnnotations;

namespace DAL;

public class CourseDepartment
{
    [Key]
    public int Id {get; set;}
    public int CourseId {get; set;}
    public int DepartmentId {get; set;}
    public Course Course {get; set;} = null!;
    public Department Department {get; set;} = null!;
}
