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

        public async Task<List<Fighter>> GetAllFightersAsync()
        {
            return await _context.Fighters
                .Include(f => f.Category)
                .ToListAsync();
        }

        public async Task AddFighterAsync(Fighter fighter)
        {
            _context.Fighters.Add(fighter);
            await _context.SaveChangesAsync();
        }
        public async Task EditFighterAsync(Fighter fighter)
        {
            var existingFighter = await _context.Fighters.FindAsync(fighter.Id);
            if (existingFighter == null)
            {
                throw new InvalidOperationException("Fighter not found.");
            }

            existingFighter.FirstName = fighter.FirstName;
            existingFighter.LastName = fighter.LastName;
            existingFighter.NickName = fighter.NickName;
            existingFighter.DateOfBirth = fighter.DateOfBirth;
            existingFighter.Height = fighter.Height;
            existingFighter.Reach = fighter.Reach;
            existingFighter.Country = fighter.Country;
            existingFighter.CategoryId = fighter.CategoryId;
            existingFighter.ImageUrl = fighter.ImageUrl;

            _context.Fighters.Update(existingFighter);
            await _context.SaveChangesAsync();
        }

        public async Task SoftDeleteFighterAsync(Guid fighterId)
{
    var fighter = await _context.Fighters.FindAsync(fighterId);
    if (fighter == null)
    {
        throw new InvalidOperationException("Fighter not found.");
    }

    // Mark the fighter as deleted
    fighter.IsDeleted = true;
    await _context.SaveChangesAsync();
}

    }
}
