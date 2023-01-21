using Microsoft.AspNetCore.Mvc;

namespace Familytree.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
