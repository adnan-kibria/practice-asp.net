namespace BLL;

public interface IUserService
{
    Task<IEnumerable<UserDTO>> GetAll();
    Task<UserDTO> Get(Guid guid);
    Task<bool> Add(UserDTO user);
    Task<bool> Update(UserDTO user);
    Task<bool> Delete(Guid guid);
}
