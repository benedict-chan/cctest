using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BenedictWebApi.Controllers
{
    /// <summary>
    /// Just use as a simple MVC 4 page
    /// </summary>
    public class AdvertisementController : Controller
    {
        //
        // GET: /Advertisement/

        public ActionResult New()
        {
            return View();
        }

    }
}
