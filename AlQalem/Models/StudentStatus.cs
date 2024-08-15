

namespace AlQalem.Models
{
    public class StudentStatus
    {
        public Guid StudentStatusId { get; set; } 
        public string Name { get; set; }

        public bool IsDeleted { get; set; } 

        public ICollection<Student> Students { get; set; }
    }

}
