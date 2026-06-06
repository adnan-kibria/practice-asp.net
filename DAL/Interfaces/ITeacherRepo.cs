namespace DAL;

public interface ITeacherRepo
{
    IEnumerable<Teacher> GetAll();
    Teacher Get(int id);
    bool Add(Teacher teacher);
    bool Update(Teacher teacher);
    bool Delete(int id);
}
