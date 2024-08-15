using System.ComponentModel.DataAnnotations;

namespace AlQalem.DTOs.GradeLevel
{
    public class CreateGradeLevelDTO
    {
        [Required]
        [MaxLength(100)]
        public string LevelName { get; set; }
    }
}
