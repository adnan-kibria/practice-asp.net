namespace DAL;

public interface ICourseRepo
{
    IEnumerable<Course> GetAll();
    Course Get(Guid guid);
    bool Add(Course course);
    bool Update(Course course);
    bool Delete(Guid guid);
}
