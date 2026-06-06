using AutoMapper;
using DAL;

namespace BLL;

public class DepartmentService : IDepartmentService
{
    private readonly IDepartmentRepo _deptRepo;
    Mapper mapper;
    public DepartmentService(DataAccessFactory daf)
    {
        _deptRepo = daf.GetDepartmentRepo();
        mapper = MapperConfig.GetMapper();
    }

    public async Task<bool> Add(DepartmentDTO dept)
    {
        if(dept != null)
        {
            var data = mapper.Map<Department>(dept);
            await _deptRepo.Add(data);
            return true;
        }
        return false;
    }

    public Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<DepartmentDTO> Get(int id)
    {
        var data = await _deptRepo.Get(id);
        return mapper.Map<DepartmentDTO>(data);
    }

    public async Task<IEnumerable<DepartmentDTO>> GetAll()
    {
        var data = await _deptRepo.GetAll();
        return mapper.Map<List<DepartmentDTO>>(data);
    }

    public Task<bool> Update(DepartmentDTO dept)
    {
        throw new NotImplementedException();
    }
}
