using Microsoft.AspNetCore.Mvc;
using ProyectoRestaurante.Models;
using ProyectoRestaurante.Repository;
using System.Diagnostics;

namespace ProyectoRestaurante.Controllers
{
    public class HomeController : Controller
    {
        private RepositoryMenu repo;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, RepositoryMenu repo)
        {
            _logger = logger;
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index1()
        {   
            List <ItemMenu> items = this.repo.GetItemMenu();

            return View(items);
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