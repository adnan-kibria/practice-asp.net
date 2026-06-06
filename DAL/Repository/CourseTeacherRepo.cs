namespace DAL;

public class CourseTeacherRepo : ICourseTeacherRepo
{
    private readonly SchlDbContext _db;
    public CourseTeacherRepo(SchlDbContext db)
    {
        _db = db;
    }
    public CourseTeacher Get(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<CourseTeacher> GetAll()
    {
        throw new NotImplementedException();
    }
}
