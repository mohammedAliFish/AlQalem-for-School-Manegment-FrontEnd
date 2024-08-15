using AlQalem.DTOs.Grade;


public interface InterfaceGradeService
{
    Task<IEnumerable<GradeDTO>> GetGradesAsync();
    Task<IEnumerable<GradeDTO>> GetAllGradesAsync();

    Task<GradeDTO> GetGradeByIdAsync(Guid id);
    Task<GradeDTO> CreateGradeAsync(CreateGradeDTO createGradeDTO);
    Task<GradeDTO> UpdateGradeAsync(Guid id, UpdateGradeDTO updateGradeDTO);
    Task DeleteGradeAsync(Guid id);
}
