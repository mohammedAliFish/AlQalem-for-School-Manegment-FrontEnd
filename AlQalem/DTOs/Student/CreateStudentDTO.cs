using AlQalem.Enums;
namespace AlQalem.DTOs.Student
{
    public class CreateStudentDTO
    {
        
        public required string Name { get; set; }
        public required Guid ClassId { get; set; }
        public required Guid StatusId { get; set; }


    }
}
