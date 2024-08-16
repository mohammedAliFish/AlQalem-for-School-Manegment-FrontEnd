using AlQalem.DTOs.Student;


public interface InterfaceStudentService
{
    Task<IEnumerable<StudentDTO>> GetStudentsAsync();
   
    Task<StudentDTO> GetStudentByIdAsync(Guid id);
    Task<StudentDTO> CreateStudentAsync(CreateStudentDto createStudentDto);
    Task<StudentDTO> UpdateStudentAsync(Guid id, UpdateStudentDTO updateStudentDTO);

    Task DeleteStudentAsync(Guid id);
}
