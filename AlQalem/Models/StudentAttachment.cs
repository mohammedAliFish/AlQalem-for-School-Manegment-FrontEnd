namespace AlQalem.Models
{
    public class StudentAttachment
    {
        public Guid StudentAttachmentId { get; set; } 
        public Guid StudentId { get; set; } 
        public Guid AttachmentId { get; set; } 
        public bool IsProfilePicture { get; set; }

        public Student Student { get; set; } 
        public Attachment Attachment { get; set; } 
    }

}
