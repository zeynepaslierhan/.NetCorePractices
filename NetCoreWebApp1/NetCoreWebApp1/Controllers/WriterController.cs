using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        CategoryManager cm = new CategoryManager(new EFCategoryRepository());
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

        [HttpGet]
        public IActionResult BlogAdd()
        {

            List<SelectListItem> categories = (from x in cm.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()
                                               }).ToList();
            ViewBag.cv = categories;
            return View();
        }

        [HttpPost]
        public IActionResult BlogAdd(Blog b)
        {
            b.BlogStatus = true;
            b.WriterId = 7; //şimdilik
            bm.TAdd(b);
            return RedirectToAction("BlogListByWriter", "Writer");
        }
    }
}
