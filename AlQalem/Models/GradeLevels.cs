namespace AlQalem.Models
{
    public class GradeLevels
    {
        public Guid GradeLevelId { get; set; } // Primary Key
        public string Name { get; set; }

        // Navigation Properties
        public ICollection<Class> Classes { get; set; } // One GradeLevel to Many Classes
        public ICollection<Grade> Grades { get; set; } // One GradeLevel to Many Grade
    }
}
