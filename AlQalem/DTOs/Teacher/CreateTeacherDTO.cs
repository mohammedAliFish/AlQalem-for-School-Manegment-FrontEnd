using System.ComponentModel.DataAnnotations;

namespace AlQalem.DTOs.Teacher
{
    public class CreateTeacherDTO
    {
        [Required]
        public Guid UserId { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
