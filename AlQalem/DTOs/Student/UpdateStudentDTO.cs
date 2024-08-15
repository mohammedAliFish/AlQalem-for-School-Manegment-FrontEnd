namespace AlQalem.DTOs.Student
{
    public class UpdateStudentDTO : CreateStudentDto
    {
        public required Guid StudentId { get; set; }

        public bool IsDeleted { get; set; }
    }
}
