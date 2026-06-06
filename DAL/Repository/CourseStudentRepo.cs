namespace DAL;

public class CourseStudentRepo : ICourseStudentRepo
{
    private readonly SchlDbContext _db;
    public CourseStudentRepo(SchlDbContext db)
    {
        _db = db;
    }
    public CourseStudent Get(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<CourseStudent> GetAll()
    {
        throw new NotImplementedException();
    }
}
