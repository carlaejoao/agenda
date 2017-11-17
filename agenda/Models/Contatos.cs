using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace agenda.Models
{
    [Table("contatos")]
    public class Contatos : EntityModel
    {


        [Column(name: "id_codigo")]
        public int Codigo { get; set; }

        [Column(name: "nome_contato")]
        public String Nome { get; set; }

        [Column(name: "email_contato")]
        public String Email { get; set; }

        [Column(name: "codigo_categoria")]
        public int Codigo { get; set; }

        [Column(name: "codigo_cidade")]
        public int Codigo { get; set; }



        public int GetCode()
        {
            return Codigo;
        }

    }
}