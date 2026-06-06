namespace DAL;

public interface IDepartmentRepo
{
    Task<IEnumerable<Department>> GetAll();
    Task<Department> Get(int id);
    Task<bool> Add(Department dept);
    Task<bool> Update(Department dept);
    Task<bool> Delete(int id);
}
