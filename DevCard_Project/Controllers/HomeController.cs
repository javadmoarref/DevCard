using System.Collections.Generic;
using DevCard_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DevCard_Project.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly  List<Service> _services = new List<Service>
        {
            new Service(1, "نقره ای"),
            new Service(2, "طلایی"),
            new Service(3, "پلاتین"),
            new Service(4, "الماس")
        };

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult ProjectDetail(long id) 
        {
            var project = ProjectStore.GetProjectBy(id);
            return View(project);
        }
        [HttpGet]
        public IActionResult Contact()
        {

            var model = new Contact
            {
                Services = new SelectList(_services,"Id","Name")
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            model.Services = new SelectList(_services, "Id", "Name");
            if (!ModelState.IsValid)
            {
                ViewBag.Error = "مشکلی پیش آمده لطفا دوباره تلاش کنید.";
                return View(model);
            }
            ModelState.Clear();
            model = new Contact
            {
                Services = new SelectList(_services,"Id","Name")
            };
            ViewBag.Success = "پیام شما با موفقیت ارسال شد.";
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
