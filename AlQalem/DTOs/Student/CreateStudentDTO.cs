using AlQalem.Enums;
namespace AlQalem.DTOs.Student
{
    public class CreateStudentDto
    {
        
        public required string Name { get; set; }
        public required Guid ClassId { get; set; }
        public required Guid StatusId { get; set; }

    }
}
