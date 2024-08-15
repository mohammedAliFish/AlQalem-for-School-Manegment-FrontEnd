using System.ComponentModel.DataAnnotations;

namespace AlQalem.DTOs.GradeLevel
{
    public class UpdateGradeLevelDTO: CreateGradeLevelDTO
    {
        
        public required Guid GradeLevelId { get; set; }

      
    }
}
