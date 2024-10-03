
using AlQalem.Data;
using AlQalem.Models;
using Microsoft.EntityFrameworkCore;

public class AcademicYearSeeder
{
    public static async Task Seed(ApplicationDbContext context)
    {

        var count = await context.AcademicYears.CountAsync();

        if (count > 0)
            return;
       
        var academicYears = new List<AcademicYear>
        {
            new AcademicYear { AcademicYearId = Guid.NewGuid(), Year = new DateTime(2023) },
            new AcademicYear { AcademicYearId = Guid.NewGuid(), Year = new DateTime(2024) },
            new AcademicYear { AcademicYearId = Guid.NewGuid(), Year = new DateTime(2025) },
            new AcademicYear { AcademicYearId = Guid.NewGuid(), Year = new DateTime(2026) },
            new AcademicYear { AcademicYearId = Guid.NewGuid(), Year = new DateTime(2027) },
            new AcademicYear { AcademicYearId = Guid.NewGuid(), Year = new DateTime(2028) },
            new AcademicYear { AcademicYearId = Guid.NewGuid(), Year = new DateTime(2029) },
            new AcademicYear { AcademicYearId = Guid.NewGuid(), Year = new DateTime(2030) }
        };

        await context.AcademicYears.AddRangeAsync(academicYears);
        await context.SaveChangesAsync();
    }
}
