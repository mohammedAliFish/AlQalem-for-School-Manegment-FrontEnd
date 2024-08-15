namespace AlQalem.DTOs.StudentAttachment
{
    public class StudentAttachmentDTO
    {
        public Guid StudentAttachmentId { get; set; }
        public Guid StudentId { get; set; }
        public Guid AttachmentId { get; set; }
        public bool IsProfilePicture { get; set; }
    }
}
