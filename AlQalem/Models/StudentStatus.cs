

using AlQalem.Enums;


namespace AlQalem.Models
{
    public class StudentStatus
    {
        public Guid StudentStatusId { get; set; }

        
        public required StudentStatusEnums Name { get; set; }

        public bool IsDeleted { get; set; } 

        public ICollection<Student> Students { get; set; }
    }

}
