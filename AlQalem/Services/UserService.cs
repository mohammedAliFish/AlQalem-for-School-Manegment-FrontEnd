using AlQalem.Data;
using AlQalem.DTOs.User;
using AlQalem.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

public class UserService : InterfaceUserService
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public UserService(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<UserDTO>> GetUsersAsync()
    {
        var users = await _context.Users
            .Include(u => u.Role)
            .Include(u => u.Teacher)
            .ToListAsync();
        return _mapper.Map<IEnumerable<UserDTO>>(users);
    }

    public async Task<IEnumerable<UserDTO>> GetAllUsersAsync()
    {
        var users = await _context.Users.IgnoreQueryFilters().ToListAsync();
        return _mapper.Map<IEnumerable<UserDTO>>(users);
    }

    public async Task<UserDTO> GetUserByIdAsync(Guid id)
    {
        var user = await _context.Users
            .Include(u => u.Role)
            .Include(u => u.Teacher)
            .FirstOrDefaultAsync(u => u.UserId == id);
        return _mapper.Map<UserDTO>(user);
    }

    public async Task<UserDTO> CreateUserAsync(CreateUserDTO userDto)
    {
        var user = _mapper.Map<User>(userDto);
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return _mapper.Map<UserDTO>(user);
    }

    public async Task<UserDTO> UpdateUserAsync(Guid id, UpdateUserDTO userDto)
    {
        var user = await _context.Users.FindAsync(id);
        if (user == null) return null;

        _mapper.Map(userDto, user);
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
        return _mapper.Map<UserDTO>(user);
    }

    public async Task DeleteUserAsync(Guid id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user == null) return;
        user.IsDeleted= true;
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
    }
}
