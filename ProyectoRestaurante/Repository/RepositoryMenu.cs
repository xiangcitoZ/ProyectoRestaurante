using ProyectoRestaurante.Data;
using ProyectoRestaurante.Models;

namespace ProyectoRestaurante.Repository
{
    public class RepositoryMenu
    {
        private RestauranteContext context;

        public RepositoryMenu(RestauranteContext context)
        {
            this.context = context;

        }

        public List<ItemMenu> GetItemMenu()
        {
            var consulta = from datos in this.context.ItemMenu
                           select datos;
            return consulta.ToList();
        }


        public ItemMenu FindItemMenu(int idmenu)
        {
            var consulta = from datos in this.context.ItemMenu
                           where datos.IdMenu == idmenu
                           select datos;
            return consulta.FirstOrDefault();
        }

       

        public async Task InsertItemMenuAsync
         (int idmenu, string nombre, string descripcion, string imagen,
            decimal precio)
        {

            ItemMenu menu = new ItemMenu();

            menu.IdMenu = idmenu;
            menu.Nombre = nombre;
            menu.Descripcion = descripcion;
            menu.Imagen = imagen;
            menu.Precio = precio;
           

            this.context.ItemMenu.Add(menu);

            await this.context.SaveChangesAsync();
        }


        public async Task UpdateItemMenuAsync
             (int idmenu, string nombre, string descripcion, string imagen,
                  decimal precio)
        {

            ItemMenu menu = this.FindItemMenu(idmenu);

            menu.Nombre = nombre;
            menu.Descripcion = descripcion;
            menu.Imagen = imagen;
            menu.Precio = precio;
            

            await this.context.SaveChangesAsync();
        }


        public async Task DeleteItemMenuAsync(int idmenu)
        {
            ItemMenu menu = this.FindItemMenu(idmenu);

            this.context.ItemMenu.Remove(menu);

            await this.context.SaveChangesAsync();
        }

    }
}
