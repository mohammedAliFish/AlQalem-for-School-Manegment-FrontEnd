using System.ComponentModel.DataAnnotations;

namespace AlQalem.DTOs.Class
{
    public class SubjectTeacherDto
    {
        public required Guid SubjectId { get; set; }

        public required Guid TeacherId { get; set; }
    }
}
