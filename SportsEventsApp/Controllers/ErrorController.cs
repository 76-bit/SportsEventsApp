using Microsoft.AspNetCore.Mvc;

namespace SportsEventsApp.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/Error404")]
        public IActionResult Error404()
        {
            return View("Error404");  
        }

        [Route("Error/Error500")]
        public IActionResult Error500()
        {
            return View("Error500");  
        }
        //Note: the 404 and 500 custom error pages either cannot be seen in a development stage (like in visual studio) or i just dont know how to do them
    }

}
