namespace AlQalem.DTOs.StudentAttachment
{
    public class CreateStudentAttachmentDTO
    {
        public Guid StudentId { get; set; }
        public Guid AttachmentId { get; set; }
        public bool IsProfilePicture { get; set; }
    }
}
