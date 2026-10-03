using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Reales, Jonnidel")]
    public class Reales_Jonnidel_Controller : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Jonnidel Reales",
                Tagline = "Aspiring Software Developer",
                Course = "BS Information Technology",
                Section = "31E1",
                Bio = "I am a BS Information Technology student interested in programming, networking, and technology. I enjoy building systems and applications that help me improve my skills in software development. My goal is to become a professional software developer in the future.",
                PhotoPath = "~/images/Realess.png",
                Email = "your-email@email.com",
                GitHubUrl = "https://github.com/WspJon",
                LinkedInUrl = null,
                Skills = new List<string> { "C#", "ASP.NET Core MVC", ".NET", "HTML/CSS", "Git" },

                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "IT Elective 2 Prelim Exam",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/WspJon/IT_ELECTIVE_2_PRELIM_EXAM_Reales.git",
                        Description = "A C# project focused on object-oriented programming and REST API integration using HttpClient.",
                        TechStack = new List<string> { "C#", ".NET", "HttpClient", "REST API" }
                    },

                    new ProjectItem
                    {
                        Title = "Prelim Activity 3",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/WspJon/BSIT31E1_Prelim_A3_Reales.git",
                        Description = "A C# activity created as part of the IT Elective 2 prelim requirements.",
                        TechStack = new List<string> { "C#", ".NET" }
                    },

                    new ProjectItem
                    {
                        Title = "Prelim Quiz 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/WspJon/BSIT_31E1_PRELIM_Q1_Reales_Jonnidel.git",
                        Description = "A C# project demonstrating object-oriented programming concepts.",
                        TechStack = new List<string> { "C#", ".NET", "OOP" }
                    },

                    new ProjectItem
                    {
                        Title = "Prelim Hands-On 2",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/WspJon/BSIT31E1_PRELIM_H2_Reales_Jonnidel.git",
                        Description = "A C# project focused on file processing and software design concepts.",
                        TechStack = new List<string> { "C#", ".NET", "OOP" }
                    },

                    new ProjectItem
                    {
                        Title = "Prelim Hands-On 1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/WspJon/-BSIT31E1_PRELIM_H1_REALES_JONNIDEL.git",
                        Description = "A C# console project created for the IT Elective 2 prelim hands-on activity.",
                        TechStack = new List<string> { "C#", "Console" }
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective 2 Midterm Exam",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/WspJon/IT_ELECTIVE_2_MIDTERM_EXAM_REALES_JONNIDEL.git",
                        Description = "A C# project developed for the IT Elective 2 Midterm Exam.",
                        TechStack = new List<string> { "C#", ".NET" }
                    },

                    new ProjectItem
                    {
                        Title = "Midterm Hands-On 1, 2 and 3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/WspJon/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_Reales_Jonnidel.git",
                        Description = "A web-based project created for the IT Elective 2 midterm hands-on activities.",
                        TechStack = new List<string> { "C#", "ASP.NET Core MVC", ".NET" }
                    },

                    new ProjectItem
                    {
                        Title = "Midterm Quiz 3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/WspJon/IT_ELECTIVE_2_MIDTERM_Q3_Reales_Jonnidel.git",
                        Description = "An ASP.NET Core MVC project created for the IT Elective 2 Midterm Quiz 3.",
                        TechStack = new List<string> { "C#", "ASP.NET Core MVC" }
                    },

                    new ProjectItem
                    {
                        Title = "Midterm Quiz 2",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/WspJon/IT_ELECTIVE_2_MIDTERM_Q2_Reales_Jonnidel.git",
                        Description = "A project created for the IT Elective 2 Midterm Quiz 2.",
                        TechStack = new List<string> { "C#", ".NET" }
                    },

                    new ProjectItem
                    {
                        Title = "Midterm Quiz 1",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/WspJon/IT_ELECTIVE_2_MIDTERM_Q1.git",
                        Description = "A project created for the IT Elective 2 Midterm Quiz 1.",
                        TechStack = new List<string> { "C#", ".NET" }
                    },

                    new ProjectItem
                    {
                        Title = "Midterm Quiz 1 - Reales",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/WspJon/IT_ELECTIVE_2_MIDTERM_Q1_Reales.git",
                        Description = "A repository created for the IT Elective 2 Midterm Quiz 1.",
                        TechStack = new List<string> { "C#", ".NET" }
                    },

                    new ProjectItem
                    {
                        Title = "Prefinal Quiz",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/WspJon/IT-ELECT-PREFINALS---QUIZ.git",
                        Description = "An ASP.NET Core MVC project created for the IT Elective Prefinal Quiz.",
                        TechStack = new List<string> { "C#", "ASP.NET Core MVC", "HTML/CSS" }
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective 2 Prefinal Exam",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/WspJon/IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_Reales_Jonnidel.git",
                        Description = "An ASP.NET Core MVC project developed for the IT Elective 2 Prefinal Exam.",
                        TechStack = new List<string> { "C#", "ASP.NET Core MVC", ".NET" }
                    },

                    new ProjectItem
                    {
                        Title = "Prefinal Activity 1",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/WspJon/IT_ELECTIVE_PREFINALS_A1_Reales.git",
                        Description = "A project created for the IT Elective Prefinal Activity 1.",
                        TechStack = new List<string> { "C#", ".NET" }
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective Prefinal Project",
                        Stage = ProjectStage.PreFinal,
                        RepoUrl = "https://github.com/WspJon/IT_ELECTIVE_PREFINALS_PROJECT.git",
                        LiveUrl = null,
                        Description = "A project developed as part of the IT Elective Prefinal requirements.",
                        TechStack = new List<string> { "C#", "ASP.NET Core MVC", ".NET" }
                    }
                }
            };

            return View(profile);
        }
    }
}