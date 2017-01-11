using Corecsharp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Corecsharp2.Controllers
{
    public class HomeController : Controller
    {

        private CCDbContext db = new CCDbContext();
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Contact model )
        {

            db.Contacts.Add(model);
            db.SaveChanges();

           return View();
        }
    }
}