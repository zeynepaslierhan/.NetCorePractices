﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApp1.Controllers
{
    //[Authorize]
    [AllowAnonymous]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
