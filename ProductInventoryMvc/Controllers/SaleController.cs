using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductInventoryMvc.Models.Entity;

namespace ProductInventoryMvc.Controllers
{
    public class SaleController : Controller
    {
        // GET: Sale
        Dbo_ProductInventoryEntities db = new Dbo_ProductInventoryEntities();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult NewSale()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewSale(Tbl_Sales p)
        {
            db.Tbl_Sales.Add(p);
            db.SaveChanges();
            return View("Index");
        }
    }
}