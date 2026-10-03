using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Lim, Gamaliel")]   // shown on the Home list; use "Last, First" so sorting is by surname
    public class LimGamalielController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Gamaliel Lim",
                Tagline = "Aspiring Music Artist",
                Course = "BS Information Technology",
                Section = "3A",
                Bio = "wala akong bio e hehe",
                PhotoPath = "~/images/juandelacruz.jpg",
                Email = "cocnigamaliel@gmail.com",
                GitHubUrl = "https://github.com/cocnigamaliel-star",
                LinkedInUrl = "https://linkedin.com/in/your-profile",   // or null
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "SQL", "HTML/CSS", "Git" },

                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Prelim Project Title",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/your-username/prelim-repo",
                        Description = "One or two sentences on what it does.",
                        TechStack = new List<string> { "C#", "Console" }
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Project Title",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/your-username/midterm-repo",
                        Description = "One or two sentences on what it does.",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },
                    new ProjectItem
                    {
                        Title = "Final Project Title",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/your-username/final-repo",
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