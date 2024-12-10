using SportsEventsApp.Data;

namespace SportsEventsApp.Services.Interfaces
{
    public interface IUserFightService
    {
        Task AddToListAsync(string userId, Guid fightId, string listType);
        Task RemoveFromListAsync(string userId, Guid fightId, string listType);
        Task<List<Fight>> GetListAsync(string userId, string listType);
    }
}
