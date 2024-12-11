using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportsEventsApp.Models;
using SportsEventsApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SportsEventsApp.Controllers
{
    public class FightersController : Controller
    {
        private readonly IFighterService _fighterService;
        private readonly ICategoryService _categoryService;

        public FightersController(IFighterService fighterService, ICategoryService categoryService)
        {
            _fighterService = fighterService;
            _categoryService = categoryService;
        }

        // Display all fighters
        public async Task<IActionResult> Index()
        {
            var fighters = await _fighterService.GetAllFightersAsync();
            var viewModel = fighters.Select(f => new FighterViewModel
            {
                Id = f.Id,
                FirstName = f.FirstName,
                LastName = f.LastName,
                NickName = f.NickName,
                DateOfBirth = f.DateOfBirth,
                Height = f.Height,
                Reach = f.Reach,
                Country = f.Country,
                Category = f.Category?.Name ?? "Unknown",
                ImageUrl = f.ImageUrl //ignore the warning - i literaly have a default image
            }).ToList();

            return View(viewModel);
        }

        // Add a new fighter (GET)
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Add()
        {
            ViewBag.Categories = new SelectList(await _categoryService.GetAllCategoriesAsync(), "Id", "Name");
            return View(new FighterViewModel());
        }

        // Add a new fighter (POST)
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(FighterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = new SelectList(await _categoryService.GetAllCategoriesAsync(), "Id", "Name");
                return View(model);
            }

            var fighter = new Fighter
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                NickName = model.NickName,
                DateOfBirth = model.DateOfBirth,
                Height = model.Height,
                Reach = model.Reach,
                Country = model.Country,
                CategoryId = model.CategoryId,
                ImageUrl = string.IsNullOrEmpty(model.ImageUrl) ? "/images/default-fighter.jpg" : model.ImageUrl
            };

            await _fighterService.AddFighterAsync(fighter);
            return RedirectToAction(nameof(Index));
        }

        // Edit an existing fighter (GET)
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(Guid id)
        {
            var fighter = await _fighterService.GetFighterByIdAsync(id);
            if (fighter == null) return NotFound();

            var viewModel = new FighterViewModel
            {
                Id = fighter.Id,
                FirstName = fighter.FirstName,
                LastName = fighter.LastName,
                NickName = fighter.NickName,
                DateOfBirth = fighter.DateOfBirth,
                Height = fighter.Height,
                Reach = fighter.Reach,
                Country = fighter.Country,
                CategoryId = fighter.CategoryId,
                ImageUrl = fighter.ImageUrl //ignore the warning - i literaly have a default image
            };

            ViewBag.Categories = new SelectList(await _categoryService.GetAllCategoriesAsync(), "Id", "Name", viewModel.CategoryId);
            return View(viewModel);
        }

        // Edit an existing fighter (POST)
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(FighterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = new SelectList(await _categoryService.GetAllCategoriesAsync(), "Id", "Name", model.CategoryId);
                return View(model);
            }

            var fighter = new Fighter
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                NickName = model.NickName,
                DateOfBirth = model.DateOfBirth,
                Height = model.Height,
                Reach = model.Reach,
                Country = model.Country,
                CategoryId = model.CategoryId,
                ImageUrl = string.IsNullOrEmpty(model.ImageUrl) ? "/images/default-fighter.jpg" : model.ImageUrl
            };

            await _fighterService.EditFighterAsync(fighter);
            return RedirectToAction(nameof(Index));
        }

        // Confirm Delete (GET)
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var fighter = await _fighterService.GetFighterByIdAsync(id);
            if (fighter == null) return NotFound();

            var viewModel = new FighterViewModel
            {
                Id = fighter.Id,
                FirstName = fighter.FirstName,
                LastName = fighter.LastName,
                NickName = fighter.NickName,
                ImageUrl = fighter.ImageUrl
            };

            return View(viewModel);
        }

        // Delete (POST)
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(FighterViewModel model)
        {
            await _fighterService.SoftDeleteFighterAsync(model.Id);
            return RedirectToAction(nameof(Index));
        }

        // Fighter Details (GET)
        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var fighter = await _fighterService.GetFighterByIdAsync(id);
            if (fighter == null || fighter.IsDeleted)
                return NotFound();

            var viewModel = new FighterViewModel
            {
                Id = fighter.Id,
                FirstName = fighter.FirstName,
                LastName = fighter.LastName,
                NickName = fighter.NickName,
                DateOfBirth = fighter.DateOfBirth,
                Height = fighter.Height,
                Reach = fighter.Reach,
                Country = fighter.Country,
                Category = fighter.Category?.Name ?? "Unknown",
                ImageUrl = fighter.ImageUrl
            };

            return View("FighterDetails", viewModel);
        }

    }
}
