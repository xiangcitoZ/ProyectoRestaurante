using Microsoft.AspNetCore.Mvc;
using ProyectoRestaurante.Models;
using ProyectoRestaurante.Repository;
using System.Diagnostics;

namespace ProyectoRestaurante.Controllers
{
    public class HomeController : Controller
    {
        private RepositoryMenu repo;
        private RepositoryPedido repopedido;
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, RepositoryMenu repo, RepositoryPedido repopedido)
        {
            _logger = logger;
            this.repo = repo;
            this.repopedido = repopedido;
        }

        public IActionResult Index(int idmesa)
        {DatosMenuPedidos datos = new DatosMenuPedidos();
            datos.Items = this.repo.GetItemMenu();
            datos.Pedidos = this.repopedido.GetPedidos();
            ViewData["IDMESA"] = idmesa;
            ViewData["PEDIDO"] = datos.Pedidos;
            return View(datos);
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