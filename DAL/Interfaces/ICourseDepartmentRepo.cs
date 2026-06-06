namespace DAL;

public interface ICourseDepartmentRepo
{
    Task<IEnumerable<CourseDepartment>> GetAll();
    Task<CourseDepartment> Get(int id);
}
