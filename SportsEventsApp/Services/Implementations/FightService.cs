﻿using SportsEventsApp.Data;
using SportsEventsApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using static SportsEventsApp.Constants.ModelConstants;

namespace SportsEventsApp.Services.Implementations
{
    public class FightService : IFightService
    {
        private readonly SportEventsAppDbContext _context;

        public FightService(SportEventsAppDbContext context)
        {
            _context = context;
        }

        // Get all fights with optional inclusion of deleted fights
        public async Task<List<Fight>> GetAllFightsAsync(bool includeDeleted = false)
        {
            return await _context.Fights
                .Where(f => includeDeleted || !f.IsDeleted)
                .OrderBy(f => f.DateOfTheFight)
                .ToListAsync();
        }

        // Get fight by ID, ensuring it's not deleted
        public async Task<Fight?> GetFightByIdAsync(Guid fightId)
        {
            return await _context.Fights
                .Include(f => f.FighterFights) // Include the relationship
                    .ThenInclude(ff => ff.Fighter) // Include the Fighter entity
                        .ThenInclude(f => f.Category) // Include the Category of the Fighter
                .Where(f => !f.IsDeleted && f.Id == fightId)
                .FirstOrDefaultAsync();
        }


        // Add a new fight
        public async Task AddFightAsync(Fight fight)
        {
            if (fight == null) throw new ArgumentNullException(nameof(fight));

            // Assign default image if none is provided
            if (string.IsNullOrEmpty(fight.ImageUrl))
            {
                fight.ImageUrl = DefaultImageUrl;
            }

            _context.Fights.Add(fight);
            await _context.SaveChangesAsync();
        }

        // Edit an existing fight
        public async Task EditFightAsync(Fight updatedFight)
        {
            var existingFight = await _context.Fights.FindAsync(updatedFight.Id);
            if (existingFight == null || existingFight.IsDeleted)
            {
                throw new InvalidOperationException("Cannot edit a non-existent or deleted fight.");
            }

            existingFight.Title = updatedFight.Title;
            existingFight.Description = updatedFight.Description;
            existingFight.DateOfTheFight = updatedFight.DateOfTheFight;

            // Use provided image or fallback to default
            existingFight.ImageUrl = string.IsNullOrEmpty(updatedFight.ImageUrl)
                ? DefaultImageUrl
                : updatedFight.ImageUrl;

            _context.Fights.Update(existingFight);
            await _context.SaveChangesAsync();
        }

        // Soft-delete a fight by marking it as deleted
        public async Task SoftDeleteFightAsync(Guid fightId)
        {
            var fight = await _context.Fights.FindAsync(fightId);
            if (fight == null || fight.IsDeleted)
            {
                throw new InvalidOperationException("Cannot delete a non-existent or already deleted fight.");
            }

            fight.IsDeleted = true;
            await _context.SaveChangesAsync();
        }

        // Optional: Restore a soft-deleted fight
        public async Task RestoreFightAsync(Guid fightId)
        {
            var fight = await _context.Fights.FindAsync(fightId);
            if (fight == null || !fight.IsDeleted)
            {
                throw new InvalidOperationException("Cannot restore a non-existent or active fight.");
            }

            fight.IsDeleted = false;
            await _context.SaveChangesAsync();
        }

        // Get upcoming fights
        public async Task<List<Fight>> GetUpcomingFightsAsync()
        {
            return await _context.Fights
                .Where(f => !f.IsDeleted && f.DateOfTheFight > DateTime.Now)
                .OrderBy(f => f.DateOfTheFight)
                .ToListAsync();
        }

        // Get archived fights
        public async Task<List<Fight>> GetArchivedFightsAsync()
        {
            return await _context.Fights
                .Where(f => !f.IsDeleted && f.DateOfTheFight <= DateTime.Now)
                .OrderByDescending(f => f.DateOfTheFight)
                .ToListAsync();
        }

    }
}
