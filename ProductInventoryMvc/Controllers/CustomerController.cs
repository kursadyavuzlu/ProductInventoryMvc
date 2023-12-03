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
        public ActionResult Index(string p)
        {
            var values = from d in db.Tbl_Customers select d;
            if (!string.IsNullOrEmpty(p))
            {
                values = values.Where(m => m.CustomerName.Contains(p));
            }
            return View(values.ToList());
            //var cstm = db.Tbl_Customers.ToList();
            //return View(cstm);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Tbl_Customers p)
        {
            if (!ModelState.IsValid)
            {
                return View("Add");
            }
            db.Tbl_Customers.Add(p);
            db.SaveChanges();
            return View();
        }

        public ActionResult Delete(int id)
        {
            var cstm = db.Tbl_Customers.Find(id);
            db.Tbl_Customers.Remove(cstm);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetCustomer(int id)
        {
            var cstm = db.Tbl_Customers.Find(id);
            return View("GetCustomer", cstm);
        }

        public ActionResult Update(Tbl_Customers p)
        {
            var cstm = db.Tbl_Customers.Find(p.CustomerID);
            cstm.CustomerName = p.CustomerName;
            cstm.CustomerSurname = p.CustomerSurname;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}