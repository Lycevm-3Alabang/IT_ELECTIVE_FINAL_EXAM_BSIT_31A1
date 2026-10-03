using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Solo, Joshua S")]   // shown on the Home list; use "Last, First" so sorting is by surname
    public class SoloJoshuaController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Solo, Joshua S",
                Tagline = "Aspiring Full-Stack Developer",
                Course = "BS Information Technology",
                Section = "31E1",
                Bio = "im being handsome thats it: ",
                PhotoPath = "~/images/Solo.jpg",
                Email = "joshuasolo555@gmail.com",
                GitHubUrl = "https://github.com/your-username",
                LinkedInUrl = "https://linkedin.com/in/your-profile",   // or null
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "SQL", "HTML/CSS", "Git" },

                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Prefinal exam",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/Diirie3/IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_Solo_Joshua.git",
                        Description = "Prefinal exam",
                        TechStack = new List<string> { "C#", }
                    },
                    new ProjectItem
                    {
                        Title = "Project for Final",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/Lycevm-3Alabang/IT_ELECTIVE_SSO_BSIT_31A1.git",
                        Description = "Final exam group",
                        TechStack = new List<string> { "C#",  }
                    },
                    new ProjectItem
                    {
                        Title = "Midterm exam",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/Diirie3/IT_ELECTIVE_2_MIDTERM_EXAM_-5-_-Solo---where-set_number.git",
                        LiveUrl = null,   // add a deployed link if you have one
                        Description = "Midterm exam.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "SQL Server" }
                    }
                }
            };

            return View(profile);
        }
    }
}