namespace BLL;

public interface IStudentService
{
    Task<IEnumerable<StudentDTO>> GetAll();
    Task<StudentDTO> Get(int id);
    Task<bool> Add(StudentDTO student);
    Task<bool> Update(StudentDTO student);
    Task<bool> Delete(int id);
}
