using SportsEventsApp.Data;
using SportsEventsApp.Models;

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

        //Task AddFightToWatchlistAsync(string userId, Guid fightId);
        Task AddFightToFavoritesAsync(string userId, Guid fightId);
        Task RemoveFightFromFavoritesAsync(string userId, Guid fightId);

        ///Task<PaginatedListViewModel<Fight>> GetUserWatchlistAsync(string userId, int page, int pageSize);
        Task<PaginatedListViewModel<Fight>> GetUserFavoritesAsync(string userId, int page, int pageSize);
    }
}
