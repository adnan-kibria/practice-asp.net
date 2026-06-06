namespace DAL;

public class UserRepo : IUserRepo
{
    private readonly SchlDbContext _db;
    public UserRepo(SchlDbContext db)
    {
        _db = db;
    }
    public bool Add(User user)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Guid guid)
    {
        throw new NotImplementedException();
    }

    public User Get(Guid guid)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<User> GetAll()
    {
        throw new NotImplementedException();
    }

    public bool Update(User user)
    {
        throw new NotImplementedException();
    }
}
