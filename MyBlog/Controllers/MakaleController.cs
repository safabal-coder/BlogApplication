using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Controllers
{

    public class MakaleController : Controller
    {

        Model1 context = new Model1();

        // GET: Makale
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detay(int id)
        {
            var data = context.tbl_makale.FirstOrDefault(x => x.MakaleId==id);
            return View(data); 
        }
    }
}