namespace DAL;

public class CourseRepo : ICourseRepo
{
    private readonly SchlDbContext _db;
    public CourseRepo(SchlDbContext db)
    {
        _db = db;
    }
    public bool Add(Course course)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Guid guid)
    {
        throw new NotImplementedException();
    }

    public Course Get(Guid guid)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Course> GetAll()
    {
        throw new NotImplementedException();
    }

    public bool Update(Course course)
    {
        throw new NotImplementedException();
    }
}
