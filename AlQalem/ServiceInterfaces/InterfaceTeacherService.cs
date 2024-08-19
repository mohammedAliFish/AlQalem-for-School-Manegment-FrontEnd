using AlQalem.DTOs.Teacher;

public interface InterfaceTeacherService
{
    Task<IEnumerable<TeacherDTO>> GetTeachersAsync();

   
    Task<TeacherDTO> GetTeacherByIdAsync(Guid id);
    Task<TeacherDTO> CreateTeacherAsync(CreateTeacherDTO teacherDto);
    Task<TeacherDTO> UpdateTeacherAsync(Guid id, UpdateTeacherDTO teacherDto);
    Task DeleteTeacherAsync(Guid id);

    
}
