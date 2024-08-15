using AlQalem.Enums;

namespace AlQalem.Models
{
   public class School
{
    public Guid SchoolId { get; set; } 
    public string Name { get; set; }
    public string LogoPath { get; set; }
    public SchoolType Type { get; set; }
    public bool IsDeleted { get; set; }

    public ICollection<Class> Classes { get; set; } 
}

}
