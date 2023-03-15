using ProyectoRestaurante.Data;
using ProyectoRestaurante.Models;

namespace ProyectoRestaurante.Repository
{
    public class RepositoryPedido
    {
        private RestauranteContext context;

        public RepositoryPedido(RestauranteContext context)
        {
            this.context = context;

        }

        public List<Pedido> GetPedidos()
        {
            var consulta = from datos in this.context.Pedido
                           select datos;
            return consulta.ToList();
        }

        public Pedido FindPedido(int idpedido)
        {
            var consulta = from datos in this.context.Pedido
                           where datos.IdPedido == idpedido
                           select datos;
            return consulta.FirstOrDefault();
        }

        //public List<ItemMenu> GetItemMenuPedidos(int idmenu)
        //{
        //    var consulta = from datos in this.context.ItemMenu
        //                   where datos.IdMenu == idmenu
        //                   select datos;
        //    return consulta.ToList();
        //}


        public async Task InsertPedidoAsync
         (int idpedido, decimal total, DateTime fecha, string itemsMenu,
            int idmesa,int idmenu)
        {
            
            Pedido pedido = new Pedido();
            
            pedido.IdPedido = idpedido;
            pedido.Total = total;
            pedido.Fecha  = fecha;
            pedido.ItemsMenu = itemsMenu;
            pedido.IdMesa = idmesa;
            pedido.IdMenu = idmenu;

            this.context.Pedido.Add(pedido);
            
            await this.context.SaveChangesAsync();
        }


        public async Task UpdatePedidoAsync
              (int idpedido, decimal total, DateTime fecha, string itemsMenu,
                 int idmesa, int idmenu)
        {

            Pedido pedido = this.FindPedido(idpedido);

            pedido.Total = total;
            pedido.Fecha = fecha;
            pedido.ItemsMenu = itemsMenu;
            pedido.IdMesa = idmesa;
            pedido.IdMenu = idmenu;

            await this.context.SaveChangesAsync();
        }


        public async Task DeletePedidoAsync(int idpedido)
        {
            Pedido pedido = this.FindPedido(idpedido);

            this.context.Pedido.Remove(pedido);

            await this.context.SaveChangesAsync();
        }


        //MODEL

        

    }
}
