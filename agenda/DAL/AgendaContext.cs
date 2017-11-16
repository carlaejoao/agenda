using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using agenda.Models;


namespace agenda.DAL
{
    public class AgendaContext : DbContext
    {
        private const string NAME_CONNECTION_STRING = "agenda";

        public AgendaContext() : base(NAME_CONNECTION_STRING) { }

        public DbSet<Categoria> Categorias { get; }
    }
}                                                                                                                                                                                                                                                                                                                                                                                               