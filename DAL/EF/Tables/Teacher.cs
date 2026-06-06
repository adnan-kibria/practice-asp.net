using System.ComponentModel.DataAnnotations;

namespace DAL;

public class Teacher
{
    [Key]
    public int Id {get; set;}
    public string Name {get; set;}
    public string Phone {get; set;}
    public string Address {get; set;}
    public Guid UserId {get; set;}
    public int DepartmentId {get; set;}
    public User User {get; set;} = null!;
    public Department Department {get; set;} = null!;
    public ICollection<CourseTeacher> CourseTeachers {get; set;} = new List<CourseTeacher>();
}
