using System.ComponentModel.DataAnnotations;

namespace AlQalem.DTOs.Class
{
    public class ClassDTO
    {
        public Guid ClassId { get; set; }

        [MaxLength(20)]
        public required string Name { get; set; }
        
        public required Guid GradeLevelId { get; set; }
        
        public required Guid SchoolId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
