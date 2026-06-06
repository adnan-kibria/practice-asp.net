namespace DAL;

public class RoleRepo : IRoleRepo
{
    private readonly SchlDbContext _db;
    public RoleRepo(SchlDbContext db)
    {
        _db = db;
    }

    public Task<Role> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Role>> GetAll()
    {
        throw new NotImplementedException();
    }
}
