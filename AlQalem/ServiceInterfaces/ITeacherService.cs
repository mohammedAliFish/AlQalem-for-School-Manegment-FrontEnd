using AlQalem.DTOs.Teacher;

public interface ITeacherService
{
    Task<IEnumerable<TeacherDTO>> GetTeachersAsync();

    Task<IEnumerable<TeacherDTO>> GetAllTeachersAsync();
    Task<TeacherDTO> GetTeacherByIdAsync(Guid id);
    Task<TeacherDTO> CreateTeacherAsync(CreateTeacherDTO teacherDto);
    Task<TeacherDTO> UpdateTeacherAsync(Guid id, UpdateTeacherDTO teacherDto);
    Task DeleteTeacherAsync(Guid id);

    Task<bool> CheckIfUserExistsAsync(Guid userId);
}
