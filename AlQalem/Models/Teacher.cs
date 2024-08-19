namespace AlQalem.Models
{
    public class Teacher
    {
        public Guid TeacherId { get; set; } 
       
        public required string Name { get; set; }
        public bool IsDeleted { get; set; }

        
        public ICollection<ClassTeacher> ClassTeachers { get; set; }
        public ICollection<ClassSubjectTeacher> ClassSubjectTeachers { get; set; }
        public ICollection<TeacherSubject> TeacherSubjects { get; set; }
    }

}
