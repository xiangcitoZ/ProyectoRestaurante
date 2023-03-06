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


    }
}
