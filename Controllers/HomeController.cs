using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pipelines_dotnet_core.Models;

namespace pipelines_dotnet_core.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Just some random comments to check the Git Hub stuff
            return View();
            //some more changes just to check if it is working. And if it is good.
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
