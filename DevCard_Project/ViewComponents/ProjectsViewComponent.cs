using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_Project.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1, "تاکسی", "درخواست آنلاین تاکسی درون شهری ","project-1.jpg", "javad"),
                new Project(2, "زود فود", "درخواست آنلاین غذا برای کل کشور ","project-2.jpg","zodfod"),
                new Project(3, "مدارس", "مدیریت یکپارچه مدارس  ","project-3.jpg", "monop"),
                new Project(4, "فضا پیما", "مدیریت یکپارچه فضا پیماهای ناسا ","project-4.jpg", "nasa")
            };
            return View("_Projects",projects);
        }
    }
}