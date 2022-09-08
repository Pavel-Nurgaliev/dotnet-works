using Microsoft.AspNetCore.Mvc;

namespace ShopUniversalApp.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
