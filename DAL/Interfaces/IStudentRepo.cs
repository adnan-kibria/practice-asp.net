namespace DAL;

public interface IStudentRepo
{
    Task<IEnumerable<Student>> GetAll();
    Task<Student> Get(int id);
    Task<bool> Add(Student student);
    Task<bool> Update(Student student);
    Task<bool> Delete(int id);
}
