using AlQalem.Enums;
using System.ComponentModel.DataAnnotations;

namespace AlQalem.DTOs.Grade
{
    public class GradeDTO
    {

        public required Guid GradeId { get; set; }

        [Range(0, 100)]
        public required decimal Score { get; set; }
        public required Guid StudentId { get; set; }
        public required Guid SubjectId { get; set; }
        public required Guid AcademicYearId { get; set; }
        public required Guid GradeLevelId { get; set; }
        public required GradeTypeEnum GradeType { get; set; }

        public string StudentName { get; set; }
        public string SubjectName { get; set; }
    }
}
