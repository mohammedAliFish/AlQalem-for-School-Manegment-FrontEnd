using AlQalem.Models;
using Microsoft.EntityFrameworkCore;
namespace AlQalem.Seeders
{
    public static class RolePermissionSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { RoleId = Guid.Parse("b7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"), Name = "Admin" },
                new Role { RoleId = Guid.Parse("c7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"), Name = "Teacher" },
                new Role { RoleId = Guid.Parse("d7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"), Name = "Student" }
            );
        }
    }
}
