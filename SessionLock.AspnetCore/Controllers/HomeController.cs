using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SessionLock.AspnetCore.Models;
using System.Diagnostics;
using System.Threading;

namespace SessionLock.AspnetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string userName)
        {
            if (!string.IsNullOrWhiteSpace(userName))
            {
                HttpContext.Session.SetString("UserName", userName);
                string uName = HttpContext.Session.GetString("UserName");

                for (var i = 0; i < 10; i++)
                {
                    _logger.LogInformation($"{HttpContext.Session.Id} {uName}");
                    Thread.Sleep(1000);
                }
            }
            return View();
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
