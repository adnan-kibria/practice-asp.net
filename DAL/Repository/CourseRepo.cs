namespace DAL;

public class CourseRepo : ICourseRepo
{
    private readonly SchlDbContext _db;
    public CourseRepo(SchlDbContext db)
    {
        _db = db;
    }

    public Task<bool> Add(Course course)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(Guid guid)
    {
        throw new NotImplementedException();
    }

    public Task<Course> Get(Guid guid)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Course>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<bool> Update(Course course)
    {
        throw new NotImplementedException();
    }
}
