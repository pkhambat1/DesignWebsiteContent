using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DesignWebsiteContent.Models;

namespace DesignWebsiteContent.Controllers {
    public class HomeController : Controller {

        public IActionResult Index() {
            return View();
        }

        public JsonResult GenerateJSON(InputOutput model) {
            var result = model.GenerateOutput();
            return Json(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
