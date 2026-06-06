namespace DAL;

public class CourseStudentRepo : ICourseStudentRepo
{
    private readonly SchlDbContext _db;
    public CourseStudentRepo(SchlDbContext db)
    {
        _db = db;
    }

    public Task<CourseStudent> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CourseStudent>> GetAll()
    {
        throw new NotImplementedException();
    }
}
