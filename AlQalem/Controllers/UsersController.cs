using AlQalem.DTOs.User;
using AlQalem.Models;
using AutoMapper; 
using Microsoft.AspNetCore.Mvc;
using AlQalem.Exceptions.UserExceptions;

namespace AlQalem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly InterfaceUserService _userService;
        private readonly IMapper _mapper; 

        public UsersController(InterfaceUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetUsers()
        {
            var users = await _userService.GetUsersAsync();
            var userDtos = _mapper.Map<IEnumerable<UserDTO>>(users); 
            return Ok(userDtos);
        }

        
       

        
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDTO>> GetUserById(Guid id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null)
            {
                throw new UserNotFoundException();
            }
            var userDto = _mapper.Map<UserDTO>(user);
            return Ok(userDto);
        }

        
        [HttpPost]
        public async Task<ActionResult<UserDTO>> CreateUser(CreateUserDTO createUserDTO)
        {
            var user = _mapper.Map<User>(createUserDTO); 
            var createdUser = await _userService.CreateUserAsync(createUserDTO);
            var createdUserDto = _mapper.Map<UserDTO>(createdUser);
            return CreatedAtAction(nameof(GetUserById), new { id = createdUserDto.UserId }, createdUserDto);
        }

        
        [HttpPut("{id}")]
        public async Task<ActionResult<UserDTO>> UpdateUser(Guid id, UpdateUserDTO updateUserDTO)
        {
            if (id != updateUserDTO.UserId)
            {
                throw new UserIdMismatchException();
            }

            var user = _mapper.Map<User>(updateUserDTO); 
            var updatedUser = await _userService.UpdateUserAsync(id, updateUserDTO);
            if (updatedUser == null)
            {
                throw new UserNotFoundException();
            }
            var updatedUserDto = _mapper.Map<UserDTO>(updatedUser); 
            return Ok(updatedUserDto);
        }

        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null)
            {
                throw new UserNotFoundException();
            }

            await _userService.DeleteUserAsync(id);
            return NoContent();
        }
    }
}
