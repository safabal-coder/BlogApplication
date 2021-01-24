using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Controllers
{
    

    public class KategoriController : Controller
    {
        // GET: Kategori

        Model1 context = new Model1();


        public ActionResult Index(int id)
        {
            

            return View(id);
        }


        public PartialViewResult KategoriWidget()
        {
            return PartialView(context.tbl_kategori.ToList());

        }

        public ActionResult MakaleListele(int id)
        {

            var data = context.tbl_makale.Where(x => x.KategoriId == id).ToList();

            return View("MakaleListeleWidget", data); 


        }

    }
}