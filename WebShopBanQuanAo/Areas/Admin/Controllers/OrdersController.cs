﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebShopBanQuanAo.Areas.Admin.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Admin/Orders
        public ActionResult ListOrders()
        {
            return View();
        }
        public ActionResult DetailOrders()
        {
            return View();
        }

    }
}