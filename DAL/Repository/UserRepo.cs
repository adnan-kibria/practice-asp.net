namespace DAL;

public class UserRepo : IUserRepo
{
    private readonly SchlDbContext _db;
    public UserRepo(SchlDbContext db)
    {
        _db = db;
    }

    public Task<bool> Add(User user)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(Guid guid)
    {
        throw new NotImplementedException();
    }

    public Task<User> Get(Guid guid)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<bool> Update(User user)
    {
        throw new NotImplementedException();
    }
}
