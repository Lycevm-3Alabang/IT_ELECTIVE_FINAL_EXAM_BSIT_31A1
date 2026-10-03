using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Bulandus, Niño Vincent")]
    public class BulandusVincent : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Niño Vincent Bulandus",
                Tagline = "Future IT Professional",
                Course = "BS Information Technology",
                Section = "3E1",

                Bio = "I like configuring and troubleshooting computers",

                PhotoPath = "~/images/VincentBulandus.jpg",

                Email = "your-email@example.com",

                GitHubUrl = "https://github.com/jeaguilar547-ui",
                LinkedInUrl = null,

                Skills = new List<string>
                {
                    "C#",
                    "ASP.NET Core MVC",
                    "HTML/CSS",
                    "JavaScript",
                    "SQL",
                    "GitHub"
                },

                // Keep projects in Prelim → Midterm → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "IT Elective 2 Final exam",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/Lycevm-3Alabang/IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.git",
                        Description = "An IT Elective 2 project template used as a foundation for developing an ASP.NET Core MVC application.",
                        TechStack = new List<string>
                        {
                            "C#",
                            "ASP.NET Core MVC",
                            "HTML/CSS"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective 2 Pre-Final Exam",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/vincentbulandus1220/IT_ELECTIVE_2_-BSIT-31E1-_PREFINAL_EXAM_Bulandus_Ni-o.git",
                        Description = "A midterm examination project developed as part of the IT Elective 2 course.",
                        TechStack = new List<string>
                        {
                            "C#",
                            "ASP.NET Core MVC",
                            "HTML/CSS"
                        }
                    },

                    new ProjectItem
                    {
                        Title = "IT Elective 2 Midterm Exam",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/vincentbulandus1220/IT-Elective-2-Midterm-Exam.git",
                        LiveUrl = null,
                        Description = "An ASP.NET Core MVC project developed for the IT Elective 2 pre-final examination.",
                        TechStack = new List<string>
                        {
                            "C#",
                            "ASP.NET Core MVC",
                            "HTML/CSS"
                        },




                    }
                }
            };

            return View(profile);
        }
    }
}