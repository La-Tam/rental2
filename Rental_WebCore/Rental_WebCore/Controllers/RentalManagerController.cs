using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Rental_WebCore.Controllers
{
    public class RentalManagerController : Controller
    {
        public IActionResult DashboardIndex()
        {
            return View();
        }
        public IActionResult ContractIndex()
        {
            return View();
        }
        public IActionResult ElectricityAndWaterIndex()
        {
            return View();
        }
        public IActionResult InvoiceIndex()
        {
            return View();
        }
        public IActionResult SettingServiceIndex()
        {
            return View();
        }
        public IActionResult CreatContract()
        {
            return View();
        }
        public IActionResult DetailContract()
        {
            return View();
        }
    }
}