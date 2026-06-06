namespace DAL;

public interface IRoleRepo
{
    Task<IEnumerable<Role>> GetAll();
    Task<Role> Get(int id);
}
