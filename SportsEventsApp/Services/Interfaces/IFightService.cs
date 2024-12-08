using SportsEventsApp.Data;

namespace SportsEventsApp.Services.Interfaces
{
    public interface IFightService
    {
        Task<List<Fight>> GetAllFightsAsync(bool includeDeleted = false);
        Task<Fight?> GetFightByIdAsync(Guid fightId);
        Task<Fighter?> GetFighterByIdAsync(Guid fighterId);
        Task<List<Fighter>> GetAllFightersAsync();

        Task AddFightAsync(Fight fight, List<Guid> fighterIds);
        Task EditFightAsync(Fight fight, List<Guid> fighterIds);

        Task SoftDeleteFightAsync(Guid fightId);
        Task<List<Fight>> GetUpcomingFightsAsync();
        Task<List<Fight>> GetArchivedFightsAsync();
    }
}
