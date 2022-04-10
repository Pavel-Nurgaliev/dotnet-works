using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UsersAndRewardsMain.Models;
using UsersAndRewardsSQL;

namespace UsersAndRewardsMain.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private DataBaseDAO _data;
        public HomeController(ILogger<HomeController> logger)
        {
            string connectionStringBuilder = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            _data = new DataBaseDAO(connectionStringBuilder);
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RefreshDataBase()
        {
            _data.refreshDataBase();

            return RedirectToAction("Index");
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
