using AlQalem.DTOs.StudentAttachment;
using AlQalem.Enums;
namespace AlQalem.DTOs.Student
{
    public class CreateStudentDTO
    {
        public Guid StudentId { get; set; }
        public required string Name { get; set; }
        public required Guid ClassId { get; set; }
        public required Guid StatusId { get; set; }


       
    }
}
