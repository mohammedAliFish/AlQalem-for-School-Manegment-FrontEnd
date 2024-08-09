namespace AlQalem.Models
{
    public class StudentStatus
    {
        public Guid StudentStatusId { get; set; } 
        public byte Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }

}
