using AlQalem.Enums;
namespace AlQalem.DTOs.StudentStatus
{
    public class StudentStatusDTO
    {
        public Guid StudentStatusId { get; set; }
        public  StudentStatusEnums Name { get; set; }
    }
}
