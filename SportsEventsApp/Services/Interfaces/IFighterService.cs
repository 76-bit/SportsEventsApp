using SportsEventsApp.Data;

namespace SportsEventsApp.Services.Interfaces
{
    public interface IFighterService
    {
        Task<Fighter?> GetFighterByIdAsync(Guid fighterId);
        Task<List<Fighter>> GetAllFightersAsync(bool includeDeleted = false); // New method for listing fighters
        Task AddFighterAsync(Fighter fighter); // New method for adding a fighter
        Task EditFighterAsync(Fighter fighter);
        Task SoftDeleteFighterAsync(Guid fighterId);

    }
}
