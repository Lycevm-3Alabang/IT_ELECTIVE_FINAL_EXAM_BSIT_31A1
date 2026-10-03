using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var classmates = typeof(HomeController).Assembly.GetTypes()
                .Where(t => typeof(Controller).IsAssignableFrom(t) && !t.IsAbstract)
                .Select(t => new { Type = t, Attr = t.GetCustomAttribute<ClassmateAttribute>() })
                .Where(x => x.Attr != null)
                .Select(x => new ClassmateListItem
                {
                    Name = x.Attr!.Name,
                    ControllerName = x.Type.Name.Replace("Controller", "")
                })
                .OrderBy(c => c.Name, StringComparer.OrdinalIgnoreCase)   // alphabetical
                .ToList();

            return View(classmates);
        }
    }
}