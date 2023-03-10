using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoRestaurante.Models
{
    [Table("Pedido")]
    public class Pedido
    {

            [Key]
            [Column("IdPedido")]
            public int IdPedido { get; set; }
          
            [Column("Total")]
            public decimal Total { get; set; }
            [Column("Fecha")]
            public DateTime Fecha { get; set; }
            [Column("ItemsMenu")]
            public string ItemsMenu { get; set; }
            [Column("IdMesa")]
            public int IdMesa { get; set; }
            [Column("IdMenu")]
            public int IdMenu { get; set; }


    }
}
