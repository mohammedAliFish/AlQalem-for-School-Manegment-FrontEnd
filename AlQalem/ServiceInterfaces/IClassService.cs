using AlQalem.DTOs.Class;
using AlQalem.DTOs.School;


public interface IClassService
{
    Task<IEnumerable<ClassDTO>> GetAllClassesAsync();
    Task<IEnumerable<ClassDTO>> GetAllClassesIncludingDeletedAsync();
    Task<ClassDTO> GetClassByIdAsync(Guid id);
    Task<ClassDTO> CreateClassAsync(CreateClassDTO createClassDto);
    Task<ClassDTO> UpdateClassAsync(Guid id, UpdateClassDTO updateClassDTO);
    Task DeleteClassAsync(Guid id);
}
