using AlQalem.DTOs.StudentAttachment;
using AlQalem.Enums;
using System.ComponentModel.DataAnnotations;

namespace AlQalem.DTOs.Student
{
    public class StudentDTO
    {
        public Guid StudentId { get; set; }
        [MaxLength(20)]
        public required string Name { get; set; }
        public required Guid ClassId { get; set; }
        public required Guid StatusId { get; set; }
        public  bool IsDeleted { get; set; }
        public ICollection<StudentAttachmentDTO> StudentAttachments { get; set; }



    }
}
