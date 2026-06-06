namespace DAL;

public class TeacherRepo : ITeacherRepo
{
    private readonly SchlDbContext _db;
    public TeacherRepo(SchlDbContext db)
    {
        _db = db;
    }
    public bool Add(Teacher teacher)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Teacher Get(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Teacher> GetAll()
    {
        throw new NotImplementedException();
    }

    public bool Update(Teacher teacher)
    {
        throw new NotImplementedException();
    }
}
