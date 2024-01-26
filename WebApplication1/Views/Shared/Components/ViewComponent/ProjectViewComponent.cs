using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using WebApplication1.Models;

namespace WebApplication1.ViewComponent
{
    public class ProjectViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1, "خانم نجفی", "project-1.jpg", "امانیرولاسکو1", "نداف1"),
                new Project(2, "خانم سلیمانی", "project-2.jpg", "2امانیرولاسکو", "2نداف"),
                new Project(3, "خانم صدوقی", "project-3.jpg", "امانیرولاسکو3", "3نداف"),
                new Project(4, "خانم رحمانی", "project-4.jpg", "4امانیرولاسکو", "نداف4")
            };
            return View("_Projects",projects);
        }
    }
}