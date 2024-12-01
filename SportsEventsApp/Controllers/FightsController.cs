using Microsoft.AspNetCore.Mvc;
using SportsEventsApp.Services.Interfaces;
using SportsEventsApp.Models;

namespace SportsEventsApp.Controllers
{
    public class FightsController : Controller
    {
        private readonly IFightService _fightService;

        public FightsController(IFightService fightService)
        {
            _fightService = fightService;
        }

        // Display all fights with pagination
        public async Task<IActionResult> Index(int page = 1, int pageSize = 8)
        {
            var fights = await _fightService.GetAllFightsAsync();
            var paginatedFights = fights
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var viewModel = new PaginatedListViewModel<FightViewModel>
            {
                Items = paginatedFights.Select(f => new FightViewModel
                {
                    Id = f.Id,
                    Title = f.Title,
                    Description = f.Description,
                    DateOfTheFight = f.DateOfTheFight,
                    ImageUrl = f.ImageUrl
                }).ToList(),
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(fights.Count / (double)pageSize)
            };

            return View(viewModel);
        }

        // Fight details
        public async Task<IActionResult> Details(Guid id)
        {
            var fight = await _fightService.GetFightByIdAsync(id);
            if (fight == null || fight.IsDeleted) return NotFound();

            var viewModel = new FightViewModel
            {
                Id = fight.Id,
                Title = fight.Title,
                Description = fight.Description,
                DateOfTheFight = fight.DateOfTheFight,
                ImageUrl = fight.ImageUrl
            };

            return View(viewModel);
        }
    }
}
