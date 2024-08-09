using AlQalem.Models;

public class Grade
{
    public Guid GradeId { get; set; } 
    public decimal Score { get; set; }
    public Guid StudentId { get; set; } 
    public Guid SubjectId { get; set; } 
    public Guid AcademicYearId { get; set; } 
    public int GradeLevel { get; set; }

    public Student Student { get; set; } 
    public Subject Subject { get; set; } 
    public AcademicYear AcademicYear { get; set; } 
}
