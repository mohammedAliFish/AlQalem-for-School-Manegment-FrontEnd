namespace AlQalem.Models
{
    public class AcademicYear
    {
        public Guid AcademicYearId { get; set; } 
        public DateTime Year { get; set; }

        public ICollection<Grade> Grades { get; set; }
    }

}
