using AlQalem.DTOs.School;


public interface ISchoolService
{
    Task<IEnumerable<SchoolDTO>> GetSchoolsAsync();
    Task<IEnumerable<SchoolDTO>> GetAllSchoolsIncludingDeletedAsync();
    Task<SchoolDTO> GetSchoolByIdAsync(Guid id);
    Task<SchoolDTO> CreateSchoolAsync(SchoolDTO schoolDto);
    Task<SchoolDTO> UpdateSchoolAsync(Guid id, UpdateSchoolDTO schoolUpdateDTO);
    Task DeleteSchoolAsync(Guid id);
}
