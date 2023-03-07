﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoRestaurante.Models
{
    [Table("Mesa")]
    public class Mesa
    {

            [Key]
            [Column("IdMesa")]
            public int IdMesa { get; set; }
            [Column("Estado")]
            public string Estado { get; set; }
            [Column("Numero")]
            public int Numero { get; set; }
            [Column("Cantidad")]
            public int Cantidad { get; set; }
           

        
    }
}
