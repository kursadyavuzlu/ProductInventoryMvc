using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductInventoryMvc.Models.Entity;

namespace ProductInventoryMvc.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        Dbo_ProductInventoryEntities db = new Dbo_ProductInventoryEntities();
        public ActionResult Index()
        {
            var ctg = db.Tbl_Categories.ToList();
            return View(ctg);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Tbl_Categories p)
        {
            if (!ModelState.IsValid)
            {
                return View("Add");
            }
            db.Tbl_Categories.Add(p);
            db.SaveChanges();
            return View();
        }

        public ActionResult Delete(int id)
        {
            var ctg = db.Tbl_Categories.Find(id);
            db.Tbl_Categories.Remove(ctg);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetCategory(int id)
        {
            var ctg = db.Tbl_Categories.Find(id);
            return View("GetCategory", ctg);
        }

        public ActionResult Update(Tbl_Categories p)
        {
            var ctg = db.Tbl_Categories.Find(p.CategoryID);
            ctg.CategoryName = p.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}