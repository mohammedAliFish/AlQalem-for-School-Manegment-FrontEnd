namespace AlQalem.Models
{
    public class User
    {
        public Guid UserId { get; set; } 
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public Guid RoleId { get; set; } 
        public bool IsDeleted { get; set; }

        public Role Role { get; set; }
        public Teacher Teacher { get; set; }
        
    }

}
