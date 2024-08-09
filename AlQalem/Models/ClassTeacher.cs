namespace AlQalem.Models
{
    public class ClassTeacher
    {
        public Guid ClassId { get; set; } 
        public Class Class { get; set; } 

        public Guid TeacherId { get; set; } 
        public Teacher Teacher { get; set; } 
    }

}
