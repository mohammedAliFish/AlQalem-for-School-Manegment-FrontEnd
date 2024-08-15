using AlQalem.Enums;
namespace AlQalem.DTOs.Student
{
    public class CreateStudentDto
    {
        
        public required string Name { get; set; }
        public Guid ClassId { get; set; }
        public Guid StatusId { get; set; }

    }
}
