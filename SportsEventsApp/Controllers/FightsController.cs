using Microsoft.AspNetCore.Mvc;
using SportsEventsApp.Services.Interfaces;
using SportsEventsApp.Models;
using SportsEventsApp.Data;

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
        public async Task<IActionResult> Index(int page = 1, int pageSize = 4)
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

        // Add a new fight (GET)
        public IActionResult Add()
        {
            return View(new FightViewModel());
        }

        // Add a new fight (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(FightViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var fight = new Fight
            {
                Title = model.Title,
                Description = model.Description,
                DateOfTheFight = model.DateOfTheFight,
                ImageUrl = model.ImageUrl,
                PublisherId = User.Identity?.Name // Set publisher to current user
            };

            await _fightService.AddFightAsync(fight);
            return RedirectToAction(nameof(Index));
        }

        // Edit an existing fight (GET)
        public async Task<IActionResult> Edit(Guid id)
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

        // Edit an existing fight (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(FightViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var fight = new Fight
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Description,
                DateOfTheFight = model.DateOfTheFight,
                ImageUrl = model.ImageUrl,
            };

            await _fightService.EditFightAsync(fight);
            return RedirectToAction(nameof(Index));
        }

        // Soft-delete a fight
        public async Task<IActionResult> Delete(Guid id)
        {
            await _fightService.SoftDeleteFightAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
