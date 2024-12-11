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

    //GET Watchlist (removed logic)
    [Authorize]
    [HttpGet]
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

    // GET favorites of current user
    [HttpGet]
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
    //Note - removed logic, there used to be a watchlist page, but i decited that the favorites and watchlist page are almost similar so there is no point of having both
    //Leaving it here in case I change my mind
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
