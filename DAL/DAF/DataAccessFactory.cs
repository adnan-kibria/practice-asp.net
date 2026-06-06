using Microsoft.EntityFrameworkCore.Storage;

namespace DAL;

public class DataAccessFactory
{
    private readonly SchlDbContext _db;
    public DataAccessFactory(SchlDbContext db)
    {
        _db = db;
    }
    public IUserRepo GetUserRepo()
    {
        return new UserRepo(_db);
    }
    public ITeacherRepo GetTeacherRepo()
    {
        return new TeacherRepo(_db);
    }
    public IStudentRepo GetStudentRepo()
    {
        return new StudentRepo(_db);
    }
    public IRoleRepo GetRoleRepo()
    {
        return new RoleRepo(_db);
    }
    public IDepartmentRepo GetDepartmentRepo()
    {
        return new DepartmentRepo(_db);
    }
    public ICourseTeacherRepo GetCourseTeacherRepo()
    {
        return new CourseTeacherRepo(_db);
    }
    public ICourseStudentRepo GetCourseStudentRepo()
    {
        return new CourseStudentRepo(_db);
    }
    public ICourseDepartmentRepo GetCourseDepartmentRepo()
    {
        return new CourseDepartmentRepo(_db);
    }
    public ICourseRepo GetCourseRepo()
    {
        return new CourseRepo(_db);
    }
}
