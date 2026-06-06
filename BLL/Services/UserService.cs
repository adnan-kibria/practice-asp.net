using DAL;

namespace BLL;

public class UserService : IUserService
{
    private readonly IUserRepo _userRepo;
    public UserService(DataAccessFactory factory)
    {
        _userRepo = factory.GetUserRepo();
    }

    public Task<bool> Add(UserDTO user)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(Guid guid)
    {
        throw new NotImplementedException();
    }

    public Task<UserDTO> Get(Guid guid)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UserDTO>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<bool> Update(UserDTO user)
    {
        throw new NotImplementedException();
    }
}
