﻿namespace AlQalem.Models
{
    public class Permission
    {
        public Guid PermissionId { get; set; } 
        public string Name { get; set; }
        public int PermissionNumber { get; set; }

        public ICollection<RolePermission> RolePermissions { get; set; }
    }

}