using SportsEventsApp.Data;
using SportsEventsApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using static SportsEventsApp.Constants.ModelConstants;
using SportsEventsApp.Models;

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
        public async Task AddFightAsync(Fight fight, List<Guid> fighterIds)
        {
            if (fight == null) throw new ArgumentNullException(nameof(fight));
            if (fighterIds == null || fighterIds.Count != 2)
                throw new ArgumentException("Exactly two fighter IDs must be provided.", nameof(fighterIds));

            // Assign default image if none is provided
            if (string.IsNullOrEmpty(fight.ImageUrl))
            {
                fight.ImageUrl = DefaultImageUrl;
            }

            // Assign default YouTube thumbnail if no URL is provided
            if (string.IsNullOrEmpty(fight.YouTubeUrl))
            {
                fight.YouTubeUrl = "/images/default-youtube.jpg"; // Default "no video" image path
            }

            // Link fighters to the fight
            fight.FighterFights = fighterIds.Select(fighterId => new FighterFight
            {
                FighterId = fighterId,
                FightId = fight.Id
            }).ToList();

            _context.Fights.Add(fight);
            await _context.SaveChangesAsync();
        }

        // Edit an existing fight
        public async Task EditFightAsync(Fight updatedFight, List<Guid> fighterIds)
        {
            var existingFight = await _context.Fights
                .Include(f => f.FighterFights)
                .FirstOrDefaultAsync(f => f.Id == updatedFight.Id);

            if (existingFight == null || existingFight.IsDeleted)
            {
                throw new InvalidOperationException("Cannot edit a non-existent or deleted fight.");
            }

            // Update basic fight details
            existingFight.Title = updatedFight.Title;
            existingFight.Description = updatedFight.Description;
            existingFight.DateOfTheFight = updatedFight.DateOfTheFight;

            // Use provided image or fallback to default
            existingFight.ImageUrl = string.IsNullOrEmpty(updatedFight.ImageUrl)
                ? DefaultImageUrl
                : updatedFight.ImageUrl;

            // Update YouTube URL
            existingFight.YouTubeUrl = updatedFight.YouTubeUrl;

            // Update linked fighters
            _context.FightersFights.RemoveRange(existingFight.FighterFights); // Clear existing links
            existingFight.FighterFights = fighterIds.Select(fighterId => new FighterFight
            {
                FighterId = fighterId,
                FightId = existingFight.Id
            }).ToList();

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

        public async Task<Fighter?> GetFighterByIdAsync(Guid fighterId)
        {
            return await _context.Fighters
                .Where(f => !f.IsDeleted) // Exclude deleted fighters
                .FirstOrDefaultAsync(f => f.Id == fighterId);
        }

        public async Task<List<Fighter>> GetAllFightersAsync()
        {
            return await _context.Fighters
                .Where(f => !f.IsDeleted) // Exclude deleted fighters
                .Include(f => f.Category) // Ensure Category is included
                .Select(f => new Fighter
                {
                    Id = f.Id,
                    FirstName = f.FirstName,
                    LastName = f.LastName,
                    NickName = f.NickName,
                    DateOfBirth = f.DateOfBirth,
                    Height = f.Height,
                    Reach = f.Reach,
                    Category = f.Category,
                    ImageUrl = f.ImageUrl,
                    Country = f.Country
                })
                .ToListAsync();
        }

        //public async Task AddFightToWatchlistAsync(string userId, Guid fightId)
        //{
        //    if (string.IsNullOrEmpty(userId)) throw new ArgumentNullException(nameof(userId));

        //    // Check if user exists
        //    var userExists = await _context.Users.AnyAsync(u => u.Id == userId);
        //    if (!userExists)
        //    {
        //        throw new InvalidOperationException($"User with ID {userId} does not exist.");
        //    }

        //    // Check if fight exists
        //    var fightExists = await _context.Fights.AnyAsync(f => f.Id == fightId && !f.IsDeleted);
        //    if (!fightExists)
        //    {
        //        throw new InvalidOperationException($"Fight with ID {fightId} does not exist.");
        //    }

        //    // Check if the fight is already in the watchlist
        //    var alreadyExists = await _context.UsersFights.AnyAsync(uf => uf.UserId == userId && uf.FightId == fightId && uf.ListType == "Watchlist");
        //    if (alreadyExists)
        //    {
        //        throw new InvalidOperationException("This fight is already in the user's watchlist.");
        //    }

        //    // Add the fight to the watchlist
        //    var userFight = new UserFight
        //    {
        //        UserId = userId,
        //        FightId = fightId,
        //        ListType = "Watchlist"
        //    };

        //    _context.UsersFights.Add(userFight);
        //    await _context.SaveChangesAsync();
        //}

        public async Task AddFightToFavoritesAsync(string userId, Guid fightId)
        {
            if (string.IsNullOrEmpty(userId)) throw new ArgumentNullException(nameof(userId));

            // Check if user exists
            var userExists = await _context.Users.AnyAsync(u => u.Id == userId);
            if (!userExists)
            {
                throw new InvalidOperationException($"User with ID {userId} does not exist.");
            }

            // Check if fight exists
            var fightExists = await _context.Fights.AnyAsync(f => f.Id == fightId && !f.IsDeleted);
            if (!fightExists)
            {
                throw new InvalidOperationException($"Fight with ID {fightId} does not exist.");
            }

            // Check if the fight is already in the favorites
            var alreadyExists = await _context.UsersFights.AnyAsync(uf => uf.UserId == userId && uf.FightId == fightId && uf.ListType == "Favorites");
            if (alreadyExists)
            {
                return; // Fight is already in favorites, do nothing
            }

            // Add the fight to the favorites
            var userFight = new UserFight
            {
                UserId = userId,
                FightId = fightId,
                ListType = "Favorites"
            };

            _context.UsersFights.Add(userFight);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveFightFromFavoritesAsync(string userId, Guid fightId)
        {
            var userFight = await _context.UsersFights.FirstOrDefaultAsync(uf => uf.UserId == userId && uf.FightId == fightId && uf.ListType == "Favorites");
            if (userFight == null)
            {
                throw new InvalidOperationException("This fight is not in the user's favorites.");
            }

            _context.UsersFights.Remove(userFight);
            await _context.SaveChangesAsync();
        }

        //public async Task<PaginatedListViewModel<Fight>> GetUserWatchlistAsync(string userId, int page, int pageSize)
        //{
        //    var query = _context.UsersFights
        //        .Where(uf => uf.UserId == userId)
        //        .Select(uf => uf.Fight)
        //        .Where(f => !f.IsDeleted) // Exclude soft-deleted fights
        //        .OrderBy(f => f.DateOfTheFight); // Order by fight date

        //    var totalCount = await query.CountAsync();
        //    var fights = await query
        //        .Skip((page - 1) * pageSize)
        //        .Take(pageSize)
        //        .ToListAsync();

        //    return new PaginatedListViewModel<Fight>
        //    {
        //        Items = fights,
        //        CurrentPage = page,
        //        TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize)
        //    };
        //}

        public async Task<PaginatedListViewModel<Fight>> GetUserFavoritesAsync(string userId, int page, int pageSize)
        {
            var query = _context.UsersFights
                .Where(uf => uf.UserId == userId)
                .Select(uf => uf.Fight)
                .Where(f => !f.IsDeleted) // Exclude soft-deleted fights
                .OrderBy(f => f.DateOfTheFight); // Order by fight date

            var totalCount = await query.CountAsync();
            var fights = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new PaginatedListViewModel<Fight>
            {
                Items = fights,
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize)
            };
        }

    }
}
