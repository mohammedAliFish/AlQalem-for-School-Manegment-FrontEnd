using System.ComponentModel.DataAnnotations;

namespace AlQalem.DTOs.Class
{
    public class CreateClassDTO
    {
        [MaxLength(100), Required] 
        public required string Name { get; set; }

        [Required]
        public Guid GradeLevelId { get; set; }  
        public Guid SchoolId { get; set; }
    }
}
