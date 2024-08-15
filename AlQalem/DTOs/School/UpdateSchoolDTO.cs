using AlQalem.Enums;

namespace AlQalem.DTOs.School
{
    public class UpdateSchoolDTO : CreateSchoolDTO
    {
        public required Guid SchoolId { get; set; }

       
    }
}
