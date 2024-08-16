using AlQalem.DTOs.Subject;


public interface InterfaceSubjectService
{
    Task<IEnumerable<SubjectDTO>> GetSubjectsAsync();

    Task<SubjectDTO> GetSubjectByIdAsync(Guid id);
    Task<SubjectDTO> CreateSubjectAsync(CreateSubjectDTO createSubjectDTO);
    Task<SubjectDTO> UpdateSubjectAsync(Guid id, UpdateSubjectDTO updateSubjectDTO);
    Task DeleteSubjectAsync(Guid id);

    Task<bool> HasClassSubjectTeachersAsync(Guid id);
    Task<bool> HasGradesAsync(Guid id);
}
