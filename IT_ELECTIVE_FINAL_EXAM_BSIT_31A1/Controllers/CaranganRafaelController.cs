using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Carangan, Rafael")]   // shown on the Home list; use "Last, First" so sorting is by surname
    public class CaranganRafaelController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Rafael Carangan",
                Tagline = "Aspiring Full-Stack Developer",
                Course = "BS Information Technology",
                Section = "3A",
                Bio = "Write 2–4 sentences about yourself: your interests, what you enjoy building, and your goals.",
                PhotoPath = "~/images/rafaelcarangan.jpg",
                Email = "rafaelcarangan2004@email.com",
                GitHubUrl = "https://github.com/RFLCRNGN",
        
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "SQL", "HTML/CSS", "Git" },

                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Prelim Project Title",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/RFLCRNGN/CARANGAN_ACTIVITY-1.git",
                        Description = "One or two sentences on what it does.",
                        TechStack = new List<string> { "C#", "Console" }
                    },
                    new ProjectItem
                    {
                        Title = "Midterm Project Title",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/RFLCRNGN/BSIT_-32A2-_A2_CARANGA_RAFAEL.gito",
                        Description = "One or two sentences on what it does.",
                        TechStack = new List<string> { "C#", "WinForms" }
                    },
                    new ProjectItem
                    {
                        Title = "Final Project Title",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/RFLCRNGN/BSIT_32A2_CARANGAN_RAFAEL_A2.git",
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