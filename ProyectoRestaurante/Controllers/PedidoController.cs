using Microsoft.AspNetCore.Mvc;
using ProyectoRestaurante.Models;
using ProyectoRestaurante.Repository;

namespace ProyectoRestaurante.Controllers
{
    public class PedidoController : Controller
    {
        private RepositoryPedido repo;

        public PedidoController(RepositoryPedido repo)
        {
            this.repo = repo;
        }

        public IActionResult Pedido()
        {
            List<Pedido> Pedidos = this.repo.GetPedidos();
            return View(Pedidos);
        }

        //public IActionResult ItemPedidos(int idmenu)
        //{
        //    List<ItemMenu> ItemPedidos = this.repo.GetItemMenuPedidos(idmenu);
        //    return View(ItemPedidos);
        //}

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Pedido pedido)
        {
            await this.repo.InsertPedidoAsync
                (pedido.IdPedido, pedido.Total, pedido.Fecha,
                pedido.ItemsMenu, pedido.IdMesa, pedido.IdMenu);
            return RedirectToAction("Pedido");
        }

        public IActionResult Edit(int idpedido)
        {
            Pedido pedido = this.repo.FindPedido(idpedido);
            return View(pedido);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Pedido pedido)
        {
            await this.repo.UpdatePedidoAsync
                (pedido.IdPedido, pedido.Total, pedido.Fecha,
                pedido.ItemsMenu, pedido.IdMesa, pedido.IdMenu);
            return RedirectToAction("Pedido");
        }

        public async Task<IActionResult> Delete(int idpedido)
        {
            await this.repo.DeletePedidoAsync(idpedido);
            return RedirectToAction("Pedido");
        }


    }
}
