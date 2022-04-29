using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebShopBanQuanAo.Areas.Admin.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Admin/Products
        public ActionResult Checkout()
        {
            return View();
        }
        public ActionResult DetailProduct()
        {
            return View();
        }
        public ActionResult ListProduct()
        {
            return View();
        }
        public ActionResult GridProduct()
        {
            return View();
        }
        
    }
}