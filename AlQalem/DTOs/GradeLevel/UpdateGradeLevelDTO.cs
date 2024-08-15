using System.ComponentModel.DataAnnotations;

namespace AlQalem.DTOs.GradeLevel
{
    public class UpdateGradeLevelDTO
    {
        [Required]
        public Guid GradeLevelId { get; set; }

        [MaxLength(100)]
        public string LevelName { get; set; }
    }
}
