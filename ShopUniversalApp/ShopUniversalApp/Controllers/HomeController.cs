using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ShopUniversalApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
