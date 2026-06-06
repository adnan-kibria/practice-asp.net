namespace DAL;

public interface IUserRepo
{
    Task<IEnumerable<User>> GetAll();
    Task<User> Get(Guid guid);
    Task<bool> Add(User user);
    Task<bool> Update(User user);
    Task<bool> Delete(Guid guid);
}
