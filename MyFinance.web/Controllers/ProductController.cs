using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFinance.Domain.Entites;
using MyFinanceService;
using System.Collections.Specialized;

namespace MyFinance.web.Controllers
{
    
    public class ProductController : Controller
    {
        GestionProduct gp = null;
        public ProductController()
        {
            gp = new GestionProduct();
        }
        // GET: Product
        public ActionResult Index()
        {
            
            return View(gp.GetMany());
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View(gp.FindById(id));
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product p)
        {

            // TODO: Add insert logic here
            gp.Create(p);
            gp.Commit();

                return RedirectToAction("Index");
          
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View(gp.FindById(id));
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id , FormCollection formvalues)
        {
            try
            {
                Product p = null;
                // TODO: Add update logic here
                p= gp.FindById(id);

                p.Description = formvalues["Description"];
                gp.Update(p);
                gp.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View(gp.FindById(id));
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int ?id)
        {
            try
            {
                // TODO: Add delete logic here
                gp.Remove(e => e.ProductId == id);
                gp.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
