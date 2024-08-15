using System.ComponentModel.DataAnnotations;

namespace AlQalem.DTOs.Subject
{
    public class SubjectDTO
    {
        public required Guid SubjectId { get; set; }
        [MaxLength(20)]
        public required string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
