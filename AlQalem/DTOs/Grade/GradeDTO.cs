namespace AlQalem.DTOs.Grade
{
    public class GradeDTO
    {
        public Guid GradeId { get; set; }
        public decimal Score { get; set; }
        public Guid StudentId { get; set; }
        public Guid SubjectId { get; set; }
        public Guid AcademicYearId { get; set; }
        public Guid GradeLevelId { get; set; }
    }
}
