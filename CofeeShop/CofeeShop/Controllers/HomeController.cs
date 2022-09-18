using Microsoft.AspNetCore.Mvc;

namespace CofeeShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
