namespace DAL;

public interface ICourseStudentRepo
{
    IEnumerable<CourseStudent> GetAll();
    CourseStudent Get(int id);
}
