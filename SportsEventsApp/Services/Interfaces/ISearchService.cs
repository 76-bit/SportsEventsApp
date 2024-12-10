using SportsEventsApp.Data;

namespace SportsEventsApp.Services.Interfaces
{
    public interface ISearchService
    {
        Task<List<Fight>> SearchFightsAsync(string query);
    }
}
