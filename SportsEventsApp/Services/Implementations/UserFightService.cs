using Microsoft.EntityFrameworkCore;
using SportsEventsApp.Data;
using SportsEventsApp.Services.Interfaces;

public class UserFightService : IUserFightService
{
    private readonly SportEventsAppDbContext _context;

    public UserFightService(SportEventsAppDbContext context)
    {
        _context = context;
    }

    public async Task AddToListAsync(string userId, Guid fightId, string listType)
    {
        if (await _context.UsersFights.AnyAsync(uf => uf.UserId == userId && uf.FightId == fightId && uf.ListType == listType))
            return; // Avoid duplicates

        var userFight = new UserFight
        {
            UserId = userId,
            FightId = fightId,
            ListType = listType
        };

        _context.UsersFights.Add(userFight);
        await _context.SaveChangesAsync();
    }

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

    public async Task<List<Fight>> GetListAsync(string userId, string listType)
    {
        return await _context.UsersFights
            .Where(uf => uf.UserId == userId && uf.ListType == listType)
            .Select(uf => uf.Fight)
            .ToListAsync();
    }
}
