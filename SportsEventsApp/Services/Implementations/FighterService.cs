using SportsEventsApp.Data;
using Microsoft.EntityFrameworkCore;
using SportsEventsApp.Services.Interfaces;

namespace SportsEventsApp.Services.Implementations
{
    public class FighterService : IFighterService
    {
        private readonly SportEventsAppDbContext _context;

        public FighterService(SportEventsAppDbContext context)
        {
            _context = context;
        }

        public async Task<Fighter?> GetFighterByIdAsync(Guid fighterId)
        {
            return await _context.Fighters
                .Include(f => f.Category)
                .FirstOrDefaultAsync(f => f.Id == fighterId);
        }
    }
}
