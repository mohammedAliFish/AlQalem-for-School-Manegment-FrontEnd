using System.Diagnostics;

namespace AlQalem.Models
{
    public class Class
    {
        public Guid ClassId { get; set; } // Primary Key
        public string Name { get; set; }
        public Guid GradeLevelId { get; set; } // Foreign Key to GradeLevel
        public Guid SchoolId { get; set; } // Foreign Key to School
        public bool IsDeleted { get; set; }

        // Navigation Properties
        public GradeLevels GradeLevel { get; set; } // One Class belongs to One GradeLevel
        public School School { get; set; } // One Class belongs to One School
        public ICollection<Student> Students { get; set; } // One Class to Many Students
        public ICollection<ClassTeacher> ClassTeachers { get; set; } // One Class to Many Teachers (via ClassTeachers)
        public ICollection<ClassSubjectTeacher> ClassSubjectTeachers { get; set; }
    }

}
