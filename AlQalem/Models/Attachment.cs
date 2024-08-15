namespace AlQalem.Models
{
    public class Attachment
    {
        public Guid AttachmentId { get; set; } 
        public required string FileName { get; set; }
        public required int FileSize { get; set; }
        public required string FileExtension { get; set; }
        public required string FilePath { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<StudentAttachment> StudentAttachments { get; set; }
    }


}
