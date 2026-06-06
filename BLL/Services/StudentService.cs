using DAL;

namespace BLL;

public class StudentService : IStudentService
{
    private readonly IStudentRepo _studentRepo;
    public StudentService(DataAccessFactory daf)
    {
        _studentRepo = daf.GetStudentRepo();
    }

    public Task<bool> Add(StudentDTO student)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<StudentDTO> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<StudentDTO>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<bool> Update(StudentDTO student)
    {
        throw new NotImplementedException();
    }
}
