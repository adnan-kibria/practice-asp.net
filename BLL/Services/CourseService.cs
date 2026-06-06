using DAL;

namespace BLL;

public class CourseService : ICourseService
{
    private readonly ICourseRepo _courseRepo;
    public CourseService(DataAccessFactory daf)
    {
        _courseRepo = daf.GetCourseRepo();
    }

    public Task<bool> Add(CourseDTO course)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(Guid guid)
    {
        throw new NotImplementedException();
    }

    public Task<CourseDTO> Get(Guid guid)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CourseDTO>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<bool> Update(CourseDTO course)
    {
        throw new NotImplementedException();
    }
}
