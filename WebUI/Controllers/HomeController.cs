﻿using BLL.SingletonPattern;
using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        

        // GET: Home
        public ActionResult Index()
        {
            
            return View();
        }
    }
}