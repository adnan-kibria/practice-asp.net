namespace DAL;

public interface ICourseRepo
{
    Task<IEnumerable<Course>> GetAll();
    Task<Course> Get(Guid guid);
    Task<bool> Add(Course course);
    Task<bool> Update(Course course);
    Task<bool> Delete(Guid guid);
}
