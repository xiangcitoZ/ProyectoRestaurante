using Microsoft.AspNetCore.Mvc;
using ProyectoRestaurante.Data;
using ProyectoRestaurante.Models;
using ProyectoRestaurante.Repository;

namespace ProyectoRestaurante.Controllers
{
    public class MenuController : Controller
    {
        private RepositoryMenu repo;

        public MenuController(RepositoryMenu repo)
        {
            this.repo = repo;
        }

        public IActionResult ItemMenu()
        {
            List<ItemMenu> itemMenus = this.repo.GetItemMenu();
            return View(itemMenus);
        }
    }
}
