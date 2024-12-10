using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SportsEventsApp.Models;
using SportsEventsApp.Services.Interfaces;

public class UserFightsController : Controller
{
    private readonly IUserFightService _userFightService;
    private readonly UserManager<IdentityUser> _userManager;

    public UserFightsController(IUserFightService userFightService, UserManager<IdentityUser> userManager)
    {
        _userFightService = userFightService;
        _userManager = userManager;
    }

    [Authorize]
    public async Task<IActionResult> Watchlist(int page = 1, int pageSize = 4)
    {
        var userId = _userManager.GetUserId(User);
        var fights = await _userFightService.GetListAsync(userId, "Watchlist");

        var paginatedFights = fights.Skip((page - 1) * pageSize).Take(pageSize).ToList();

        var viewModel = new PaginatedListViewModel<FightViewModel>
        {
            Items = paginatedFights.Select(f => new FightViewModel
            {
                Id = f.Id,
                Title = f.Title,
                Description = f.Description,
                ImageUrl = f.ImageUrl,
                DateOfTheFight = f.DateOfTheFight
            }).ToList(),
            CurrentPage = page,
            TotalPages = (int)Math.Ceiling(fights.Count / (double)pageSize)
        };

        return View(viewModel);
    }

    [Authorize]
    public async Task<IActionResult> Favorites(int page = 1, int pageSize = 4)
    {
        var userId = _userManager.GetUserId(User);
        var fights = await _userFightService.GetListAsync(userId, "Favorites");

        var paginatedFights = fights.Skip((page - 1) * pageSize).Take(pageSize).ToList();

        var viewModel = new PaginatedListViewModel<FightViewModel>
        {
            Items = paginatedFights.Select(f => new FightViewModel
            {
                Id = f.Id,
                Title = f.Title,
                Description = f.Description,
                ImageUrl = f.ImageUrl,
                DateOfTheFight = f.DateOfTheFight
            }).ToList(),
            CurrentPage = page,
            TotalPages = (int)Math.Ceiling(fights.Count / (double)pageSize)
        };

        return View(viewModel);
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> AddToWatchlist(Guid fightId)
    {
        var userId = _userManager.GetUserId(User);
        await _userFightService.AddToListAsync(userId, fightId, "Watchlist");
        return RedirectToAction(nameof(Watchlist));
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> AddToFavorites(Guid fightId)
    {
        var userId = _userManager.GetUserId(User);
        await _userFightService.AddToListAsync(userId, fightId, "Favorites");
        return RedirectToAction(nameof(Favorites));
    }
}
