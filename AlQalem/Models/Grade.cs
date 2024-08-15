using AlQalem.Models;


public class Grade
{
    public Guid GradeId { get; set; } // Primary Key
    public decimal Score { get; set; }
    public Guid StudentId { get; set; } // Foreign Key to Student
    public Guid SubjectId { get; set; } // Foreign Key to Subject
    public Guid AcademicYearId { get; set; } // Foreign Key to AcademicYear
    public Guid GradeLevelId { get; set; } // Foreign Key to GradeLevel

    // Navigation Properties
    public Student Student { get; set; } // One Grade belongs to One Student
    public Subject Subject { get; set; } // One Grade belongs to One Subject
    public AcademicYear AcademicYear { get; set; } // One Grade belongs to One AcademicYear
    public GradeLevels GradeLevel { get; set; }
}
