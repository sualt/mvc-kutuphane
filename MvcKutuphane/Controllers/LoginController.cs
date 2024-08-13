using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MvcKutuphane.Models.Entity;

namespace MvcKutuphane.Controllers
{
    public class LoginController : Controller
    {
        DBKUTUPHANEEntities1 db=new DBKUTUPHANEEntities1();
        // GET: Login
        public ActionResult GirişYap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GirisYap(TBLUYELER p)
        {
            var bilgiler = db.TBLUYELER.FirstOrDefault(x => x.MAİL == p.MAİL && x.SIFRE == p.SIFRE);
            if(bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.MAİL, false);
                return RedirectToAction("Index");   
            }
            else
            {

            }
            return View();  
        }
    }
}