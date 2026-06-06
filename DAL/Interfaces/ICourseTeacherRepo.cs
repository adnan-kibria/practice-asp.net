namespace DAL;

public interface ICourseTeacherRepo
{
    Task<IEnumerable<CourseTeacher>> GetAll();
    Task<CourseTeacher> Get(int id);
}
