using Microsoft.AspNetCore.Mvc;

namespace GraveTracker.Areas.Frostgrave.Controllers
{
    [Area("Frostgrave")]
    public class FGHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
