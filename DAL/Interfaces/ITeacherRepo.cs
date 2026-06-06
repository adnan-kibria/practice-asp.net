namespace DAL;

public interface ITeacherRepo
{
    Task<IEnumerable<Teacher>> GetAll();
    Task<Teacher> Get(int id);
    Task<bool> Add(Teacher teacher);
    Task<bool> Update(Teacher teacher);
    Task<bool> Delete(int id);
}
