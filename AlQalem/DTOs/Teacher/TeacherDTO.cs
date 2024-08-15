using System.ComponentModel.DataAnnotations;

namespace AlQalem.DTOs.Teacher
{
    public class TeacherDTO
    {
        public Guid TeacherId { get; set; }
        public Guid UserId { get; set; }
        [MaxLength(20)]
        public required string Name { get; set; }
        public bool IsDeleted { get; set; }

        
    }
}
