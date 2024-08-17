using AlQalem.Models;
using AlQalem.Enums;

public class Grade
{
    public Guid GradeId { get; set; }
    public decimal Score { get; set; }
    public Guid StudentId { get; set; } 
    public Guid SubjectId { get; set; } 
    public Guid AcademicYearId { get; set; } 
    public Guid GradeLevelId { get; set; }
    public GradeTypeEnum GradeType { get; set; }


    public Student Student { get; set; } 
    public Subject Subject { get; set; } 
    public AcademicYear AcademicYear { get; set; } 
    public GradeLevels GradeLevel { get; set; }
}
