using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApp1.Controllers
{
    public class AboutController : Controller
    {

        AboutManager aboutManager = new AboutManager(new EFAboutRepository());
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult SocialMediaAbout()
        {
            return PartialView();
        }
    }
}
