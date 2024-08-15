using System.ComponentModel.DataAnnotations;

namespace AlQalem.DTOs.Teacher
{
    public class CreateTeacherDTO
    {
        
        public required Guid UserId { get; set; }
        [MaxLength(20)]
        public required string Name { get; set; }
    }
}
