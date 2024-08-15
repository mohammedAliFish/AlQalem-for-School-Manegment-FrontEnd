using AlQalem.Models;
using Microsoft.EntityFrameworkCore;
namespace AlQalem.Seeders
{
    public static class RoleSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { RoleId = Guid.NewGuid(), Name = "Admin" },
                new Role { RoleId = Guid.NewGuid(), Name = "Teacher" },
                new Role { RoleId = Guid.NewGuid(), Name = "Student" }
            );
        }
    }
}
