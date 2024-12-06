using SportsEventsApp.Data;

namespace SportsEventsApp.Services.Interfaces
{
    public interface IFighterService
    {
        Task<Fighter?> GetFighterByIdAsync(Guid fighterId);
    }
}
