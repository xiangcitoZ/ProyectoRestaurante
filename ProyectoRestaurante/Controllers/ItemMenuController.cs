using Microsoft.AspNetCore.Mvc;
using ProyectoRestaurante.Data;
using ProyectoRestaurante.Helpers;
using ProyectoRestaurante.Models;
using ProyectoRestaurante.Repository;

namespace ProyectoRestaurante.Controllers
{
    public class ItemMenuController : Controller
    {
        private RepositoryMenu repo;
        private HelperPathProvider helperPath;

        public ItemMenuController(RepositoryMenu repo, 
            HelperPathProvider helperPath)
        {
            this.repo = repo;
            this.helperPath = helperPath;
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
        public async Task<IActionResult> Create(ItemMenu menu,
            IFormFile fichero)
        {


            string fileName = fichero.FileName;

            string path = this.helperPath.MapPath(fileName, Folders.Images);
            using (Stream stream = new FileStream(path, FileMode.Create))
            {
                await fichero.CopyToAsync(stream);
            }
            ViewData["MENSAJE"] = "Fichero subido a " + path;

            await this.repo.InsertItemMenuAsync
                (menu.IdMenu, menu.Nombre, menu.Categoria,
                fileName, menu.Precio);
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
               (menu.IdMenu, menu.Nombre, menu.Categoria,
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
