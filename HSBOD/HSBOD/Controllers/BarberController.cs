using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HSBOD.Models;

namespace HSBOD.Controllers
{
    public class BarberController : Controller
    {
        // GET: Barber
        public ActionResult Random()
        {
            var barber = new Barber() { FirstName = "Cornell!" };

            return View(barber);
        }
    }
}