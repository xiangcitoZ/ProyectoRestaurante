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

        public IActionResult Index(int idmesa, string descripcion)
        {DatosMenuPedidos datos = new DatosMenuPedidos();
            datos.Items = this.repo.GetItemMenu();
            datos.Pedidos = this.repo.GetPedidosMesa(idmesa);
            datos.Items = this.repo.GetItemMenuCategoria(descripcion);
            ViewData["IDMESA"] = idmesa;
            ViewData["PEDIDO"] = datos.Pedidos;





            return View(datos);
        }


        //public IActionResult Create(int IdMenu, string ItemsMenu, decimal Total, int idmesa)
        //{
        //    ViewData["IDMENU"] = IdMenu;
        //    ViewData["ITEMSMENU"] = ItemsMenu;
        //    ViewData["TOTAL"] = Total;
        //    ViewData["IDMESA"] = idmesa;
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> Create(Pedido pedido)
        //{
        //    await this.repo.InsertPedidoAsync
        //        (pedido.IdPedido, pedido.Total, DateTime.Now,
        //        pedido.ItemsMenu, pedido.IdMesa, pedido.IdMenu);

        //    return RedirectToAction("Index", "Home");
        //}


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