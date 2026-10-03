
using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Guiruela John Paul")]
    public class GuiruelaJohnPaulController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Guiruela John Paul",
                Tagline = "Aspiring Web Developer",
                Course = "BS Information Technology",
                Section = "31A1",

                Bio = "I am an Information Technology student who enjoys learning programming and web development. I want to improve my coding skills and create useful systems that can help people in their daily lives.",

                PhotoPath = "~/images/elisha.jpg",
                Email = "johnpaulguiruela08@gmail.com",
                GitHubUrl = "https://github.com/johnpaulguiruela08-cell?tab=repositories",
                LinkedInUrl = "https://github.com/johnpaulguiruela08-cell"
                ,
                Skills = new List<string>
                {
                    "HTML",
                    "CSS",
                    "JavaScript",
                    "PHP",
                    "C#",
                    "SQL",
                    "ASP.NET Core MVC"
                },

                // Projects arranged by academic stage
                Projects = new List<ProjectItem>
                {
                    // PRELIM PROJECT 1
                    new ProjectItem
                    {
                        Title = "Guiru ela Prelim Exam",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/johnpaulguiruela08-cell/GUIRUELA_PRELIM_EXAM",
                        Description = "A project created for the IT Elective 2 Prelim Examination.",
                        TechStack = new List<string>
                        {
                            "C#",
                            "Programming"
                        }
                    },

                    // PRELIM PROJECT 2
                    new ProjectItem
                    {
                        Title = "IT Elective 2 Template",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/johnpaulguiruela08-cell/IT_ELECTIVE_2_TEMPLATE",
                        Description = "A template project for IT Elective 2 activities.",
                        TechStack = new List<string>
                        {
                            "C#",
                            "ASP.NET Core MVC"
                        }
                    },

                    // MIDTERM PROJECT
                    new ProjectItem
                    {
                        Title = "IT Elective 2 Midterm Exam - Set 4",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/johnpaulguiruela08-cell/IT_ELECTIVE_2_MIDTERM_EXAM_-Set-4-_-Johnpaul-Guiruela-",
                        Description = "A project created for the IT Elective 2 Midterm Examination.",
                        TechStack = new List<string>
                        {
                            "C#",
                            "ASP.NET Core MVC"
                        }
                    },

                    // PREFINAL PROJECT 1
                    new ProjectItem
                    {
                        Title = "IT Elective 2 PreFinal Exam",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/johnpaulguiruela08-cell/IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_Guiruela_John-Paul",
                        Description = "A project created for the IT Elective 2 PreFinal Examination.",
                        TechStack = new List<string>
                        {
                            "C#",
                            "ASP.NET Core MVC"
                        }
                    },

                    // PREFINAL PROJECT 2
                    new ProjectItem
                    {
                        Title = "Guiruela Modern Portfolio MVC",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/johnpaulguiruela08-cell/Guiruela-ModernPortfolioMVC",
                        Description = "A modern portfolio website project using the MVC pattern.",
                        TechStack = new List<string>
                        {
                            "C#",
                            "ASP.NET Core MVC",
                            "HTML",
                            "CSS"
                        }
                    }
                }
            };

            return View(profile);
        }
    }
}
