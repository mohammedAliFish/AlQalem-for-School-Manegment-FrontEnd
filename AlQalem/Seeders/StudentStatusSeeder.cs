using AlQalem.Data;
using AlQalem.Models;
using Microsoft.EntityFrameworkCore;

namespace AlQalem.Seeders
{
    public class StudentStatusSeeder
    {
        public static async Task Seed(ApplicationDbContext context)
        {
            
            var count = await context.StudentStatuses.CountAsync();

            
            if (count > 0)
                return;

            var studentStatuses = new List<StudentStatus>
            {
                new StudentStatus { StudentStatusId = Guid.NewGuid(), Name = "مستمر" },
                new StudentStatus { StudentStatusId = Guid.NewGuid(), Name = "منقول" },
                new StudentStatus { StudentStatusId = Guid.NewGuid(), Name = "مفصول" },
                new StudentStatus { StudentStatusId = Guid.NewGuid(), Name = "منقطع" }
            };

            await context.StudentStatuses.AddRangeAsync(studentStatuses);
            await context.SaveChangesAsync();
        }
    }
}
