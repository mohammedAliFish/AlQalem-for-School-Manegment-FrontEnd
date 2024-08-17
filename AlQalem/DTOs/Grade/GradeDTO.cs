using AlQalem.Enums;

namespace AlQalem.DTOs.Grade
{
    public class GradeDTO
    {

        public required Guid GradeId { get; set; }
        public required decimal Score { get; set; }
        public required Guid StudentId { get; set; }
        public required Guid SubjectId { get; set; }
        public required Guid AcademicYearId { get; set; }
        public required Guid GradeLevelId { get; set; }
        public required GradeTypeEnum GradeType { get; set; }
    }
}
