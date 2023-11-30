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
    }
}