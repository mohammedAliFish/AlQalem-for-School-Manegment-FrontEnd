using System.ComponentModel.DataAnnotations;

namespace AlQalem.DTOs.Class
{
    public class CreateClassDTO
    {
        [Required, MaxLength(100)]
        public required string Name { get; set; }

        public required Guid GradeLevelId { get; set; }

        public required Guid SchoolId { get; set; }

        public required IList<SubjectTeacherDto> ClassSubjectTeachers { get; set; }
    }
}
