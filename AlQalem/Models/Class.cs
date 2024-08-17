

namespace AlQalem.Models
{
    public class Class
    {
        public Guid ClassId { get; set; } 
        public required string Name { get; set; }
        public Guid GradeLevelId { get; set; } 
        public Guid SchoolId { get; set; } 
        public bool IsDeleted { get; set; }

        
        public GradeLevels GradeLevel { get; set; }
        public School School { get; set; }
        public ICollection<Student> Students { get; set; } 
        public ICollection<ClassTeacher> ClassTeachers { get; set; } 
        public ICollection<ClassSubjectTeacher> ClassSubjectTeachers { get; set; }
    }

}
