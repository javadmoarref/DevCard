 using System.Collections.Generic;
using System.Linq;
using DevCard_Project.Models;

namespace DevCard_Project.Data
{
    public class ProjectStore
    {
        public static List<Project> GetProjects() 
        {
            return new List<Project>
            {
                new Project(1, "تاکسی", "درخواست آنلاین تاکسی درون شهری ","project-1.jpg", "javad"),
                new Project(2, "زود فود", "درخواست آنلاین غذا برای کل کشور ","project-2.jpg","zodfod"),
                new Project(3, "مدارس", "مدیریت یکپارچه مدارس  ","project-3.jpg", "monop"),
                new Project(4, "فضا پیما", "مدیریت یکپارچه فضا پیماهای ناسا ","project-4.jpg", "nasa")
            };
        }

        public static Project GetProjectBy(long id)
        {
            return GetProjects().FirstOrDefault(x => x.Id == id);
        }
    }
}
