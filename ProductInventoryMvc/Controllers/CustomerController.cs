using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductInventoryMvc.Models.Entity;

namespace ProductInventoryMvc.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        Dbo_ProductInventoryEntities db = new Dbo_ProductInventoryEntities();
        public ActionResult Index()
        {
            var cstm = db.Tbl_Customers.ToList();
            return View(cstm);
        }
    }
}