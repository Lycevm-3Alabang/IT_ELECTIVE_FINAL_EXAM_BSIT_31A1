using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Fernandez, Gio")]   // shown on the Home list; use "Last, First" so sorting is by surname
    public class FernandezGioController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Gio Fernandez",
                Tagline = "Aspiring Full-Stack Developer",
                Course = "BS Information Technology",
                Section = "31E1",
                Bio = "Hi! My name is Gio. My interests are cooking, playing chess, and gaming. I enjoy learning new things and building projects that I find interesting. My goal is to have a good life, enjoy what I do, and have fun along the way.",
                PhotoPath = "~/images/gio.jpg",
                Email = "gionfernandez060606@gmail.com",
                GitHubUrl = "https://github.com/MonkeySlays6",
                LinkedInUrl = "https://linkedin.com/in/your-profile",   // or null
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "SQL", "HTML/CSS", "Git", "Python" },

                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_PRELIM_EXAM_FERNANDEZ_GIO",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/MonkeySlays6/IT_ELECTIVE_2_PRELIM_EXAM_FERNANDEZ_GIO",
                        Description = "A C#/.NET 10 exam project covering OOP principles and HttpClient/REST API consumption, including TheMealDB and JSONPlaceholder exercises.",
                        TechStack = new List<string> { "C#", ".NET 10", "HttpClient" }
                    },
                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_MIDTERM_EXAM_2_Fernandez_Gio",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/MonkeySlays6/IT_ELECTIVE_2_MIDTERM_EXAM_2_Fernandez_Gio",
                        Description = "A midterm examination about creating a program based on the given task.",
                        TechStack = new List<string> { "ASP.NET Core MVC", ".NET" }
                    },
                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_BSIT31E1_PREFINAL_QUIZ_FERNANDEZ_GIO",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/MonkeySlays6/IT_ELECTIVE_2_BSIT31E1_PREFINAL_QUIZ_FERNANDEZ_GIO",
                        Description = "An ASP.NET Core MVC portfolio application with login-first access, a project index, individual project detail pages, technologies, GitHub links, and responsive design.",
                        TechStack = new List<string> { "C#", "ASP.NET Core MVC", ".NET" }
                    },
                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_SSO_BSIT_31A1",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/Lycevm-3Alabang/IT_ELECTIVE_SSO_BSIT_31A1.git",
                        LiveUrl = null,   // add a deployed link if you have one
                        Description = "MVC Website made by the whole section.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "C#" }
                    }
                }
            };

            return View(profile);
        }
    }
}