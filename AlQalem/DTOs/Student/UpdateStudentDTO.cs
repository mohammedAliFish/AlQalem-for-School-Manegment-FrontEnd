namespace AlQalem.DTOs.Student
{
    public class UpdateStudentDTO : CreateStudentDTO
    {
        public required Guid StudentId { get; set; }

        public bool IsDeleted { get; set; }
    }
}
