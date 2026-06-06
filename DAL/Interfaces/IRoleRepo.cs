namespace DAL;

public interface IRoleRepo
{
    IEnumerable<Role> GetAll();
    Role Get(int id);
}
