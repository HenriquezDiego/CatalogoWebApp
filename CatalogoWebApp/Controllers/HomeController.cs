using Microsoft.AspNetCore.Mvc;

namespace AdminLTE.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Table()
        {

            return View();
        }
    }
}