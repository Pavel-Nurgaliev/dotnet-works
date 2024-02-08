using EnglishWords.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EnglishWords.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        bool? _isEnglishWord = null;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetEnglishWords()
        {
            return View("Index", new PrinterWordsModel(true));
        }
        public IActionResult GetRussianWords()
        {
            return View("Index", new PrinterWordsModel(false));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}