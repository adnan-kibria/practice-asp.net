namespace DAL;

public interface IUserRepo
{
    IEnumerable<User> GetAll();
    User Get(Guid guid);
    bool Add(User user);
    bool Update(User user);
    bool Delete(Guid guid);
}
