﻿using System;
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
            //checking again if the Pull Request cause sthe CI/CI build to execute
            //need to create a new branch
            //Disables the draft PR validation in the azure pipeline yaml file in Github repo
            //Uncommented the triggeres portion in the yaml file
            // trying again, why is this not working
            //trying yet again
            //tryign again
            //ONe more change to test 
            //and another change
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
