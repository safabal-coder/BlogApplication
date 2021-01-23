using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;

namespace MyBlog.Controllers
{

    using App_Classes;

    public class HomeController : Controller
    {
        Model1 context = new Model1();


        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult _MakaleListele()
        {
            return PartialView(context.tbl_makale.ToList());

        }

        public PartialViewResult PopulerMakalelerWidget()
        {
            var model = context.tbl_makale.OrderByDescending(x => x.EklenmeTarihi).Take(3).ToList();
            return PartialView(model); 
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}