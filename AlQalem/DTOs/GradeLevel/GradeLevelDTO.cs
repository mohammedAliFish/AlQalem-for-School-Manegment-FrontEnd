using System.ComponentModel.DataAnnotations;

namespace AlQalem.DTOs.GradeLevel
{
    public class GradeLevelDTO
    {
        public required Guid GradeLevelId { get; set; }

        [MaxLength(30)]
        public required string LevelName { get; set; }
    }
}
