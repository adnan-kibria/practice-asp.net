using System.ComponentModel.DataAnnotations;

namespace DAL;

public class User
{
    [Key]
    public Guid Id {get; set;} = Guid.NewGuid();
    public string Email {get; set;}
    public string Password {get; set;}
    public int RoleId {get; set;}
    public Role Role {get; set;} = null!;
    public ICollection<Student> Students {get; set;} = new List<Student>();
    public ICollection<Teacher> Teachers {get; set;} = new List<Teacher>();
}
