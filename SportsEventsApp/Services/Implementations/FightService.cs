using SportsEventsApp.Data;
using SportsEventsApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace SportsEventsApp.Services.Implementations
{
    public class FightService : IFightService
    {
        private readonly SportEventsAppDbContext _context;

        public FightService(SportEventsAppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Fight>> GetAllFightsAsync(bool includeDeleted = false)
        {
            return await _context.Fights
                .Where(f => includeDeleted || !f.IsDeleted)
                .OrderBy(f => f.DateOfTheFight)
                .ToListAsync();
        }

        public async Task<Fight?> GetFightByIdAsync(Guid fightId)
        {
            return await _context.Fights
                .Where(f => !f.IsDeleted && f.Id == fightId)
                .FirstOrDefaultAsync();
        }

        public async Task AddFightAsync(Fight fight)
        {
            _context.Fights.Add(fight);
            await _context.SaveChangesAsync();
        }

        public async Task EditFightAsync(Fight fight)
        {
            _context.Fights.Update(fight);
            await _context.SaveChangesAsync();
        }

        public async Task SoftDeleteFightAsync(Guid fightId)
        {
            var fight = await _context.Fights.FindAsync(fightId);
            if (fight != null)
            {
                fight.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Fight>> GetUpcomingFightsAsync()
        {
            return await _context.Fights
                .Where(f => !f.IsDeleted && f.DateOfTheFight > DateTime.Now)
                .OrderBy(f => f.DateOfTheFight)
                .ToListAsync();
        }

        public async Task<List<Fight>> GetArchivedFightsAsync()
        {
            return await _context.Fights
                .Where(f => !f.IsDeleted && f.DateOfTheFight <= DateTime.Now)
                .OrderByDescending(f => f.DateOfTheFight)
                .ToListAsync();
        }
    }
}
