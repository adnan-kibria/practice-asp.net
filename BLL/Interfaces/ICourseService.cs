namespace BLL;

public interface ICourseService
{
    Task<IEnumerable<CourseDTO>> GetAll();
    Task<CourseDTO> Get(Guid guid);
    Task<bool> Add(CourseDTO course);
    Task<bool> Update(CourseDTO course);
    Task<bool> Delete(Guid guid);
}
