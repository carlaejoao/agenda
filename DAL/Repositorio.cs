using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using agenda.Models;
using System.Data.Entity;

namespace agenda.DAL
{
    public class Repositorio<T> where T : class, EntityModel
    {
        private AgendaContext context = new AgendaContext();

        public List<T> Todas()
        {
            return context.Set<T>().ToList();
        }

        public List<T> Get(Func<T, Boolean> predicate)
        {
            return context.Set<T>().Where(predicate).ToList();
        }

        public T Get(int key)
        {
            return context.Set<T>().Find(key);
        }

        public void Save(T element)
        {
            if (context.Set<T>().Find(element) == null)
                context.Set<T>().Add(element);
            else
                context.Entry(element).State = EntityState.Modified;

            context.SaveChanges();
        }

        public void Remove(T element)
        {
            context.Set<T>().Remove(element);
            context.SaveChanges();
        }
    }
}