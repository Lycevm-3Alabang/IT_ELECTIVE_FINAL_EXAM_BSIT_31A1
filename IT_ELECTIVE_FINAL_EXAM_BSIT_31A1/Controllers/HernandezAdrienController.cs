using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Hernandez, Adrien")]   // shown on the Home list; use "Last, First" so sorting is by surname
    public class HernandezAdrienController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Hernandez Adrien",
                Tagline = "YOLO",
                Course = "BS Information Technology",
                Section = "31E1",
                Bio = "I am Adrien V. Hernandez, and I am 20 years old. I like art, music and gaming.",
                PhotoPath = "~/images/ayen.jpg",
                Email = "Ayen@gmail.com",
                GitHubUrl = "https://github.com/adrienhernandez001-cell",
                LinkedInUrl = "https://linkedin.com/in/your-profile",   // or null
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "SQL", "HTML/CSS", "Git" },

                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "MIDTERM Exam",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/adrienhernandez001-cell/IT_ELECTIVE_2_MIDTERM_EXAM_2_Hernandez_Adrien.git",
                        Description = "A complete Clinic Patient Monitoring System.",
                        TechStack = new List<string> { "C#", "Console" }
                    },
                    new ProjectItem
                    {
                        Title = "PREFINAL Exam",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/adrienhernandez001-cell/IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_Hernandez_Adrien.git",
                        Description = "It shows the questions and the answers I have for that exam.",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },
                    new ProjectItem
                    {
                        Title = "PREFINAL and FINALS Project",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/adrienhernandez001-cell/IT_ELECTIVE_PREFINALS_PROJECT_Hernandez-Bano-Saw.git",
                        LiveUrl = null,   // add a deployed link if you have one
                        Description = "It is designed to manage customer support requests, assign them to support teams, and track ticket statuses and priorities.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "SQL Server" }
                    }
                }
            };

            return View(profile);
        }
    }
}