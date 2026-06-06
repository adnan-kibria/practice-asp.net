using AutoMapper;
using DAL;

namespace BLL;

public class MapperConfig
{
    public static MapperConfiguration config = new MapperConfiguration(cfg =>
    {
        cfg.CreateMap<Department, DepartmentDTO>().ReverseMap();
    });

    public static Mapper GetMapper()
    {
        return new Mapper(config);
    }
}
