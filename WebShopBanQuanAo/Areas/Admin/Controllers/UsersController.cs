using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebShopBanQuanAo.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult AccountVerified()
        {
            return View();
        }
        public ActionResult Customers()
        {
            return View();
        }
        public ActionResult LookScreen()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult ResetPassword()
        {
            return View();
        }
    }
}