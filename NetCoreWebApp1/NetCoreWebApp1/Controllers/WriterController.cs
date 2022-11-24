using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
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
        WriterManager wm = new WriterManager(new EFWriterRepository());

        Context c = new Context();
        public IActionResult Index()
        {
            var _userMail = User.Identity.Name;
            var values = wm.GetListAll(x => x.WriterMail == _userMail);
            return View(values);
        }

        //Writer Layout Parçaları
        public PartialViewResult WriterSidebar()
        {
            var _userMail = User.Identity.Name;
            var values = wm.GetListAll(x => x.WriterMail == _userMail);
            return PartialView(values);
        }
        public PartialViewResult Writernavbar()
        {
            var _userMail = User.Identity.Name;
            var values = wm.GetListAll(x => x.WriterMail == _userMail);
            return PartialView(values);
        }

        //Yazara Ait Blogların listelendiği sayfa
        public IActionResult BlogListByWriter()
        {
            var _userMail = User.Identity.Name;
            var _userId = c.writers.Where(x => x.WriterMail == _userMail).Select(y => y.WriterId).FirstOrDefault();
            var values = bm.GetListWithCategoryByWriter(_userId);
            return View(values);
        }


        // Blog Ekleme Sayfası
        public List<SelectListItem> CategoryListForView()
        {
            List<SelectListItem> categories = (from x in cm.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()
                                               }).ToList();
            return categories;

        }

        // BlogAdd sayfasında Kategorilerin listelenmesi için gerekli listeyi veren fonksiyon

        [HttpGet]
        public IActionResult BlogAdd()
        {
            ViewBag.cv = CategoryListForView();
            return View();
        }

        [HttpPost]
        public IActionResult BlogAdd(Blog b)
        {
            BlogValidator bv = new BlogValidator();
            ValidationResult result = bv.Validate(b);

            var _userMail = User.Identity.Name;
            var _userId = c.writers.Where(x => x.WriterMail == _userMail).Select(y => y.WriterId).FirstOrDefault();
            if (result.IsValid)
            {

                b.BlogStatus = false;
                b.WriterId = _userId; 
                bm.TAdd(b);
                return RedirectToAction("BlogListByWriter", "Writer");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

                ViewBag.cv = CategoryListForView();
                return View();
            }
        }
    
        // İlgili Blogu silme
        public IActionResult DeleteBlog(int id)
        {
            var blog = bm.TGetById(id);
            bm.TDelete(blog);
            return RedirectToAction("BlogListByWriter", "Writer");
        }
    
        // İlgili blogu güncelleme
        [HttpGet]
        public IActionResult BlogEdit(int id)
        {
            var values = bm.TGetById(id);
            ViewBag.cv = CategoryListForView();
            return View(values);
        }

        [HttpPost]
        public IActionResult BlogEdit(Blog b)
        {
            BlogValidator bv = new BlogValidator();
            ValidationResult result = bv.Validate(b);

            var _userMail = User.Identity.Name;
            var _userId = c.writers.Where(x => x.WriterMail == _userMail).Select(y => y.WriterId).FirstOrDefault();
            if (result.IsValid)
            {

                b.BlogStatus = false;
                b.WriterId = _userId; 
                bm.TUpdate(b);
                return RedirectToAction("BlogListByWriter", "Writer");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

                ViewBag.cv = CategoryListForView();
                return View();
            }
        }
    
        // İlgili blogun aktifliğini değiştirme

        public IActionResult ChangeStatusBlog(int id)
        {
            var blog = bm.TGetById(id);
            if (blog.BlogStatus)
            {
                blog.BlogStatus = false;
            }
            else
            {
                blog.BlogStatus = true;
            }

            bm.TUpdate(blog);
            return RedirectToAction("BlogListByWriter");
        }
    }
}
