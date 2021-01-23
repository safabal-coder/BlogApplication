using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Controllers
{
    public class EtiketController : Controller
    {

        Model1 context = new Model1();

        // GET: Etiket
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult EtiketWidget()
        {
            return PartialView(context.tbl_etiket.ToList());
        }
    }
}