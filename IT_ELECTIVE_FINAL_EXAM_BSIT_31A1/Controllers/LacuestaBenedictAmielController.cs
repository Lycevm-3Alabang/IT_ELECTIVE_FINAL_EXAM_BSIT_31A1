using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Lacuesta, Benedict Amiel")]   // shown on the Home list; use "Last, First" so sorting is by surname
    public class LacuestaBenedictAmielController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Benedict Amiel Lacuesta",
                Tagline = "Aspiring Full-Stack Developer",
                Course = "BS Information Technology",
                Section = "31E1",
                Bio = "I’m a hardworking and adaptable professional with experience in content moderation and virtual assistance. I’m a quick learner, responsible, and able to work well with different people. I’m always open to learning new skills and taking on new challenges.",
                PhotoPath = "~/images/pfp.jpg",
                Email = "Benedictlacuesta@gmail.com",
                GitHubUrl = "https://github.com/BenedictAmiel",
                LinkedInUrl = "https://linkedin.com/in/your-profile",   // or null
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "SQL", "HTML/CSS", "Git" },

                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Prelim Exam",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/BenedictAmiel/IT_ELECTIVE_2_PRELIM_EXAM_Lacuesta_BenedicAmiel",
                        Description = "A C#/.NET 10 exam project covering OOP principles and HttpClient/REST API consumption, including TheMealDB and JSONPlaceholder exercises.",
                        TechStack = new List<string> { "C#", "Console" }
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Q2",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/BenedictAmiel/IT_ELECTIVE_2_MIDTERM_Q2_Lacuesta_Benedict",
                        Description = "A midterm quiz about creating a program based on the given task.",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },
                    new ProjectItem
                    {
                        Title = "PreFinal Exam",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/BenedictAmiel/IT_ELECTIVE_2_-31E1-_PREFINAL_EXAM_Lacuesta_BenedictAmiel",
                        Description = "An ASP.NET Core MVC examination application that displays 20 questions, choices, and selected answers without using a database.\r\n .",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },
                    new ProjectItem
                    {
                        Title = "Final Exam",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/Lycevm-3Alabang/IT_ELECTIVE_SSO_BSIT_31A1",
                        LiveUrl = null,   // add a deployed link if you have one
                        Description = "MVC Website made by the whole section.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "SQL Server" }
                    }
                }
            };

            return View(profile);
        }
    }
}