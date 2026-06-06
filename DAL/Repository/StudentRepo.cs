namespace DAL;

public class StudentRepo : IStudentRepo
{
    private readonly SchlDbContext _db;
    public StudentRepo(SchlDbContext db)
    {
        _db = db;
    }
    public bool Add(Student student)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Student Get(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Student> GetAll()
    {
        throw new NotImplementedException();
    }

    public bool Update(Student student)
    {
        throw new NotImplementedException();
    }
}
