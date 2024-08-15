using AlQalem.Models;
using Microsoft.EntityFrameworkCore;
namespace AlQalem.Seeders
{
    public static class PermissionSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permission>().HasData(
                new Permission { PermissionId = Guid.Parse("a7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"), Name = "View" },
                new Permission { PermissionId = Guid.Parse("b7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"), Name = "Create" },
                new Permission { PermissionId = Guid.Parse("c7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"), Name = "Edit" },
                new Permission { PermissionId = Guid.Parse("d7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"), Name = "Delete" }
            );
        }
    }
}
