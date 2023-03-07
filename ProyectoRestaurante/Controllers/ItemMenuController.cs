using Microsoft.AspNetCore.Mvc;
using ProyectoRestaurante.Data;
using ProyectoRestaurante.Models;
using ProyectoRestaurante.Repository;

namespace ProyectoRestaurante.Controllers
{
    public class ItemMenuController : Controller
    {
        private RepositoryMenu repo;

        public ItemMenuController(RepositoryMenu repo)
        {
            this.repo = repo;
        }

        public IActionResult ItemMenu()
        {
            List<ItemMenu> itemMenus = this.repo.GetItemMenu();
            return View(itemMenus);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ItemMenu menu)
        {
            await this.repo.InsertItemMenuAsync
                (menu.IdMenu, menu.Nombre, menu.Descripcion,
                menu.Imagen, menu.Precio);
            return RedirectToAction("ItemMenu");
        }

        public IActionResult Edit(int idmenu)
        {
            ItemMenu menu = this.repo.FindItemMenu(idmenu);
            return View(menu);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ItemMenu menu)
        {
            await this.repo.UpdateItemMenuAsync
               (menu.IdMenu, menu.Nombre, menu.Descripcion,
                menu.Imagen, menu.Precio);
            return RedirectToAction("ItemMenu");
        }

        public async Task<IActionResult> Delete(int idmenu)
        {
            await this.repo.DeleteItemMenuAsync(idmenu);
            return RedirectToAction("ItemMenu");
        }


    }
}
