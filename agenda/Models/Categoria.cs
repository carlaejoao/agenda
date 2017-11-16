using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace agenda.Models
{
    [Table("categorias")]
    public class Categoria : EntityModel
    {
        [Column(name: "codigo_categoria")]
        public int Codigo { get; set; }

        [Column(name: "nome_categoria")]
        public String Nome { get; set; }

        public int GetCode()
        {
            return Codigo;
        }

    }
}