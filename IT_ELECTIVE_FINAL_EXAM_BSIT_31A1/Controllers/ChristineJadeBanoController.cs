using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Bano, Christine Jade N ")]   // shown on the Home list; use "Last, First" so sorting is by surname
    public class ChristineJadeBanoController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Christine Jade Bano",
                Tagline = "YOOOLOOOO",
                Course = "BS Information Technology",
                Section = "31E1",
                Bio = "I am Jade u can call me Jade, and i am 20 yrs old and only girl in the family",
                PhotoPath = "~/images/cat-cat-dance.png",
                Email = "banochristinejade@gmail.com",
                GitHubUrl = "https://github.com/jade-cmd06",
                LinkedInUrl = "https://linkedin.com/in/your-profile",   // or null
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "SQL", "HTML/CSS", "Git" },

                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Prelim Exam",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/jade-cmd06/IT_ELECTIVE_2_PRELIM_EXAM_BANO_CHRISTINE-JADE.git",
                        Description = "A C# project that shows how to make programs using basic coding skills.",
                        TechStack = new List<string> { "C#", "Console" }
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Exam",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/jade-cmd06/IT_ELECTIVE_2_MIDTERM_EXAM_SET3_BANO.git",
                        Description = "A C# project that shows how to build a simple Windows application. It uses forms to display information and let users interact with the program.",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },
                    new ProjectItem
                    {
                        Title = "PREFINAlS, PROJECT",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/jade-cmd06/IT_ELECTIVE_PREFINALS_PROJECT.git",
                        LiveUrl = null,   // add a deployed link if you have one
                        Description = "One or two sentences on what it does.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "SQL Server" }
                    }
                }
            };

            return View(profile);
        }
    }
}