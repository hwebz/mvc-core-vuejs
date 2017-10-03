using Microsoft.AspNetCore.Mvc;

namespace MvcCoreVuejs.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View("SpaFallback");
        }

        public IActionResult SpaFallback()
        {
            return View("SpaFallback");
        }
    }
}
