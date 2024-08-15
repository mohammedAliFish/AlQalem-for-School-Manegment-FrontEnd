using System.ComponentModel.DataAnnotations;

namespace AlQalem.DTOs.GradeLevel
{
    public class CreateGradeLevelDTO
    {
        
        [MaxLength(30)]
        public required string LevelName { get; set; }
    }
}
