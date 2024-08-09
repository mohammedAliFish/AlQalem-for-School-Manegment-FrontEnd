namespace AlQalem.Models
{
    public class Class
    {
        public Guid ClassId { get; set; } 
        public string Name { get; set; }
        public int GradeLevel { get; set; }
        public Guid SchoolId { get; set; } 
        public bool IsDeleted { get; set; }

        public School School { get; set; } 
        public ICollection<Student> Students { get; set; }
        public ICollection<ClassSubjectTeacher> ClassSubjectTeachers { get; set; }
        public ICollection<ClassTeacher> ClassTeachers { get; set; }
    }

}
