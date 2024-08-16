using AlQalem.DTOs.School;


public interface InterfaceSchoolService
{
    Task<IEnumerable<SchoolDTO>> GetSchoolsAsync();
    
    Task<SchoolDTO> GetSchoolByIdAsync(Guid id);
    Task<SchoolDTO> CreateSchoolAsync(SchoolDTO schoolDto);
    Task<SchoolDTO> UpdateSchoolAsync(Guid id, UpdateSchoolDTO schoolUpdateDTO);
    Task DeleteSchoolAsync(Guid id);
}
