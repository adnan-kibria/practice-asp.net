namespace DAL;

public class TeacherRepo : ITeacherRepo
{
    private readonly SchlDbContext _db;
    public TeacherRepo(SchlDbContext db)
    {
        _db = db;
    }

    public Task<bool> Add(Teacher teacher)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Teacher> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Teacher>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<bool> Update(Teacher teacher)
    {
        throw new NotImplementedException();
    }
}
