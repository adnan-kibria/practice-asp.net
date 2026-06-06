namespace DAL;

public class StudentRepo : IStudentRepo
{
    private readonly SchlDbContext _db;
    public StudentRepo(SchlDbContext db)
    {
        _db = db;
    }

    public Task<bool> Add(Student student)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Student> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Student>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<bool> Update(Student student)
    {
        throw new NotImplementedException();
    }
}
