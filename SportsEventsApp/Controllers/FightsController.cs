﻿using Microsoft.AspNetCore.Mvc;
using SportsEventsApp.Services.Interfaces;
using SportsEventsApp.Models;
using SportsEventsApp.Data;
using static SportsEventsApp.Constants.ModelConstants;
using SportsEventsApp.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SportsEventsApp.Controllers
{
    public class FightsController : Controller
    {
        private readonly IFightService _fightService;
        private readonly UserManager<IdentityUser> _userManager;

        public FightsController(IFightService fightService, UserManager<IdentityUser> userManager)
        {
            _fightService = fightService;
            _userManager = userManager;
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
				ImageUrl = fight.ImageUrl,
                YouTubeUrl = fight.YouTubeUrl,
				Fighters = fight.FighterFights
					.Where(ff => ff.Fighter != null)
					.Select(ff => new FighterViewModel
					{
						Id = ff.Fighter.Id,
						FirstName = ff.Fighter.FirstName,
						LastName = ff.Fighter.LastName,
						NickName = ff.Fighter.NickName,
						DateOfBirth = ff.Fighter.DateOfBirth,
						Height = ff.Fighter.Height,
						Reach = ff.Fighter.Reach,
						Category = ff.Fighter.Category?.Name ?? "Unknown", // Handle null Category
						ImageUrl = ff.Fighter.ImageUrl // ignore warning, default image is set
					})
					.ToList()
			};

			return View(viewModel);
		}


        // Add a new fight (GET)
        public async Task<IActionResult> Add()
        {
            var fighters = await _fightService.GetAllFightersAsync();

            ViewBag.Fighters = fighters.Select(f => new SelectListItem
            {
                Value = f.Id.ToString(),
                Text = $"{f.FirstName} {f.LastName} ({f.NickName})"
            }).ToList();

            return View(new FightViewModel());
        }

        //Add a new fight (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(FightViewModel model, [FromForm] List<Guid> SelectedFighters)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Validate that exactly two fighters are provided
            if (SelectedFighters == null || SelectedFighters.Count != 2)
            {
                ModelState.AddModelError(string.Empty, "You must select exactly two fighters.");
                return View(model);
            }

            // Create the new fight object
            var fight = new Fight
            {
                Title = model.Title,
                Description = model.Description,
                DateOfTheFight = model.DateOfTheFight,
                ImageUrl = string.IsNullOrEmpty(model.ImageUrl) ? ModelConstants.DefaultImageUrl : model.ImageUrl,
                YouTubeUrl = model.YouTubeUrl,
                PublisherId = _userManager.GetUserId(User)
            };

            await _fightService.AddFightAsync(fight, SelectedFighters);

            return RedirectToAction(nameof(Index));
        }


        // Edit an existing fight (GET)
        [HttpGet]
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
                ImageUrl = fight.ImageUrl,
                YouTubeUrl = fight.YouTubeUrl,
                Fighters = fight.FighterFights
                    .Select(ff => new FighterViewModel
                    {
                        Id = ff.FighterId
                    }).ToList()
            };

            ViewBag.Fighters = (await _fightService.GetAllFightersAsync())
                .Select(f => new SelectListItem
                {
                    Value = f.Id.ToString(),
                    Text = $"{f.FirstName} {f.LastName} ({f.NickName})"
                }).ToList();

            return View(viewModel);
        }

        // Edit an existing fight (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(FightViewModel model, List<Guid> SelectedFighters)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Validate that exactly two fighters are selected
            if (SelectedFighters == null || SelectedFighters.Count != 2)
            {
                ModelState.AddModelError(string.Empty, "You must select exactly two fighters.");
                ViewBag.Fighters = (await _fightService.GetAllFightersAsync())
                    .Select(f => new SelectListItem
                    {
                        Value = f.Id.ToString(),
                        Text = $"{f.FirstName} {f.LastName} ({f.NickName})"
                    }).ToList();
                return View(model);
            }

            // Create the updated fight object
            var fight = new Fight
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Description,
                DateOfTheFight = model.DateOfTheFight,
                ImageUrl = string.IsNullOrEmpty(model.ImageUrl) ? ModelConstants.DefaultImageUrl : model.ImageUrl,
                YouTubeUrl = model.YouTubeUrl // ignore warning, i have a default image
            };

            await _fightService.EditFightAsync(fight, SelectedFighters);

            return RedirectToAction(nameof(Index));
        }


        // Soft-delete a fight
        public async Task<IActionResult> Delete(Guid id)
        {
            await _fightService.SoftDeleteFightAsync(id);
            return RedirectToAction(nameof(Index));
        }

        //Confirm Delete (GET)
        public async Task<IActionResult> ConfirmDelete(Guid id)
        {
            var fight = await _fightService.GetFightByIdAsync(id);
            if (fight == null || fight.IsDeleted)
            {
                return NotFound();
            }

            var viewModel = new FightViewModel
            {
                Id = fight.Id,
                Title = fight.Title
            };

            return View(viewModel);
        }

        // Confirm Delete (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmDelete(FightViewModel model)
        {
            await _fightService.SoftDeleteFightAsync(model.Id);
            return RedirectToAction(nameof(Index));
        }

        // Display old (archived) fights
        public async Task<IActionResult> Archived(int page = 1, int pageSize = 4)
        {
            var fights = await _fightService.GetArchivedFightsAsync();
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

        // Display upcoming fights
        public async Task<IActionResult> Upcoming(int page = 1, int pageSize = 4)
        {
            var fights = await _fightService.GetUpcomingFightsAsync();
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

        // Add fight to favorites
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddToFavorites(Guid id)
        {
            var userId = _userManager.GetUserId(User);
            if (string.IsNullOrEmpty(userId)) return Unauthorized();

            await _fightService.AddFightToFavoritesAsync(userId, id);
            return RedirectToAction(nameof(Favorites));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveFromFavorites(Guid id)
        {
            var userId = _userManager.GetUserId(User);
            if (string.IsNullOrEmpty(userId)) return Unauthorized();

            await _fightService.RemoveFightFromFavoritesAsync(userId, id);
            return RedirectToAction(nameof(Favorites));
        }

        // Favorites page with pagination
        public async Task<IActionResult> Favorites(int page = 1, int pageSize = 4)
        {
            var userId = _userManager.GetUserId(User);
            if (string.IsNullOrEmpty(userId)) return Unauthorized();

            var paginatedList = await _fightService.GetUserFavoritesAsync(userId, page, pageSize);
            var viewModel = new PaginatedListViewModel<FightViewModel>
            {
                Items = paginatedList.Items.Select(f => new FightViewModel
                {
                    Id = f.Id,
                    Title = f.Title,
                    Description = f.Description,
                    DateOfTheFight = f.DateOfTheFight,
                    ImageUrl = f.ImageUrl
                }).ToList(),
                CurrentPage = paginatedList.CurrentPage,
                TotalPages = paginatedList.TotalPages
            };

            return View("Favorites", viewModel);
        }
    }
}
