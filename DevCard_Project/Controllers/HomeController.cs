﻿using System;
using DevCard_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevCard_Project.Controllers
{
    public class HomeController : Controller
    {
        

        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact();
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(Contact form)
        {
            var name = form.Name;
             return Json(Ok());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
