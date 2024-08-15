using System.ComponentModel.DataAnnotations;

namespace AlQalem.DTOs.Subject
{
    public class CreateSubjectDTO
    {
        [MaxLength(20)]
        public required string Name { get; set; }
        
    }
}
