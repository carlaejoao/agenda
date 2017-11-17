using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using agenda.DAL;
using agenda.Models;

namespace agenda.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            var repo = new Repositorio<Categoria>();
            return View(repo.Todas());
        }

        // GET: Categorias/Details/5
        public ActionResult Details(int id)
        {
            var repo = new Repositorio<Categoria>();
            return View(repo.Get(id));
        }

        // GET: Categorias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categorias/Create
        [HttpPost]
        public ActionResult Create(Categoria categoria)
        {
            try
            {
                var repo = new Repositorio<Categoria>();
                repo.Save(categoria);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categorias/Edit/5
        public ActionResult Edit(int id)
        {
            var repo = new Repositorio<Categoria>();
            return View(repo.Get(id));
        }

        // POST: Categorias/Edit/5
        [HttpPost]
        public ActionResult Edit(Categoria categoria)
        {
            try
            {
                var repo = new Repositorio<Categoria>();
                repo.Save(categoria);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categorias/Delete/5
        public ActionResult Delete(int id)
        {
            var repo = new Repositorio<Categoria>();
            return View(repo.Get(id));
        }

        // POST: Categorias/Delete/5
        [HttpPost]
        public ActionResult Delete(Categoria categoria)
        {
            try
            {
                var repo = new Repositorio<Categoria>();
                repo.Remove(categoria);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}