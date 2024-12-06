using Microsoft.AspNetCore.Mvc;
using SportsEventsApp.Models;
using SportsEventsApp.Services.Interfaces;

namespace SportsEventsApp.Controllers
{
    public class FightersController : Controller
    {
        private readonly IFighterService _fighterService;

        public FightersController(IFighterService fighterService)
        {
            _fighterService = fighterService;
        }

        // Fighter details action
        public async Task<IActionResult> Details(Guid id)
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
                Category = fighter.Category.Name,
                ImageUrl = fighter.ImageUrl
            };

            return View("FighterDetails", viewModel); // Use the same FighterDetails view
        }
    }
}
