
using AlQalem.DTOs.GradeLevel;
using AlQalem.DTOs.Student;
using AlQalem.DTOs.Subject;
using AlQalem.DTOs.Teacher;
using System.ComponentModel.DataAnnotations;

namespace AlQalem.DTOs.Class
{
    public class ClassDTO
    {
        public Guid ClassId { get; set; }

        [MaxLength(20)]
        public required string Name { get; set; }

        public  Guid GradeLevelId { get; set; }
        public  GradeLevelDTO GradeLevel { get; set; }

        public  Guid SchoolId { get; set; }

        public ICollection<SubjectDTO> Subjects { get; set; }
        public ICollection<TeacherDTO> Teachers { get; set; }
        public ICollection<StudentDTO> Students { get; set; }
    }
}
