using SportsEventsApp.Data;

namespace SportsEventsApp.Services.Interfaces
{
    public interface IFightService
    {
        Task<List<Fight>> GetAllFightsAsync(bool includeDeleted = false);
        Task<Fight?> GetFightByIdAsync(Guid fightId);
        Task AddFightAsync(Fight fight);
        Task EditFightAsync(Fight fight);
        Task SoftDeleteFightAsync(Guid fightId);
        Task<List<Fight>> GetUpcomingFightsAsync();
        Task<List<Fight>> GetArchivedFightsAsync();
    }
}
