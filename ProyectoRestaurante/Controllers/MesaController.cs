using Microsoft.AspNetCore.Mvc;
using ProyectoRestaurante.Models;
using ProyectoRestaurante.Repository;

namespace ProyectoRestaurante.Controllers
{
    public class MesaController : Controller
    {
        private RepositoryMenu repo;

        public MesaController(RepositoryMenu repo)
        {
            this.repo = repo;
        }

        public IActionResult Mesa()
        {
            List<Mesa> Mesas = this.repo.GetMesas();
            return View(Mesas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Mesa mesa)
        {
            await this.repo.InsertMesaAsync
                ( mesa.Estado
                , mesa.Cantidad);
            return RedirectToAction("Mesa");
        }

        public IActionResult Edit(int idmesa)
        {
            Mesa mesa = this.repo.FindMesa(idmesa);
            return View(mesa);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Mesa mesa)
        {
            await this.repo.UpdateMesaAsync
                (mesa.IdMesa, mesa.Estado
                , mesa.Cantidad);
            return RedirectToAction("Mesa");
        }

        public async Task<IActionResult> Delete(int idmesa)
        {
            await this.repo.DeleteMesaAsync(idmesa);
            return RedirectToAction("Mesa");
        }





    }
}
