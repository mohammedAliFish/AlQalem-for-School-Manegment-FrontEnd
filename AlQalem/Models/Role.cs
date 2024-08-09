namespace AlQalem.Models
{
    public class Role
    {
        public Guid RoleId { get; set; } 
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<RolePermission> RolePermissions { get; set; }
    }

}
