using AlQalem.DTOs.Student;


public interface IStudentService
{
    Task<IEnumerable<StudentDTO>> GetStudentsAsync();
    Task<IEnumerable<StudentDTO>> GetAllStudentsAsync();
    Task<StudentDTO> GetStudentByIdAsync(Guid id);
    Task<StudentDTO> CreateStudentAsync(CreateStudentDto createStudentDto);
    Task<StudentDTO> UpdateStudentAsync(Guid id, UpdateStudentDTO updateStudentDTO);

    Task DeleteStudentAsync(Guid id);
}
