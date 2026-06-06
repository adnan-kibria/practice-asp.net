using DAL;

namespace BLL;

public class TeacherService : ITeacherService
{
    private readonly ITeacherRepo _teacherRepo;
    public TeacherService(DataAccessFactory daf)
    {
        _teacherRepo = daf.GetTeacherRepo();
    }

    public Task<bool> Add(TeacherDTO teacher)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<TeacherDTO> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TeacherDTO>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<bool> Update(TeacherDTO teacher)
    {
        throw new NotImplementedException();
    }
}
