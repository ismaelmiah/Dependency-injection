using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Example_2_WebApplication_.Models;
using Library2.Infrastructure;

namespace Example_2_WebApplication_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITestingModel _testing;

        public HomeController(ILogger<HomeController> logger, ITestingModel testing)
        {
            _logger = logger;
            _testing = testing;
        }

        public IActionResult Index()
        {
            var model = _testing.ShowData()+"\t" + _logger.GetHashCode();
            return View((object)model);
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
