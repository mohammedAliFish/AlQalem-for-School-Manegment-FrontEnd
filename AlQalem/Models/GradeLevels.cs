namespace AlQalem.Models
{
    public class GradeLevels
    {
        public Guid GradeLevelId { get; set; } 
        public string Name { get; set; }
        public ICollection<Class> Classes { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}
