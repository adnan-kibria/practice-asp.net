using System.ComponentModel.DataAnnotations;

namespace DAL;

public class CourseTeacher
{
    [Key]
    public int Id {get; set;}
    public int CourseId {get; set;}
    public int TeacherId {get; set;}
    public Course Course {get; set;} = null!;
    public Teacher Teacher {get; set;} = null!;
}
