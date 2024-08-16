using AlQalem.DTOs.Class;



public interface InterfaceClassService
{
    Task<IEnumerable<ClassDTO>> GetAllClassesAsync();
    Task<ClassDTO> GetClassByIdAsync(Guid id);
    Task<ClassDTO> CreateClassAsync(CreateClassDTO createClassDto);
    Task<ClassDTO> UpdateClassAsync(Guid id, UpdateClassDTO updateClassDTO);
    Task DeleteClassAsync(Guid id);
}
