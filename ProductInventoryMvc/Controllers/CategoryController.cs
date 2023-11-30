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
            db.Tbl_Categories.Add(p);
            db.SaveChanges();
            return View();
        }
    }
}