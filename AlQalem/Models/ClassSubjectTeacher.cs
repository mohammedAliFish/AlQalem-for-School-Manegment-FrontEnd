namespace AlQalem.Models
{
    

    public class ClassSubjectTeacher
    {
        public Guid ClassSubjectTeacherId { get; set; } 
        public Guid ClassId { get; set; } 
        public Guid SubjectId { get; set; } 
        public Guid TeacherId { get; set; } 

        public Class Class { get; set; } 
        public Subject Subject { get; set; } 
        public Teacher Teacher { get; set; } 
    }

}

