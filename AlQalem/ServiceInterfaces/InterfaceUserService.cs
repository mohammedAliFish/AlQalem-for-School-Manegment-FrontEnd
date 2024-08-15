using AlQalem.DTOs.User;


public interface InterfaceUserService
{
    Task<IEnumerable<UserDTO>> GetUsersAsync();

    Task<IEnumerable<UserDTO>> GetAllUsersAsync();
    Task<UserDTO> GetUserByIdAsync(Guid id);
    Task<UserDTO> CreateUserAsync(CreateUserDTO createUserDTO);
    Task<UserDTO> UpdateUserAsync(Guid id, UpdateUserDTO updateUserDTO);
    Task DeleteUserAsync(Guid id);
}
