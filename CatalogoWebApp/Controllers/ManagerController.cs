using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoWebApp.Controllers
{
    public class ManagerController : Controller
    {
        public const string SessionKeyName = "_Name";


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string user, string password)
        {
            if (user == "Admin" && password == "Catolica10")
            {
                HttpContext.Session.SetString(SessionKeyName, "Admin");
            }

            return Redirect("/Home/Index");

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove(SessionKeyName);
            return Redirect("/Home/Index");

        }
    }
}
