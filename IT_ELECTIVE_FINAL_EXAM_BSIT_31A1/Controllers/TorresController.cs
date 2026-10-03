using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("TORRES, KATLEEN JADE")]   // shown on the Home list; use "Last, First" so sorting is by surname
    public class Torres : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "KATLEEN JADE TORRES",
                Tagline = "Aspiring Web Developer",
                Course = "BS Information Technology",
                Section = "31E1",
                Bio = "I am interested in learning about programming, software development, databases, and different technologies.",
                PhotoPath = "~/images/Torres.png",
                Email = "katleenftorres@gmail.com",
                GitHubUrl = "https://github.com/BSIT31E1-PRELIMS-TORRES",
                LinkedInUrl = "jade-torres-08652a265",   // or null
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "VBNET", "Git" },

                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Prelim Project Title",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/BSIT31E1-PRELIMS-TORRES/BSIT31E1_Prelim_A3_Katleen_Torres.git",
                        Description = "PRELIM_A3.",
                        TechStack = new List<string> { "C#", "Console" }
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Project Title",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/BSIT31E1-PRELIMS-TORRES/BSIT31E1_PRELIM_A2_TORRES_KATLEEN_JADE.git",
                        Description = "A2.",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },
                    new ProjectItem
                    {
                        Title = "Final Project Title",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/BSIT31E1-PRELIMS-TORRES/IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_Torres_KatleenJade.git",
                        LiveUrl = null,   // add a deployed link if you have one
                        Description ="Final",
                        TechStack = new List<string> { "ASP.NET Core MVC", "SQL Server" }
                    }
                }
            };

            return View(profile);
        }
    }
}