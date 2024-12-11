using SportsEventsApp.Data;

namespace SportsEventsApp.Services.Interfaces
{
    public interface IFighterService
    {
        Task<Fighter?> GetFighterByIdAsync(Guid fighterId);
        Task<List<Fighter>> GetAllFightersAsync(bool includeDeleted = false);
        Task AddFighterAsync(Fighter fighter);
        Task EditFighterAsync(Fighter fighter);
        Task SoftDeleteFighterAsync(Guid fighterId);

    }
}
