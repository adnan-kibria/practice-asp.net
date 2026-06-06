namespace DAL;

public interface IDepartmentRepo
{
    IEnumerable<Department> GetAll();
    Department Get(int id);
    bool Add(Department dept);
    bool Update(Department dept);
    bool Delete(int id);
}
