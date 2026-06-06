namespace DAL;

public interface ICourseStudentRepo
{
    Task<IEnumerable<CourseStudent>> GetAll();
    Task<CourseStudent> Get(int id);
}
