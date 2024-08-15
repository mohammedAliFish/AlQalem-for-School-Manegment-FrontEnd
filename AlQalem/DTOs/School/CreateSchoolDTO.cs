using AlQalem.Enums;

namespace AlQalem.DTOs.School
{
    public class CreateSchoolDTO
    {
        public required string Name { get; set; }
        public required IFormFile Logo { get; set; }
        
        public required SchoolType Type { get; set; }
    }
}
