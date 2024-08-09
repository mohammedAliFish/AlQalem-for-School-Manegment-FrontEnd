namespace AlQalem.Models
{
    public class Subject
    {
        public Guid SubjectId { get; set; } 
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<ClassSubjectTeacher> ClassSubjectTeachers { get; set; }
        public ICollection<Grade> Grades { get; set; }
        public ICollection<TeacherSubject> TeacherSubjects { get; set; }
    }

}
