using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Rental_WebCore.Controllers
{
    public class PricingTableController : Controller
    {
        public IActionResult PricingTable()
        {
            return View();
        }
    }
}