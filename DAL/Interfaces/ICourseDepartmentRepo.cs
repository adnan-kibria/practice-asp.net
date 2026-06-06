namespace DAL;

public interface ICourseDepartmentRepo
{
    IEnumerable<CourseDepartment> GetAll();
    CourseDepartment Get(int id);
}
