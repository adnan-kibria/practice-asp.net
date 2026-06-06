using Microsoft.EntityFrameworkCore;

namespace DAL;

public class DepartmentRepo : IDepartmentRepo
{
    private readonly SchlDbContext _db;
    public DepartmentRepo(SchlDbContext db)
    {
        _db = db;
    }

    public async Task<bool> Add(Department dept)
    {
        await _db.Departments.AddAsync(dept);
        return await _db.SaveChangesAsync() > 0;
    }

    public Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<Department> Get(int id)
    {
        return await _db.Departments.FindAsync(id);
    }

    public async Task<IEnumerable<Department>> GetAll()
    {
        return await _db.Departments.ToListAsync();
    }

    public Task<bool> Update(Department dept)
    {
        throw new NotImplementedException();
    }
}
