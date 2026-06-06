namespace DAL;

public class DepartmentRepo : IDepartmentRepo
{
    private readonly SchlDbContext _db;
    public DepartmentRepo(SchlDbContext db)
    {
        _db = db;
    }
    public bool Add(Department dept)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Department Get(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Department> GetAll()
    {
        throw new NotImplementedException();
    }

    public bool Update(Department dept)
    {
        throw new NotImplementedException();
    }
}
