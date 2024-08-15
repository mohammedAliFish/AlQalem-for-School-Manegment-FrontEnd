﻿namespace AlQalem.DTOs.User
{
   
   
        public class CreateUserDTO
        {
            public required string Username { get; set; }
            public required string Email { get; set; }
            public required string Password { get; set; } 
            public required string PhoneNumber { get; set; }
            public Guid RoleId { get; set; }
            public bool IsDeleted { get; set; }
        }
    

}

