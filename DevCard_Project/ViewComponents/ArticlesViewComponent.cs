using System.Collections.Generic;
using DevCard_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_Project.ViewComponents
{
    public class ArticlesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1, "آموزش Asp.net core mvc", "کاملترین آموزش Asp.net core mvc به زبان فارسی",
                    "blog-post-thumb-card-1.jpg"),
                new Article(2, "آموزش Git & Github", "کاملترین آموزش Git & Github به زبان فارسی",
                    "blog-post-thumb-card-2.jpg"),
                new Article(3, "آموزش Onion", "کاملترین آموزش Onion به زبان فارسی", "blog-post-thumb-card-3.jpg"),
                new Article(4, " آموزش طراحی سایت", "کاملترین آموزش طراحی سایت به زبان فارسی",
                    "blog-post-thumb-card-4.jpg"),
            };
            return View("_Articles",articles);
        }
    }
}
