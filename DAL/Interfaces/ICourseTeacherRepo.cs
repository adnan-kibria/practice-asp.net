namespace DAL;

public interface ICourseTeacherRepo
{
    IEnumerable<CourseTeacher> GetAll();
    CourseTeacher Get(int id);
}
