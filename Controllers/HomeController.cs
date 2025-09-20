using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ravioli.Models;

namespace Ravioli.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult AnaSayfa()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Hakkimizda()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Mantilar()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Aparatifler()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Corbalar()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Saatler()
        {
            //buraya saat ekleme kodu gelecek
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
