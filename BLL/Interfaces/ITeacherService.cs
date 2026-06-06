namespace BLL;

public interface ITeacherService
{
    Task<IEnumerable<TeacherDTO>> GetAll();
    Task<TeacherDTO> Get(int id);
    Task<bool> Add(TeacherDTO teacher);
    Task<bool> Update(TeacherDTO teacher);
    Task<bool> Delete(int id);
}
