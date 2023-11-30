using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductInventoryMvc.Models.Entity;

namespace ProductInventoryMvc.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        Dbo_ProductInventoryEntities db = new Dbo_ProductInventoryEntities();
        public ActionResult Index()
        {
            var prd = db.Tbl_Products.ToList();
            return View(prd);
        }

        [HttpGet]
        public ActionResult Add()
        {
            List<SelectListItem> values = (from i in db.Tbl_Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.CategoryName,
                                               Value = i.CategoryID.ToString()
                                           }).ToList();
            ViewBag.vl = values;
            return View();
        }

        [HttpPost]
        public ActionResult Add(Tbl_Products p)
        {
            var ctg = db.Tbl_Categories.Where(m => m.CategoryID == p.Tbl_Categories.CategoryID).FirstOrDefault();
            p.Tbl_Categories = ctg;
            db.Tbl_Products.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}