using AlQalem.Data;
using AlQalem.Models;
using Microsoft.EntityFrameworkCore;

namespace AlQalem.Seeders
{
    public class GradeLevelSeeder
    {
        public static async Task Seed(ApplicationDbContext context)
        {
          
            var count = await context.GradeLevels.CountAsync();

           
            if (count > 0)
                return;

         
            var gradeLevels = new List<GradeLevels>
            {
                new GradeLevels { GradeLevelId = Guid.NewGuid(), Name = "الاول متوسط" },
                new GradeLevels { GradeLevelId = Guid.NewGuid(), Name = "الثاني متوسط" },
                new GradeLevels { GradeLevelId = Guid.NewGuid(), Name = "الثالث متوسط" }
            };

          
            await context.GradeLevels.AddRangeAsync(gradeLevels);
            await context.SaveChangesAsync();
        }
    }
}
