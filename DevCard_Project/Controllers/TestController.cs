using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace DevCard_Project.Controllers
{
    public class TestController : Controller
    {
        //public IActionResult Index()
        //{
        //    return Content("<h1> Hello Javad Badbakht </h1>","text/html");
        //}

        //public IActionResult Index()
        //{
        //    return new EmptyResult();
        //    return null;
        //}

        //public IActionResult Index()
        //{
        //    //return File("~/test.txt", "text/html");
        //    var fileByte = System.IO.File.ReadAllBytes("wwwroot/test.txt");
        //    return File(fileByte, MediaTypeNames.Text.Plain, "testfile.txt");
        //}

        //public IActionResult Index()
        //{
        //    return Json(new {id = 12,
        //        name = "javad",
        //        job = "Programmer" });
        //}

        //public IActionResult Index()
        //{
        //    return new JavaScriptResult("alert('Hello Hello javad')");
        //}

        //public IActionResult Index()
        //{
        //    return RedirectToAction("Contact","Home");
        //}

        public IActionResult Index()
        {
            return new StatusCodeResult(401);
        }
    }

    //public class JavaScriptResult:ContentResult
    //{
    //    public JavaScriptResult(string data)
    //    {
    //        Content = data;
    //        ContentType = "application/javascript";
    //    }
    //}
}
