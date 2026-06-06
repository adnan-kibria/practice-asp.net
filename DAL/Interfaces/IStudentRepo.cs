namespace DAL;

public interface IStudentRepo
{
    IEnumerable<Student> GetAll();
    Student Get(int id);
    bool Add(Student student);
    bool Update(Student student);
    bool Delete(int id);
}
