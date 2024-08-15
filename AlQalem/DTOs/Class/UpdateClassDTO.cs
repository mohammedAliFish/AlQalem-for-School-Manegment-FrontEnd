using System.ComponentModel.DataAnnotations;

namespace AlQalem.DTOs.Class
{
    public class UpdateClassDTO
    {
        public Guid ClassId { get; set; }
        [MaxLength(20)]
        public required string Name { get; set; }

        public required string GradeLevel { get; set; }
        public bool IsDeleted { get; set; }
    }
}
