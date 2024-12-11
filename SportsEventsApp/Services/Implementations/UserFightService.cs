using Microsoft.EntityFrameworkCore;
using SportsEventsApp.Data;
using SportsEventsApp.Services.Interfaces;

//This is the service holding the logic for the favorites page's functionality
public class UserFightService : IUserFightService
{
    private readonly SportEventsAppDbContext _context;

    public UserFightService(SportEventsAppDbContext context)
    {
        _context = context;
    }

    // Add to favorites
    public async Task AddToListAsync(string userId, Guid fightId, string listType)
    {
        if (await _context.UsersFights.AnyAsync(uf => uf.UserId == userId && uf.FightId == fightId && uf.ListType == listType))
            return;

        var userFight = new UserFight
        {
            UserId = userId,
            FightId = fightId,
            ListType = listType
        };

        _context.UsersFights.Add(userFight);
        await _context.SaveChangesAsync();
    }

    //Remove from favorites 
    public async Task RemoveFromListAsync(string userId, Guid fightId, string listType)
    {
        var userFight = await _context.UsersFights
            .FirstOrDefaultAsync(uf => uf.UserId == userId && uf.FightId == fightId && uf.ListType == listType);

        if (userFight != null)
        {
            _context.UsersFights.Remove(userFight);
            await _context.SaveChangesAsync();
        }
    }

    // Get favorites (for displaying)
    public async Task<List<Fight>> GetListAsync(string userId, string listType)
    {
        return await _context.UsersFights
            .Where(uf => uf.UserId == userId && uf.ListType == listType)
            .Select(uf => uf.Fight)
            .ToListAsync();
    }
}
