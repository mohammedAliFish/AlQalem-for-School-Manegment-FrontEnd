
using AlQalem.Data;
using AlQalem.Models;
using Microsoft.EntityFrameworkCore;

public class AcademicYearSeeder
{
    public static async Task Seed(ModelBuilder modelBuilder)
    {
        

       
        var academicYears = new List<AcademicYear>
        {
            new AcademicYear { AcademicYearId = Guid.NewGuid(), Year = new DateTime(2023, 1, 1) },
            new AcademicYear { AcademicYearId = Guid.NewGuid(), Year = new DateTime(2024, 1, 1) },
            new AcademicYear { AcademicYearId = Guid.NewGuid(), Year = new DateTime(2025, 1, 1) },
            new AcademicYear { AcademicYearId = Guid.NewGuid(), Year = new DateTime(2026, 1, 1) },
            new AcademicYear { AcademicYearId = Guid.NewGuid(), Year = new DateTime(2027, 1, 1) },
            new AcademicYear { AcademicYearId = Guid.NewGuid(), Year = new DateTime(2028, 1, 1) },
            new AcademicYear { AcademicYearId = Guid.NewGuid(), Year = new DateTime(2029, 1, 1) },
            new AcademicYear { AcademicYearId = Guid.NewGuid(), Year = new DateTime(2030, 1, 1) }
        };
        modelBuilder.Entity<AcademicYear>().HasData(academicYears.ToArray());

    }
}
