using AlQalem.Enums;
using System.ComponentModel.DataAnnotations;

namespace AlQalem.DTOs.School
{
    public class SchoolDTO
    {
        public Guid SchoolId { get; set; }

        [MaxLength(20)]
        public required string Name { get; set; }
        public required string LogoPath { get; set; }
        
        public required SchoolType Type { get; set; }
        public bool IsDeleted { get; set; }
    }
}
