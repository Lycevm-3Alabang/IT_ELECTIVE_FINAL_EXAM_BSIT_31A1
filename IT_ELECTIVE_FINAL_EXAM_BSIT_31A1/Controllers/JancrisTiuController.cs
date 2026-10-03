using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Tiu, Jancris")]   // shown on the Home list; use "Last, First" so sorting is by surname
    public class JancrisTiuController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Jancris Tiu",
                Tagline = "Aspiring Game Developer",
                Course = "BS Information Technology",
                Section = "E1",
                Bio = "Design around your constraints.",
                PhotoPath = "~/images/chuu.jpg",
                Email = "jancristiu6@email.com",
                GitHubUrl = "https://github.com/TiuJancris",
                LinkedInUrl = "https://linkedin.com/in/your-profile",   // or null
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "SQL", "HTML/CSS", "Git" },

                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Buzz Fizz",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/TiuJancris/BSIT31E1_PRELIM_A1TiuJancris.git",
                        Description = "Buzz Fizz.",
                        TechStack = new List<string> { "C#", "Console" }
                    },
                    new ProjectItem
                    {
                        Title = "Pokemon Static Database",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/TiuJancris/BFT_IT_ELECTIVE_2_MIDTERM_Q1.git",
                        Description = "static database.",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },
                     new ProjectItem
                    {
                        Title = "Prelim Exam",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/TiuJancris/IT_ELECTIVE_2_PRELIM_EXAM_TIU_JANCRIS.git",
                        Description = "preliminary exam.",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },
                    new ProjectItem
                    {
                        Title = "BSIT 31E1 Finals",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/Lycevm-3Alabang/IT_ELECTIVE_SSO_BSIT_31A1.git",
                        LiveUrl = null,
                        Description = "mvc website.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "SQL Server" }
                    }
                }
            };

            return View(profile);
        }
    }
}