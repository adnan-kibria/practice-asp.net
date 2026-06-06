using System.ComponentModel.DataAnnotations;

namespace DAL;

public class Department
{
    [Key]
    public int Id {get; set;}
    public string Name {get; set;}
    public ICollection<Student> Students {get; set;} = new List<Student>();
    public ICollection<Teacher> Teachers {get; set;} = new List<Teacher>();
    public ICollection<CourseDepartment> CourseDepartments {get; set;} = new List<CourseDepartment>(); 
}
