namespace AlQalem.DTOs.Teacher
{
    public class UpdateTeacherDTO
    {
        public required Guid TeacherId { get; set; }
        public required Guid UserId { get; set; }
        public required string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
