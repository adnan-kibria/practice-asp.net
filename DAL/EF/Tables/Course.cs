using System.ComponentModel.DataAnnotations;

namespace DAL;

public class Course
{
    [Key]
    public int Id {get; set;}
    public string Name {get; set;}
    public float Credit {get; set;}
    public ICollection<CourseDepartment> CourseDepartments {get; set;} = new List<CourseDepartment>();
    public ICollection<CourseStudent> CourseStudents {get; set;} = new List<CourseStudent>();
    public ICollection<CourseTeacher> CourseTeachers {get; set;} = new List<CourseTeacher>();
}
