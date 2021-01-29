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
        public ActionResult Index(int id)
        {
            return View(id);
        }

        public PartialViewResult EtiketWidget()
        {
            return PartialView(context.tbl_etiket.ToList());
        }

        public ActionResult MakaleListele(int id)
        {
            var data = context.tbl_makale.Where(x => x.tbl_etiket.Any(y=>y.EtiketId==id)).ToList();
            return View("MakaleListeleWidget",data); 
        }
    }
}