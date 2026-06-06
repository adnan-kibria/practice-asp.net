namespace DAL;

public class CourseTeacherRepo : ICourseTeacherRepo
{
    private readonly SchlDbContext _db;
    public CourseTeacherRepo(SchlDbContext db)
    {
        _db = db;
    }

    public Task<CourseTeacher> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CourseTeacher>> GetAll()
    {
        throw new NotImplementedException();
    }
}
