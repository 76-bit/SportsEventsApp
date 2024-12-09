using Microsoft.AspNetCore.Mvc;

namespace SportsEventsApp.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/Error404")]
        public IActionResult Error404()
        {
            return View("Error404");  // Create a view for 404 error
        }

        [Route("Error/Error500")]
        public IActionResult Error500()
        {
            return View("Error500");  // Create a view for 500 error
        }
    }

}
