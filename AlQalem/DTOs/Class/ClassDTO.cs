using System.ComponentModel.DataAnnotations;

namespace AlQalem.DTOs.Class
{
    public class ClassDTO
    {
        public Guid ClassId { get; set; }

        [MaxLength(100)] // يجب أن يكون الطول مطابقًا لنوع البيانات في قاعدة البيانات
        public required string Name { get; set; }

        public Guid GradeLevelId { get; set; } // تغيير نوع البيانات إلى Guid للتوافق مع النموذج
        public Guid SchoolId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
