using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Roque, Kevin Clerck")]   // shown on the Home list; use "Last, First" so sorting is by surname
    public class RoqueKevinClerckController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Kevin Clerck Roque",
                Tagline = "Aspiring Full-Stack Developer",
                Course = "BS Information Technology",
                Section = "BSIT31A1",
                Bio = "I do digital art and programming",
                PhotoPath = "~/images/Roque.jpg",
                Email = "kcofficial14@email.com",
                GitHubUrl = "https://github.com/KevinRoque1",
                LinkedInUrl = "https://ph.linkedin.com/in/kevin-clerck-roque-a82904422",   // or null
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "SQL", "HTML/CSS", "Git" },

                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Prelim (Fizzbuzz)",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/KevinRoque1/BSIT31E1_PRELIM_A1_ROQUE_KEVIN_CLERCK",
                        Description = "demonstrate basic C# skills",
                        TechStack = new List<string> { "C#", "Console" }
                    },
                    new ProjectItem
                    {
                        Title = "Midterm (Attendance_Checkin_System)",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/KevinRoque1/IT_ELECTIVE_2_MIDTERM_EXAM_8_ROQUE_KEVIN_CLERCK",
                        Description = "demonstrate basic MVC skills",
                        TechStack = new List<string> { "ASP.NET Core MVC" }
                    },
                    new ProjectItem
                    {
                        Title = "Pre-Final (Portfolio Showcase)",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/KevinRoque1/IT_ELECTIVE_2_BSIT31E1_PREFINAL_QUIZ_ROQUE_KEVIN_CLERCK.git",
                        LiveUrl = null,   // add a deployed link if you have one
                        Description = "Showcase of my portfolio throughout the semester",
                        TechStack = new List<string> { "ASP.NET Core MVC"}
                    }
                }
            };

            return View(profile);
        }
    }
}