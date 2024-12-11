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

        //Get a single fighter by his id
        public async Task<Fighter?> GetFighterByIdAsync(Guid fighterId)
        {
            return await _context.Fighters
                .Include(f => f.Category)
                .FirstOrDefaultAsync(f => f.Id == fighterId && !f.IsDeleted);
        }

        //Get all fighters
        public async Task<List<Fighter>> GetAllFightersAsync(bool includeDeleted = false)
        {
            return await _context.Fighters
                .Where(f => includeDeleted || !f.IsDeleted)
                .Include(f => f.Category)
                .ToListAsync();
        }

        //Adding a fighter logic
        public async Task AddFighterAsync(Fighter fighter)
        {
            _context.Fighters.Add(fighter);
            await _context.SaveChangesAsync();
        }

        //Editing a fighter logic
        public async Task EditFighterAsync(Fighter updatedFighter)
        {
            var existingFighter = await _context.Fighters.FindAsync(updatedFighter.Id);
            if (existingFighter == null || existingFighter.IsDeleted)
            {
                throw new InvalidOperationException("Cannot edit a non-existent or deleted fighter.");
            }

            existingFighter.FirstName = updatedFighter.FirstName;
            existingFighter.LastName = updatedFighter.LastName;
            existingFighter.NickName = updatedFighter.NickName;
            existingFighter.DateOfBirth = updatedFighter.DateOfBirth;
            existingFighter.Height = updatedFighter.Height;
            existingFighter.Reach = updatedFighter.Reach;
            existingFighter.Country = updatedFighter.Country;
            existingFighter.CategoryId = updatedFighter.CategoryId;
            existingFighter.ImageUrl = string.IsNullOrEmpty(updatedFighter.ImageUrl) ? "/images/default-fighter.jpg" : updatedFighter.ImageUrl;

            _context.Fighters.Update(existingFighter);
            await _context.SaveChangesAsync();
        }

        //Mark a fighter as deleted (soft-delete him)
        public async Task SoftDeleteFighterAsync(Guid fighterId)
        {
            var fighter = await _context.Fighters.FindAsync(fighterId);
            if (fighter == null)
            {
                throw new InvalidOperationException("Fighter not found.");
            }

            fighter.IsDeleted = true;
            await _context.SaveChangesAsync();
        }
    }
}
