using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("joshua villacorte")]   // shown on the Home list; use "Last, First" so sorting is by surname
    public class VILLACORTEJOSHUA0Controller : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "VILACORTE JOSHUA JOSEPH",
                Tagline = "Aspiring Full-Stack Developer",
                Course = "BS Information Technology",
                Section = "31E1",
                Bio = "Write 2–4 sentences about yourself: your interests, what you enjoy building, and your goals.",
                PhotoPath = "~/images/villacorte.png",
                Email = "coleapollo32@gmail.com",
                GitHubUrl = "https://github.com/coleapollo32-glitch",
                LinkedInUrl = "https://www.linkedin.com/in/cole-apollo-654953440/?isSelfProfile=true",   // or null
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "SQL", "HTML/CSS", "Git" },

                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "BSIT31E1_A1_PRELIM_VILLACORTE_JOSHUA.git",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/coleapollo32-glitch/BSIT31E1_A1_PRELIM_VILLACORTE_JOSHUA.git",
                        Description = "One or two sentences on what it does.",
                        TechStack = new List<string> { "C#", "Console" }
                    },
                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_Midterm_A1_villacorte_joshua.git",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "IT_ELECTIVE_2_Midterm_A1_villacorte_joshua.git",
                        Description = "One or two sentences on what it does.",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },
                    new ProjectItem
                    {
                        Title = "IT_ELECTIVE_SSO_BSIT_31A1.git",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/Lycevm-3Alabang/IT_ELECTIVE_SSO_BSIT_31A1.git",
                        LiveUrl = null,   // add a deployed link if you have one
                        Description = "One or two sentences on what it does.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "SQL Server" }
                    } ,
                     new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_PRELIM_EXAM_villacorte.git",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/coleapollo32-glitch/IT_ELECTIVE_2_PRELIM_EXAM_villacorte.git",
                        LiveUrl = null,   // add a deployed link if you have one
                        Description = "One or two sentences on what it does.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "SQL Server" }
                    },
                     new ProjectItem
                    {
                        Title = "IT_Elective_-Pre-finals_villacorte_joshua.git",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/coleapollo32-glitch/IT_Elective_-Pre-finals_villacorte_joshua.git",
                        LiveUrl = null,   // add a deployed link if you have one
                        Description = "One or two sentences on what it does.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "SQL Server" }
                    },
                     new ProjectItem
                    {
                        Title = "BSIT31E1_PRELIM_A3_VILLACORTE.git",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/coleapollo32-glitch/BSIT31E1_PRELIM_A3_VILLACORTE.git",
                        LiveUrl = null,   // add a deployed link if you have one
                        Description = "One or two sentences on what it does.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "SQL Server" }
                    },
                     new ProjectItem
                    {
                        Title = "coleapollo32-glitch/ModelBindingDemo.git",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/coleapollo32-glitch/ModelBindingDemo.git",
                        LiveUrl = null,   // add a deployed link if you have one
                        Description = "One or two sentences on what it does.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "SQL Server" }
                    },
                      new ProjectItem
                    {
                        Title = "IT_ELECTIVE_2_MIDTERM_EXAM_1_villacorte_joshua.git",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/coleapollo32-glitch/IT_ELECTIVE_2_MIDTERM_EXAM_1_villacorte_joshua.git",
                        LiveUrl = null,   // add a deployed link if you have one
                        Description = "One or two sentences on what it does.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "SQL Server" }
                    },
                      new ProjectItem
                    {
                        Title = "IT_ELECTIVE_SSO_BSIT_31A1.git",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/Lycevm-3Alabang/IT_ELECTIVE_SSO_BSIT_31A1.git",
                        LiveUrl = null,   // add a deployed link if you have one
                        Description = "One or two sentences on what it does.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "SQL Server" }
                    },
                }
            };

            return View(profile);
        }
    }
}