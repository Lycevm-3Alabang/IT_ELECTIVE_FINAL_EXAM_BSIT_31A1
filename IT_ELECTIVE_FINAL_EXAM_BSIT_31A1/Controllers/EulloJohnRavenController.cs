using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Eullo, John Raven")]   // shown on the Home list; use "Last, First" so sorting is by surname
    public class EulloJohnRaven : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "John Raven J. Eullo",
                Tagline = "Aspiring Full-Stack Developer",
                Course = "BS Information Technology",
                Section = "3A",
                Bio = "I love outdoor activities and online coop games. My goal in life is to create a life changing app",
                PhotoPath = "~/images/EulloPicture.jpg",
                Email = "eulloraven@gmail.com",
                GitHubUrl = "https://github.com/EulloJohnRaven",
                LinkedInUrl = "https://www.linkedin.com/in/raven-eullo-ba92123b5/?isSelfProfile=true",   // or null
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "SQL", "HTML/CSS", "Git" },

                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Prelim A1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/EulloJohnRaven/BSIT31E1_PRELIM_A1_EULLO_JOHNRAVEN.git",
                        Description = "Prelim Activity 1.",
                        TechStack = new List<string> { "C#" }
                    },
                    new ProjectItem
                    {
                        Title = "Prelim A2",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/EulloJohnRaven/BSIT31E1_PRELIM_A2_EULLO_JOHNRAVEN.git",
                        Description = "Prelim Activity 2.",
                        TechStack = new List<string> { "C#" }
                    },
                    new ProjectItem
                    {
                        Title = "Prelim A3",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/EulloJohnRaven/BSIT31E1_PRELIM_A3_EULLO_JOHNRAVEN.git",
                        Description = "HTTP Server and ClientStartup",
                        TechStack = new List<string> { "C#" }
                    },
                    new ProjectItem
                    {
                        Title = "Prelim H1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/EulloJohnRaven/BSIT31E1_PRELIM_H1_EULLO_JOHNRAVEN.git",
                        Description = "Student Management System.",
                        TechStack = new List<string> { "C#" }
                    },
                    new ProjectItem
                    {
                        Title = "Prelim H2",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/EulloJohnRaven/BSIT31E1_PRELIM_H2_EULLO_JOHNRAVEN.git",
                        Description = "File Ingestion Engine.",
                        TechStack = new List<string> { "C#" }
                    },
                    new ProjectItem
                    {
                        Title = "Prelim Q1",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/EulloJohnRaven/BSIT_31E1_PRELIM_Q1_Eullo_JohnRaven.git",
                        Description = "Transport resolver challenge.",
                        TechStack = new List<string> { "C#" }
                    },
                    new ProjectItem
                    {
                        Title = "Prelim Exam",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/EulloJohnRaven/IT_ELECTIVE_2_PRELIM_EXAM_EULLO_JOHNRAVEN.git",
                        Description = "OOP Principles & HttpClient / REST API Consumption.",
                        TechStack = new List<string> { "C#", "Console" }
                    },

                    new ProjectItem
                    {
                        Title = "Midterm A1",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/EulloJohnRaven/IT_ELECTIVE_2_MIDTERM_A1_EULLO_JOHNRAVEN.git",
                        Description = "Midterm Activity 1.",
                        TechStack = new List<string> { "C#" }
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Q1",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/stephanie-mendoza189/IT_ELECTIVE_2_MIDTERM_Q1_BEMR.git",
                        Description = "Genshin Character Build Guide (Collaborative).",
                        TechStack = new List<string> { "C#" }
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Q2",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/EulloJohnRaven/IT_ELECTIVE_2_MIDTERM_Q2_Eullo_JohnRaven.git",
                        Description = "Playlist App.",
                        TechStack = new List<string> { "C#" }
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Q3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/EulloJohnRaven/IT_ELECTIVE_2_MIDTERM_Q3_Eullo_JohnRaven.git",
                        Description = "MVC Authentication.",
                        TechStack = new List<string> { "C#" }
                    },
                    new ProjectItem
                    {
                        Title = "Midterm H1, H2, & H3",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/EulloJohnRaven/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_Eullo_JohnRaven.git",
                        Description = "Hardware POS.",
                        TechStack = new List<string> { "C#" }
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Exam",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/EulloJohnRaven/T_ELECTIVE_2_MIDTERM_EXAM_5_Eullo_JohnRaven.git",
                        Description = "Equipment Borrowing Monitoring System.",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },

                    new ProjectItem
                    {
                        Title = "Prefinal A1",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/EulloJohnRaven/BSIT31E1_PREFINAL_A1_Eullo_JohnRaven.git",
                        Description = "Prefinal Activity 1.",
                        TechStack = new List<string> { "C#" }
                    },
                    new ProjectItem
                    {
                        Title = "Prefinal Project",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/EulloJohnRaven/IT_ELECTIVE_PREFINALS_PROJECT.git",
                        LiveUrl = null,
                        Description = "Lyceum Support Desk (Collaborative).",
                        TechStack = new List<string> { "ASP.NET Core MVC", "SQL Server" }
                    },
                    new ProjectItem
                    {
                        Title = "Prefinal Portfolio",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/EulloJohnRaven/IT_ELECTIVE_2_PREFINALS_Eullo_JohnRaven.git",
                        LiveUrl = null,
                        Description = "Prefinal Portfolio compilation.",
                        TechStack = new List<string> { "ASP.NET Core MVC" }
                    },
                    new ProjectItem
                    {
                        Title = "Prefinal Exam",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/EulloJohnRaven/IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_Eullo_JohnRaven.git",
                        LiveUrl = null,
                        Description = "Prefinal Examination Jeopardy App.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "SQL Server" }
                    }
                }
            };

            return View(profile);
        }
    }
}

