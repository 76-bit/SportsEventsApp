using Microsoft.AspNetCore.Mvc;
using SportsEventsApp.Models;
using SportsEventsApp.Services.Interfaces;

namespace SportsEventsApp.Controllers
{
    public class SearchController : Controller
    {
        private readonly ISearchService _searchService;

        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        // Search Results (GET)
        public async Task<IActionResult> Index(string query, int page = 1, int pageSize = 4)
        {
            //check if something has been written at all
            if (string.IsNullOrEmpty(query))
            {
                return RedirectToAction("Index", "Fights");
            }

            var searchResults = await _searchService.SearchFightsAsync(query);
            var paginatedResults = searchResults
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var viewModel = new PaginatedListViewModel<FightViewModel>
            {
                Items = paginatedResults.Select(f => new FightViewModel
                {
                    Id = f.Id,
                    Title = f.Title,
                    Description = f.Description,
                    DateOfTheFight = f.DateOfTheFight,
                    ImageUrl = f.ImageUrl
                }).ToList(),
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(searchResults.Count / (double)pageSize),
                SearchQuery = query
            };

            return View(viewModel);
        }
    }
}
