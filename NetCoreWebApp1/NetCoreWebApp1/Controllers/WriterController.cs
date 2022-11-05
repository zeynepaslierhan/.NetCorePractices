using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
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
        BlogManager bm = new BlogManager(new EFBlogRepository());
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult WriterSidebar()
        {
            return PartialView();
        }
        public PartialViewResult Writernavbar()
        {
            return PartialView();
        }
        public IActionResult BlogListByWriter(int id)
        {
            var values = bm.GetListWithCategoryByWriter(7);
            return View(values);
        }
    }
}
