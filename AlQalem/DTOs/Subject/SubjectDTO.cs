using System.ComponentModel.DataAnnotations;

namespace AlQalem.DTOs.Subject
{
    public class SubjectDTO
    {
        public Guid SubjectId { get; set; }
        public required string Name { get; set; }

    }
}

