using Microsoft.EntityFrameworkCore;
using ProyectoRestaurante.Models;
using System.Collections.Generic;


namespace ProyectoRestaurante.Data
{
    public class RestauranteContext : DbContext
    {
        public RestauranteContext(DbContextOptions<RestauranteContext> options) : base(options) { }


        public DbSet<ItemMenu> ItemMenu { get; set; }
    }
}
