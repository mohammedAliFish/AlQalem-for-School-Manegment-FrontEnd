using AlQalem.DTOs.Grade;


public interface IGradeService
{
    Task<IEnumerable<GradeDTO>> GetGradesAsync();
    
    Task<GradeDTO> GetGradeByIdAsync(Guid id);
    Task<GradeDTO> CreateGradeAsync(CreateGradeDTO createGradeDTO);
    Task<GradeDTO> UpdateGradeAsync(Guid id, UpdateGradeDTO updateGradeDTO);
    Task DeleteGradeAsync(Guid id);
}
