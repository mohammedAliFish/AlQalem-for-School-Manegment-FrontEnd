namespace AlQalem.Models
{
    public class Student
    {
        public Guid StudentId { get; set; } 
        public string Name { get; set; }
        public Guid ClassId { get; set; } 
        public Guid StatusId { get; set; } 
        public bool IsDeleted { get; set; }

        public Class Class { get; set; } 
        public StudentStatus Status { get; set; } 
        public ICollection<Grade> Grades { get; set; }
        public ICollection<StudentAttachment> StudentAttachments { get; set; }
    }

}
