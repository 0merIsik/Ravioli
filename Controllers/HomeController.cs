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
            ViewBag.Title = "Ravioli Mantı Evi - Anasayfa";
            ViewBag.Description = "Ravioli Mantı Evi, dünya ve yöresel mantı çeşitlerini buluşturan samimi bir mekan.";
            ViewBag.Keywords = "mantı, ravioli, geleneksel yemek, restoran, Kayseri mantısı";
            ViewBag.OgTitle = ViewBag.Title;
            ViewBag.OgDescription = ViewBag.Description;
            return View();
        }
        [HttpGet]
        public IActionResult Hakkimizda()
        {
            ViewBag.Title = "Hakkımızda - Ravioli Mantı Evi";
            ViewBag.Description = "Ravioli Mantı Evi’nin kuruluş hikayesi, değerleri ve müşteri memnuniyetine verdiği önem.";
            ViewBag.Keywords = "ravioli mantı evi, hakkımızda, restoran hikayesi, değerlerimiz";
            ViewBag.OgTitle = ViewBag.Title;
            ViewBag.OgDescription = ViewBag.Description;
            return View();
        }
        [HttpGet]
        public IActionResult Mantilar()
        {
            ViewBag.Title = "Menü - Ravioli Mantı Evi";
            ViewBag.Description = "Dünya ve yöresel mantı çeşitleri, özel tarifler ve lezzetli seçeneklerimizi menümüzde keşfedin.";
            ViewBag.Keywords = "mantı çeşitleri, menü, yemekler, ravioli, Kayseri mantısı, özel tarifler";
            ViewBag.OgTitle = ViewBag.Title;
            ViewBag.OgDescription = ViewBag.Description;
            return View();
        }
        [HttpGet]
        public IActionResult Aparatifler()
        {
            ViewBag.Title = "Aparatifler - Ravioli Mantı Evi";
            ViewBag.Description = "Ravioli Mantı Evi’nin özenle hazırladığı aparatif seçeneklerini keşfedin. Her damak zevkine uygun lezzetler.";
            ViewBag.Keywords = "aparatifler, başlangıç, atıştırmalık, ravioli, restoran menüsü";
            ViewBag.OgTitle = ViewBag.Title;
            ViewBag.OgDescription = ViewBag.Description;
            return View();
        }
        [HttpGet]
        public IActionResult Corbalar()
        {
            ViewBag.Title = "Çorbalar - Ravioli Mantı Evi";
            ViewBag.Description = "Geleneksel ve özgün tariflerle hazırlanan çorba çeşitlerimizi menümüzde keşfedin.";
            ViewBag.Keywords = "çorbalar, geleneksel çorba, sıcak başlangıç, restoran menüsü, ravioli";
            ViewBag.OgTitle = ViewBag.Title;
            ViewBag.OgDescription = ViewBag.Description;
            return View();
        }
        [HttpGet]
        public IActionResult Saatler()
        {
            ViewBag.Title = "Çalışma Saatleri - Ravioli Mantı Evi";
            ViewBag.Description = "Ravioli Mantı Evi’nin açılış ve kapanış saatleri. Bizi ziyaret etmek için en uygun zamanı öğrenin.";
            ViewBag.Keywords = "çalışma saatleri, açılış saatleri, kapanış saatleri, restoran saatleri";
            ViewBag.OgTitle = ViewBag.Title;
            ViewBag.OgDescription = ViewBag.Description;
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
