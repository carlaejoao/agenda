using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace agenda.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Column("id_codigo")]
        public int Codigo { get; set; }

        [Required]
        [Column("nome_categoria")]
        public String Nome { get; set; }

    }
}