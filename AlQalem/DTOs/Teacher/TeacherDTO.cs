using System.ComponentModel.DataAnnotations;

namespace AlQalem.DTOs.Teacher
{
    public class TeacherDTO
    {
        public  Guid TeacherId { get; set; }


        public required string Name { get; set; }

    }
}
