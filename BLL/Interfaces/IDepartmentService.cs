namespace BLL;

public interface IDepartmentService
{
    Task<IEnumerable<DepartmentDTO>> GetAll();
    Task<DepartmentDTO> Get(int id);
    Task<bool> Add(DepartmentDTO dept);
    Task<bool> Update(DepartmentDTO dept);
    Task<bool> Delete(int id);
}
