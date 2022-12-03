using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApp1.ViewComponents.Profile
{
    public class WriterSidebarProfile : ViewComponent
    {
        WriterManager wm = new WriterManager(new EFWriterRepository());
        public IViewComponentResult Invoke()
        {
            var _userMail = User.Identity.Name;
            var values = wm.GetListAll(x => x.WriterMail == _userMail);
            return View(values);
        }
    }
}
