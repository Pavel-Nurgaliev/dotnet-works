using Microsoft.AspNetCore.Mvc;

namespace ShopUniversalApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
