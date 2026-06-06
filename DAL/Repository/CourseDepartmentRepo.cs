namespace DAL;

public class CourseDepartmentRepo : ICourseDepartmentRepo
{
    private readonly SchlDbContext _db;
    public CourseDepartmentRepo(SchlDbContext db)
    {
        _db = db;
    }
    public CourseDepartment Get(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<CourseDepartment> GetAll()
    {
        throw new NotImplementedException();
    }
}
