using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class Test : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
