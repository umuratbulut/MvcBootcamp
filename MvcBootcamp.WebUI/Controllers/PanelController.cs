﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootcamp.WebUI.Controllers
{
    public class PanelController : Controller
    {
        // GET: Panel
        [Route("panel")]
        public ActionResult Index()
        {
            return View();
        }
    }
}