using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Para, Andrea")]   // shown on the Home list; use "Last, First" so sorting is by surname
    public class AndreaParaController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Andrea Para",
                Tagline = "Aspiring Network Enginner",
                Course = "BS Information Technology",
                Section = "31E1",
                Bio = "We suffer more often in imagination than in reality, Then i use my brain until not functioning.",
                PhotoPath = "~/images/Deng.png",
                Email = "andreapar516@gmail.com",
                GitHubUrl = "https://github.com/andreapar516-a11y",
                LinkedInUrl = "https://linkedin.com/in/your-profile",   // or null
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "SQL", "HTML/CSS", "Git" },

                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "BSIT_-section-_PRELIM_Q1_Para_Andrea",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/https://github.com/andreapar516-a11y/IT_ELECTIVE_2_PRELIM_EXAM.git/prelim-repo",
                        Description = "One or two sentences on what it does.",
                        TechStack = new List<string> { "C#", "Console" }
                    },
                     new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_PRELIM_EXAM.git",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/https://github.com/andreapar516-a11y/IT_ELECTIVE_2_PRELIM_EXAM.git/prelim-repo",
                        Description = "One or two sentences on what it does.",
                        TechStack = new List<string> { "C#", "Console" }
                    },
                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_MIDTERM_Q2_Para_Andrea",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/https://github.com/andreapar516-a11y/IT_ELECTIVE_2_MIDTERM_Q2_Para_Andrea.git/midterm-repo",
                        Description = "One or two sentences on what it does.",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },
                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_PREFINALS_ACT1",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/https://github.com/andreapar516-a11y/IT_ELECTIVE_PREFINALS_ACT1.git/final-repo",
                        LiveUrl = null,   // add a deployed link if you have one
                        Description = "One or two sentences on what it does.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "SQL Server" }
                    },
                    new ProjectItem
                    {
                        Title = "Final Project Title",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/andreapar516-a11y/final-repo",
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