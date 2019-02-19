using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Rental_WebCore.Controllers
{
    public class PropertyController : Controller
    {
        public IActionResult Index(string id)
        {
            return View((object)id);
        }

        public IActionResult AddNew(int id)
        {
            return View((object)id);
        }

        public IActionResult Create()
        {
            return RedirectToAction("ListProperty");
        }

        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Save()
        {
            return RedirectToAction("ListProperty");
        }

        public IActionResult Delete()
        {
            return RedirectToAction("ListProperty");
        }

        public IActionResult ListProperty()
        {
            return View();
        }
    }
}