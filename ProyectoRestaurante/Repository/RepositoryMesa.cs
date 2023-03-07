using ProyectoRestaurante.Data;
using ProyectoRestaurante.Models;

namespace ProyectoRestaurante.Repository
{
    public class RepositoryMesa
    {

        private RestauranteContext context;

        public RepositoryMesa(RestauranteContext context)
        {
            this.context = context;

        }

        public List<Mesa> GetMesas()
        {
            var consulta = from datos in this.context.Mesa
                           select datos;
            return consulta.ToList();
        }

        public Mesa FindMesa(int idmesa)
        {
            var consulta = from datos in this.context.Mesa
                           where datos.IdMesa == idmesa
                           select datos;
            return consulta.FirstOrDefault();
        }

        public async Task InsertMesaAsync
         ( string estado, int numero,int cantidad)
        {
            //INSTANCIAR EL MODELO
            Mesa mesa = new Mesa();
            //ASIGNAMOS PROPIEDADES
            
            mesa.Estado = estado;
            mesa.Numero = numero;
            mesa.Cantidad = cantidad;
            //AÑADIMOS EL MODEL A LA COLECCION CONTEXT
            this.context.Mesa.Add(mesa);
            //GUARDAMOS CAMBIOS EN LA BASE DE DATOS
            await this.context.SaveChangesAsync();
        }

        
        public async Task UpdateMesaAsync
             (int idmesa, string estado, int numero, int cantidad)
        {
          
            Mesa mesa = this.FindMesa(idmesa);
         
            mesa.Estado = estado;
            mesa.Numero = numero;
            mesa.Cantidad = cantidad;
            
            await this.context.SaveChangesAsync();
        }

         
        public async Task DeleteMesaAsync(int idmesa)
        {

            Mesa mesa = this.FindMesa(idmesa);

            this.context.Mesa.Remove(mesa);
           
            await this.context.SaveChangesAsync();
        }

    }
}
