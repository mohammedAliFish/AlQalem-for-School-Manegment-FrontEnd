namespace AlQalem.Models
{
    public class Attachment
    {
        public Guid AttachmentId { get; set; } 
        public string FileName { get; set; }
        public int FileSize { get; set; }
        public string FileExtension { get; set; }
        public string FilePath { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<StudentAttachment> StudentAttachments { get; set; }
    }


}
