using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HSBOD.Models;

namespace HSBOD.Controllers
{
    public class HairstylistController : Controller
    {
        // GET: Hairstylist
        public ActionResult Random()
        {
            var hairstylist = new Hairstylist() {FirstName = "Tasha!"};
            return View(hairstylist);
        }
    }
}