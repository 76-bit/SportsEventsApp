using Microsoft.EntityFrameworkCore;
using SportsEventsApp.Data;
using SportsEventsApp.Services.Interfaces;

namespace SportsEventsApp.Services.Implementations
{
    public class SearchService : ISearchService
    {
        private readonly SportEventsAppDbContext _context;

        public SearchService(SportEventsAppDbContext context)
        {
            _context = context;
        }

        //Search for maching title, description or one of the two fighters's names
        public async Task<List<Fight>> SearchFightsAsync(string query)
        {
            query = query.ToLower();

            return await _context.Fights
                .Where(f => !f.IsDeleted &&
                            (f.Title.ToLower().Contains(query) ||
                             f.Description.ToLower().Contains(query) ||
                             f.FighterFights.Any(ff => ff.Fighter.FirstName.ToLower().Contains(query) ||
                                                       ff.Fighter.LastName.ToLower().Contains(query))))
                .Include(f => f.FighterFights)
                .ThenInclude(ff => ff.Fighter)
                .ToListAsync();
        }
    }
}
