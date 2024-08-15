namespace AlQalem.DTOs.Grade
{
    public class CreateGradeDTO
    {
        public decimal Score { get; set; }
        public Guid StudentId { get; set; }
        public Guid SubjectId { get; set; }
        public Guid AcademicYearId { get; set; }
        public Guid GradeLevelId { get; set; }
    }
}
