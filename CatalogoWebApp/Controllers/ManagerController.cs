using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoWebApp.Controllers
{
    public class ManagerController : Controller
    {
        private const string SessionKeyName = "_Name";
        private const string Error = "_Error";


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string user, string password)
        {
            if (user == "Admin" && password == "Catolica10")
            {
                HttpContext.Session.SetString(SessionKeyName, "Admin");
            }
            else
            {
                HttpContext.Session.SetString(Error,"Usuario o contraseña incorrecta");
            }

            return Redirect("/Home/Index");

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove(SessionKeyName);
            HttpContext.Session.Remove(Error);
            return Redirect("/Home/Index");

        }
    }
}
