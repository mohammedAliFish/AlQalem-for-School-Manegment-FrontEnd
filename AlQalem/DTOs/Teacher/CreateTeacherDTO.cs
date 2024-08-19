using System.ComponentModel.DataAnnotations;

namespace AlQalem.DTOs.Teacher
{
    public class CreateTeacherDTO
    {
        
        
        [MaxLength(20)]
        public required string Name { get; set; }
    }
}
