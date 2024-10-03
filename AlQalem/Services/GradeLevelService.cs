using AlQalem.ServiceInterfaces;
using AlQalem.Data;
using Microsoft.EntityFrameworkCore;

namespace AlQalem.Services
{
    public class GradeLevelService : InterfaceGradeLevelService
    {
        private readonly ApplicationDbContext _context;

        public GradeLevelService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Object> GetGradeLevelsListAsync()
        {
            var gradeLevels = await _context.GradeLevels.ToListAsync();
            return gradeLevels;
        }
    }
}
