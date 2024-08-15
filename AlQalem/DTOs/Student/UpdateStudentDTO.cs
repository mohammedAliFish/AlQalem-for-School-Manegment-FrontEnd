namespace AlQalem.DTOs.Student
{
    public class UpdateStudentDTO : CreateStudentDto
    {
        public Guid StudentId { get; set; }

        public bool IsDeleted { get; set; }
    }
}
