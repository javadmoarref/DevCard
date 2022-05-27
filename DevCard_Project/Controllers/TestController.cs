using Microsoft.AspNetCore.Mvc;

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
