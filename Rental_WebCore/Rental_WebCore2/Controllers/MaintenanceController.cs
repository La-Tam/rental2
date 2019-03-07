using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Rental_WebCore.Controllers
{
    public class MaintenanceController : Controller
    {
       
        public ActionResult Maintenance(string language)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            return View();
        }
       
     
       
        
      

    }
}