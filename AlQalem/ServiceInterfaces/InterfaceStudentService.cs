using AlQalem.DTOs.Student;


public interface InterfaceStudentService
{
    Task<IEnumerable<StudentDTO>> GetStudentsAsync();
   
    Task<StudentDTO> GetStudentByIdAsync(Guid id);
    Task<StudentDTO> CreateStudentAsync(CreateStudentDTO createStudentDto);
    Task<StudentDTO> UpdateStudentAsync(Guid id, UpdateStudentDTO updateStudentDTO);

    Task<Object> GetStudentStatusListAsync();

    Task DeleteStudentAsync(Guid id);
}
