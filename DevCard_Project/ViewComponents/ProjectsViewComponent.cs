using DevCard_Project.Data;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_Project.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string name)
        {
            var projects = ProjectStore.GetProjects();
            return View("_Projects",projects);
        }
    }
}