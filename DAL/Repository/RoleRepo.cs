namespace DAL;

public class RoleRepo : IRoleRepo
{
    private readonly SchlDbContext _db;
    public RoleRepo(SchlDbContext db)
    {
        _db = db;
    }
    public Role Get(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Role> GetAll()
    {
        throw new NotImplementedException();
    }
}
