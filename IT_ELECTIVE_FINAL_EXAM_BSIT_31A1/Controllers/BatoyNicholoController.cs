using IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A1.Controllers
{
    [Classmate("Batoy, Nicholo")]   // shown on the Home list; use "Last, First" so sorting is by surname
    public class BatoyNicholoController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ClassmateProfile
            {
                FullName = "Batoy Nicholo John",
                Tagline = "Aspiring Full-Stack Developer",
                Course = "BS Information Technology",
                Section = "E1",
                Bio = "I am an Information Technology student passionate about software development and modern web technologies. I enjoy building practical web applications and backend systems using C# and ASP.NET Core. My goal is to become a proficient full-stack developer and build reliable, user-centered digital solutions.",
                PhotoPath = "~/images/Batoy.jpg",
                Email = "nicholox08@email.com",
                GitHubUrl = "https://github.com/Matsutake08",
                LinkedInUrl = "https://linkedin.com/in/your-profile",   // or null
                Skills = new List<string> { "C#", "ASP.NET Core MVC", "SQL", "HTML/CSS", "Git" },

                // Keep these in Prelim → Final order
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Student Management System",
                        Stage = ProjectStage.Prelim,
                        RepoUrl = "https://github.com/Matsutake08/BSIT31E1_PRELIM_H1_BATOY_NICHOLO",
                        LiveUrl = null,   // add a deployed link if you have one
                        Description = "Console app for managing student records, grades, and class averages.",
                        TechStack = new List<string> { "C#", "Console" }
                    },
                    new ProjectItem
                    {
                        Title = "Pixel & Meeple POS",
                        Stage = ProjectStage.Midterm,
                        RepoUrl = "https://github.com/Matsutake08/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_BATOY_NICHOLO",
                        LiveUrl = null,   // add a deployed link if you have one
                        Description = "Point-of-sale web app.",
                        TechStack = new List<string> { "C#", "ASP.NET Core MVC" }
                    },
                    new ProjectItem
                    {
                        Title = "BSIT-31E1 Final Project",
                        Stage = ProjectStage.Final,
                        RepoUrl = "https://github.com/Lycevm-3Alabang/IT_ELECTIVE_SSO_BSIT_31A1.git",
                        LiveUrl = null,   // add a deployed link if you have one
                        Description = "MVC Website.",
                        TechStack = new List<string> { "ASP.NET Core", "C#", "OAuth / SSO" }
                    }
                }
            };

            return View(profile);
        }
    }
}